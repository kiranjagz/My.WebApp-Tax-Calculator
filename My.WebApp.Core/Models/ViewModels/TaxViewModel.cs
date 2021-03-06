﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My.WebApp.Core.Models.ViewModels
{
    public class TaxViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "annual income")]
        public double AnnualIncome { get; set; }
        [Display(Name = "postal code")]
        public string PostalCode { get; set; }
    }
}
