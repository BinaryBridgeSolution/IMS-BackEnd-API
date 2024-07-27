using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class Item
    {
        [Required]
        [MaxLength(300)]
        public string ItemId { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
