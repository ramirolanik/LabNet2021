using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPoo
{
    public class Avion : Transporte

    {
        public Avion (int cantidadPasajeros, string name):base(cantidadPasajeros, name)
        {

        }
        public override string Pasajeros()
        {
            return $"{nombre} Tiene {cantidadPasajeros} pasajeros";
        }

        public override string Avanzar()
        {
             return "Soy un avion y estoy avanzando";
        }

        public override string Detenerse()
        {
            return "Soy un avion y estoy detenido";
        }

        
    }
}
