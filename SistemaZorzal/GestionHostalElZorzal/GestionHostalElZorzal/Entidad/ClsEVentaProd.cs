using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHostalElZorzal.Entidad
{
    class ClsEVentaProd
    {
        public string DniCli { get; set; }
        public string Codigo { get; set; }
        public string Cantidad { get; set; }
        public string PrecioUnit { get; set; }
        public string CantidadCompra { get; set; }
        public string Importe { get; set; }

        public string ImporteFinal { get; set; }

        public string Estado { get; set; }
    }
}
