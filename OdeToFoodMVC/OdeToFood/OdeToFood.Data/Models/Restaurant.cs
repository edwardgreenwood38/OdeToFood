using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        //public IEnumerable<Restaurant> Restaurants { get; set; }
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
