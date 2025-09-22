namespace Library;

public class Elfo
{
    public string Nombre { get; set; }
    public int Vida { get; set; } = 100;

    private List<Item> Lista_Items = new List<Item>();

    public Elfo(string nombre)
    {
        this.Nombre = nombre;
    }

    public void AgregarItem(Item item)
    {
        Lista_Items.Add(item);
    }

    public void QuitarItem(Item item)
    {
        Lista_Items.Remove(item);
    }

    public int Ataque_total
    {
        get
        {
            int resultado = 0;
            foreach (var item in Lista_Items)
            {
                resultado += item.Ataque;
            }
            return resultado;
        }
    }

    public int Defensa_total
    {
        get
        {
            int resultado = 0;
            foreach (var item in Lista_Items)
            {
                resultado += item.Defensa;
            }
            return resultado;
        }
    }

    // Método de ataque 
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
    public void Curar_Elfo(Elfo elfo)
    {
        elfo.Vida = 100;
    }

    public void Curar_Mago(Mago mago)
    {
        mago.Vida = 100;
    }

    public void Curar_Enano(Enano enano)
    {
        enano.Vida = 100;
    }
    
    public void Curar()
    {
        this.Vida = 100;
    }

    
    

}


    
    
