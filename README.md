# Mouse Bounder

<p align="center">
  <img src="https://raw.githubusercontent.com/kdserra/Mouse-Bounder/main/Preview/app.png"/>
</p>

<p align="center">
  Restrict the mouse to the bounds of a Windows application.
</p>

## Usage

1. Open Mouse Bounder
2. Open the Process List
3. Select a Process
4. Press the "Bound" button
5. Done!
6. When you are finished, press the "Unbound" button.

The refresh button will update the process list.

## Download

Head to the [Releases](https://github.com/kdserra/Mouse-Bounder/releases).

## Build Information

C# Windows Form Application

Target Framework
.NET 7

Built using Visual Studio 2022

### Publish

To produce the final binaries run `publish.bat`

The final binary will be located in:
```.\Mouse-Bounder\Mouse-Bounder\bin\Release\net7.0-windows\<RID>\publish\```

Where `<RID>` is the [runtime identifier](https://learn.microsoft.com/en-us/dotnet/core/rid-catalog):
- win-x64
- win-x86
- win-arm64
