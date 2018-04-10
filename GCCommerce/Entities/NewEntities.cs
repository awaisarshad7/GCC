using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GCCommerce.Entities
{
    public class NewEntities
    {
        
        public int NewsId { get; set; }
        [Required]
        public string NewsValue { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
