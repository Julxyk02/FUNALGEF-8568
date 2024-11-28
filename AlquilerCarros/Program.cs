using AlquilerCarros;

AlquilerUtil[] alquier = new AlquilerUtil[100];
ClienteUtil[] clientes = new ClienteUtil[100];
CarroUtil[] carros = new CarroUtil[100];

int carrosCount = 0, servicioCount = 0, boletaCount = 0;
string regresar = "";
do{
    Console.WriteLine("--------Menú--------");
    Console.WriteLine("1.Agregar carro");
    Console.WriteLine("2.Listar carro");
    Console.WriteLine("3.Eliminar carro");
    Console.WriteLine("4.Agregar cliente");
    Console.WriteLine("5.Listar cliente");
    Console.WriteLine("6.Eliminar cliente");
    Console.WriteLine("7.agregar alquiler");
    Console.WriteLine("8.Listar alquiler");
    Console.WriteLine("9.Carros al alquilar");
    Console.WriteLine("Seleccionar opcion:");
    int opcion = int.Parse(Console.ReadLine());
    switch(opcion){
        case 1:
            CarroUtil.crearCarro(carros,ref carrosCount);
            break;
        case 2:
            CarroUtil.listarCarro(carros, carrosCount);
            break;
        case 3:
            CarroUtil.eliminarCarro(carros, carrosCount);
            break;
        case 4:
            ClienteUtil.crearCliente(clientes, ref carrosCount);
            break;
        case 5:
            ClienteUtil.listarCliente(clientes, carrosCount);
            break;
        case 6:
            ClienteUtil.eliminarCliente(clientes, carrosCount);
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
    }
    Console.WriteLine("Regresar al menú?[si/no]");
    regresar = Console.ReadLine();
    Console.Clear();

} while(regresar == "si");
