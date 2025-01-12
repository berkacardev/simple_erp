namespace UserInterfaceWF
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.picButtonProductsForm = new System.Windows.Forms.PictureBox();
            this.picButtonCustomersForm = new System.Windows.Forms.PictureBox();
            this.picButtonSalesForm = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new MdiTabControl.TabControl();
            this.btnAllSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonProductsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonCustomersForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonSalesForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picButtonProductsForm
            // 
            this.picButtonProductsForm.Image = ((System.Drawing.Image)(resources.GetObject("picButtonProductsForm.Image")));
            this.picButtonProductsForm.Location = new System.Drawing.Point(12, 12);
            this.picButtonProductsForm.Name = "picButtonProductsForm";
            this.picButtonProductsForm.Size = new System.Drawing.Size(127, 151);
            this.picButtonProductsForm.TabIndex = 0;
            this.picButtonProductsForm.TabStop = false;
            this.picButtonProductsForm.Click += new System.EventHandler(this.picButtonProductsForm_Click);
            // 
            // picButtonCustomersForm
            // 
            this.picButtonCustomersForm.Image = ((System.Drawing.Image)(resources.GetObject("picButtonCustomersForm.Image")));
            this.picButtonCustomersForm.Location = new System.Drawing.Point(12, 169);
            this.picButtonCustomersForm.Name = "picButtonCustomersForm";
            this.picButtonCustomersForm.Size = new System.Drawing.Size(127, 151);
            this.picButtonCustomersForm.TabIndex = 0;
            this.picButtonCustomersForm.TabStop = false;
            this.picButtonCustomersForm.Click += new System.EventHandler(this.picButtonCustomersForm_Click);
            // 
            // picButtonSalesForm
            // 
            this.picButtonSalesForm.Image = ((System.Drawing.Image)(resources.GetObject("picButtonSalesForm.Image")));
            this.picButtonSalesForm.Location = new System.Drawing.Point(12, 326);
            this.picButtonSalesForm.Name = "picButtonSalesForm";
            this.picButtonSalesForm.Size = new System.Drawing.Size(127, 151);
            this.picButtonSalesForm.TabIndex = 0;
            this.picButtonSalesForm.TabStop = false;
            this.picButtonSalesForm.Click += new System.EventHandler(this.picButtonSalesForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Location = new System.Drawing.Point(145, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 504);
            this.panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(676, 504);
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabIndex = 0;
            // 
            // btnAllSales
            // 
            this.btnAllSales.Location = new System.Drawing.Point(12, 483);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Size = new System.Drawing.Size(127, 33);
            this.btnAllSales.TabIndex = 2;
            this.btnAllSales.Text = "Satışlar";
            this.btnAllSales.UseVisualStyleBackColor = true;
            this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 550);
            this.Controls.Add(this.btnAllSales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picButtonSalesForm);
            this.Controls.Add(this.picButtonCustomersForm);
            this.Controls.Add(this.picButtonProductsForm);
            this.KeyPreview = true;
            this.Name = "MainUI";
            this.Text = "MainUI";
            ((System.ComponentModel.ISupportInitialize)(this.picButtonProductsForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonCustomersForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonSalesForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picButtonProductsForm;
        private System.Windows.Forms.PictureBox picButtonCustomersForm;
        private System.Windows.Forms.PictureBox picButtonSalesForm;
        private System.Windows.Forms.Panel panel1;
        private MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.Button btnAllSales;
    }
}