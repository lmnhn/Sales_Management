namespace SalesWinApp
{
    partial class frmProduct
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
            dgvProductDetails = new DataGridView();
            btnRemove = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductDetails
            // 
            dgvProductDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductDetails.Location = new Point(2, 366);
            dgvProductDetails.Name = "dgvProductDetails";
            dgvProductDetails.ReadOnly = true;
            dgvProductDetails.RowHeadersWidth = 51;
            dgvProductDetails.RowTemplate.Height = 29;
            dgvProductDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductDetails.Size = new Size(917, 263);
            dgvProductDetails.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(57, 190);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(57, 99);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(57, 274);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(57, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(272, 161);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(215, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 164);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 7;
            label1.Text = "Search by Product Name:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Location = new Point(556, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 342);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 628);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvProductDetails);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Management";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductDetails).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductDetails;
        private Button btnRemove;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox groupBox1;
    }
}