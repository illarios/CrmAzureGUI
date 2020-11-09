namespace CrmAzureGUI
{
    partial class Customers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_lname = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_IA = new System.Windows.Forms.CheckBox();
            this.BTN_AddCust = new System.Windows.Forms.Button();
            this.TB_idRemove = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_remove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DB_btn = new System.Windows.Forms.Button();
            this.BTN_mainMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "LName";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "IsActive";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_lname
            // 
            this.TB_lname.Location = new System.Drawing.Point(76, 92);
            this.TB_lname.Name = "TB_lname";
            this.TB_lname.Size = new System.Drawing.Size(125, 27);
            this.TB_lname.TabIndex = 0;
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(76, 51);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(125, 27);
            this.TB_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_IA);
            this.groupBox1.Controls.Add(this.BTN_AddCust);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddCustomer";
            // 
            // CB_IA
            // 
            this.CB_IA.AutoSize = true;
            this.CB_IA.Location = new System.Drawing.Point(119, 130);
            this.CB_IA.Name = "CB_IA";
            this.CB_IA.Size = new System.Drawing.Size(18, 17);
            this.CB_IA.TabIndex = 1;
            this.CB_IA.UseVisualStyleBackColor = true;
            // 
            // BTN_AddCust
            // 
            this.BTN_AddCust.Location = new System.Drawing.Point(62, 167);
            this.BTN_AddCust.Name = "BTN_AddCust";
            this.BTN_AddCust.Size = new System.Drawing.Size(130, 29);
            this.BTN_AddCust.TabIndex = 0;
            this.BTN_AddCust.Text = "Add";
            this.BTN_AddCust.UseVisualStyleBackColor = true;
            this.BTN_AddCust.Click += new System.EventHandler(this.BTN_AddCust_Click);
            // 
            // TB_idRemove
            // 
            this.TB_idRemove.Location = new System.Drawing.Point(72, 275);
            this.TB_idRemove.Name = "TB_idRemove";
            this.TB_idRemove.Size = new System.Drawing.Size(125, 27);
            this.TB_idRemove.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_remove
            // 
            this.BTN_remove.Location = new System.Drawing.Point(56, 108);
            this.BTN_remove.Name = "BTN_remove";
            this.BTN_remove.Size = new System.Drawing.Size(130, 29);
            this.BTN_remove.TabIndex = 0;
            this.BTN_remove.Text = "Remove";
            this.BTN_remove.UseVisualStyleBackColor = true;
            this.BTN_remove.Click += new System.EventHandler(this.BTN_remove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_remove);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RemoveCustomer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(698, 360);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DB_btn);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(266, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 416);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DB_View";
            // 
            // DB_btn
            // 
            this.DB_btn.Location = new System.Drawing.Point(303, 385);
            this.DB_btn.Name = "DB_btn";
            this.DB_btn.Size = new System.Drawing.Size(168, 29);
            this.DB_btn.TabIndex = 0;
            this.DB_btn.Text = "Reload Cust Table";
            this.DB_btn.UseVisualStyleBackColor = true;
            this.DB_btn.Click += new System.EventHandler(this.DB_btn_Click_1);
            // 
            // BTN_mainMenu
            // 
            this.BTN_mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_mainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_mainMenu.Location = new System.Drawing.Point(952, 8);
            this.BTN_mainMenu.Name = "BTN_mainMenu";
            this.BTN_mainMenu.Size = new System.Drawing.Size(94, 29);
            this.BTN_mainMenu.TabIndex = 5;
            this.BTN_mainMenu.Text = "MainMenu";
            this.BTN_mainMenu.UseVisualStyleBackColor = true;
            this.BTN_mainMenu.Click += new System.EventHandler(this.BTN_mainMenu_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.BTN_mainMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_idRemove);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.TB_lname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Customers";
            this.Text = "Customers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_lname;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_AddCust;
        private System.Windows.Forms.TextBox TB_idRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_remove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DB_btn;
        private System.Windows.Forms.CheckBox CB_IA;
        private System.Windows.Forms.Button BTN_mainMenu;
    }
}

