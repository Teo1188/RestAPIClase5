# RestAPIClase5
Rest API Clase 5

API REST con .NET
Este repositorio contiene una API REST construida con .NET que permite realizar operaciones básicas de gestión de datos. La API está diseñada para facilitar la integración con sistemas externos a través de solicitudes HTTP.

Endpoints Disponibles
A continuación se detallan los principales endpoints de la API:

1. GET /weatherforecast
Descripción: Obtiene una lista de todos los elementos disponibles en la base de datos.
Respuesta: Retorna una lista de objetos con la información de cada elemento.
2. GET /WeatherForecast/{id}
Descripción: Obtiene un elemento específico por su ID.
Parámetros:
id: El ID del elemento que deseas obtener.
Respuesta: Un objeto con la información del elemento solicitado.
3. POST /WeatherForecast
Descripción: Crea un nuevo elemento en la base de datos.
Cuerpo de la solicitud:
json
```bash
{
    "date": "2025-01-20",
    "temperatureC": 19,
    "summary": "Mild"
}
```
Respuesta: Retorna el objeto creado, incluyendo su ID asignado.
5. PUT /WeatherForecast/{id}
Descripción: Actualiza un elemento existente por su ID.
Parámetros:
id: El ID del elemento que deseas actualizar.
Cuerpo de la solicitud:
json
```bash
{
    "date": "2025-01-20",
    "temperatureC": 19,
    "summary": "Mild"
}
```
Respuesta: Retorna el objeto actualizado.
6. DELETE /WeatherForecast/{id}
Descripción: Elimina un elemento por su ID.
Parámetros:
id: El ID del elemento que deseas eliminar.
Respuesta: Un mensaje de confirmación de eliminación.
Pruebas con Postman
Este repositorio incluye una colección de Postman que puedes importar para realizar pruebas directamente contra los endpoints de la API. La colección está disponible en el archivo postman_collection.json.

Cómo usar la colección de Postman:
Descarga el archivo Ejercicioclase5API.postman_collection desde este repositorio.
Abre Postman y selecciona "Importar".
Importa el archivo descargado.
Una vez importada la colección, podrás realizar las pruebas a los endpoints de la API.
Instalación
Clona este repositorio en tu máquina local:
```bash
git clone https://github.com/Teo1188/RestAPIClase5.git
```
Abre el proyecto en Visual Studio o tu editor de código preferido.
Restaura los paquetes NuGet:

dotnet restore
Ejecuta el proyecto:
dotnet run
La API debería estar corriendo en http://localhost:5057
