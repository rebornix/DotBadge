#A C# port of Shields-style badge library.

## How to integrate with your project
To install DotBadge, run the following command in the Package Manager Console:

```
PM> Install-Package DotBadge
```

A folder called `templates` will be copied to your target project, remember to set this folder as `Copy Always`

## Sample
```
using System.Xml.Linq;
using DotBadge;

namespace Badge
{
    class Program
    {
        static void Main(string[] args)
        {
            var bp = new BadgePainter();
            var xDoc = XDocument.Parse(bp.DrawSVG("Nuget Downloads", "0 total", ColorScheme.Red, Style.Flat));
            xDoc.Save(@"C:\Users\peng\Desktop\nuget.svg");
        }
    }
}

```