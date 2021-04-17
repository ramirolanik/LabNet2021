using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPoo
{
    public class Automovil : Transporte

    {
        public Automovil (int cantidadPasajeros, string name):base(cantidadPasajeros, name)
        {

        }                   
            public override string Pasajeros()
        {
            return $"{nombre} Tiene {cantidadPasajeros} pasajeros";
        }
        
        public override string Avanzar()
        {
            return "Soy un auto y estoy avanzando";
        }

        public override string Detenerse()
        {
            return "Soy un auto y estoy detenido";
        }
    }
}
