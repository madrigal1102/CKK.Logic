
using CKK.Logic.Interfaces;
using CKK.Logic.Models;

namespace CKK.UI
{
    public partial class InventoryManagementForm : Form
    {
        Store store = new Store();
        public InventoryManagementForm(Store _store)
        {
            store = _store;
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = Int32.Parse(idTextBox.Text);
            product.Name = productTextBox.Text;
            int quantity = Int32.Parse(quantityTextBox.Text);

            store.AddStoreItem(product, quantity);

            InventoryListBox.Items.Add(product.Id + " " + product.Name + " " + quantity);

        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            List<StoreItem> allItems = store.GetStoreItems();

        }



        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}

