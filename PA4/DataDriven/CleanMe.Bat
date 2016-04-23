rmdir /S /Q Debug
rmdir /S /Q ipch
rmdir /S /Q Release
del /F /S *.sdf
del /F /S /A:H *.suo
rmdir /S /Q DataDriven\Debug
rmdir /S /Q DataDriven\Release
rmdir /S /Q DataDriven\bin
rmdir /S /Q DataDriven\obj