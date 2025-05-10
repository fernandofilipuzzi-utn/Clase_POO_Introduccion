@echo off
setlocal enabledelayedexpansion

REM Verifica que haya 3 argumentos
if "%~3"=="" (
    echo Uso: %0 Persona Nombre DNI
    exit /b 1
)

set NUMERO_OBJETO=%1
set NOMBRE=%2
set DNI=%3
set TEMPLATE=.\ElEscriba\Relevamiento\Models\Persona\Persona.plantilla
set OUTPUT=.\ElEscriba\Relevamiento\Datas\objeto_%NUMERO_OBJETO%.instancia

REM Crear archivo con reemplazos
(for /f "usebackq delims=" %%A in ("%TEMPLATE%") do (
    set "linea=%%A"
    call set "linea=%%linea:VALOR_NOMBRE=%NOMBRE%%%"
    call set "linea=%%linea:VALOR_DNI=%DNI%%%"
    echo !linea!
)) > "%OUTPUT%"

echo Archivo generado: %OUTPUT%