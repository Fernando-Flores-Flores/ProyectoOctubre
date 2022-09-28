namespace BackAgosto.Entidades
{
    public class DetalleInventario
    {
        public int Id { get; set; }
        public string detalle { get; set; }
        public int nro { get; set; }
        public int cantidad { get; set; }
        public string codigo { get; set; }
        public string oficina { get; set; }
        public string equipo{ get; set; }
        public string observaciones{ get; set; }
        public string area { get; set; }

        public Inventario Inventario { get; set; }
    }
}
