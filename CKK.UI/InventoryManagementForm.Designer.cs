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
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(25, 75);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(25, 93);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(170, 23);
            idTextBox.TabIndex = 1;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(258, 75);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(49, 15);
            productLabel.TabIndex = 2;
            productLabel.Text = "Product";
            // 
            // productTextBox
            // 
            productTextBox.Location = new Point(258, 93);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(170, 23);
            productTextBox.TabIndex = 3;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(504, 75);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(53, 15);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(504, 93);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(170, 23);
            quantityTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(25, 142);
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
            InventoryListBox.Location = new Point(25, 228);
            InventoryListBox.Name = "InventoryListBox";
            InventoryListBox.Size = new Size(339, 199);
            InventoryListBox.TabIndex = 7;
            // 
            // allStoreItems
            // 
            allStoreItems.FormattingEnabled = true;
            allStoreItems.ItemHeight = 15;
            allStoreItems.Location = new Point(418, 229);
            allStoreItems.Name = "allStoreItems";
            allStoreItems.Size = new Size(335, 199);
            allStoreItems.TabIndex = 8;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(258, 142);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(170, 23);
            removeItemButton.TabIndex = 9;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click_1;
            // 
            // viewAllButton
            // 
            viewAllButton.Location = new Point(504, 142);
            viewAllButton.Name = "viewAllButton";
            viewAllButton.Size = new Size(170, 23);
            viewAllButton.TabIndex = 10;
            viewAllButton.Text = "View All Items";
            viewAllButton.UseVisualStyleBackColor = true;
            viewAllButton.Click += viewAllButton_Click_1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(293, 188);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(168, 23);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
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
    }
}