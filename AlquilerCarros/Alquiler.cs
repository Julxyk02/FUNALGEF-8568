using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class Alquiler{
        public int numero { get; set; }
        public Carro CarroAlq { get; set; }
        public Cliente Contraste { get; set; }
        public double Precio { get; set; }
        public override string ToString(){
            return $"Numero: {numero}, Alquilar: {CarroAlq}, Contraste: {Contraste}, Precio: {Precio}";
        }
    }
}
