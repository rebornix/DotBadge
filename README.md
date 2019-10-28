## C# port of [Shields-style](http://shields.io/) badge library and CLI

## CLI

Invoke your commandline shell, and run `DotBadge.exe --help`.

### Sample
`DotBadge.exe -sb "Downloads" -st "1000" -c "Green" -sl 0` 

`DotBadge.exe -sb "Build" -st "fail" -c "Red" -sl 0` 

`DotBadge.exe -sbhttps://github.com/rebornix/DotBadge/edit/master/Readme.md# "Star" -st "234" -c "#ddf" -sl 1` 

## Nuget package
To integrate the latest DotBadge with your project, run following command in the Package Manager Console:

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

### Docker

#### Build

Build docker image

```
docker build -t dot-badge .
```

### Run

```
docker run -it --rm -v D:\DEV\DotBadge\:/out dot-badge -sb "Downloads" -st "1000" -c "Green" -sl 0 -p "/out/tick.svg"
```