@ECHO OFF

SET project="Raylib_FrameWork"
SET framework="netcoreapp3.1"
SET config="Release"

dotnet build %project%.csproj --configuration "%config%"
dotnet exec bin/%config%/%framework%/RayDot.dll
dotnet clean %project%.csproj --configuration "%config%"

@REM PAUSE
