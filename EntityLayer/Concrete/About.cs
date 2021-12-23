﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string   AboutDetails1 { get; set; }
        
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }

        [StringLength(100)]
        public string AbountImage1 { get; set; }

        [StringLength(100)]
        public string AbountImage2 { get; set; }
    }
}
