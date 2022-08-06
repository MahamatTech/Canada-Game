using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CanadaGames.Views
{
    public class PlacementWithUserVM
    {
        [Display(Name = "Placment Name")]
        public string PlacmentName { get; set; }

        [Display(Name = "User Account")]
        public string UserName { get; set; }

        [Display(Name = "User Name")]
        public string UserFullName { get; set; }

    }
}
