# scrub
A simple `dotnet` tool for cleaning out any `bin` or `obj` folders. Especially
useful if you are switching between developing on Windows and WSL with Ubuntu.
The only difference between `scrub` and
[`clean`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-clean) is
that `scrub` removes everything within the `bin` or `obj` folders, not just the
build artifacts created by `MSBuild`. 

# Install
Install `scrub` globally with

```
dotnet pack
dotnet tool install --global --add-source ./nupkg scrub
``` 

and run it with

```
scrub
```

# Usage

Simply run `scrub` in any folder you want to clean out. It will recursively
traverse any folder and remove all `bin` and `obj` folders it encounters. 



