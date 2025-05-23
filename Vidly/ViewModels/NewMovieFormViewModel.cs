﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewMovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }


        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte? StockAmount { get; set; }

        public IEnumerable<Genre> Genres { get; set; }   

        public string Title 
        { 
            get
            {
                return (Id != 0) ? "Edit Movie" : "New Movie";
            }
        }

        public NewMovieFormViewModel()
        {
            Id = 0;
        }

        public NewMovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            StockAmount = movie.StockAmount;
            GenreId = movie.GenreId;
        }
    }
}