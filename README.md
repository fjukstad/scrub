![.NET Core](https://github.com/fjukstad/scrub/workflows/.NET%20Core/badge.svg)
![https://www.nuget.org/packages/scrub](https://img.shields.io/nuget/v/scrub?color=success&logoColor=white&logo=NuGet)

# scrub

A simple `dotnet` tool for removing `bin` or `obj` folders. Especially
useful if you are switching between developing on Windows and WSL frequently,
and you want to quickly clean out any left-over files. The difference between
`scrub` and
[`clean`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-clean) is
that `scrub` removes everything within the `bin` or `obj` folders, not just the
build artifacts created by `MSBuild`.

# Usage

Simply run `scrub` in any folder you want to clean out. It will recursively
traverse any folder and remove all `bin` and `obj` folders it encounters.

## Example

### Basic

```sh
bjorn:/mnt/c/src/scrub$ scrub
Should I remove '/mnt/c/src/scrub/bin'? y/n
y
Removing '/mnt/c/src/scrub/bin'
Should I remove '/mnt/c/src/scrub/obj'? y/n
y
Removing '/mnt/c/src/scrub/obj'
```

### Skip user interaction

You can skip user interaction by running `scrub` with `--ask false`:

```sh
bjorn:/mnt/c/src/scrub$ scrub --ask false
Removing '/mnt/c/src/scrub/bin'
Removing '/mnt/c/src/scrub/obj'
```

### Where to `scrub`

You can also point it to where it should scrub await folders with `--path`

```sh
bjorn:/mnt/c/src$ scrub --path scrub/ --ask false
Removing '/mnt/c/src/scrub/bin'
Removing '/mnt/c/src/scrub/obj'
```

### List folders

If you only want to list out `bin` and `obj` folders that `scrub` finds, run it
with the `--list` flag:

```sh
bjorn:/mnt/c/src/scrub$ scrub --list
'/mnt/c/src/scrub/bin'
'/mnt/c/src/scrub/obj'
```

# Install

Install `scrub` globally with

```
dotnet tool install --global scrub
```
