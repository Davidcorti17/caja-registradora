const string nombreComercio = "KIOSCO EL RECREO";

Console.WriteLine("=== " + nombreComercio + " ===");

Console.Write("Nombre del cajero: ");
string cajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {cajero}. Caja abierta.");

Console.Write("Nombre del producto: ");
string producto = Console.ReadLine();

Console.Write("Precio: ");
decimal precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Producto: {producto} - Precio: ${precio}");