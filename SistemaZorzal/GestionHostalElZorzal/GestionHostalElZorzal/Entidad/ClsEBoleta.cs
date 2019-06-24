using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHostalElZorzal.Entidad
{
    class ClsEBoleta
    {
        public string ruc { get; set; }
        public string fecha { get; set; }
        public string serie { get; set; }
        public string numero { get; set; }
        public string codEmp { get; set; }
        public string nomEmp { get; set; }
        public string dniCli { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }
    }
}
