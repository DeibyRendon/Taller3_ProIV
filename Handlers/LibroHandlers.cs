namespace Libreria.LibroHandlesrs;
using Libreria.Libro;
using Libreria.AutorHandlers;
public class LibroHandles
{
    private AutorHandles _autorHandles;
    private List<LibroDTO> _libro;
    public LibroHandles(List<LibroDTO> libro,AutorHandles autorHandles)
    {   this.AutorHandles=autorHandles;
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

    public Boolean create(LibroDTO libro )
    {
        Boolean registrado = false;
        if (AutorHandles.encontrado(libro.autorid))
        {
            this._libro.Add(libro);
            registrado = true;
        }
        return registrado;

    }


    /*     public void create(LibroDTO libro)
        {

            this._libro.Add(libro);

        } */

    public void update(LibroDTO libro, Guid id)
    {
        foreach (LibroDTO buscarlibro in this._libro)
            if (buscarlibro.id == id)
            {
                buscarlibro.titulo = libro.titulo;
                break;
            }
    }

}