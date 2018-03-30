using System.Collections.Generic;
using pieshop.Models;

namespace pieshop.ViewModels
{
    public class HomeViewModel{
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}