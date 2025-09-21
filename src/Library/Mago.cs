namespace Library;
/// <summary>
/// Clase mago,tiene objetos magicos y libro de hehcizo especiales.
/// </summary>
public class Mago
{
    public string Nombre {get; set;}
    public int Vida { get; set; } = 100;
    /// <summary>
    /// Constructor de Mago, solo hace falta el nombre
    /// </summary>
    
    public Mago(string name)
    {
        this.Nombre = name;
    }

    private List<Item> Lista_Items = new List<Item>();
    private List<ItemMagico> Lista_ItemsMagicos = new List<ItemMagico>();
    private Libro Libro_Hechizos;
    
    /// <summary>
    /// El ataque total se calcula solamente en base a los objetos
    /// </summary>
    public int Ataque_total
    {
        get
        {
            int resultado = 0;
            foreach (var item in Lista_Items)
            {
                resultado += item.Ataque;
            }

            foreach (var itemMagico in Lista_ItemsMagicos)
            {
                resultado += itemMagico.Ataque;
            }

            if (Libro_Hechizos != null)
            {
                int damage = Libro_Hechizos.Hechizo.Ataque;
                resultado += damage;
            }
            
            return resultado;
        }
        
    }
    /// <summary>
    /// La defensa total se calcula solamente en base a los objetos
    /// </summary>
    public int Defensa_total
    {
        get
        {
            int resultado = 0;
            foreach (var item in Lista_Items)
            {
                resultado += item.Defensa;
            }

            foreach (var itemMagico in Lista_ItemsMagicos)
            {
                resultado += itemMagico.Defensa;
            }
            return resultado;
        }
        
    }

    public void Atacar_Elfo(Elfo elfo)
    {
        int danio = this.Ataque_total;
        int defensa = elfo.Defensa_total;
        int danio_resultante;
        if (defensa > danio)
        {
            danio_resultante = 0;
        }
        else
        {
            danio_resultante = danio - defensa; 
        }

        if (danio_resultante >= elfo.Vida)
        {
            elfo.Vida = 0;
        }
        else
        {
            elfo.Vida -= danio_resultante;
        }
    }
    
    public void Atacar_Enano(Enano enano)
    {
        int danio = this.Ataque_total;
        int defensa = enano.Defensa_total;
        int danio_resultante;
        if (defensa > danio)
        {
            danio_resultante = 0;
        }
        else
        {
            danio_resultante = danio - defensa; 
        }

        if (danio_resultante >= enano.Vida)
        {
            enano.Vida = 0;
        }
        else
        {
            enano.Vida -= danio_resultante;
        }
    }
    
    public void Atacar_Mago(Mago mago)
    {
        int danio = this.Ataque_total;
        int defensa = mago.Defensa_total;
        int danio_resultante;
        if (defensa > danio)
        {
            danio_resultante = 0;
        }
        else
        {
            danio_resultante = danio - defensa; 
        }

        if (danio_resultante >= mago.Vida)
        {
            mago.Vida = 0;
        }
        else
        {
            mago.Vida -= danio_resultante;
        }
    }

    public void Agregar_Item(Item item)
    {
        Lista_Items.Add(item);
    }

    public void Quitar_Item(Item item)
    {
        Lista_Items.Remove(item);
    }
    
    public void Agregar_ItemMagico(ItemMagico itemMag)
    {
        Lista_ItemsMagicos.Add(itemMag);
    }
    
    public void Quitar_ItemMagicos(ItemMagico itemMag)
    {
        Lista_ItemsMagicos.Remove(itemMag);
    }

    public void Agregar_Libro(Libro libro)
    {
        Libro_Hechizos = libro;
    }

    public void Quitar_Libro()
    {
        Libro_Hechizos = null;
    }
    
}


