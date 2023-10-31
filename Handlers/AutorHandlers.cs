namespace Libreria.AutorHandlers;
using Libreria.Autor;

public class AutorHandles
{
    private List<AutorDTO> _autor;

    public List<AutorDTO> Autor { get => _autor; set => _autor = value; }

    public AutorHandles()
    {
        this.Autor = new List<AutorDTO>();
    }
    

    public List<AutorDTO> ALL()
    {
        return this.Autor;
    }

    public void create(AutorDTO autor)
    {
        this.Autor.Add(autor);
    }



    public void update(AutorDTO autor, Guid id)
    {
        foreach (AutorDTO buscar_Autor in this.Autor)
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
        foreach (AutorDTO buscar_Autor in this.Autor)
            if (buscar_Autor.id == id)
            {
                encontrado = true;
                break;
            }

        return encontrado;
    }

}