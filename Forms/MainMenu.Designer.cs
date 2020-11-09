namespace CrmAzureGUI.Forms
{
    partial class MainMenu
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
            this.BTN_cust = new System.Windows.Forms.Button();
            this.BTN_orders = new System.Windows.Forms.Button();
            this.BTN_prod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_cust
            // 
            this.BTN_cust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_cust.Location = new System.Drawing.Point(77, 82);
            this.BTN_cust.Name = "BTN_cust";
            this.BTN_cust.Size = new System.Drawing.Size(167, 62);
            this.BTN_cust.TabIndex = 0;
            this.BTN_cust.Text = "Customers";
            this.BTN_cust.UseVisualStyleBackColor = true;
            this.BTN_cust.Click += new System.EventHandler(this.BTN_cust_Click);
            // 
            // BTN_orders
            // 
            this.BTN_orders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_orders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_orders.Location = new System.Drawing.Point(320, 82);
            this.BTN_orders.Name = "BTN_orders";
            this.BTN_orders.Size = new System.Drawing.Size(174, 62);
            this.BTN_orders.TabIndex = 1;
            this.BTN_orders.Text = "Orders";
            this.BTN_orders.UseVisualStyleBackColor = true;
            this.BTN_orders.Click += new System.EventHandler(this.BTN_orders_Click);
            // 
            // BTN_prod
            // 
            this.BTN_prod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_prod.Location = new System.Drawing.Point(566, 82);
            this.BTN_prod.Name = "BTN_prod";
            this.BTN_prod.Size = new System.Drawing.Size(175, 62);
            this.BTN_prod.TabIndex = 2;
            this.BTN_prod.Text = "Products";
            this.BTN_prod.UseVisualStyleBackColor = true;
            this.BTN_prod.Click += new System.EventHandler(this.BTN_prod_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(320, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "OrderProducts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_prod);
            this.Controls.Add(this.BTN_orders);
            this.Controls.Add(this.BTN_cust);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_cust;
        private System.Windows.Forms.Button BTN_orders;
        private System.Windows.Forms.Button BTN_prod;
        private System.Windows.Forms.Button button1;
    }
}