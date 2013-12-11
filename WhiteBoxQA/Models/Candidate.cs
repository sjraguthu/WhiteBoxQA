using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WhiteBoxQA.Models
{
    public class Candidate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int FavoriteNumber { get; set; }

        public int Remainder { get; set; }
    }
}