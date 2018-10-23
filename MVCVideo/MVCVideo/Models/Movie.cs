using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCVideo.Models;

namespace MVCVideo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The name field is required")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name="Number in Stock")]
        public int NumberInStuck { get; set; }

        public Genre genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public int GenreId { get; set; }
    }
}