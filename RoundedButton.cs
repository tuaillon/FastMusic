using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FastMusic
{

public class RoundedButton : Button
{
    public int CornerRadius { get; set; } = 20;
    public bool IsCircle { get; set; } = false;

    private bool isHovered = false;
    private bool isPressed = false;

    public RoundedButton()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        isHovered = true;
        this.Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        isHovered = false;
        this.Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs mevent)
    {
        base.OnMouseDown(mevent);
        isPressed = true;
        this.Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
        base.OnMouseUp(mevent);
        isPressed = false;
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        // Clear square corners using parent back color, avoiding region clipping jaggedness
        if (this.Parent != null)
        {
            using (SolidBrush parentBrush = new SolidBrush(this.Parent.BackColor))
            {
                pe.Graphics.FillRectangle(parentBrush, ClientRectangle);
            }
        }

        this.Region = null;

        GraphicsPath path = new GraphicsPath();
        Rectangle rect = ClientRectangle;

        // Inset by 1.5 pixels to keep anti-aliasing fully inside control boundaries
        rect.X += 1;
        rect.Y += 1;
        rect.Width -= 3;
        rect.Height -= 3;

        if (IsCircle)
        {
            path.AddEllipse(rect);
        }
        else
        {
            int diameter = CornerRadius;
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;
            if (diameter <= 0) diameter = 1;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseAllFigures();
        }

        Color backColor = this.BackColor;
        if (isPressed)
        {
            backColor = Color.FromArgb(
                Math.Max(0, this.BackColor.R - 20),
                Math.Max(0, this.BackColor.G - 20),
                Math.Max(0, this.BackColor.B - 20)
            );
        }
        else if (isHovered)
        {
            backColor = Color.FromArgb(
                Math.Min(255, this.BackColor.R + 25),
                Math.Min(255, this.BackColor.G + 25),
                Math.Min(255, this.BackColor.B + 25)
            );
        }

        using (SolidBrush brush = new SolidBrush(backColor))
        {
            pe.Graphics.FillPath(brush, path);
        }

        if (this.BackgroundImage != null)
        {
            pe.Graphics.SetClip(path);
            if (this.BackgroundImageLayout == ImageLayout.Stretch)
            {
                pe.Graphics.DrawImage(this.BackgroundImage, ClientRectangle);
            }
            else if (this.BackgroundImageLayout == ImageLayout.Zoom)
            {
                float imageAspect = (float)this.BackgroundImage.Width / this.BackgroundImage.Height;
                float controlAspect = (float)ClientRectangle.Width / ClientRectangle.Height;
                RectangleF destRect = ClientRectangle;
                if (imageAspect > controlAspect)
                {
                    destRect.Height = ClientRectangle.Width / imageAspect;
                    destRect.Y = (ClientRectangle.Height - destRect.Height) / 2f;
                }
                else
                {
                    destRect.Width = ClientRectangle.Height * imageAspect;
                    destRect.X = (ClientRectangle.Width - destRect.Width) / 2f;
                }
                pe.Graphics.DrawImage(this.BackgroundImage, destRect);
            }
            else if (this.BackgroundImageLayout == ImageLayout.Center)
            {
                Rectangle destRect = new Rectangle(
                    (ClientRectangle.Width - this.BackgroundImage.Width) / 2,
                    (ClientRectangle.Height - this.BackgroundImage.Height) / 2,
                    this.BackgroundImage.Width,
                    this.BackgroundImage.Height
                );
                pe.Graphics.DrawImage(this.BackgroundImage, destRect);
            }
            else
            {
                using (TextureBrush tb = new TextureBrush(this.BackgroundImage))
                {
                    pe.Graphics.FillPath(tb, path);
                }
            }
            pe.Graphics.ResetClip();
        }

        if (this.Image != null)
        {
            Rectangle imgRect = GetImageRectangle(this.Image, ClientRectangle, this.ImageAlign);
            pe.Graphics.DrawImage(this.Image, imgRect);
        }

        Color penColor = this.ForeColor;
        int penWidth = 1;
        if (isHovered)
        {
            penWidth = 2;
            penColor = Color.FromArgb(
                Math.Min(255, this.ForeColor.R + 30),
                Math.Min(255, this.ForeColor.G + 30),
                Math.Min(255, this.ForeColor.B + 30)
            );
        }

        using (Pen pen = new Pen(penColor, penWidth))
        {
            pe.Graphics.DrawPath(pen, path);
        }

        TextRenderer.DrawText(pe.Graphics, this.Text, this.Font, ClientRectangle, this.ForeColor,
                              TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private Rectangle GetImageRectangle(Image img, Rectangle clientRect, ContentAlignment align)
    {
        int x = (clientRect.Width - img.Width) / 2;
        int y = (clientRect.Height - img.Height) / 2;

        switch (align)
        {
            case ContentAlignment.TopLeft:
                x = 4; y = 4; break;
            case ContentAlignment.TopCenter:
                y = 4; break;
            case ContentAlignment.TopRight:
                x = clientRect.Width - img.Width - 4; y = 4; break;
            case ContentAlignment.MiddleLeft:
                x = 4; break;
            case ContentAlignment.MiddleCenter:
                break;
            case ContentAlignment.MiddleRight:
                x = clientRect.Width - img.Width - 4; break;
            case ContentAlignment.BottomLeft:
                x = 4; y = clientRect.Height - img.Height - 4; break;
            case ContentAlignment.BottomCenter:
                y = clientRect.Height - img.Height - 4; break;
            case ContentAlignment.BottomRight:
                x = clientRect.Width - img.Width - 4; y = clientRect.Height - img.Height - 4; break;
        }
        return new Rectangle(x, y, img.Width, img.Height);
    }
}

} // namespace FastMusic