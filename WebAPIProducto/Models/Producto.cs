namespace WebAPIProducto.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; //Por default que ponga este valor
        public string Descripcion { get; set; }= string.Empty; //Por default que ponga este valor
        public decimal Precio { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public bool Activo { get; set; }
    }
}