namespace Library;

public class ItemMagico
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public ItemMagico(string nombre, int ataque, int defensa)
    {
        Nombre = nombre;
        Ataque = ataque;
        Defensa = defensa; 
    }
}