namespace Libreria.LibroHandlesrs;
using Libreria.Libro;
using Libreria.AutorHandlers;
public class LibroHandles
{
    private AutorHandles _autorHandles;
    private List<LibroDTO> _libro;
    public LibroHandles(List<LibroDTO> libro, AutorHandles autorHandles)
    {
        this.AutorHandles = autorHandles;
        this._libro = libro;
    }

    public AutorHandles AutorHandles { get => _autorHandles; set => _autorHandles = value; }

    public List<LibroDTO> ALL()
    {
        return this._libro;
    }

    /*    public void create(LibroDTO libro)
       {
           this._libro.Add(libro);
       } */

    public Boolean CrearLibro(LibroDTO libro)
    {
        Boolean registrado = false;
        if (AutorHandles.encontrado(libro.autorid))
        {
            this._libro.Add(libro);
            registrado = true;
        }
        return registrado;

    }

    public void ActualizarLibro(LibroDTO libro, Guid id)
    {
        foreach (LibroDTO buscarlibro in this._libro)
            if (buscarlibro.id == id)
            {
                buscarlibro.titulo = libro.titulo;
                break;
            }
    }

    public void EliminarLibro(Guid id)
    {
        foreach (LibroDTO buscar_libro in this._libro)
            if (buscar_libro.id == id)
            {
                this._libro.Remove(buscar_libro);
                break;
            }
    }

}