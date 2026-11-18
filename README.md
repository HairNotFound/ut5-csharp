# UT5 PR05 · Solución C#

Una solución (`UT5_PR05.sln`) con un proyecto de consola por bloque. Cada proyecto tiene un menú interactivo.

| Proyecto | Funciones |
|---|---|
| ProyectoArray | Máximo, mínimo, mediana, media, ordenar, desviación típica, binarizar |
| ProyectoNumero | Primo, factorial, segundos a h/min/s, serie de Pell, Armstrong, dígitos diferentes |
| ProyectoString | Palíndromo, mayúsculas/minúsculas, ocurrencias, repetir strings, duplicar letras, borrar apariciones |
| ProyectoDecimales | Redondear al alza, quitar decimales, ecuación de segundo grado |

Para ejecutar uno: `dotnet run --project ProyectoArray` (requiere .NET 8 o superior).

## Cómo trabajar

1. Nunca se programa en `main` ni en `develop`.
2. Crea tu rama desde `develop`: `git switch develop`, `git pull` y `git switch -c feature/nombre-tarea`.
3. Commits pequeños con mensaje claro: `feat: calcular mediana`, `fix: error al leer número vacío`.
4. Sube tu rama (`git push -u origin feature/nombre-tarea`) y abre un pull request hacia `develop`.
5. El jefe revisa el PR y lo fusiona. Después mueve tu issue a DONE y ciérralo.

Al final de cada sprint, el jefe fusiona `develop` en `main` con un pull request.
