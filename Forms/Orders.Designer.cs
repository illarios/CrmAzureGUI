namespace CrmAzureGUI
{
    partial class Orders
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
            this.CB_custIds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.TB_addr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_addOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_descr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_dbOrders = new System.Windows.Forms.Button();
            this.BTN_mainMenu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.CB_custIds);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.TB_addr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTN_addOrder);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_descr);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(254, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddOrder";
            // 
            // CB_custIds
            // 
            this.CB_custIds.FormattingEnabled = true;
            this.CB_custIds.Location = new System.Drawing.Point(71, 240);
            this.CB_custIds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_custIds.Name = "CB_custIds";
            this.CB_custIds.Size = new System.Drawing.Size(133, 23);
            this.CB_custIds.TabIndex = 9;
            this.CB_custIds.Click += new System.EventHandler(this.CB_custIds_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "CustomerID";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(102, 130);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(51, 15);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // TB_addr
            // 
            this.TB_addr.Location = new System.Drawing.Point(19, 147);
            this.TB_addr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_addr.Name = "TB_addr";
            this.TB_addr.Size = new System.Drawing.Size(219, 23);
            this.TB_addr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created";
            // 
            // BTN_addOrder
            // 
            this.BTN_addOrder.Location = new System.Drawing.Point(89, 272);
            this.BTN_addOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_addOrder.Name = "BTN_addOrder";
            this.BTN_addOrder.Size = new System.Drawing.Size(82, 22);
            this.BTN_addOrder.TabIndex = 0;
            this.BTN_addOrder.Text = "Add  Order";
            this.BTN_addOrder.UseVisualStyleBackColor = true;
            this.BTN_addOrder.Click += new System.EventHandler(this.BTN_addOrder_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 94);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // TB_descr
            // 
            this.TB_descr.Location = new System.Drawing.Point(19, 44);
            this.TB_descr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_descr.Name = "TB_descr";
            this.TB_descr.Size = new System.Drawing.Size(219, 23);
            this.TB_descr.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(280, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(623, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(609, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // BTN_dbOrders
            // 
            this.BTN_dbOrders.Location = new System.Drawing.Point(522, 243);
            this.BTN_dbOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_dbOrders.Name = "BTN_dbOrders";
            this.BTN_dbOrders.Size = new System.Drawing.Size(158, 22);
            this.BTN_dbOrders.TabIndex = 2;
            this.BTN_dbOrders.Text = "Reload Orders List";
            this.BTN_dbOrders.UseVisualStyleBackColor = true;
            this.BTN_dbOrders.Click += new System.EventHandler(this.BTN_dbOrders_Click);
            // 
            // BTN_mainMenu
            // 
            this.BTN_mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mainMenu.Location = new System.Drawing.Point(821, 2);
            this.BTN_mainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_mainMenu.Name = "BTN_mainMenu";
            this.BTN_mainMenu.Size = new System.Drawing.Size(82, 22);
            this.BTN_mainMenu.TabIndex = 1;
            this.BTN_mainMenu.Text = "MainMenu";
            this.BTN_mainMenu.UseVisualStyleBackColor = true;
            this.BTN_mainMenu.Click += new System.EventHandler(this.BTN_mainMenu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(104, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 34);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 338);
            this.Controls.Add(this.BTN_mainMenu);
            this.Controls.Add(this.BTN_dbOrders);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Orders";
            this.Text = "Orders";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_addOrder;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox TB_addr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_descr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_custIds;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_;
        private System.Windows.Forms.Button BTN_dbOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_mainMenu;
        private System.Windows.Forms.ListBox listBox1;
    }
}