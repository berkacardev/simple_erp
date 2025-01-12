namespace UserInterfaceWF
{
    partial class SalesUI
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
            this.btnAddList = new System.Windows.Forms.Button();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnMakePermananetSales = new System.Windows.Forms.Button();
            this.lblSalesSum = new System.Windows.Forms.Label();
            this.cmbxCustomers = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddList);
            this.groupBox1.Controls.Add(this.lblProductPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Ekranı";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(495, 24);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(177, 77);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Listeye Ekle";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Location = new System.Drawing.Point(403, 63);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductPrice.Size = new System.Drawing.Size(0, 20);
            this.lblProductPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(339, 63);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyat :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(109, 63);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductName.Size = new System.Drawing.Size(0, 20);
            this.lblProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(110, 26);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(379, 20);
            this.txtProductId.TabIndex = 0;
            this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGridView);
            this.panel1.Location = new System.Drawing.Point(2, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 292);
            this.panel1.TabIndex = 1;
            // 
            // dtGridView
            // 
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(0, 0);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(674, 289);
            this.dtGridView.TabIndex = 0;
            // 
            // btnMakePermananetSales
            // 
            this.btnMakePermananetSales.Location = new System.Drawing.Point(2, 441);
            this.btnMakePermananetSales.Name = "btnMakePermananetSales";
            this.btnMakePermananetSales.Size = new System.Drawing.Size(240, 32);
            this.btnMakePermananetSales.TabIndex = 2;
            this.btnMakePermananetSales.Text = "Peşin Satış Yap";
            this.btnMakePermananetSales.UseVisualStyleBackColor = true;
            this.btnMakePermananetSales.Click += new System.EventHandler(this.btnMakePermananetSales_Click);
            // 
            // lblSalesSum
            // 
            this.lblSalesSum.AutoSize = true;
            this.lblSalesSum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalesSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalesSum.ForeColor = System.Drawing.Color.Tomato;
            this.lblSalesSum.Location = new System.Drawing.Point(531, 419);
            this.lblSalesSum.Name = "lblSalesSum";
            this.lblSalesSum.Size = new System.Drawing.Size(0, 37);
            this.lblSalesSum.TabIndex = 3;
            // 
            // cmbxCustomers
            // 
            this.cmbxCustomers.FormattingEnabled = true;
            this.cmbxCustomers.Location = new System.Drawing.Point(2, 411);
            this.cmbxCustomers.Name = "cmbxCustomers";
            this.cmbxCustomers.Size = new System.Drawing.Size(240, 21);
            this.cmbxCustomers.TabIndex = 4;
            // 
            // SalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 485);
            this.Controls.Add(this.cmbxCustomers);
            this.Controls.Add(this.lblSalesSum);
            this.Controls.Add(this.btnMakePermananetSales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesUI";
            this.Text = "SalesUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMakePermananetSales;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Label lblSalesSum;
        private System.Windows.Forms.ComboBox cmbxCustomers;
    }
}