namespace _09_Sistema_Ventas_Consola
{
    class Producto
    {

        public Producto() {
        }
        public Producto(int _cod_producto, string _producto, int _valor)
        {
            cod_producto = _cod_producto;
            producto = _producto;
            valor = _valor;
        }

        public int cod_producto { get; set; }
        public string producto { get; set; }
        public int valor { get; set; }
    }
}
