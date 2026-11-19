# MarkovLabBackend

API ASP.NET Core 10 que consume el paquete público `MarkovLab` 1.0.0 de NuGet.org.

Abrir `MarkovLabBackend.slnx` en Visual Studio y ejecutar el perfil `https`.

- Swagger: `https://localhost:7259/swagger`
- Endpoint: `POST https://localhost:7259/api/hmm/viterbi`

La solución contiene un único proyecto en la raíz. No requiere el código de `MarkovLab.Domain` ni una base de datos.
