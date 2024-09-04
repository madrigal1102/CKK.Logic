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
            saveButton = new Button();
            searchBox = new TextBox();
            searchByName = new Button();
            sortByQuantity = new Button();
            sortbyPrice = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(25, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(25, 49);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(170, 23);
            idTextBox.TabIndex = 1;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(258, 31);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(49, 15);
            productLabel.TabIndex = 2;
            productLabel.Text = "Product";
            // 
            // productTextBox
            // 
            productTextBox.Location = new Point(258, 49);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(170, 23);
            productTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(481, 31);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(53, 15);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(481, 49);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(170, 23);
            quantityTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(25, 88);
            addButton.Name = "addButton";
            addButton.Size = new Size(170, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // InventoryListBox
            // 
            InventoryListBox.FormattingEnabled = true;
            InventoryListBox.ItemHeight = 15;
            InventoryListBox.Location = new Point(25, 203);
            InventoryListBox.Name = "InventoryListBox";
            InventoryListBox.Size = new Size(339, 199);
            InventoryListBox.TabIndex = 7;
            // 
            // allStoreItems
            // 
            allStoreItems.FormattingEnabled = true;
            allStoreItems.ItemHeight = 15;
            allStoreItems.Location = new Point(418, 203);
            allStoreItems.Name = "allStoreItems";
            allStoreItems.Size = new Size(335, 199);
            allStoreItems.TabIndex = 8;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(25, 131);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(170, 23);
            removeItemButton.TabIndex = 9;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click_1;
            // 
            // viewAllButton
            // 
            viewAllButton.Location = new Point(25, 174);
            viewAllButton.Name = "viewAllButton";
            viewAllButton.Size = new Size(170, 23);
            viewAllButton.TabIndex = 10;
            viewAllButton.Text = "View All Items";
            viewAllButton.UseVisualStyleBackColor = true;
            viewAllButton.Click += viewAllButton_Click_1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(558, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(168, 23);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(583, 160);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(170, 23);
            searchBox.TabIndex = 12;
            // 
            // searchByName
            // 
            searchByName.Location = new Point(502, 159);
            searchByName.Name = "searchByName";
            searchByName.Size = new Size(75, 23);
            searchByName.TabIndex = 13;
            searchByName.Text = "Search";
            searchByName.UseVisualStyleBackColor = true;
            searchByName.Click += searchByName_Click;
            // 
            // sortByQuantity
            // 
            sortByQuantity.Location = new Point(502, 118);
            sortByQuantity.Name = "sortByQuantity";
            sortByQuantity.Size = new Size(119, 23);
            sortByQuantity.TabIndex = 14;
            sortByQuantity.Text = "Sort By Quantity";
            sortByQuantity.UseVisualStyleBackColor = true;
            sortByQuantity.Click += sortByQuantity_Click;
            // 
            // sortbyPrice
            // 
            sortbyPrice.Location = new Point(645, 118);
            sortbyPrice.Name = "sortbyPrice";
            sortbyPrice.Size = new Size(108, 23);
            sortbyPrice.TabIndex = 15;
            sortbyPrice.Text = "sortByPrice";
            sortbyPrice.UseVisualStyleBackColor = true;
            sortbyPrice.Click += sortbyPrice_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(sortbyPrice);
            Controls.Add(sortByQuantity);
            Controls.Add(searchByName);
            Controls.Add(searchBox);
            Controls.Add(saveButton);
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