using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExpenseTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mane ADD", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("plese chos rwo first", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد حذف هذا المصروف", "تاكيد الحذق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void textSearsh_TextChanged(object sender, EventArgs e)
        {

        }

        private void panTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
