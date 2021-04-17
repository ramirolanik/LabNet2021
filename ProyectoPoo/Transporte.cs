using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPoo
{
    public abstract class Transporte
    {

        public int cantidadPasajeros { get; set; }

        public string nombre { get; set; }
            
               
                
        public Transporte(int cantidadPasajeros, string name)
        {
            this.nombre = name;
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public abstract string Pasajeros();

        public abstract string Avanzar();

        public abstract string Detenerse();


    }
}
