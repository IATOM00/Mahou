@echo off
setlocal

set "ROOT=%~dp0"

if exist "%ROOT%bin" rd /q /s "%ROOT%bin"
if exist "%ROOT%obj" rd /q /s "%ROOT%obj"
