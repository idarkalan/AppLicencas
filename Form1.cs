using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLicencas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Enabled = true;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Enabled = true;
        }

        private void btGoogleWorkspace_Click(object sender, EventArgs e)
        {
            Form CadastroLicencaForm = new CadastroLicencaForm();
            CadastroLicencaForm.ShowDialog();
            
        }
    }
}
