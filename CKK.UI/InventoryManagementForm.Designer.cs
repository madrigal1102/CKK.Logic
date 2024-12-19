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
            idLabel = new Label();
            idTextBox = new TextBox();
            productLabel = new Label();
            productTextBox = new TextBox();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            addButton = new Button();
            InventoryListBox = new ListBox();
            allStoreItems = new ListBox();
            removeItemButton = new Button();
            viewAllButton = new Button();
            searchBox = new TextBox();
            searchByName = new Button();
            sortByQuantity = new Button();
            sortbyPrice = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(29, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(41, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Price";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(29, 65);
            idTextBox.Margin = new Padding(3, 4, 3, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(194, 27);
            idTextBox.TabIndex = 1;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(295, 41);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(60, 20);
            productLabel.TabIndex = 2;
            productLabel.Text = "Product";
            // 
            // productTextBox
            // 
            productTextBox.Location = new Point(295, 65);
            productTextBox.Margin = new Padding(3, 4, 3, 4);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(194, 27);
            productTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(550, 41);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(65, 20);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(550, 65);
            quantityTextBox.Margin = new Padding(3, 4, 3, 4);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(194, 27);
            quantityTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(29, 117);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(194, 31);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // InventoryListBox
            // 
            InventoryListBox.FormattingEnabled = true;
            InventoryListBox.ItemHeight = 20;
            InventoryListBox.Location = new Point(29, 271);
            InventoryListBox.Margin = new Padding(3, 4, 3, 4);
            InventoryListBox.Name = "InventoryListBox";
            InventoryListBox.Size = new Size(387, 264);
            InventoryListBox.TabIndex = 7;
            // 
            // allStoreItems
            // 
            allStoreItems.FormattingEnabled = true;
            allStoreItems.ItemHeight = 20;
            allStoreItems.Location = new Point(478, 271);
            allStoreItems.Margin = new Padding(3, 4, 3, 4);
            allStoreItems.Name = "allStoreItems";
            allStoreItems.Size = new Size(382, 264);
            allStoreItems.TabIndex = 8;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(29, 175);
            removeItemButton.Margin = new Padding(3, 4, 3, 4);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(194, 31);
            removeItemButton.TabIndex = 9;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click_1;
            // 
            // viewAllButton
            // 
            viewAllButton.Location = new Point(29, 232);
            viewAllButton.Margin = new Padding(3, 4, 3, 4);
            viewAllButton.Name = "viewAllButton";
            viewAllButton.Size = new Size(194, 31);
            viewAllButton.TabIndex = 10;
            viewAllButton.Text = "View All Items";
            viewAllButton.UseVisualStyleBackColor = true;
            viewAllButton.Click += viewAllButton_Click_1;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(666, 213);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(194, 27);
            searchBox.TabIndex = 12;
            // 
            // searchByName
            // 
            searchByName.Location = new Point(574, 212);
            searchByName.Margin = new Padding(3, 4, 3, 4);
            searchByName.Name = "searchByName";
            searchByName.Size = new Size(86, 31);
            searchByName.TabIndex = 13;
            searchByName.Text = "Search";
            searchByName.UseVisualStyleBackColor = true;
            searchByName.Click += searchByName_Click;
            // 
            // sortByQuantity
            // 
            sortByQuantity.Location = new Point(574, 157);
            sortByQuantity.Margin = new Padding(3, 4, 3, 4);
            sortByQuantity.Name = "sortByQuantity";
            sortByQuantity.Size = new Size(136, 31);
            sortByQuantity.TabIndex = 14;
            sortByQuantity.Text = "Sort By Quantity";
            sortByQuantity.UseVisualStyleBackColor = true;
            sortByQuantity.Click += sortByQuantity_Click;
            // 
            // sortbyPrice
            // 
            sortbyPrice.Location = new Point(737, 157);
            sortbyPrice.Margin = new Padding(3, 4, 3, 4);
            sortbyPrice.Name = "sortbyPrice";
            sortbyPrice.Size = new Size(123, 31);
            sortbyPrice.TabIndex = 15;
            sortbyPrice.Text = "sortByPrice";
            sortbyPrice.UseVisualStyleBackColor = true;
            sortbyPrice.Click += sortbyPrice_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(914, 600);
            Controls.Add(sortbyPrice);
            Controls.Add(sortByQuantity);
            Controls.Add(searchByName);
            Controls.Add(searchBox);
            Controls.Add(viewAllButton);
            Controls.Add(removeItemButton);
            Controls.Add(allStoreItems);
            Controls.Add(InventoryListBox);
            Controls.Add(addButton);
            Controls.Add(quantityTextBox);
            Controls.Add(quantityLabel);
            Controls.Add(productTextBox);
            Controls.Add(productLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryManagementForm";
            Text = "InventoryManagementForm";
            Load += InventoryManagementForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label quantityLabel;
        private TextBox idTextBox;
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
    }
}