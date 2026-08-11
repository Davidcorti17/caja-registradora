const string comercio = "KIOSCO EL RECREO";
const decimal descuento10 = 0.10m;
const decimal descuento5 = 0.05m;

Console.WriteLine("=== " + comercio + " ===");

Console.WriteLine("Nombre del cajero: ");
string cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

decimal total = 0;
int cantidad = 0;
int opcion = 0;

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
            Console.WriteLine("Nombre del producto: ");
            string producto = Console.ReadLine();

            Console.WriteLine("Precio: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            total = total + precio;
            cantidad = cantidad + 1;

            Console.WriteLine($"Cargaste: {producto}");
            break;

        case 2:
            decimal porcentaje = 0;

            if (total > 50000)
            {
                porcentaje = descuento10;
            }
            else if (total > 20000)
            {
                porcentaje = descuento5;
            }

            decimal descuento = total * porcentaje;
            decimal totalFinal = total - descuento;

            Console.WriteLine("");
            Console.WriteLine("VENTA CERRADA");
            Console.WriteLine($"Productos: {cantidad}");
            Console.WriteLine($"Subtotal: {total}");
            Console.WriteLine($"Descuento: {descuento}");
            Console.WriteLine($"Total a pagar: {totalFinal}");
            break;

        default:
            Console.WriteLine("Esa opción no existe.");
            break;
    }
}
while (opcion != 2);