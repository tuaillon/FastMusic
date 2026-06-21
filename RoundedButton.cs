using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int CornerRadius { get; set; } = 20;

    protected override void OnPaint(PaintEventArgs pe)
    {
        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        GraphicsPath path = new GraphicsPath();
        Rectangle rect = ClientRectangle;

        rect.Width -= 1;
        rect.Height -= 1;

        path.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90);
        path.AddArc(rect.Right - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90);
        path.AddArc(rect.Right - CornerRadius, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);

        using (SolidBrush brush = new SolidBrush(this.BackColor))
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

        using (Pen pen = new Pen(this.ForeColor, 1))
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