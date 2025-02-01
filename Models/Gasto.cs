public class Gasto
{
    public int ID { get; set; }
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public decimal Monto { get; set; }
    public int ID_Empleado { get; set; }
    public Empleado Empleado { get; set; }
}
