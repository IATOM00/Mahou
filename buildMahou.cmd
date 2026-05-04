@echo off
setlocal

set "ROOT=%~dp0"
set "SLN=%ROOT%Mahou.sln"
set "MSBUILD=%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

echo Stopping running Mahou.exe instances, if any...
taskkill /f /im Mahou.exe >nul 2>nul

if exist "%ROOT%bin" rd /q /s "%ROOT%bin"
if exist "%ROOT%obj" rd /q /s "%ROOT%obj"

if not exist "%SLN%" (
    echo Solution file not found: "%SLN%"
    exit /b 1
)

if not exist "%MSBUILD%" (
    echo MSBuild not found: "%MSBUILD%"
    exit /b 1
)

pushd "%ROOT%" || exit /b 1
echo Building "%SLN%"
"%MSBUILD%" "%SLN%" /t:Rebuild /p:Configuration=Release /p:Platform=x86 /m
set "BUILD_EXIT=%ERRORLEVEL%"
popd

exit /b %BUILD_EXIT%
