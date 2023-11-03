using System.Reflection.Metadata;
using Libreria.Autor;
using Libreria.Libro;
using Libreria.AutorHandlers;
using Libreria.LibroHandlesrs;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<LibroDTO> BDL = new List<LibroDTO>();
AutorHandles autorhandles = new AutorHandles();
List<AutorDTO> BDA = autorhandles.Autor;
LibroHandles librohandles = new LibroHandles(BDL, autorhandles);

app.MapGet("/api/v1/autores", () =>
{
    return Results.Ok(autorhandles.ALL());
});

app.MapPost("/api/v1/autores", (AutorDTO autor) =>
{
    autorhandles.CrearAutor(autor);

    return Results.Ok(autor);
});

app.MapPut("/api/v1/autores/{id:guid}", (Guid id, AutorDTO autor) =>
{
    autorhandles.ActualizarAutor(autor, id);
    return Results.Ok(autorhandles.ALL());
});


app.MapDelete("/api/v1/autores/{id:guid}", (Guid id) =>
{
    autorhandles.EliminarAutor(id);
    return Results.Ok(autorhandles.ALL());
});

app.MapGet("/api/v1/libros", () =>
{
    return Results.Ok(librohandles.ALL());
});
app.MapGet("/api/v1/autores/{id}", (Guid id) =>
{
    if (autorhandles.encontrado(id))
    {
        return Results.Ok(autorhandles.ObtenerAutorPorId(id));
    }
    return Results.BadRequest("no se encontro el Autor");

});

app.MapPost("/api/v1/libros", (LibroDTO libro) =>
{
    if (librohandles.CrearLibro(libro))
    {
        return Results.Ok(libro);
    }
    return Results.BadRequest(libro);
});

app.MapPut("/api/v1/libros/{id:guid}", (Guid id, LibroDTO libro) =>
{
    librohandles.ActualizarLibro(libro, id);
    return Results.Ok(librohandles.ALL());
});

app.MapDelete("/api/v1/libros/{id:guid}", (Guid id) =>
{
    librohandles.EliminarLibro(id);
    return Results.Ok(librohandles.ALL());
});
app.MapGet("/api/v1/libros/{id:guid}", (Guid id) =>
{

    if (librohandles.encontrado(id))
    {
        return Results.Ok(librohandles.ObtenerLibroPorId(id));
    }
    return Results.BadRequest("no se encontro el libro");

});



app.Run();
