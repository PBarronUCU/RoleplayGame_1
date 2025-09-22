using Library;

namespace LibraryTests;
/// <summary>
/// Tests para la clase <see cref="Elfo"/>.
/// </summary>

public class Elfotest
{
    [SetUp]
    public void Setup()
    {


    }

    [Test]
    public void TestProperties()
    {
        const string name = "Nombre";
        Elfo rodri = new Elfo(name);
        
        Assert.AreEqual(name, rodri.Nombre);

        const string anothername = "OtroNombre";
        rodri.Nombre = anothername;
        
        Assert.AreEqual(anothername, rodri.Nombre);

    }

    
    /// <summary>
    /// Prueba la propiedad <see cref="Elfo.Ataque_total"/>.
    /// </summary>
    [Test]
    public void Ataque_total()
    {
        Item Objeto1 = new Item("Arco", 20, 0);
        Item Objeto2 = new Item("Capa", 0, 10);
        Elfo Legolas = new Elfo("Legolas");
        Legolas.AgregarItem(Objeto1);
        Legolas.AgregarItem(Objeto2);
        Assert.AreEqual(100, Legolas.Ataque_total);


    }
}