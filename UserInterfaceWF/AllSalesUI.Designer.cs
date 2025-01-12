namespace UserInterfaceWF
{
    partial class AllSalesUI
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
            this.lstBoxSales = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCustomerNameSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lstBoxSelledProducts = new System.Windows.Forms.ListBox();
            this.lblSalesSum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxSales
            // 
            this.lstBoxSales.FormattingEnabled = true;
            this.lstBoxSales.Location = new System.Drawing.Point(12, 12);
            this.lstBoxSales.Name = "lstBoxSales";
            this.lstBoxSales.Size = new System.Drawing.Size(332, 420);
            this.lstBoxSales.TabIndex = 0;
            this.lstBoxSales.SelectedIndexChanged += new System.EventHandler(this.lstBoxSales_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCustomerAddress);
            this.groupBox1.Controls.Add(this.lblCustomerPhoneNumber);
            this.groupBox1.Controls.Add(this.lblCustomerNameSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Location = new System.Drawing.Point(350, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(11, 19);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Adı Soyadı :";
            // 
            // lblCustomerNameSurname
            // 
            this.lblCustomerNameSurname.AutoSize = true;
            this.lblCustomerNameSurname.Location = new System.Drawing.Point(159, 17);
            this.lblCustomerNameSurname.Name = "lblCustomerNameSurname";
            this.lblCustomerNameSurname.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNameSurname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon Numarası :";
            // 
            // lblCustomerPhoneNumber
            // 
            this.lblCustomerPhoneNumber.AutoSize = true;
            this.lblCustomerPhoneNumber.Location = new System.Drawing.Point(160, 51);
            this.lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber";
            this.lblCustomerPhoneNumber.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerPhoneNumber.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adres :";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(160, 87);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerAddress.TabIndex = 0;
            // 
            // lstBoxSelledProducts
            // 
            this.lstBoxSelledProducts.FormattingEnabled = true;
            this.lstBoxSelledProducts.Location = new System.Drawing.Point(350, 142);
            this.lstBoxSelledProducts.Name = "lstBoxSelledProducts";
            this.lstBoxSelledProducts.Size = new System.Drawing.Size(420, 251);
            this.lstBoxSelledProducts.TabIndex = 0;
            // 
            // lblSalesSum
            // 
            this.lblSalesSum.AutoSize = true;
            this.lblSalesSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalesSum.Location = new System.Drawing.Point(350, 409);
            this.lblSalesSum.Name = "lblSalesSum";
            this.lblSalesSum.Size = new System.Drawing.Size(0, 25);
            this.lblSalesSum.TabIndex = 2;
            // 
            // AllSalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalesSum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstBoxSelledProducts);
            this.Controls.Add(this.lstBoxSales);
            this.Name = "AllSalesUI";
            this.Text = "AllSalesUI";
            this.Load += new System.EventHandler(this.AllSalesUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxSales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhoneNumber;
        private System.Windows.Forms.Label lblCustomerNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxSelledProducts;
        private System.Windows.Forms.Label lblSalesSum;
    }
}