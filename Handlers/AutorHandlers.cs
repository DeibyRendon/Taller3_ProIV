namespace Libreria.AutorHandlers;
using Libreria.Autor;

public class AutorHandles
{
    private List<AutorDTO> _autor;
    public AutorHandles(List<AutorDTO> autor)
    {
        this._autor = autor;
    }
    public AutorHandles()
    {
        
    }

    public List<AutorDTO> ALL()
    {
        return this._autor;
    }

    public void create(AutorDTO autor)
    {
        this._autor.Add(autor);
    }



    public void update(AutorDTO autor, Guid id)
    {
        foreach (AutorDTO buscar_Autor in this._autor)
            if (buscar_Autor.id == id)
            {
                buscar_Autor.nombre = autor.nombre;
                buscar_Autor.nacionalidad = autor.nacionalidad;

                break;
            }
    }

    public Boolean encontrado(Guid id)
    {
        Boolean encontrado = false;

        foreach (AutorDTO buscar_Autor in this._autor)
            if (buscar_Autor.id == id)
            {
                encontrado = true;
                break;
            }

        return encontrado;
    }

}