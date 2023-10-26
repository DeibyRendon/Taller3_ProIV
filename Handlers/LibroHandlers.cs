namespace Libreria.LibroHandlesrs;
using Libreria.Libro;
public class LibroHandles{
    private List<LibroDTO> _libro;
    public LibroHandles(List<LibroDTO> libro)
    {
        this._libro = libro;
    }
    public List<LibroDTO> ALL(){
        return this._libro;
    }
    public void create(LibroDTO libro){
         this._libro.Add(libro);
    }

    public void update (LibroDTO libro, Guid id){
        foreach (LibroDTO buscarlibro in this._libro)
        if (buscarlibro.id == id)
        {
            buscarlibro.titulo = libro.titulo;
            break;
        }
    }

}