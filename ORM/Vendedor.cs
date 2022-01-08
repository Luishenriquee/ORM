using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    [Class(Table = "Vendedor")]
    class Vendedor
    {
        [Id(Column = "Cod_Vendedor")]
        public int Cod_Vendedor;

        [Property]
        public string Nome_Vendedor { get; set; }

        [Property]
        public string Meta_de_Venda { get; set; }
    }
}
