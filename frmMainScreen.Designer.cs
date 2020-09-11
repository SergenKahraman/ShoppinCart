namespace ShoppingCart
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstReceiptUnitPrice = new System.Windows.Forms.ListBox();
            this.lstReceiptAmount = new System.Windows.Forms.ListBox();
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnAddToProductsList = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.txtDisplayAmount = new System.Windows.Forms.TextBox();
            this.btnCLearAllCart = new System.Windows.Forms.Button();
            this.lstCartAmountOfProducts = new System.Windows.Forms.ListBox();
            this.btnRemoveFromProductList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN";
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.Color.White;
            this.lstProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 14;
            this.lstProducts.Location = new System.Drawing.Point(61, 87);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstProducts.Size = new System.Drawing.Size(205, 312);
            this.lstProducts.TabIndex = 1;
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.White;
            this.lstCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 14;
            this.lstCart.Location = new System.Drawing.Point(829, 87);
            this.lstCart.Name = "lstCart";
            this.lstCart.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCart.Size = new System.Drawing.Size(162, 312);
            this.lstCart.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(922, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sepet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(514, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fatura";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lstReceiptUnitPrice);
            this.panel1.Controls.Add(this.lstReceiptAmount);
            this.panel1.Controls.Add(this.lstReceipt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(323, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 412);
            this.panel1.TabIndex = 2;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(283, 338);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 1;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(339, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "BİRİM FİYAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(209, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "TOPLAM : ";
            // 
            // lstReceiptUnitPrice
            // 
            this.lstReceiptUnitPrice.BackColor = System.Drawing.Color.White;
            this.lstReceiptUnitPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstReceiptUnitPrice.FormattingEnabled = true;
            this.lstReceiptUnitPrice.ItemHeight = 14;
            this.lstReceiptUnitPrice.Location = new System.Drawing.Point(342, 57);
            this.lstReceiptUnitPrice.Margin = new System.Windows.Forms.Padding(6);
            this.lstReceiptUnitPrice.MultiColumn = true;
            this.lstReceiptUnitPrice.Name = "lstReceiptUnitPrice";
            this.lstReceiptUnitPrice.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstReceiptUnitPrice.Size = new System.Drawing.Size(74, 256);
            this.lstReceiptUnitPrice.TabIndex = 1;
            // 
            // lstReceiptAmount
            // 
            this.lstReceiptAmount.BackColor = System.Drawing.Color.White;
            this.lstReceiptAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstReceiptAmount.FormattingEnabled = true;
            this.lstReceiptAmount.ItemHeight = 14;
            this.lstReceiptAmount.Location = new System.Drawing.Point(239, 57);
            this.lstReceiptAmount.Margin = new System.Windows.Forms.Padding(6);
            this.lstReceiptAmount.MultiColumn = true;
            this.lstReceiptAmount.Name = "lstReceiptAmount";
            this.lstReceiptAmount.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstReceiptAmount.Size = new System.Drawing.Size(74, 256);
            this.lstReceiptAmount.TabIndex = 1;
            // 
            // lstReceipt
            // 
            this.lstReceipt.BackColor = System.Drawing.Color.White;
            this.lstReceipt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.ItemHeight = 14;
            this.lstReceipt.Location = new System.Drawing.Point(16, 57);
            this.lstReceipt.Margin = new System.Windows.Forms.Padding(6);
            this.lstReceipt.MultiColumn = true;
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstReceipt.Size = new System.Drawing.Size(186, 256);
            this.lstReceipt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(256, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "ADET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(128, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürünler";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Location = new System.Drawing.Point(61, 454);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(205, 26);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "Sepete Ekle";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnAddToProductsList
            // 
            this.btnAddToProductsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToProductsList.Location = new System.Drawing.Point(12, 559);
            this.btnAddToProductsList.Name = "btnAddToProductsList";
            this.btnAddToProductsList.Size = new System.Drawing.Size(205, 26);
            this.btnAddToProductsList.TabIndex = 3;
            this.btnAddToProductsList.Text = "Listeye Yeni Ürün Ekle";
            this.btnAddToProductsList.UseVisualStyleBackColor = true;
            this.btnAddToProductsList.Click += new System.EventHandler(this.btnAddToProductsList_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(829, 415);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(205, 26);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "Sepetten Çıkar";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrease.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecrease.Location = new System.Drawing.Point(61, 409);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(43, 39);
            this.btnDecrease.TabIndex = 3;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncrease.Location = new System.Drawing.Point(223, 409);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(43, 39);
            this.btnIncrease.TabIndex = 2;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // txtDisplayAmount
            // 
            this.txtDisplayAmount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplayAmount.Location = new System.Drawing.Point(136, 415);
            this.txtDisplayAmount.Multiline = true;
            this.txtDisplayAmount.Name = "txtDisplayAmount";
            this.txtDisplayAmount.ReadOnly = true;
            this.txtDisplayAmount.Size = new System.Drawing.Size(56, 26);
            this.txtDisplayAmount.TabIndex = 4;
            this.txtDisplayAmount.Text = "1";
            this.txtDisplayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCLearAllCart
            // 
            this.btnCLearAllCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLearAllCart.Location = new System.Drawing.Point(829, 454);
            this.btnCLearAllCart.Name = "btnCLearAllCart";
            this.btnCLearAllCart.Size = new System.Drawing.Size(205, 26);
            this.btnCLearAllCart.TabIndex = 6;
            this.btnCLearAllCart.Text = "Sepeti Temizle";
            this.btnCLearAllCart.UseVisualStyleBackColor = true;
            this.btnCLearAllCart.Click += new System.EventHandler(this.btnCLearAllCart_Click);
            // 
            // lstCartAmountOfProducts
            // 
            this.lstCartAmountOfProducts.BackColor = System.Drawing.Color.White;
            this.lstCartAmountOfProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCartAmountOfProducts.FormattingEnabled = true;
            this.lstCartAmountOfProducts.ItemHeight = 14;
            this.lstCartAmountOfProducts.Location = new System.Drawing.Point(997, 87);
            this.lstCartAmountOfProducts.Name = "lstCartAmountOfProducts";
            this.lstCartAmountOfProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCartAmountOfProducts.Size = new System.Drawing.Size(37, 312);
            this.lstCartAmountOfProducts.TabIndex = 5;
            // 
            // btnRemoveFromProductList
            // 
            this.btnRemoveFromProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFromProductList.Location = new System.Drawing.Point(61, 486);
            this.btnRemoveFromProductList.Name = "btnRemoveFromProductList";
            this.btnRemoveFromProductList.Size = new System.Drawing.Size(205, 26);
            this.btnRemoveFromProductList.TabIndex = 0;
            this.btnRemoveFromProductList.Text = "Ürünlerden Çıkar";
            this.btnRemoveFromProductList.UseVisualStyleBackColor = true;
            this.btnRemoveFromProductList.Click += new System.EventHandler(this.btnRemoveFromProductList_Click);
            // 
            // frmMainScreen
            // 
            this.AccessibleDescription = "s";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 597);
            this.Controls.Add(this.txtDisplayAmount);
            this.Controls.Add(this.btnAddToProductsList);
            this.Controls.Add(this.btnCLearAllCart);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnRemoveFromProductList);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstCartAmountOfProducts);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnAddToProductsList;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.TextBox txtDisplayAmount;
        private System.Windows.Forms.Button btnCLearAllCart;
        private System.Windows.Forms.ListBox lstReceipt;
        private System.Windows.Forms.ListBox lstReceiptUnitPrice;
        private System.Windows.Forms.ListBox lstReceiptAmount;
        private System.Windows.Forms.ListBox lstCartAmountOfProducts;
        private System.Windows.Forms.Button btnRemoveFromProductList;
    }
}

