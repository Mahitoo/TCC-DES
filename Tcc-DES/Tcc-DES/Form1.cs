using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcc_DES
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textUsuario.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
