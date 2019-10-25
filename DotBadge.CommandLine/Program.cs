using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotBadge;
using System.IO;
using Mono.Options;
using System.Text.RegularExpressions;

namespace DotBadge.CommandLine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bp = new BadgePainter();
            bool showHelp = false;
            string subject = String.Empty;
            string status = String.Empty;
            string color = String.Empty;
            string path = "badge.svg";
            Style style = Style.Flat;
            string errorMessage= String.Empty;

            var optionSet = new OptionSet()
            {
                "Usage: DotBadge [OPTIONS]",
                "The output image's content would be like Subject|Status",
                "",
                "Options:",
                {
                    "sb|subject=","the name of Subject", sb => subject = sb
                },
                {
                    "st|status=","the value of Status", st => status = st
                },
                {
                    "c|color=","background color of Status. You can input hexadecimal color value (#ffffff or #fff) or built-in ones (Case sensitive) : " + 
                    "Yellow, YellowGreen, Green, BrightGreen, Orange, Red, Blue.", c => {
                        var r = new Regex("^#(?:[0-9a-fA-F]{3}){1,2}$", RegexOptions.IgnoreCase);
                        if (r.Match(c).Success)
                        {
                            color = c;
                        }
                        else
                        {
                            color = bp.ParseColor(c);
                            if (String.IsNullOrEmpty(color))
                            {
                                throw new OptionException("Please input correct Color. " +
                                "You can use hexadecimal color value (#ffffff or #fff) or built-in ones (Case sensitive) : " +
                                "Yellow, YellowGreen, Green, BrightGreen, Orange, Red or Blue", "-c");
                            }
                        }
                    }
                },
                {
                    "sl|style=","style of the output image. 0 for Flat, 1 for FlatSquare, 2 for Plastic.", 
                    (int sl) => {
                        if (sl > 2 || sl < 0) {
                            throw new OptionException("Please input correct Style: 0 for Flat, 1 for FlatSquare, 2 for Plastic.", "-sl");
                        }
                        else {
                            style = (Style)sl;
                        }
                    }
                },
                {
                    "p|path=", "the value of Path", p => path = p
                },
                { 
                    "h|help",  "show this message and exit", v => showHelp = v != null 
                },
                "Samples:",
                "DotBadge.exe -sb \"Downloads\" -st \"1000\" -c \"Green\" -sl 0",
                "DotBadge.exe -sb \"Build\" -st \"fail\" -c \"Red\" -sl 0",
                "DotBadge.exe -sb \"Star\" -st \"234\" -c \"#ddf\" -sl 1"
            };

            if (args.Length == 0)
            {
                Console.WriteLine("Try `DotBadge --help` for more information");
                return;
            }

            try
            {
                optionSet.Parse(args);
            }
            catch (OptionException e)
            {
                Console.Write("Argument parsing error: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Try `DotBadge --help` for more information");
                return;
            }

            if (showHelp)
            {
                optionSet.WriteOptionDescriptions(Console.Out);
                return;
            }
            Console.WriteLine($"Path : {path}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Status : {status}");
            Console.WriteLine($"Color : {color}");
            Console.WriteLine($"Style : {style}");
            File.WriteAllText(path, bp.DrawSVG(subject, status, color, style));
            Console.WriteLine("OK");
        }
    }
}
