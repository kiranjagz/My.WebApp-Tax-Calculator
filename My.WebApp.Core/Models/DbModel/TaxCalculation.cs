using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My.WebApp.Core.Models.DbModel
{
    public class TaxCalculation
    {
        [Key]
        [Display(Name = "id")]
        public int TaxCalculationId {get;set;}
        [Display(Name = "date created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "name")]
        public string Name { get; set; }
        [Display(Name = "tax calculated")]
        public decimal TaxCalculated { get; set; }
        [Display(Name = "annual income")]
        public decimal AnnualIncome { get; set; }
        [Display(Name = "tax type")]
        public string CalculationType { get; set; }
    }
}
