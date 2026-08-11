const string nombreComercio = "KIOSCO EL RECREO";

Console.WriteLine("=== " + nombreComercio + " ===");

Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

decimal total = 0;
int cantidad = 0;
int opcion;

do
{
    Console.WriteLine("");
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del producto: ");
            string producto = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            total = total + precio;
            cantidad = cantidad + 1;

            Console.WriteLine($"Producto cargado: {producto} - ${precio}");
            break;

        case 2:
            Console.WriteLine("");
            Console.WriteLine("=== VENTA CERRADA ===");
            Console.WriteLine($"Productos cargados: {cantidad}");
            Console.WriteLine($"Total: ${total}");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }
}
while (opcion != 2);