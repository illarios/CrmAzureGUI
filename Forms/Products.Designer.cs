namespace CrmAzureGUI.Forms
{
    partial class Products
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_addProduct = new System.Windows.Forms.Button();
            this.TB_price = new System.Windows.Forms.TextBox();
            this.TB_code = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_mainMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_addProduct);
            this.groupBox1.Controls.Add(this.TB_price);
            this.groupBox1.Controls.Add(this.TB_code);
            this.groupBox1.Controls.Add(this.TB_name);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // BTN_addProduct
            // 
            this.BTN_addProduct.Location = new System.Drawing.Point(67, 243);
            this.BTN_addProduct.Name = "BTN_addProduct";
            this.BTN_addProduct.Size = new System.Drawing.Size(94, 29);
            this.BTN_addProduct.TabIndex = 3;
            this.BTN_addProduct.Text = "Add";
            this.BTN_addProduct.UseVisualStyleBackColor = true;
            this.BTN_addProduct.Click += new System.EventHandler(this.BTN_addProduct_Click);
            // 
            // TB_price
            // 
            this.TB_price.Location = new System.Drawing.Point(52, 190);
            this.TB_price.Name = "TB_price";
            this.TB_price.Size = new System.Drawing.Size(125, 27);
            this.TB_price.TabIndex = 2;
            // 
            // TB_code
            // 
            this.TB_code.Location = new System.Drawing.Point(52, 123);
            this.TB_code.Name = "TB_code";
            this.TB_code.Size = new System.Drawing.Size(125, 27);
            this.TB_code.TabIndex = 1;
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(52, 52);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(125, 27);
            this.TB_name.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(290, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(735, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(560, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh Product List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_mainMenu
            // 
            this.BTN_mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mainMenu.Location = new System.Drawing.Point(953, 2);
            this.BTN_mainMenu.Name = "BTN_mainMenu";
            this.BTN_mainMenu.Size = new System.Drawing.Size(94, 29);
            this.BTN_mainMenu.TabIndex = 3;
            this.BTN_mainMenu.Text = "MainMenu";
            this.BTN_mainMenu.UseVisualStyleBackColor = true;
            this.BTN_mainMenu.Click += new System.EventHandler(this.BTN_mainMenu_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 468);
            this.Controls.Add(this.BTN_mainMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Products";
            this.Text = "Products";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_addProduct;
        private System.Windows.Forms.TextBox TB_price;
        private System.Windows.Forms.TextBox TB_code;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_mainMenu;
    }
}