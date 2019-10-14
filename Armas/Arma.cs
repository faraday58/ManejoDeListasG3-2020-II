namespace Armas
{
    public class Arma
    {

        #region Atributos
        private string nombre;
        private float precio;
        private byte stock;
        private string descripcion;

      
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public byte Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        #endregion

        #region Constructor
        public Arma(string nombre, float precio, byte stock, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Descripcion = descripcion;
        }
        #endregion




    }
}
