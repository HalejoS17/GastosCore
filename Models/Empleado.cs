using System.ComponentModel.DataAnnotations.Schema;

public class Empleado
{
    public int ID { get; set; }
    public string Nombre { get; set; }

    [ForeignKey("Departamento")] // Vincula la FK correctamente
    [Column("ID_Departamento")]  // Asegura que usa el nombre exacto en la BD
    public int ID_Departamento { get; set; }

    public Departamento Departamento { get; set; }
}
