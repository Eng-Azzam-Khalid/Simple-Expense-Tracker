namespace SimpleExpenseTracker
{
    partial class AddExpeneForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblAmount = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(20, 30);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(40, 19);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(100, 27);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(200, 27);
            this.TxtTitle.TabIndex = 1;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Location = new System.Drawing.Point(20, 70);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(66, 19);
            this.LblAmount.TabIndex = 2;
            this.LblAmount.Text = "Amount";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(100, 67);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(100, 27);
            this.TxtAmount.TabIndex = 3;
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(20, 110);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(72, 19);
            this.LblCategory.TabIndex = 4;
            this.LblCategory.Text = "Category";
            // 
            // CmbCategory
            // 
            this.CmbCategory.Location = new System.Drawing.Point(100, 107);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(150, 27);
            this.CmbCategory.TabIndex = 5;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(20, 150);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(41, 19);
            this.LblDate.TabIndex = 6;
            this.LblDate.Text = "Date";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(100, 147);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(150, 27);
            this.DtpDate.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(20, 200);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 35);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(140, 200);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 35);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddExpeneForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Name = "AddExpeneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expense";
            this.Load += new System.EventHandler(this.AddExpeneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.TextBox TxtTitle;
        public System.Windows.Forms.Label LblAmount;
        public System.Windows.Forms.TextBox TxtAmount;
        public System.Windows.Forms.Label LblCategory;
        public System.Windows.Forms.ComboBox CmbCategory;
        public System.Windows.Forms.Label LblDate;
        public System.Windows.Forms.DateTimePicker DtpDate;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnCancel;
    }
}
