using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YdGorev.Models.EF
{
    public class BasvuranPersoneller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Adi { get; set; }

        [Required]
        [MaxLength(50)]
        public string Soyadi { get; set; }
        [Required]
        [MaxLength(11)]
        public string TCKN { get; set; }
    }
}
