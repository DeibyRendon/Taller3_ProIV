using System.Reflection.Metadata;
using Libreria.Autor;
using Libreria.Libro;
using Libreria.AutorHandlers;
using Libreria.LibroHandlesrs;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<AutorDTO> BDA = new List<AutorDTO>();
List<LibroDTO> BDL = new List<LibroDTO>();
LibroHandles librohandles = new LibroHandles(BDL);
AutorHandles autorhandles = new AutorHandles(BDA);


app.MapGet("/api/v1/autor", () =>
{
    return Results.Ok(autorhandles.ALL());
});

app.MapGet("/api/v1/libro", () =>
{
    return Results.Ok(librohandles.ALL());
});

app.MapPost("/api/v1/autor", (AutorDTO autor) =>
{
    autorhandles.create(autor);
    return Results.Ok(autor);
});

app.MapPost("/api/v1/libro", (LibroDTO libro) =>
{
    librohandles.create(libro);
    return Results.Ok(libro);
});

app.MapPut("/api/v1/autor/{id:guid}", (Guid id, AutorDTO autor) =>
{
    autorhandles.update(autor, id);
    return Results.Ok(autorhandles.ALL());
});

app.MapPut("/api/v1/libro/{id:guid}", (Guid id, LibroDTO libro) =>
{
    librohandles.update(libro, id);
    return Results.Ok(librohandles.ALL());
});


app.Run();
