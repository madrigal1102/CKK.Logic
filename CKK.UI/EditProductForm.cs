using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKK.UI
{
    public partial class EditProductForm : Form
    {
        public Product EditedProduct { get; private set; }
        public EditProductForm(Product product)
        {
            InitializeComponent();
            EditedProduct = product;

            nameTextBox.Text = product.Name;
            quantityTextBox.Text = product.Quantity.ToString();
            priceTextBox.Text = product.Price.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
          !int.TryParse(quantityTextBox.Text, out int quantity) ||
          !decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Please provide valid inputs for all fields.");
                return;
            }

            // Update the EditedProduct object with new data
            EditedProduct.Name = nameTextBox.Text;
            EditedProduct.Quantity = quantity;
            EditedProduct.Price = price;

            DialogResult = DialogResult.OK; // Signal success
            Close();
        }
    }
    
}
