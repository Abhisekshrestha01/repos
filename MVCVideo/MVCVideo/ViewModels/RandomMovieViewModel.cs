﻿using MVCVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVCVideo.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> customers { get; set; }
    }
} 