const string comercio = "KIOSCO EL RECREO";
const decimal descuento10 = 0.10m;
const decimal descuento5 = 0.05m;
const decimal descuentoEfectivo = 0.10m;
const decimal recargoCredito = 0.15m;

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
            decimal totalConDescuento = total - descuento;

            int pago = 0;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Medio de pago:");
                Console.WriteLine("1 - Efectivo");
                Console.WriteLine("2 - Débito");
                Console.WriteLine("3 - Crédito");
                pago = Convert.ToInt32(Console.ReadLine());

                if (pago != 1 && pago != 2 && pago != 3)
                {
                    Console.WriteLine("Esa opción no existe.");
                }
            }
            while (pago != 1 && pago != 2 && pago != 3);

            decimal totalFinal = 0;

            switch (pago)
            {
                case 1:
                    totalFinal = totalConDescuento - (totalConDescuento * descuentoEfectivo);
                    Console.WriteLine("Pago en efectivo: 10% de descuento.");
                    break;

                case 2:
                    totalFinal = totalConDescuento;
                    Console.WriteLine("Pago con débito: sin cambios.");
                    break;

                case 3:
                    totalFinal = totalConDescuento + (totalConDescuento * recargoCredito);
                    Console.WriteLine("Pago con crédito: 15% de recargo.");
                    break;
            }

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