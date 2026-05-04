@echo off
setlocal

set "ROOT=%~dp0"
set "SLN=%ROOT%Mahou.sln"
set "MSBUILD=%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

echo Stopping running Mahou.exe instances, if any...
taskkill /f /im Mahou.exe >nul 2>nul

set "MAHOU_WAIT=0"
:wait_for_mahou_exit
tasklist /fi "imagename eq Mahou.exe" 2>nul | find /i "Mahou.exe" >nul
if errorlevel 1 goto mahou_stopped
timeout /t 1 /nobreak >nul
set /a MAHOU_WAIT+=1
if %MAHOU_WAIT% lss 10 goto wait_for_mahou_exit

echo Mahou.exe is still running. Close it manually or run this script as administrator.
exit /b 1

:mahou_stopped

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
