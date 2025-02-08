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
            SetupUI();
            InitializeComponent();
            
        }
        private void SetupUI()
        {
            this.Text = "Menu - Controle de Licenças";
            this.Size = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Label title = new Label()
            {
                Text = "Selecione o Tipo de Licença",
                Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold),
                AutoSize = true
                
            };
            title.Location = new System.Drawing.Point(
                (this.ClientSize.Width - title.Width) / 3,30
                );
            this.Controls.Add(title);

            Button googleWorkspaceButton = new Button()
            {
                Text = "Cadastrar Licença Google Workspace",
                
                Location = new System.Drawing.Point(150, 160),
                Width = 300,
                Height = 40
            };
            googleWorkspaceButton.Location = new System.Drawing.Point(
                (this.ClientSize.Width - googleWorkspaceButton.Width) / 2, 160
                );
            googleWorkspaceButton.Click += (sender, e) =>
            {
                Form cadastroForm = new CadastroLicencaForm();
                cadastroForm.ShowDialog();
            };
            this.Controls.Add(googleWorkspaceButton);

            Button optionButton1 = new Button()
            {
                Text = "Mais opções em breve",
                Location = new System.Drawing.Point(150, 160),
                Width = 300,
                Height = 40,
                Enabled = false
            };
            optionButton1.Location = new System.Drawing.Point(
                (this.ClientSize.Width - optionButton1.Width) / 2, 210
                );
            this.Controls.Add(optionButton1);
            Button optionButton2 = new Button()
            {
                Text = "Mais opções em breve",
                Location = new System.Drawing.Point(150, 160),
                Width = 300,
                Height = 40,
                Enabled = false
            };
            optionButton2.Location = new System.Drawing.Point(
                (this.ClientSize.Width - optionButton2.Width) / 2, 260
                );
            this.Controls.Add(optionButton2);
        }

    }
}
