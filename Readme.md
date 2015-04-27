## C# port of [Shields-style](http://shields.io/) badge library ![DotBadge](http://rebornix.qiniudn.com/dotbadge.svg)

### How to integrate with your project
To install the latest DotBadge, run the following command in the Package Manager Console:

```
PM> Install-Package DotBadge
```

### Code Sample
```
using DotBadge;
using System.IO;

namespace Badge
{
    class Program
    {
        static void Main(string[] args)
        {
            var bp = new BadgePainter();
            File.WriteAllText(@"C:\Users\peng\Desktop\nuget.svg", bp.DrawSVG("Badge", ".Net", ColorScheme.Red, Style.Flat));

        }
    }
}

```
