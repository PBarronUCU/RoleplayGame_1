namespace Library;

public class Hechizo
{
    public string Nombre { get; set; }
    public int Ataque { get; set;  }

    public Hechizo(string nombre, int ataque)
    {
        Nombre = nombre;
        Ataque = ataque;
    }
}