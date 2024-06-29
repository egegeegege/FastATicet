using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace frmKullaniciKayıt.ORM.Entity
{
    internal class Yoneticiler : BaseEntity
    {
        [Required]
        public string Adı { get; set; }
        [Required]
        public string Soyadı { get; set; }
        [Required]
        public string TC { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Sifre { get; set; }
        
        List<Ucuslar> Ucuslars = new List<Ucuslar>();
    }
}
