using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Practice_1
{
    public partial class AddCategory : Form
    {
        int lastid;
        public AddCategory(int id)
        {
            lastid = id;
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            tb_id.Text = lastid.ToString();
        }
    }
}
