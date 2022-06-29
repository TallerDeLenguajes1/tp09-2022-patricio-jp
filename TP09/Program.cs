using System.Text.Json;

var options = new JsonSerializerOptions { WriteIndented = true };

Console.WriteLine("Ingrese la ruta en donde desea trabajar: ");
string entrada = Console.ReadLine();
Console.Clear();

while (!Directory.Exists(entrada)) {
    Console.WriteLine("Directorio inválido. Ingrese uno válido");
    entrada = Console.ReadLine();
    Console.Clear();
}

List<string> ListadoArchivos = Directory.GetFiles(entrada, "*", SearchOption.AllDirectories).ToList();

List<Fichero> ficheros = new List<Fichero>();

Console.WriteLine($"Archivos dentro de \"{entrada}\":");
for (int i = 0; i < ListadoArchivos.Count; i++) {
    Console.WriteLine(ListadoArchivos[i]);
    string[] archivoInfoAbsoluta = ListadoArchivos[i].Split('\\');
    string nombreArchivo = archivoInfoAbsoluta.Last().Split('.').First();
    string extensionArchivo = archivoInfoAbsoluta.Last().Split('.').Last();
    string rutaArchivo = ListadoArchivos[i];
    ficheros.Add(new Fichero(nombreArchivo, extensionArchivo, rutaArchivo));
}

using (StreamWriter sw = new StreamWriter("index.json")) {
    string jsonString = JsonSerializer.Serialize(ficheros, options);
    sw.WriteLine(jsonString);

    sw.Close();
}