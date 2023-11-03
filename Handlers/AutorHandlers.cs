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

    public void CrearAutor(AutorDTO autor)
    {
        this.Autor.Add(autor);
    }



    public void ActualizarAutor(AutorDTO autor, Guid id)
    {
        foreach (AutorDTO buscar_Autor in this.Autor)
            if (buscar_Autor.id == id)
            {
                buscar_Autor.nombre = autor.nombre;
                buscar_Autor.nacionalidad = autor.nacionalidad;

                break;
            }
    }

    public void EliminarAutor(Guid id)
    {
        foreach (AutorDTO buscar_Autor in this.Autor)
            if (buscar_Autor.id == id)
            {
                this._autor.Remove(buscar_Autor);
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

    public AutorDTO ObtenerAutorPorId(Guid id)
    {
        AutorDTO encontrado = null;

        foreach (AutorDTO buscar_Autor in this.Autor)
            if (buscar_Autor.id == id)
            {
                return buscar_Autor;

            }
        return encontrado;
    }



}