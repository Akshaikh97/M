using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema; // For NotMapped

namespace Mvcapp.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        
        [Required]
        public string Category { get; set; }

        // Stored in database
        public string ImagePath { get; set; }
        
        // Not stored in database, used for upload
        [NotMapped]
        [Display(Name = "Image File")]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}