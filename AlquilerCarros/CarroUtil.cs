using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class CarroUtil{
        public static void crearCarro(CarroUtil[] carros, ref int count){
            Console.WriteLine("Ingresar placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Ingresar marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingresar precio de alquiler:");
            double precioalquiler = double.Parse(Console.ReadLine());

            Carro estudiante = new Carro{
                Placa = placa,
                Marca = marca,
                PrecioAlquiler = precioalquiler,
            };
            count++;
            Console.WriteLine("carro creado");
        }
        public static void listarCarro(CarroUtil[] carros, int count){
            Console.WriteLine("--- Lista de Carro ---");
            for (int i = 0; i < count; i++){
                Console.WriteLine($"{i + 1}. {carros[i].ToString()}");
            }
        }
        public static void eliminarCarro(CarroUtil[] carros, int count){
            Console.Write("Ingrese el numero de carro a eliminar: ");
            int indice = int.Parse(Console.ReadLine());
            if (indice > 0){
                for (int i = indice; i < count - 1; i++){
                    carros[i] = carros[i + 1];
                }
                carros[count - 1] = null;
                count--;
                Console.WriteLine("Carro eliminado.");
            }
        }
    }
}
