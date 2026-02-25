// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var Lista_Clientes = new List<Clientes>();
Lista_Clientes.Add(new Clientes() { Id = 1, Cedula = "721", Nombre = "Pepito", Correo = "pepito@email.com", Fecha = new DateTime(1995, 1, 1), Estado = false });
Lista_Clientes.Add(new Clientes() { Id = 2, Cedula = "842", Nombre = "Susana", Correo = "susana@email.com", Fecha = new DateTime(2010, 12, 24), Estado = true });
Lista_Clientes.Add(new Clientes() { Id = 3, Cedula = "952", Nombre = "Felipe", Correo = "felipe@email.com", Fecha = new DateTime(1954, 6, 13), Estado = true });

Console.WriteLine("Clientes activos");
foreach (var Cliente in Lista_Clientes.Where(x => x.Estado))
{
    Console.WriteLine(Cliente.Id + "|" + Cliente.Cedula + "|" + Cliente.Nombre + "|" + Cliente.Correo + "|" + Cliente.Fecha + "|" + Cliente.Estado);
}

var Lista_Productos = new List<Productos>();
Lista_Productos.Add(new Productos() { Id = 1, Codigo = "P01", Nombre= "Papitas", Cantidad= 73, Valor= 10000.0m});
Lista_Productos.Add(new Productos() { Id = 2, Codigo = "P02", Nombre = "Gaseosa", Cantidad = 22, Valor = 4200.0m }); 
Lista_Productos.Add(new Productos() { Id = 3, Codigo = "P03", Nombre = "Brownie", Cantidad = 5, Valor = 1000.0m });
Console.WriteLine("Mostrar Menu");
foreach (var Productos in Lista_Productos)
{
    Console.WriteLine(Productos.Id + "|" + Productos.Codigo + "|" + Productos.Nombre + "|" + Productos.Cantidad + "|" + Productos.Valor);
}
var Lista_Ventas = new List<Ventas>();
Lista_Ventas.Add(new Ventas(){Id =1, Codigo = "FA001", Cliente = 1, Fecha = new DateTime(2025, 1 ,1) Descuento = 0.0m, Total = 19000.0m});
Lista_Ventas.Add(new Ventas(){Id =2, Codigo = "FA002", Cliente = 3, Fecha = new DateTime(2026, 1 ,1) Descuento = 0.25m, Total = 750.0m});
Lista_Ventas.Add(new Ventas(){Id =3, Codigo = "FA003", Cliente = 1, Fecha = new DateTime(2026, 1 ,1) Descuento = 0.0m, Total = 10000,0m});

foreach (var Venta in Lista_Ventas)
{
    Console.WriteLine(Ventas.Id + "|" + Ventas.Codigo + "|" + Ventas.Cliente + "|" + Ventas.Fecha + "|" + Ventas.Descuento + "|" + Ventas.Total);
}

public class Clientes
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Correo { get; set; }
    public DateTime Fecha { get; set; }
    public bool Estado { get; set; }
    public List<Ventas>? Venta { get; set; }
}

public class Ventas
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
    public decimal Descuento { get; set; }
    public int Clientes { get; set; }
    public Clientes? _Cliente { get; set; }
    public List<VentasProductos>? VentaProducto { get; set; }
}

public class Productos
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Nombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Valor { get; set; }
    public List<VentasProductos>? VentaProducto { get; set; } 

}
public class VentasProductos
{
    public int Id { get; set; }
    public int Venta { get; set; }
    public int Productos { get; set; }
    public Ventas? _Venta { get; set; }
    public Productos? _Producto { get; set; }

}
