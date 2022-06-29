public class Fichero {
    private string nombre;
    private string extension;
    private string ruta;

    public string Ruta { get => ruta; set => ruta = value; }
    public string Extension { get => extension; set => extension = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    public Fichero(string nombre, string extension, string ruta) {
        this.Nombre = nombre;
        this.Extension = extension;
        this.Ruta = ruta;
    }
}
