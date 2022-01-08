
using IdentityServer4.EntityFramework.Entities;
using MassTransit.Internals.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.FSharp.Core;
using Microsoft.ServiceBus.Management;
using NHibernate.Criterion;
using NPOI.HPSF;
using NUnit.Framework;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
