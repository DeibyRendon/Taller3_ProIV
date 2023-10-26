namespace Libreria.AutorHandlers;
using Libreria.Autor;

public class AutorHandles{
    private List<AutorDTO> _autor;
    public AutorHandles(List<AutorDTO> autor)
    {
        this._autor = autor;
    }
    public List<AutorDTO> ALL(){
        return this._autor;
    }
    public void create(AutorDTO autor){
         this._autor.Add(autor);
    }

    public void update (AutorDTO autor, Guid id){
        foreach (AutorDTO buscarautor in this._autor)
        if (buscarautor.id == id)
        {
            buscarautor.nombre = autor.nombre;
            break;
        }
    }

}