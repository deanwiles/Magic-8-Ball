@echo off
echo Copying Image files from "%~dp0..\Images\" to "%~dp0wwwroot\images\" ...
xcopy /y "%~dp0..\Images\Magic 8 Ball.png" "%~dp0wwwroot\images\"
xcopy /y "%~dp0..\Images\Rotating Magic 8 Ball.gif" "%~dp0wwwroot\images\"
xcopy /y "%~dp0..\Images\favicon_package_v0.16\*.png" "%~dp0wwwroot\images\"
xcopy /y "%~dp0..\Images\favicon_package_v0.16\*.ico" "%~dp0wwwroot\images\"
xcopy /y "%~dp0..\Images\favicon_package_v0.16\*.svg" "%~dp0wwwroot\images\"
