@echo off
rem Пакетный файл для приложения SimpleCSharpApp.exe,
rem который захватывает возвращаемое им значение.
SimpleCSharpApp
@if "%ERRORLEVEL%" == "0" goto success
:fail
rem Выполнение этого приложения не удалось!
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success
rem Выполнение этого приложения прошло успешно!
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
rem Все готово.
echo All Done.