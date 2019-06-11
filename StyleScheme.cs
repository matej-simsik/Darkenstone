using System.Drawing;

namespace Darkenstone
{
    public static class ButtonStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(64, 0, 64); }
        }

        public static Color TextColor
        {
            get { return Color.White; }
        }
    }

    public static class CloseButtonStyle
    {
        public static Color BackColor
        {
            get { return Color.Maroon; }
        }

        public static Color TextColor
        {
            get { return Color.White; }
        }
    }

    public static class LightButtonStyle
    {
        public static Color BackColor
        {
            get { return Color.Purple; }
        }

        public static Color TextColor
        {
            get { return Color.White; }
        }
    }

    public static class PanelStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(34, 34, 34); }
        }

        public static Color HighlightedColor
        {
            get { return Color.FromArgb(64, 64, 64); }
        }
    }

    public static class ToolTipStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(34, 34, 34); }
        }
        public static Color TextColor
        {
            get { return Color.White; }
        }
    }

    public static class ResourceStyle
    {
        public static Color HealthColor
        {
            get { return Color.DarkRed; }
        }

        public static Color ManaColor
        {
            get { return Color.DarkBlue; }
        }
    }

    public static class OffensivenessStyle
    {
        public static Color OffensiveColor
        {
            get { return Color.DarkRed; }
        }

        public static Color DefensiveColor
        {
            get { return Color.Green; }
        }
    }

    public static class LabelStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(34, 34, 34); }
        }

        public static Color HighlightedBackColor
        {
            get { return Color.FromArgb(64, 64, 64); }
        }

        public static Color TextColor
        {
            get { return Color.White; }
        }

        public static Color TransparentBackColor
        {
            get { return Color.Transparent; }
        }
    }

    public static class AbilityCardStyle
    {
        public static Color BackColor
        {
            get { return Color.White; }
        }

        public static Color SelectedBackColor
        {
            get { return Color.FromArgb(64, 0, 64); }
        }
    }

    public static class AbilityCardContainerStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(34, 34, 34); }
        }
    }

    public static class FormStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(34, 34, 34); }
        }
    }

    public static class ColorDialogStyle
    {
        public static Color BackColor
        {
            get { return Color.FromArgb(64, 0, 64); }
        }
    }

    public static class IconStyle
    {
        public static Color BackColor
        {
            get { return Color.White; }
        }

        public static Color IconColor
        {
            get { return Color.White; }
        }

        public static Color CharacterDefaultColor
        {
            get { return Color.FromArgb(64, 0, 64); }
        }
    }

    public static class CharacterIconStyle
    {
        public static Color BackColor
        {
            get { return Color.White; }
        }

        public static Color SelectedColor
        {
            get { return Color.FromArgb(156, 62, 124); }
            //get { return Color.FromArgb(64, 0, 64); }
        }

        public static Color HighlightedColor
        {
            get { return Color.FromArgb(64, 64, 64); }
        }

        //BackColor of labels and panels which create CharacterIcon
        public static Color NotHighlightedColor
        {
            get { return Color.FromArgb(34, 34, 34); }
        }
    }
}
