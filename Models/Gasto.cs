using System.ComponentModel.DataAnnotations.Schema;

public class Gasto
{
    public int ID { get; set; }
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public decimal Monto { get; set; }

    [ForeignKey("Empleado")] // Vincula la FK correctamente
    [Column("ID_Empleado")]  // Asegura que usa el nombre exacto en la BD
    public int ID_Empleado { get; set; }

    public Empleado Empleado { get; set; }
}
