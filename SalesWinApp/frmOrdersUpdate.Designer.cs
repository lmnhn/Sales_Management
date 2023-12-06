namespace SalesWinApp
{
    partial class frmOrdersUpdate
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFreight = new MaskedTextBox();
            dtPShippedDate = new DateTimePicker();
            dtPRequiredDate = new DateTimePicker();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 102);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "Required Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 148);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Shipped Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 198);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 5;
            label5.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(180, 195);
            txtFreight.Mask = "0000000";
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(250, 27);
            txtFreight.TabIndex = 6;
            txtFreight.Text = "0";
            txtFreight.ValidatingType = typeof(int);
            // 
            // dtPShippedDate
            // 
            dtPShippedDate.Format = DateTimePickerFormat.Short;
            dtPShippedDate.Location = new Point(180, 143);
            dtPShippedDate.MaxDate = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            dtPShippedDate.Name = "dtPShippedDate";
            dtPShippedDate.Size = new Size(250, 27);
            dtPShippedDate.TabIndex = 7;
            dtPShippedDate.Value = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // dtPRequiredDate
            // 
            dtPRequiredDate.Format = DateTimePickerFormat.Short;
            dtPRequiredDate.Location = new Point(180, 102);
            dtPRequiredDate.MaxDate = new DateTime(2023, 12, 25, 23, 59, 59, 0);
            dtPRequiredDate.Name = "dtPRequiredDate";
            dtPRequiredDate.Size = new Size(250, 27);
            dtPRequiredDate.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Location = new Point(180, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(336, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmOrdersUpdate
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(487, 360);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(dtPRequiredDate);
            Controls.Add(dtPShippedDate);
            Controls.Add(txtFreight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "frmOrdersUpdate";
            Text = "Update Order";
            Load += frmOrdersUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtFreight;
        private DateTimePicker dtPShippedDate;
        private DateTimePicker dtPRequiredDate;
        private Button btnUpdate;
        private Button btnCancel;
    }
}