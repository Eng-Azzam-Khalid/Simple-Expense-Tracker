using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using SimpleExpenseTracker.DAL;
using SimpleExpenseTracker.Model;

namespace SimpleExpenseTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions(string search = "")
        {
            using (var context = new ExpenseTrackerContext())
            {
                var query = context.Expenses.Include(e => e.Category).AsQueryable();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(x => x.Title.Contains(search) || x.Category.Name.Contains(search));
                }

                var transactions = query.ToList();

                DgvExpenses.DataSource = transactions.Select(x => new
                {
                    x.ExpenseId,
                    x.Title,
                    x.Amount,
                    x.Date,
                    Category = x.Category.Name
                }).ToList();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddExpeneForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadTransactions();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgvExpenses.CurrentRow == null) return;

            int expenseId = (int)DgvExpenses.CurrentRow.Cells["ExpenseId"].Value;

            using (var context = new ExpenseTrackerContext())
            {
                var expense = context.Expenses.Find(expenseId);
                if (expense != null)
                {
                    using (var form = new AddExpeneForm())
                    {
                        form.TxtTitle.Text = expense.Title;
                        form.TxtAmount.Text = expense.Amount.ToString();
                        form.DtpDate.Value = expense.Date;
                        form.CmbCategory.SelectedValue = expense.CategoryId;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            expense.Title = form.TxtTitle.Text;
                            expense.Amount = decimal.Parse(form.TxtAmount.Text);
                            expense.Date = form.DtpDate.Value;
                            expense.CategoryId = (int)form.CmbCategory.SelectedValue;

                            context.SaveChanges();
                            LoadTransactions();
                        }
                    }
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgvExpenses.CurrentRow == null) return;

            int expenseId = (int)DgvExpenses.CurrentRow.Cells["ExpenseId"].Value;

            using (var context = new ExpenseTrackerContext())
            {
                var expense = context.Expenses.Find(expenseId);
                if (expense != null)
                {
                    var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Expenses.Remove(expense);
                        context.SaveChanges();
                        LoadTransactions();
                    }
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTransactions(TxtSearch.Text);
        }

        private void DgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
