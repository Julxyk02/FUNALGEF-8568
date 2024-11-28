

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
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
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

} while(regresar == "si");
