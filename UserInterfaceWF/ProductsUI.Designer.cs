namespace UserInterfaceWF
{
    partial class ProductsUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductLastStockQuantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.txtProductFirstStockQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductSalesPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPurchasePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewProducts = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProductLastStockQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCreateNewProduct);
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnInsertProduct);
            this.groupBox1.Controls.Add(this.btnSaveProduct);
            this.groupBox1.Controls.Add(this.txtProductFirstStockQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProductSalesPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductProfit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProductPurchasePrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(299, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 441);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // lblProductLastStockQuantity
            // 
            this.lblProductLastStockQuantity.AutoSize = true;
            this.lblProductLastStockQuantity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductLastStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductLastStockQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductLastStockQuantity.Location = new System.Drawing.Point(157, 290);
            this.lblProductLastStockQuantity.Name = "lblProductLastStockQuantity";
            this.lblProductLastStockQuantity.Size = new System.Drawing.Size(0, 25);
            this.lblProductLastStockQuantity.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Güncel Stok :";
            // 
            // btnCreateNewProduct
            // 
            this.btnCreateNewProduct.Location = new System.Drawing.Point(249, 370);
            this.btnCreateNewProduct.Name = "btnCreateNewProduct";
            this.btnCreateNewProduct.Size = new System.Drawing.Size(76, 71);
            this.btnCreateNewProduct.TabIndex = 2;
            this.btnCreateNewProduct.Text = "Yeni";
            this.btnCreateNewProduct.UseVisualStyleBackColor = true;
            this.btnCreateNewProduct.Click += new System.EventHandler(this.btnCreateNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(167, 370);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(76, 71);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.Location = new System.Drawing.Point(85, 370);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(76, 71);
            this.btnInsertProduct.TabIndex = 2;
            this.btnInsertProduct.Text = "Düzelt";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(3, 370);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(76, 71);
            this.btnSaveProduct.TabIndex = 2;
            this.btnSaveProduct.Text = "Kaydet";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtProductFirstStockQuantity
            // 
            this.txtProductFirstStockQuantity.Location = new System.Drawing.Point(98, 228);
            this.txtProductFirstStockQuantity.Name = "txtProductFirstStockQuantity";
            this.txtProductFirstStockQuantity.Size = new System.Drawing.Size(218, 20);
            this.txtProductFirstStockQuantity.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İlk Stok Adeti";
            // 
            // txtProductSalesPrice
            // 
            this.txtProductSalesPrice.Location = new System.Drawing.Point(98, 184);
            this.txtProductSalesPrice.Name = "txtProductSalesPrice";
            this.txtProductSalesPrice.Size = new System.Drawing.Size(218, 20);
            this.txtProductSalesPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satış Fiyatı(TL) :";
            // 
            // txtProductProfit
            // 
            this.txtProductProfit.Location = new System.Drawing.Point(98, 144);
            this.txtProductProfit.Name = "txtProductProfit";
            this.txtProductProfit.Size = new System.Drawing.Size(218, 20);
            this.txtProductProfit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kar(%) :";
            // 
            // txtProductPurchasePrice
            // 
            this.txtProductPurchasePrice.Location = new System.Drawing.Point(98, 106);
            this.txtProductPurchasePrice.Name = "txtProductPurchasePrice";
            this.txtProductPurchasePrice.Size = new System.Drawing.Size(218, 20);
            this.txtProductPurchasePrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alış Fiyatı :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(98, 66);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(218, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı :";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(98, 29);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(218, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodu :";
            // 
            // lstViewProducts
            // 
            this.lstViewProducts.FormattingEnabled = true;
            this.lstViewProducts.Location = new System.Drawing.Point(5, 5);
            this.lstViewProducts.Name = "lstViewProducts";
            this.lstViewProducts.Size = new System.Drawing.Size(288, 433);
            this.lstViewProducts.TabIndex = 3;
            this.lstViewProducts.UseTabStops = false;
            this.lstViewProducts.SelectedIndexChanged += new System.EventHandler(this.lstViewProducts_SelectedIndexChanged);
            // 
            // ProductsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lstViewProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductsUI";
            this.Text = "ProductsUI";
            this.Load += new System.EventHandler(this.ProductsUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.TextBox txtProductFirstStockQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductSalesPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPurchasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductLastStockQuantity;
        private System.Windows.Forms.ListBox lstViewProducts;
    }
}