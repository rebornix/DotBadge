using System;
using System.Drawing;
using System.IO;

namespace DotBadge
{
    public enum Style
    {
        Flat,
        FlatSquare,
        Plastic
    }

    public class ColorScheme
    {
        public static string BrightGreen = "#4c1";
        public static string Green = "#97CA00";
        public static string Yellow = "#dfb317";
        public static string YellowGreen = "#a4a61d";
        public static string Orange = "#fe7d37";
        public static string Red = "#e05d44";
        public static string Blue = "#007ec6";
        public static string Grey = "#555";
        public static string Gray = "#555";
        public static string LightGrey = "#9f9f9f";
        public static string LightGray = "#9f9f9f";
    }

    public class BadgePainter
    {
        public string DrawSVG(string subject, string status, string statusColor, Style style = Style.Flat)
        {
            string template;
            switch (style)
            {
                case Style.Flat:
                    template = File.ReadAllText("templates/flat-template.xml");
                    break;
                case Style.FlatSquare:
                    template = File.ReadAllText("templates/flat-square-template.xml");
                    break;
                case Style.Plastic:
                    template = File.ReadAllText("templates/plastic-template.xml");
                    break;
                default:
                    template = File.ReadAllText("templates/flat-template.xml");
                    break;
            }

            Font font = new Font("DejaVu Sans,Verdana,Geneva,sans-serif", 11, FontStyle.Regular);
            Graphics g = Graphics.FromImage(new Bitmap(1, 1));
            var subjectWidth = g.MeasureString(subject, font).Width;
            var statusWidth = g.MeasureString(status, font).Width;

            var result = String.Format(template,
                subjectWidth + statusWidth,
                subjectWidth,
                statusWidth,
                subjectWidth / 2 + 1,
                subjectWidth + statusWidth / 2 - 1,
                subject,
                status,
                statusColor);
            return result;
        }
    }
}
