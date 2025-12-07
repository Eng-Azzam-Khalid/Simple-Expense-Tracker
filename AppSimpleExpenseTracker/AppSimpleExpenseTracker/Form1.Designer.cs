namespace SimpleExpenseTracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.DgvExpenses = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExpenses
            // 
            this.DgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpenses.Location = new System.Drawing.Point(12, 50);
            this.DgvExpenses.Name = "DgvExpenses";
            this.DgvExpenses.RowTemplate.Height = 28;
            this.DgvExpenses.Size = new System.Drawing.Size(600, 300);
            this.DgvExpenses.TabIndex = 0;
            this.DgvExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExpenses_CellContentClick);
            //
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(620, 50);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 40);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(620, 100);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 40);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(620, 150);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 40);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(80, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(200, 27);
            this.TxtSearch.TabIndex = 4;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(12, 15);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(55, 19);
            this.LblSearch.TabIndex = 5;
            this.LblSearch.Text = "Search";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 370);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvExpenses);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public System.Windows.Forms.DataGridView DgvExpenses;
        public System.Windows.Forms.Button BtnAdd;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.TextBox TxtSearch;
        public System.Windows.Forms.Label LblSearch;
    }
}
