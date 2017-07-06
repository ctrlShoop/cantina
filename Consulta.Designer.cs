namespace ProjetoIICantina
{
    partial class Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.btConsulta = new System.Windows.Forms.Button();
            this.btEncerrarConsulta = new System.Windows.Forms.Button();
            this.btPagar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDivida = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbRotulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btConsulta
            // 
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(280, 116);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(135, 29);
            this.btConsulta.TabIndex = 0;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btEncerrarConsulta
            // 
            this.btEncerrarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarConsulta.Location = new System.Drawing.Point(163, 398);
            this.btEncerrarConsulta.Name = "btEncerrarConsulta";
            this.btEncerrarConsulta.Size = new System.Drawing.Size(95, 53);
            this.btEncerrarConsulta.TabIndex = 1;
            this.btEncerrarConsulta.Text = "Encerrar consulta";
            this.btEncerrarConsulta.UseVisualStyleBackColor = true;
            this.btEncerrarConsulta.Click += new System.EventHandler(this.btEncerrarConsulta_Click);
            // 
            // btPagar
            // 
            this.btPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagar.Location = new System.Drawing.Point(12, 398);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(95, 53);
            this.btPagar.TabIndex = 2;
            this.btPagar.Text = "Pagar dívida";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(320, 398);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 53);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Fechar";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(19, 116);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(255, 29);
            this.tbCodigo.TabIndex = 4;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // tbDivida
            // 
            this.tbDivida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDivida.Location = new System.Drawing.Point(19, 151);
            this.tbDivida.Multiline = true;
            this.tbDivida.Name = "tbDivida";
            this.tbDivida.ReadOnly = true;
            this.tbDivida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDivida.Size = new System.Drawing.Size(396, 241);
            this.tbDivida.TabIndex = 5;
            this.tbDivida.Text = "sdsd";
            this.tbDivida.TextChanged += new System.EventHandler(this.tbDivida_TextChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(19, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(95, 95);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // lbRotulo
            // 
            this.lbRotulo.AutoSize = true;
            this.lbRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRotulo.Location = new System.Drawing.Point(114, 12);
            this.lbRotulo.Name = "lbRotulo";
            this.lbRotulo.Size = new System.Drawing.Size(301, 39);
            this.lbRotulo.TabIndex = 7;
            this.lbRotulo.Text = "Conta do Usuário";
            this.lbRotulo.Click += new System.EventHandler(this.lbRotulo_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 463);
            this.Controls.Add(this.lbRotulo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbDivida);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.btEncerrarConsulta);
            this.Controls.Add(this.btConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btEncerrarConsulta;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDivida;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbRotulo;
    }
}