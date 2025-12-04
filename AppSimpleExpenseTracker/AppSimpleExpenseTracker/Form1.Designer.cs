namespace SimpleExpenseTracker
{
    partial class MainForm
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
            this.panTop = new System.Windows.Forms.Panel();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.textSearsh = new System.Windows.Forms.TextBox();
            this.lblSearsh = new System.Windows.Forms.Label();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.dgvExpenses);
            this.panTop.Controls.Add(this.btnEdit);
            this.panTop.Controls.Add(this.btnDelete);
            this.panTop.Controls.Add(this.btnAdd);
            this.panTop.Controls.Add(this.flowButtons);
            this.panTop.Controls.Add(this.textSearsh);
            this.panTop.Controls.Add(this.lblSearsh);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(755, 336);
            this.panTop.TabIndex = 1;
            this.panTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panTop_Paint);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTittle,
            this.colCategory,
            this.colDate});
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvExpenses.Location = new System.Drawing.Point(0, 186);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 62;
            this.dgvExpenses.RowTemplate.Height = 29;
            this.dgvExpenses.Size = new System.Drawing.Size(755, 150);
            this.dgvExpenses.TabIndex = 6;
            this.dgvExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Width = 150;
            // 
            // colTittle
            // 
            this.colTittle.HeaderText = "hedaer";
            this.colTittle.MinimumWidth = 8;
            this.colTittle.Name = "colTittle";
            this.colTittle.Width = 150;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 8;
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 150;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 8;
            this.colDate.Name = "colDate";
            this.colDate.Width = 150;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(180, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 47);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 47);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowButtons
            // 
            this.flowButtons.AutoSize = true;
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(755, 0);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(0, 336);
            this.flowButtons.TabIndex = 2;
            // 
            // textSearsh
            // 
            this.textSearsh.Location = new System.Drawing.Point(105, 21);
            this.textSearsh.Name = "textSearsh";
            this.textSearsh.Size = new System.Drawing.Size(100, 27);
            this.textSearsh.TabIndex = 1;
            this.textSearsh.TextChanged += new System.EventHandler(this.textSearsh_TextChanged);
            // 
            // lblSearsh
            // 
            this.lblSearsh.AutoSize = true;
            this.lblSearsh.Location = new System.Drawing.Point(12, 21);
            this.lblSearsh.Name = "lblSearsh";
            this.lblSearsh.Size = new System.Drawing.Size(56, 19);
            this.lblSearsh.TabIndex = 0;
            this.lblSearsh.Text = "Search";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 484);
            this.Controls.Add(this.panTop);
            this.Name = "MainForm";
            this.Text = "متتبع المصروفات";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.TextBox textSearsh;
        private System.Windows.Forms.Label lblSearsh;
    }
}

