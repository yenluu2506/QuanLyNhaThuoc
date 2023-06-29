using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HieuThuoc.Models
{
    public class StoreEntity
    {

        [Key]
        public long ID { get; set; }

        [Required(ErrorMessage = "Password not null !")]
        public string Name { get; set; }
    }
}