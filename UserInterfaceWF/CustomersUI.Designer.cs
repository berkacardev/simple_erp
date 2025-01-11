namespace UserInterfaceWF
{
    partial class CustomersUI
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
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.txtCustomerAdress = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertCustomer = new System.Windows.Forms.Button();
            this.txtCustomerEmailAdress = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewCustomers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateNewCustomer);
            this.groupBox1.Controls.Add(this.txtCustomerAdress);
            this.groupBox1.Controls.Add(this.btnDeleteCustomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnInsertCustomer);
            this.groupBox1.Controls.Add(this.txtCustomerEmailAdress);
            this.groupBox1.Controls.Add(this.btnSaveCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustomerPhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(317, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(249, 370);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(76, 71);
            this.btnCreateNewCustomer.TabIndex = 2;
            this.btnCreateNewCustomer.Text = "Yeni";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // txtCustomerAdress
            // 
            this.txtCustomerAdress.Location = new System.Drawing.Point(124, 198);
            this.txtCustomerAdress.Multiline = true;
            this.txtCustomerAdress.Name = "txtCustomerAdress";
            this.txtCustomerAdress.Size = new System.Drawing.Size(192, 153);
            this.txtCustomerAdress.TabIndex = 1;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(167, 370);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(76, 71);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Sil";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresi :";
            // 
            // btnInsertCustomer
            // 
            this.btnInsertCustomer.Location = new System.Drawing.Point(85, 370);
            this.btnInsertCustomer.Name = "btnInsertCustomer";
            this.btnInsertCustomer.Size = new System.Drawing.Size(76, 71);
            this.btnInsertCustomer.TabIndex = 2;
            this.btnInsertCustomer.Text = "Düzelt";
            this.btnInsertCustomer.UseVisualStyleBackColor = true;
            this.btnInsertCustomer.Click += new System.EventHandler(this.btnInsertCustomer_Click);
            // 
            // txtCustomerEmailAdress
            // 
            this.txtCustomerEmailAdress.Location = new System.Drawing.Point(124, 150);
            this.txtCustomerEmailAdress.Name = "txtCustomerEmailAdress";
            this.txtCustomerEmailAdress.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerEmailAdress.TabIndex = 1;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(3, 370);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(76, 71);
            this.btnSaveCustomer.TabIndex = 2;
            this.btnSaveCustomer.Text = "Kaydet";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email Adresi :";
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(124, 110);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerPhoneNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon Numarası +90";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(124, 69);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerSurname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı : ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(124, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(192, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı : ";
            // 
            // lstViewCustomers
            // 
            this.lstViewCustomers.FormattingEnabled = true;
            this.lstViewCustomers.Location = new System.Drawing.Point(12, 6);
            this.lstViewCustomers.Name = "lstViewCustomers";
            this.lstViewCustomers.Size = new System.Drawing.Size(299, 446);
            this.lstViewCustomers.TabIndex = 2;
            this.lstViewCustomers.SelectedIndexChanged += new System.EventHandler(this.lstViewCustomers_SelectedIndexChanged);
            // 
            // CustomersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 470);
            this.Controls.Add(this.lstViewCustomers);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomersUI";
            this.Text = "CustomersUI";
            this.Load += new System.EventHandler(this.CustomersUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerEmailAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnInsertCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.ListBox lstViewCustomers;
    }
}