namespace DotBadge
{
    public static class Resources
    {
        /// <summary>
        /// The flat 2.
        /// </summary>
        public static readonly string Flat = @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""{0}"" height=""20""><linearGradient id=""b"" x2=""0"" y2=""100%""><stop offset=""0"" stop-color=""#bbb"" stop-opacity="".1""/><stop offset=""1"" stop-opacity="".1""/></linearGradient><mask id=""a""><rect width=""{0}"" height=""20"" rx=""3"" fill=""#fff""/></mask><g mask=""url(#a)""><path fill=""#555"" d=""M0 0h{1}v20H0z""/><path fill=""{7}"" d=""M{1} 0h{2}v20H{1}z""/><path fill=""url(#b)"" d=""M0 0h{0}v20H0z""/></g><g fill=""#fff"" text-anchor=""middle"" font-family=""DejaVu Sans,Verdana,Geneva,sans-serif"" font-size=""11""><text x=""{3}"" y=""15"" fill=""#010101"" fill-opacity="".3"">{5}</text><text x=""{3}"" y=""14"">{5}</text><text x=""{4}"" y=""15"" fill=""#010101"" fill-opacity="".3"">{6}</text><text x=""{4}"" y=""14"">{6}</text></g></svg>";
    
        public static readonly string FlatSquare = @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""{0}"" height=""20""><g shape-rendering=""crispEdges""><path fill=""#555"" d=""M0 0h{1}v20H0z""/><path fill=""{7}"" d=""M{1} 0h{2}v20H{1}z""/></g><g fill=""#fff"" text-anchor=""middle"" font-family=""DejaVu Sans,Verdana,Geneva,sans-serif"" font-size=""11""><text x=""{3}"" y=""14"">{5}</text><text x=""{4}"" y=""14"">{6}</text></g></svg>";
    
        public static readonly string Plastic = @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""{0}"" height=""18""><linearGradient id=""b"" x2=""0"" y2=""100%""><stop offset=""0"" stop-color=""#fff"" stop-opacity="".7""/><stop offset="".1"" stop-color=""#aaa"" stop-opacity="".1""/><stop offset="".9"" stop-opacity="".3""/><stop offset=""1"" stop-opacity="".5""/></linearGradient><mask id=""a""><rect width=""{0}"" height=""18"" rx=""4"" fill=""#fff""/></mask><g mask=""url(#a)""><path fill=""#555"" d=""M0 0h{1}v18H0z""/><path fill=""{7}"" d=""M{1} 0h{2}v18H{1}z""/><path fill=""url(#b)"" d=""M0 0h{0}v18H0z""/></g><g fill=""#fff"" text-anchor=""middle"" font-family=""DejaVu Sans,Verdana,Geneva,sans-serif"" font-size=""11""><text x=""{3}"" y=""14"" fill=""#010101"" fill-opacity="".3"">{5}</text><text x=""{3}"" y=""13"">{5}</text><text x=""{4}"" y=""14"" fill=""#010101"" fill-opacity="".3"">{6}</text><text x=""{4}"" y=""13"">{6}</text></g></svg>";
    }
}
