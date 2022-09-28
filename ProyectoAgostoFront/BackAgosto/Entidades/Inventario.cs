namespace BackAgosto.Entidades
{
    public class Inventario
    {
        public int Id { get; set; }
        public string nombreInventario { get; set; }
        public string tipoInventario { get; set; }

        public List<DetalleInventario> detallesDelInventario { get; set; }


    }
}
