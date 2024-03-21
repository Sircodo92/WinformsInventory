using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Inventory
{
    public partial class NewInventoryItem : Form
    {
        public InventoryItem Item { get; set; }
        public NewInventoryItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            Item = new InventoryItem
            {
                ItemNo = Convert.ToInt32(txtItemNo.Text),
                Description = txtDescription.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };
            this.Close();
        }
    }
}
