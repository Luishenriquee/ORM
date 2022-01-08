using IdentityServer4.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace ORM
{
    [Class(Table = "Cliente")]
    public class Cliente
    {
        [Id(Column = "Cod_Cliente")]
        public int Cod_Cliente { get; set; }

        [Property]
        public string Nome_cliente { get; set; }

        [Property]
        public string Endereco { get; set; }
    }
}
