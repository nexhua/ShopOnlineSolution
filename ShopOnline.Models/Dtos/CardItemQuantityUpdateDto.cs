using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CardItemQuantityUpdateDto
    {
        public int CardItemId { get; set; }
        public int Quantity { get; set; }
    }
}
