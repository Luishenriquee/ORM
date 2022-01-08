using IdentityServer4.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
