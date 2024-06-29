using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKullaniciKayıt.ORM.Entity
{
    public class Ucuslar : BaseEntity
    {
        public int UcusID { get; set; }
        public int YoneticiID { get; set; }

        public DateTime AlisTarihi { get; set; }
        public DateTime BinisTarihi { get; set; }
        public double FaturaTutarı { get; set; }

        List<Yoneticiler> Yoneticilers = new List<Yoneticiler>();
    }
}
