public class Producto {
    private string[] Nombres = {"Fernet Branca", "Cerveza Quilmes", "Termidor tinto", "Vodka Smirnoff", "Coca-Cola", "Pepsi", "Papas Lays", "Secco Naranja", "Chocolinas", "Merengadas", "Maní", "Pochoclos", "Praliné"};
    private string[] Sizes = {"Pequeño", "Mediano", "Grande", "Extra-Grande"};
    private string nombre;
    private DateTime fechaVencimiento;
    private float precio;
    private string tamanio;

    public string Nombre { get => nombre; set => nombre = value; }
    public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamanio { get => tamanio; set => tamanio = value; }

    public Producto() {
        DateTime limitDate = new DateTime(2025, 12, 31);
        int range = (limitDate - DateTime.Today).Days;
        Random rnd = new Random();
        this.Nombre = Nombres[rnd.Next(13)];
        this.Tamanio = Sizes[rnd.Next(4)];
        this.Precio = rnd.Next(1000, 5001);
        this.FechaVencimiento = DateTime.Today.AddDays(rnd.Next(range));
    }

    public override string ToString() {
        return $"Nombre: {this.Nombre}\nTamaño: {this.Tamanio}\nFecha de vencimiento: {this.FechaVencimiento.ToShortDateString()}\nPrecio: ${this.Precio}";
    }
}