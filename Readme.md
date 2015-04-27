## C# port of [Shields-style](http://shields.io/) badge library ![DotBadge](http://rebornix.qiniudn.com/dotbadge.svg)

## Standalone exe
[Download](http://cmy.me/dotbadge)

Invoke your commandline shell, and run `DotBadge.exe --help`.

### Sample
`DotBadge.exe -sb "Downloads" -st "1000" -c "Green" -sl 0` ![demo1](http://rebornix.qiniudn.com/demo1.svg)

`DotBadge.exe -sb "Build" -st "fail" -c "Red" -sl 0` ![demo2](http://rebornix.qiniudn.com/demo2.svg)

`DotBadge.exe -sbhttps://github.com/rebornix/DotBadge/edit/master/Readme.md# "Star" -st "234" -c "#ddf" -sl 1` ![demo3](http://rebornix.qiniudn.com/demo3.svg)

## Integrate with your project
To ref the latest DotBadge, run following command in the Package Manager Console:

```
PM> Install-Package DotBadge
```

### Sample
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
