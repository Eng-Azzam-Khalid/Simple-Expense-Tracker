using System;
using System.Windows.Forms;
using System.Linq;
using SimpleExpenseTracker.DAL;
using SimpleExpenseTracker.Model;

namespace SimpleExpenseTracker
{
    public partial class AddExpeneForm : Form
    {
        public AddExpeneForm()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (var context = new ExpenseTrackerContext())
            {
                CmbCategory.DataSource = context.Categories.ToList();
                CmbCategory.DisplayMember = "Name";
                CmbCategory.ValueMember = "CategoryId";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitle.Text) || string.IsNullOrWhiteSpace(TxtAmount.Text))
            {
                MessageBox.Show("Please enter Title and Amount.");
                return;
            }

            using (var context = new ExpenseTrackerContext())
            {
                var expense = new Expense
                {
                    Title = TxtTitle.Text,
                    Amount = decimal.Parse(TxtAmount.Text),
                    Date = DtpDate.Value,
                    CategoryId = (int)CmbCategory.SelectedValue
                };

                context.Expenses.Add(expense);
                context.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            // فارغة حالياً، يمكن إضافة التحقق من القيم إذا أحببت
        }

        private void AddExpeneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
