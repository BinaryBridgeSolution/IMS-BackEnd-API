using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Models
{
    public class CreateItemDTO
    {
        public string ItemId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
