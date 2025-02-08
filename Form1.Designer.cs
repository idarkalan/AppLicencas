namespace AppLicencas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btGoogleWorkspace = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(228, 23);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(337, 29);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Selecione o Tipo de Licença";
            // 
            // btGoogleWorkspace
            // 
            this.btGoogleWorkspace.AutoSize = true;
            this.btGoogleWorkspace.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoogleWorkspace.Location = new System.Drawing.Point(233, 115);
            this.btGoogleWorkspace.Name = "btGoogleWorkspace";
            this.btGoogleWorkspace.Size = new System.Drawing.Size(343, 41);
            this.btGoogleWorkspace.TabIndex = 1;
            this.btGoogleWorkspace.Text = "Cadastrar Licença Google Workspace";
            this.btGoogleWorkspace.UseVisualStyleBackColor = true;
            this.btGoogleWorkspace.Click += new System.EventHandler(this.btGoogleWorkspace_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(233, 192);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(332, 41);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "Mais opções em breve";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(233, 275);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(332, 41);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "Mais opções em breve";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btGoogleWorkspace);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = ":";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btGoogleWorkspace;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
    }
}

