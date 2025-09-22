using Library;

namespace LibraryTests;
/// <summary>
/// Tests para la clase <see cref="Mago"/>.
/// </summary>

public class MagoTest
{
    [SetUp]
    public void Setup()
    {


    }

    [Test]
    public void TestProperties()
    {
        const string name = "Nombre";
        Mago magician = new Mago(name);
        
        Assert.AreEqual(name, magician.Nombre);

        const string anothername = "OtroNombre";
        magician.Nombre = anothername;
        
        Assert.AreEqual(anothername, magician.Nombre);

    }

    
    /// <summary>
    /// Prueba la propiedad <see cref="Mago.Ataque_total"/>.
    /// </summary>
    [Test]
    public void Ataque_total()
    {
        Item Objeto1 = new Item("Uchigatana", 30, 0);
        Item Objeto2 = new Item("Cimitarra", 40, 0);
        ItemMagico ObjetoMagico1 = new ItemMagico("Staff", 10, 1);
        ItemMagico ObjetoMagico2 = new ItemMagico("RoyalStaff", 20, 0);
        Mago Ranni = new Mago("Ranni");
        Ranni.Agregar_Item(Objeto1);
        Ranni.Agregar_Item(Objeto2);
        Ranni.Agregar_ItemMagico(ObjetoMagico1);
        Ranni.Agregar_ItemMagico(ObjetoMagico2);
        Assert.AreEqual(100, Ranni.Ataque_total);


    }
}