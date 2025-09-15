using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techly.DAL.Models;

namespace Techly.DAL.ViewModels
{
    public class ShoppingCartVm
    {
        public IEnumerable<ShoppingCart> ShoppingCartList { get; set; }
        public OrderHeader OrderHeader { get; set; }
        
    }
}
