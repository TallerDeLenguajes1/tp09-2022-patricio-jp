using System.Text.Json;

var options = new JsonSerializerOptions { WriteIndented = true };

Random rnd = new Random();

int cantProductos = rnd.Next(16);

Console.WriteLine($"Generando {cantProductos} productos aleatorios...");
List<Producto> productos = new List<Producto>();
for (int i = 0; i < cantProductos; i++) {
    productos.Add(new Producto());
}


Console.WriteLine("\nGuardando productos en \"productos.json\"...");

using (StreamWriter sw = new StreamWriter("productos.json")) {
    string jsonString = JsonSerializer.Serialize(productos, options);
    sw.WriteLine(jsonString);
    sw.Close();
}


Console.WriteLine("\nLeyendo productos ya generados...");
List<Producto> productosCargados;
using (StreamReader sr = new StreamReader("productos.json")) {
    string jsonStringRead = sr.ReadToEnd();
    productosCargados = JsonSerializer.Deserialize<List<Producto>>(jsonStringRead);
    sr.Close();
}

Console.WriteLine("\nProductos generados:");
foreach (Producto product in productosCargados) {
    Console.WriteLine(product.ToString() + "\n");
}
