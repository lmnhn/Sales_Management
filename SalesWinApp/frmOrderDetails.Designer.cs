namespace SalesWinApp
{
    partial class frmOrderDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOrderId = new MaskedTextBox();
            txtProductId = new MaskedTextBox();
            txtUPrice = new MaskedTextBox();
            txtQuantity = new MaskedTextBox();
            label6 = new Label();
            txtTotal = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 169);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(202, 38);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(299, 27);
            txtOrderId.TabIndex = 6;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(202, 80);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(299, 27);
            txtProductId.TabIndex = 7;
            // 
            // txtUPrice
            // 
            txtUPrice.Location = new Point(202, 126);
            txtUPrice.Name = "txtUPrice";
            txtUPrice.Size = new Size(299, 27);
            txtUPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(202, 166);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(299, 27);
            txtQuantity.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 226);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(202, 223);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(299, 27);
            txtTotal.TabIndex = 11;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 321);
            Controls.Add(txtTotal);
            Controls.Add(txtQuantity);
            Controls.Add(txtUPrice);
            Controls.Add(txtProductId);
            Controls.Add(txtOrderId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOrderDetails";
            Text = "Order Detail";
            Load += frmOrderDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtOrderId;
        private MaskedTextBox txtProductId;
        private MaskedTextBox txtUPrice;
        private MaskedTextBox txtQuantity;
        private Label label6;
        private MaskedTextBox txtTotal;
    }
}