using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationOglasi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име")]
        public string ime { get; set; }
        [Required]
        [Display(Name = "Објаснување")]
        public string desc { get; set; }
        public List<Oglas> Albums { get; set; }
    }
}