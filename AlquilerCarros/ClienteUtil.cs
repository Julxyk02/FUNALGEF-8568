using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    internal class ClienteUtil{
        public static void crearCliente(ClienteUtil[] clientes, ref int count){
            Console.WriteLine("Ingresar Dni:");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Pago:");
            double pagomaximo = double.Parse(Console.ReadLine());

            Cliente estudiante = new Cliente{
                Dni = dni,
                Nombre = nombre,
                PagoMaximo = pagomaximo,
            };
            count++;

            Console.WriteLine("cliente creado");

        }
        public static void listarCliente(ClienteUtil[] clientes, int count){
            Console.WriteLine("--- Lista de Cliente ---");
            for (int i = 0; i < count; i++){
                Console.WriteLine($"{i + 1}. {clientes[i].ToString()}");
            }
        }
        public static void eliminarCliente(ClienteUtil[] clientes, int count){
            Console.Write("Ingrese el numero de cliente a eliminar: ");
            int indice = int.Parse(Console.ReadLine());
            if (indice > 0){
                for (int i = indice; i < count - 1; i++){
                    clientes[i] = clientes[i + 1];
                }
                clientes[count - 1] = null;
                count--;
                Console.WriteLine("Cliente eliminado.");
            }
        }
    }
}
