﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsumirAPI.Model
{
    public class Pie
    {
        public int PieID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
    }
}
