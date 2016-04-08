using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Permissionamento.Context
{
    public class Contexto : IdentityDbContext<IdentityUser>
    {
        public Contexto()
            : base(@"Data SourceFilter=(localdb)\mssqllocaldb ;Integrated Security=True; CatalogLocation=LibraPermissionamento; Connect Timeout=15; Encrypt=False; TrustServerCertificate=False")
        {

        }

        public static Contexto Create()
        {
            return new Contexto();
        }
    }
}