namespace CKK.UI
{
    partial class InventoryManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.allStoreItems = new System.Windows.Forms.ListBox();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchByName = new System.Windows.Forms.Button();
            this.sortByQuantity = new System.Windows.Forms.Button();
            this.sortbyPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(25, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(33, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(25, 49);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(118, 23);
            this.priceTextBox.TabIndex = 1;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(149, 31);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(49, 15);
            this.productLabel.TabIndex = 2;
            this.productLabel.Text = "Product";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(149, 49);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(118, 23);
            this.productTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(273, 31);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 15);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(273, 49);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(118, 23);
            this.quantityTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(25, 78);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.ItemHeight = 15;
            this.InventoryListBox.Location = new System.Drawing.Point(25, 203);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(339, 199);
            this.InventoryListBox.TabIndex = 7;
            // 
            // allStoreItems
            // 
            this.allStoreItems.FormattingEnabled = true;
            this.allStoreItems.ItemHeight = 15;
            this.allStoreItems.Location = new System.Drawing.Point(418, 203);
            this.allStoreItems.Name = "allStoreItems";
            this.allStoreItems.Size = new System.Drawing.Size(409, 199);
            this.allStoreItems.TabIndex = 8;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(697, 437);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(130, 23);
            this.removeItemButton.TabIndex = 9;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(697, 408);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(130, 23);
            this.viewAllButton.TabIndex = 10;
            this.viewAllButton.Text = "View All Items";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(506, 159);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(199, 23);
            this.searchBox.TabIndex = 12;
            // 
            // searchByName
            // 
            this.searchByName.Location = new System.Drawing.Point(418, 159);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(75, 23);
            this.searchByName.TabIndex = 13;
            this.searchByName.Text = "Search";
            this.searchByName.UseVisualStyleBackColor = true;
            // 
            // sortByQuantity
            // 
            this.sortByQuantity.Location = new System.Drawing.Point(418, 437);
            this.sortByQuantity.Name = "sortByQuantity";
            this.sortByQuantity.Size = new System.Drawing.Size(130, 23);
            this.sortByQuantity.TabIndex = 14;
            this.sortByQuantity.Text = "Sort By Quantity";
            this.sortByQuantity.UseVisualStyleBackColor = true;
            // 
            // sortbyPrice
            // 
            this.sortbyPrice.Location = new System.Drawing.Point(418, 408);
            this.sortbyPrice.Name = "sortbyPrice";
            this.sortbyPrice.Size = new System.Drawing.Size(130, 23);
            this.sortbyPrice.TabIndex = 15;
            this.sortbyPrice.Text = "sortByPrice";
            this.sortbyPrice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Image";
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(417, 49);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(75, 23);
            this.selectImageButton.TabIndex = 17;
            this.selectImageButton.Text = "Image";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Location = new System.Drawing.Point(506, 49);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(143, 23);
            this.imagePathTextBox.TabIndex = 18;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 117);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(135, 23);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(926, 499);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortbyPrice);
            this.Controls.Add(this.sortByQuantity);
            this.Controls.Add(this.searchByName);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.allStoreItems);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "InventoryManagementForm";
            this.Text = "InventoryManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idLabel;
        private Label quantityLabel;
        private TextBox priceTextBox;
        private Label productLabel;
        private TextBox productTextBox;
        private TextBox quantityTextBox;
        private Button addButton;
        private ListBox InventoryListBox;
        private ListBox allStoreItems;
        private Button removeItemButton;
        private Button viewAllButton;
        private Button saveButton;
        private TextBox searchBox;
        private Button searchByName;
        private Button sortByQuantity;
        private Button sortbyPrice;
        private Label label1;
        private Button selectImageButton;
        private TextBox imagePathTextBox;
        private Button editButton;
    }
}