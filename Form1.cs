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
            SetupUI();
        }
        private void SetupUI()
        {
            this.Text = "Controle de Licenças";
            this.Size = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Label title = new Label()
            {
                Text = "Controle de Licenças",
                Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(20, 20)
            };
            this.Controls.Add(title);

            TextBox searchBox = new TextBox()
            {
                Text = "Buscar por SERIAL ou Solicitante...",
                Width = 300,
                Location = new System.Drawing.Point(20, 60)
            };
            this.Controls.Add(searchBox);
            DataGridView licenseGrid = new DataGridView()
            {
                Location = new System.Drawing.Point(20, 100),
                Size = new System.Drawing.Size(750, 300)
            };
            licenseGrid.Columns.Add("ID", "ID");
            licenseGrid.Columns.Add("Serial", "Serial");
            licenseGrid.Columns.Add("DataCompra", "Data de Compra");
            licenseGrid.Columns.Add("Responsavel", "Responsável");
            licenseGrid.Columns.Add("Solicitante", "Solicitante");
            this.Controls.Add(licenseGrid);

            Button addButton = new Button()
            {
                Text = "Adicionar Licença",
                Location = new System.Drawing.Point(20, 420),
                Width = 150
            };
            this.Controls.Add(addButton);
        }
    }
}
