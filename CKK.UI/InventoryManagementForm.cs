
using CKK.DB.Interfaces;
using CKK.DB.Repositary;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.DB;

namespace CKK.UI
{
    public partial class InventoryManagementForm : Form
    {
        IUnitOfWork _unitOfWork;
        public InventoryManagementForm(IUnitOfWork uow)
        {
            _unitOfWork = uow;
            InitializeComponent();
        }


        private void LoadItems()
        {
            allStoreItems.Items.Clear();
            List<Product> allItems = _unitOfWork.Products.GetAll();

            foreach (Product item in allItems)
            {
                allStoreItems.Items.Add(item.Id + "-" + item.Price + "=" + item.Quantity + "-" + item.Name);
                if (!string.IsNullOrEmpty(item.ImagePath) && File.Exists(item.ImagePath))
                {
                    PictureBox productImage = new PictureBox();
                    productImage.Image = Image.FromFile(item.ImagePath);
                    productImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    productImage.Size = new Size(100, 100);
                    allStoreItems.Controls.Add(productImage);
                }
            }
        }

        private void InventoryManagementForm_Load_1(object sender, EventArgs e)
        {

        }

        private void searchByName_Click(object sender, EventArgs e)
        {

            List<Product> items = _unitOfWork.Products.GetAll();
            List<Product> search = _unitOfWork.Products.GetAll().Where(x => x.Name.Contains(searchBox.Text)).ToList();

            string searchName = search.FirstOrDefault().Name;

            foreach (Product item in items)
            {
                if (searchName == item.Name)
                {
                    allStoreItems.Items.Add(item.Id + "-" + item.Name + "=" + item.Quantity);
                }
            }
        }

        private void sortByQuantity_Click(object sender, EventArgs e)
        {
            List<Product> allItems = _unitOfWork.Products.GetAll().OrderBy(x => x.Quantity).ToList();
            LoadItems();
        }

        private void sortbyPrice_Click(object sender, EventArgs e)
        {
            List<Product> allItems = _unitOfWork.Products.GetAll().OrderBy(x => x.Price).ToList();
            LoadItems();
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePathTextBox.Text = openFileDialog.FileName; // Display the selected file path
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Price = Int32.Parse(idTextBox.Text);
            product.Name = productTextBox.Text;
            product.Quantity = Int32.Parse(quantityTextBox.Text);

            product.ImagePath = imagePathTextBox.Text;

            _unitOfWork.Products.Add(product);

            InventoryListBox.Items.Add(product.Price + "-" + product.Quantity + "=" + product.Name);

            idTextBox.Clear();
            productTextBox.Clear();
            quantityTextBox.Clear();
            imagePathTextBox.Clear();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            List<Product> items = _unitOfWork.Products.GetAll();
            if (allStoreItems.SelectedIndex != -1)
            {
                int itemToRemove = allStoreItems.SelectedIndex;
                string selectText = allStoreItems.Items[itemToRemove].ToString();
                int dashIndex = selectText.IndexOf("-");
                int prodId = int.Parse(selectText.Substring(0, dashIndex));


                _unitOfWork.Products.Delete(prodId);

                LoadItems();
            }
        }
    }
}

