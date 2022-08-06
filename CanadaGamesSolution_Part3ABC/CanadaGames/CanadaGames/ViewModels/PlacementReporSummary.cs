using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CanadaGames.ViewModels
{
    public class PlacementReporSummary
    {
        public int ID { get; set; }

        [Display(Name = "Athlete")]
        public string FullName
        {
            get
            {
                return FirstName
                    + (string.IsNullOrEmpty(MiddleName) ? " " :
                        (" " + (char?)MiddleName[0] + ". ").ToUpper())
                    + LastName;
            }
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Display(Name = " Average placement")]
        public decimal Averageplacement { get; set; }

        [Display(Name = "Highest placement")]
        public int HighestPlacement { get; set; }

        [Display(Name = "Lowest placement")]
        public double Lowestplacement { get; set; }

        [Display(Name = "Total Events")]
        public double TotalEvents { get; set; }
    }
}
