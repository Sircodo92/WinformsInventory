﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms.Inventory
{
    public class InventoryItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //toString method   
        public override string ToString()
        {
            return ItemNo + " " + Description + " " + Price.ToString("c");
        }
    }
}
