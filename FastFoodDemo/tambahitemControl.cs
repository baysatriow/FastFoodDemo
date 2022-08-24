using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class tambahitemControl : UserControl
    {
        public tambahitemControl()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuUtama frmUtama = new FormMenuUtama();
            frmUtama.Show();
        }
    }
}
