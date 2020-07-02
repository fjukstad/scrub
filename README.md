![.NET Core](https://github.com/fjukstad/scrub/workflows/.NET%20Core/badge.svg)
![https://www.nuget.org/packages/scrub](https://img.shields.io/nuget/v/scrub?color=success&logoColor=white&logo=NuGet)
# scrub
A simple `dotnet` tool for cleaning out any `bin` or `obj` folders. Especially
useful if you are switching between developing on Windows and WSL with Ubuntu.
The only difference between `scrub` and
[`clean`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-clean) is
that `scrub` removes everything within the `bin` or `obj` folders, not just the
build artifacts created by `MSBuild`. 


# Usage

Simply run `scrub` in any folder you want to clean out. It will recursively
traverse any folder and remove all `bin` and `obj` folders it encounters.  

```
bjorn:/mnt/c/src/scrub$ scrub
Removing '/mnt/c/src/scrub/bin'
Removing '/mnt/c/src/scrub/obj'
```

You can also point it to where it should scrub await folders with `--path`

```
bjorn:/mnt/c/src$ scrub --path scrub/
Removing '/mnt/c/src/scrub/bin'
Removing '/mnt/c/src/scrub/obj'
```

# Install
Install `scrub` globally with

```
dotnet tool install --global scrub
``` 





