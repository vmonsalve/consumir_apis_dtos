#Manejo de DTOs

Ejemplo donde estudiaremos el concepto dto, consumiendo una api externa.

## Como hacer funcionar el proyecto.

```
dotnet watch run --project CONSUMIR_API_DTOs.csproj
```

## Endpoint

    verbo: get
    url: http://localhost:5140/api/Posts

## appsetings.json

Agregar la url al archivo appsetting.json

```json 
"BaseUrlPosts" :"https://jsonplaceholder.typicode.com/posts"
```