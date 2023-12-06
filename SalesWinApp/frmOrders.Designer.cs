namespace SalesWinApp
{
    partial class frmOrders
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
            dgvOrders = new DataGridView();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            lbSearch = new Label();
            txtSearch = new MaskedTextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(10, 273);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(927, 243);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(62, 124);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(62, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(62, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(152, 128);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(139, 20);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Find by Member ID:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(306, 125);
            txtSearch.Mask = "00000";
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 27);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "0";
            txtSearch.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Location = new Point(534, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 194);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 517);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(dgvOrders);
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order's Management";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnSearch;
        private Label lbSearch;
        private MaskedTextBox txtSearch;
        private GroupBox groupBox1;
    }
}