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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            NewInventoryItem addItemForm = new NewInventoryItem();
            addItemForm.ShowDialog();
            if (addItemForm.Item != null)
            {
                listBox1.Items.Add(addItemForm.Item);
                List<InventoryItem> items = InventoryDB.GetItems();
                items.Add(addItemForm.Item);
                InventoryDB.SaveItems(items);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex != -1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(selectedIndex);
                    List<InventoryItem> items = InventoryDB.GetItems();
                    items.RemoveAt(selectedIndex);
                    InventoryDB.SaveItems(items);
                    MessageBox.Show("Item has been deleted");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshItems()
        {
            listBox1.Items.Clear();
            List<InventoryItem> items = InventoryDB.GetItems();
            foreach (InventoryItem item in items)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }
    }
}
