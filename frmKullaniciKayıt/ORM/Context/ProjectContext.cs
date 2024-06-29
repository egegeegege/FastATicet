using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmKullaniciKayıt.ORM.Entity;

namespace frmKullaniciKayıt.ORM.Context
{
    internal class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=.;Database=FastATicet;uid=sa;pwd=1453";
        }
        public DbSet<Ucuslar> Ucuslars { get; set; }
        public DbSet<Yoneticiler> Yoneticilers { get; set; }
    }
}
