﻿using System;
namespace assignment_5.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumItems { get; set;}

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
