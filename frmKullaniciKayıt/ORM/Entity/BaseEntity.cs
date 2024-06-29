using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKullaniciKayıt.ORM.Entity
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public DateTime? Deletetime { get; set; }
        [Required]
        public bool Aktifmi { get; set; }
    }
}
