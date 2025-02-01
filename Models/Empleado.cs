public class Empleado
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public int ID_Departamento { get; set; }
    public Departamento Departamento { get; set; }
}
