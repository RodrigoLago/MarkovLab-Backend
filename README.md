# MarkovLab Backend

API REST desarrollada con ASP.NET Core para ejecutar el algoritmo de Viterbi sobre secuencias de ADN mediante modelos ocultos de Markov (HMM).

La API utiliza el paquete NuGet MarkovLab, que contiene la implementación del algoritmo y los modelos necesarios para su ejecución.

## Funcionalidades

- Recepción de secuencias de ADN.
- Recepción de modelos HMM con sus probabilidades configuradas.
- Validación de modelos ocultos de Markov.
- Ejecución del algoritmo de Viterbi.
- Obtención de la secuencia de estados ocultos más probable.
- Exposición de los resultados mediante una API REST.

## Tecnologías

- C#
- ASP.NET Core 10
- Swagger / OpenAPI
- NuGet MarkovLab 1.0.0

## Requisitos

- .NET SDK 10

## Instalación y ejecución

Clonar el repositorio:

```bash
git clone https://github.com/RodrigoLago/MarkovLab-Backend.git
```

Acceder al directorio:

```bash
cd MarkovLab-Backend
```

Restaurar las dependencias:

```bash
dotnet restore
```

Ejecutar la aplicación:

```bash
dotnet run --launch-profile https
```

## Swagger

La documentación interactiva de la API está disponible en:

https://localhost:7259/swagger

## Endpoint

### Ejecutar Viterbi

POST /api/hmm/viterbi

Recibe un modelo HMM y una secuencia de ADN.

El modelo debe incluir:

- Estados ocultos y sus probabilidades iniciales.
- Probabilidades de transición entre estados.
- Probabilidades de emisión para los nucleótidos A, C, G y T.

### Respuesta

La API devuelve:

- statePath: camino de estados ocultos más probable.
- probability: probabilidad del camino y las observaciones.
- logProbability: probabilidad en escala logarítmica.
- steps: información de las etapas del algoritmo.

## Arquitectura

La API consume el paquete NuGet MarkovLab, manteniendo separada la lógica algorítmica de la capa HTTP.

El algoritmo de Viterbi y los modelos de dominio se encuentran implementados en la librería independiente.

## Proyectos relacionados

- Librería NuGet: https://github.com/RodrigoLago/MarkovLab
- Frontend: https://github.com/RodrigoLago/MarkovLab-Frontend

## Autor

Lago Rodrigo Iván

## Licencia

MIT