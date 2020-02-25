using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Cuisine { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1,5)]
        public float Rating { get; set; }

        [Required]
        [Range(1,5)]
        public int AverageCost { get; set; }
    }
}