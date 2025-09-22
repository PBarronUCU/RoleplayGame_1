using Library;

namespace ProgramNamespace 
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            Elfo Patri = new Elfo("Patri");
            Elfo Rodri = new Elfo("Rodri");

            
            Item arco = new Item("arco", 20, 0);
            Item escudo = new Item("escudo", 0, 20);

            Patri.AgregarItem(arco);
            Rodri.AgregarItem(escudo);

            // Probar ataque
            Patri.Atacar_Elfo(Rodri);
            Console.WriteLine($"Vida de {Rodri.Nombre} después del ataque: {Rodri.Vida}");
        }
    }
}