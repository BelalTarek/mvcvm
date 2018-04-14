using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace RCS.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser user { get; set; }

        public string UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Model { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public int NumberOfChairs { get; set; }

        [Required]
        public float RentAmount { get; set; }

        [Required]
        public bool isAvailable { get; set; }

        [Required]
        public string color { get; set; }



    }
}