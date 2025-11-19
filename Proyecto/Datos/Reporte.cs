using System;

public class Reporte
{
    public int IdReporte { get; set; }
    public int IdUsuario { get; set; }
    public int IdProducto { get; set; }
    public DateTime FechaReporte { get; set; }
    public string TipoReporte { get; set; } // "Venta", "Compra", "Devolucion"
    public int Cantidad { get; set; }
    public decimal Total { get; set; }
}