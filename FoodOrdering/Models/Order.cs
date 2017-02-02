using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Models
{
    public class Order
    {
        public int Id { get; set; }

        [MaxLength(16)]
        public string AccountNumber { get; set; }

        public byte ExpMonth { get; set; }
        public byte ExpYear { get; set; }
        public byte CvcCode { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(6)]
        public string Zip { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
