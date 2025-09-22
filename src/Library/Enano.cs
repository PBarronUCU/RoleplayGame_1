namespace Library
{
    public class Enano
    {
        public string Nombre { get; set; } //Nombre del enano.
        public int Vida { get; set; } = 100; //Vida del enano, el cual inicialmente es 100.
        
        private List<Item> Lista_Items = new List<Item>();

        public Enano(string nombre)
        {
            this.Nombre = nombre;
        }
        
        public void AgregarItem(Item item)
        {
            Lista_Items.Add(item); //Se agrega un item a la lista.
        }

        public void QuitarItem(Item item)
        {
            Lista_Items.Remove(item); //Se quita un item de la lista.
        }
        
        public int Ataque_Total
        {
            get
            {
                int resultado = 0; //En esta variable se sumará el valor de ataque de los items.
                foreach (var item in Lista_Items)
                {
                    resultado += item.Ataque; //Se recorre item por item y el valor de ataque se le suma a la variable de definimos previamente.
                }
                return resultado; //Se retorna el valor de ataque total.
            }
        }

       public int Defensa_total
        {
            get
            {
                int resultado = 0; //En esta variable se sumará el valor de defensa de los items.
                foreach (var item in Lista_Items)
                {
                    resultado += item.Defensa; //Se recorre item por item y el valor de defensa se le suma a la variable que definimos previamente.
                }
                return resultado; //Se retorna el valor de defensa total.
            }
        }

        public void Atacar_Elfo(Elfo elfo)
        {
            int danio = this.Ataque_Total; //Se le asigna el valor de AtaqueTotal al daño que resive.
            int defensa = elfo.Defensa_total; //Similar pasa con la Defensa.
            int danioResultante; //Se devuelve el daño que resive.

            if (defensa > danio)
            {
                danioResultante = 0; //Si la defensa es mayor al daño resivido, el daño total será 0.
            } else
            {
                danioResultante = danio - defensa;  //Sinó al daño resivido se le resta el valor de la defensa.
            }

            if (danioResultante >= elfo.Vida)
            {
                elfo.Vida = 0; //Si el daño que el elfo es mayor a su vida, su vida se volverá 0 y, por lo tanto, el elfo morirá.
            } else
            {
                elfo.Vida -= danioResultante; //Sinó, se le resta a su vida lo que resive de daño.
            }
        }
        public void Atacar_Mago(Mago mago)
        {
            int danio = this.Ataque_Total; //Se le asigna el valor de AtaqueTotal al daño que resive.
            int defensa = mago.Defensa_total; //Similar pasa con la Defensa.
            int danioResultante; //Se devuelve el daño que resive.

            if (defensa > danio)
            {
                danioResultante = 0; //Si la defensa es mayor al daño resivido, el daño total será 0.
            } else
            {
                danioResultante = danio - defensa;  //Sinó al daño resivido se le resta el valor de la defensa.
            }

            if (danioResultante >= mago.Vida)
            {
                mago.Vida = 0; //Si el daño que el mago es mayor a su vida, su vida se volverá 0 y, por lo tanto, el mago morirá.
            } else
            {
                mago.Vida -= danioResultante; //Sinó, se le resta a su vida lo que resive de daño.
            }
        }   
    
        public void Atacar_Mago(Enano enano)
        {
            int danio = this.Ataque_Total; //Se le asigna el valor de AtaqueTotal al daño que resive.
            int defensa = enano.Defensa_total; //Similar pasa con la Defensa.
            int danioResultante; //Se devuelve el daño que resive.

            if (defensa > danio)
            {
                danioResultante = 0; //Si la defensa es mayor al daño resivido, el daño total será 0.
            } else
            {
                danioResultante = danio - defensa;  //Sinó al daño resivido se le resta el valor de la defensa.
            }

            if (danioResultante >= enano.Vida)
            {
                enano.Vida = 0; //Si el daño que el enano es mayor a su vida, su vida se volverá 0 y, por lo tanto, el enano morirá.
            } else
            {
                enano.Vida -= danioResultante; //Sinó, se le resta a su vida lo que resive de daño.
            }
        }

        public int DefensaTotal { get; set; }
    }
}