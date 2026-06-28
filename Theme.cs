using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FastMusic
{
    internal class ThemeJson
    {
        public string Name { get; set; }
        public string BackGroundColor { get; set; }
        public string ButtonsColor { get; set; }
        public string TextColor { get; set; }
    }

    internal struct Theme
    {
        public string Name;
        public Color BackGroundColor;
        public Color ButtonsColor;
        public Color TextColor;

        public Theme(string name)
        {
            string path = Path.Combine(PathManager.GetDefaultThemePath, name + ".json");
            ThemeJson temp = JsonSerializer.Deserialize<ThemeJson>(File.ReadAllText(path));
            this.Name = temp.Name;
            this.BackGroundColor = ColorTranslator.FromHtml(temp.BackGroundColor);
            this.ButtonsColor = ColorTranslator.FromHtml(temp.ButtonsColor);
            this.TextColor = ColorTranslator.FromHtml(temp.TextColor);
        }

        public static Theme FromFile(string filePath)
        {
            ThemeJson temp = JsonSerializer.Deserialize<ThemeJson>(File.ReadAllText(filePath));
            return new Theme
            {
                Name = temp.Name,
                BackGroundColor = ColorTranslator.FromHtml(temp.BackGroundColor),
                ButtonsColor = ColorTranslator.FromHtml(temp.ButtonsColor),
                TextColor = ColorTranslator.FromHtml(temp.TextColor)
            };
        }
        public override string ToString() => Name ?? "Default";

        public static Theme Default => new Theme
        {
            Name = "Default",
            BackGroundColor = Color.FromArgb(255, 30, 30, 30), 
            ButtonsColor = Color.FromArgb(255, 60, 60, 60),
            TextColor = Color.White
        };
    }

    class ThemeManager
    {
        private static List<Theme> m_availablesThemes = null;
        private static Theme? m_currentTheme = null;

        public static List<Theme> AvailablesThemes
        {
            get
            {
                if ( LicenseManager.UsageMode == LicenseUsageMode.Designtime )
                    return new List<Theme>();
                if ( m_availablesThemes == null )
                    m_availablesThemes = LoadThemes();
                return m_availablesThemes;
            }
        }

        public static Theme CurrentTheme
        {
            get
            {
                if ( m_currentTheme == null )
                {
                    m_currentTheme = AvailablesThemes.Count > 0
                        ? AvailablesThemes[0]
                        : Theme.Default;
                }
                return m_currentTheme.Value;
            }
            set => m_currentTheme = value;
        }

        public static void SetTheme(Theme theme)
        {
            CurrentTheme = theme;
        }

        public static List<Theme> LoadThemes()
        {
            string dir = PathManager.GetDefaultThemePath;
            List<Theme> res = new List<Theme>();

            if ( !Directory.Exists(dir) )
                return res;

            foreach ( string file in Directory.GetFiles(dir) )
            {
                if ( Path.GetExtension(file).Equals(".json", StringComparison.OrdinalIgnoreCase) )
                {
                    try
                    {
                        res.Add(Theme.FromFile(file));
                    }
                    catch ( Exception ex )
                    {
                        MessageBox.Show("Could not load theme : " + ex);
                    }
                }
            }

            return res;
        }

        public static void ApplyTheme(Form form)
        {
            form.BackColor = CurrentTheme.BackGroundColor;
            ApplyThemeToControls(form.Controls);
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach ( Control control in controls )
            {
                if ( control is Button button )
                {
                    button.BackColor = CurrentTheme.ButtonsColor;
                    button.ForeColor = CurrentTheme.TextColor;
                }
                else if ( control is Label label )
                {
                    label.ForeColor = CurrentTheme.TextColor;
                }

                if ( control.HasChildren )
                {
                    ApplyThemeToControls(control.Controls);
                }
            }
        }
    }
}
