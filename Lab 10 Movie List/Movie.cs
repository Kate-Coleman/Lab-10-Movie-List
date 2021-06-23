﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Movie_List
{
    public class Movie
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie(string title, string category)
        { 
            Title = title;
            Category = category;
        }
    public Movie()
        {
        }
    }
}
