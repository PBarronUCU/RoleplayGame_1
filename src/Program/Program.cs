using Library;

namespace Program;

public static class Program
{
    public static void Main()
    {
        Mago Patri = new Mago("Patri");
        Elfo Rodri = new Elfo("Rodri");
        Libro Necronomicon =  new Libro("Necronomicon");
        Hechizo Fireball = new Hechizo("Fireball",10);
        Item Cimitarra = new Item("cimitarra", 110, 0);
        Item Escudo = new Item("escudo", 0, 20);
        ItemMagico MoonlightGreatsword = new ItemMagico("MoonlightGreatsword",50,0);
        Patri.Agregar_ItemMagico(MoonlightGreatsword);
        Patri.Agregar_Libro(Necronomicon);
        Rodri.AgregarItem(Cimitarra);
        Rodri.AgregarItem(Escudo);
        Necronomicon.Agregar(Fireball);
        Patri.Atacar_Elfo(Rodri);
        Console.WriteLine($"{Patri.Nombre} ataco a {Rodri.Nombre}.{Rodri.Nombre} quedo con {Rodri.Vida}");
        Rodri.Atacar_Mago(Patri);
        Console.WriteLine($"{Rodri.Nombre} ataco a {Patri.Nombre}.{Patri.Nombre} quedo con {Patri.Vida}");
        
    }
}