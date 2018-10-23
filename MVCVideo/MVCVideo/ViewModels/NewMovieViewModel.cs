using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCVideo.Models;

namespace MVCVideo.ViewModels
{
    public class NewMovieViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "The name field is required")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int? NumberInStuck { get; set; }



        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }
        public IEnumerable<Genre> genres { get; set; }
        public string Title
        {
            get
            {
                return (Id != 0) ? "Edit Movie" : "New Movie";



            }
        }
        public NewMovieViewModel()
        {
            Id = 0;
        }
        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStuck = movie.NumberInStuck;
            GenreId = movie.GenreId;
        }
    }
}