namespace SalesWinApp
{
    partial class frmMembers
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
            dgvMemberDetail = new DataGridView();
            btnRemove = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberDetail).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMemberDetail
            // 
            dgvMemberDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberDetail.Location = new Point(12, 323);
            dgvMemberDetail.Name = "dgvMemberDetail";
            dgvMemberDetail.ReadOnly = true;
            dgvMemberDetail.RowHeadersWidth = 51;
            dgvMemberDetail.RowTemplate.Height = 29;
            dgvMemberDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberDetail.Size = new Size(1133, 228);
            dgvMemberDetail.TabIndex = 0;
            dgvMemberDetail.CellContentDoubleClick += dgvMemberDetail_CellContentDoubleClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(72, 139);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(72, 90);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(72, 197);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(72, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(375, 124);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 27);
            txtSearch.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 127);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 12;
            label1.Text = "Find by Country or City:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Location = new Point(657, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 265);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 563);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberDetail);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members Management";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberDetail).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberDetail;
        private Button btnRemove;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox groupBox1;
    }
}