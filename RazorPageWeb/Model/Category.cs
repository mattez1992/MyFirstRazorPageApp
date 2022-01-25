using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPageWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(1,100, ErrorMessage = "Must be between 1 and 100.")]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
