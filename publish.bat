:: Mouse Bounder Publish Script
:: Produces the final binaries for release

dotnet publish -r win-x86 -c Release
dotnet publish -r win-x64 -c Release
dotnet publish -r win-arm64 -c Release

PAUSE