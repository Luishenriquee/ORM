using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    [Class(Table = "Produto")]
    class Produto
    {
        [Id(Column = Cod_Produto)]
        public int Cod_Produto;

        [Property]
        public string Ddescricao { get; set; }

        [Property]
        public float Valor_Unitario { get; set; }
    }
}
