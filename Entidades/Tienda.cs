using System;
using System.Collections.Generic;
using System.Text;

namespace Cap10_12.Entidades
{
    public class Tienda
    {
        public int ArticuloId { get; set; }
        public string NombreArticulo { get; set; }
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public int CantidadArticulo { get; set; }
        public string Descripcion { get; set; }
    }
}
