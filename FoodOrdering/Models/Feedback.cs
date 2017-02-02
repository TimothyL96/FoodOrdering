using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Message { get; set; }
    }
}
