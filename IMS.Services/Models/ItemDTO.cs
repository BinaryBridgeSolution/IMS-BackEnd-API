using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Models
{
    public class ItemDTO
    {
        public string ItemId { get; set; }       
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
