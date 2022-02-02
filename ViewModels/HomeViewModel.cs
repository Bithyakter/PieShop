using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using BethanysPieShop.Models;
using PieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
