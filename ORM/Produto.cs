using IdentityServer4.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
