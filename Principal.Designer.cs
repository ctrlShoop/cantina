namespace ProjetoIICantina
{
    partial class FrameMercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameMercado));
            this.btFinalizarCompra = new System.Windows.Forms.Button();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.lbTitProduto = new System.Windows.Forms.Label();
            this.lbTitPreco = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbQtde = new System.Windows.Forms.TextBox();
            this.lbCod = new System.Windows.Forms.Label();
            this.lbQtde = new System.Windows.Forms.Label();
            this.tbNotinha = new System.Windows.Forms.TextBox();
            this.btAdcConta = new System.Windows.Forms.Button();
            this.btConfirmaProduto = new System.Windows.Forms.Button();
            this.coxinha = new System.Windows.Forms.PictureBox();
            this.btInsereProd = new System.Windows.Forms.Button();
            this.btRelatorioVenda = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coxinha)).BeginInit();
            this.SuspendLayout();
            // 
            // btFinalizarCompra
            // 
            this.btFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizarCompra.Location = new System.Drawing.Point(1181, 348);
            this.btFinalizarCompra.Margin = new System.Windows.Forms.Padding(1);
            this.btFinalizarCompra.Name = "btFinalizarCompra";
            this.btFinalizarCompra.Size = new System.Drawing.Size(120, 60);
            this.btFinalizarCompra.TabIndex = 0;
            this.btFinalizarCompra.Text = "Finalizar compra";
            this.btFinalizarCompra.UseVisualStyleBackColor = true;
            this.btFinalizarCompra.Click += new System.EventHandler(this.btFinalizaCompra_Click);
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbImagemProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImagemProduto.BackgroundImage")));
            this.pbImagemProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Location = new System.Drawing.Point(51, 58);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(350, 350);
            this.pbImagemProduto.TabIndex = 1;
            this.pbImagemProduto.TabStop = false;
            this.pbImagemProduto.Click += new System.EventHandler(this.pbImagemProduto_Click);
            // 
            // lbTitProduto
            // 
            this.lbTitProduto.AutoSize = true;
            this.lbTitProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbTitProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitProduto.Location = new System.Drawing.Point(48, 419);
            this.lbTitProduto.Name = "lbTitProduto";
            this.lbTitProduto.Size = new System.Drawing.Size(116, 31);
            this.lbTitProduto.TabIndex = 3;
            this.lbTitProduto.Text = "Produto";
            // 
            // lbTitPreco
            // 
            this.lbTitPreco.AutoSize = true;
            this.lbTitPreco.BackColor = System.Drawing.Color.Transparent;
            this.lbTitPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitPreco.Location = new System.Drawing.Point(45, 483);
            this.lbTitPreco.Name = "lbTitPreco";
            this.lbTitPreco.Size = new System.Drawing.Size(90, 31);
            this.lbTitPreco.TabIndex = 4;
            this.lbTitPreco.Text = "Preço";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.Location = new System.Drawing.Point(170, 419);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(120, 31);
            this.lbProduto.TabIndex = 5;
            this.lbProduto.Text = "Coxinha\r\n";
            this.lbProduto.Click += new System.EventHandler(this.lbProduto_Click);
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.BackColor = System.Drawing.Color.Transparent;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(170, 483);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(71, 31);
            this.lbPreco.TabIndex = 6;
            this.lbPreco.Text = "3.50";
            this.lbPreco.Click += new System.EventHandler(this.lbPreco_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(585, 58);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(118, 22);
            this.tbCodigo.TabIndex = 7;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // tbQtde
            // 
            this.tbQtde.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbQtde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQtde.Location = new System.Drawing.Point(585, 104);
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(118, 22);
            this.tbQtde.TabIndex = 8;
            this.tbQtde.TextChanged += new System.EventHandler(this.tbQtde_TextChanged);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(423, 58);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(156, 24);
            this.lbCod.TabIndex = 10;
            this.lbCod.Text = "Código Produto";
            // 
            // lbQtde
            // 
            this.lbQtde.AutoSize = true;
            this.lbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtde.Location = new System.Drawing.Point(426, 104);
            this.lbQtde.Name = "lbQtde";
            this.lbQtde.Size = new System.Drawing.Size(118, 24);
            this.lbQtde.TabIndex = 11;
            this.lbQtde.Text = "Quantidade";
            // 
            // tbNotinha
            // 
            this.tbNotinha.BackColor = System.Drawing.Color.Khaki;
            this.tbNotinha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNotinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotinha.Location = new System.Drawing.Point(938, 58);
            this.tbNotinha.Multiline = true;
            this.tbNotinha.Name = "tbNotinha";
            this.tbNotinha.ReadOnly = true;
            this.tbNotinha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotinha.Size = new System.Drawing.Size(363, 244);
            this.tbNotinha.TabIndex = 12;
            this.tbNotinha.Text = "a";
            this.tbNotinha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btAdcConta
            // 
            this.btAdcConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdcConta.Location = new System.Drawing.Point(938, 348);
            this.btAdcConta.Name = "btAdcConta";
            this.btAdcConta.Size = new System.Drawing.Size(120, 60);
            this.btAdcConta.TabIndex = 13;
            this.btAdcConta.Text = "Marcar Conta";
            this.btAdcConta.UseVisualStyleBackColor = true;
            this.btAdcConta.Click += new System.EventHandler(this.btAdcConta_Click);
            // 
            // btConfirmaProduto
            // 
            this.btConfirmaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaProduto.Location = new System.Drawing.Point(51, 544);
            this.btConfirmaProduto.Name = "btConfirmaProduto";
            this.btConfirmaProduto.Size = new System.Drawing.Size(350, 60);
            this.btConfirmaProduto.TabIndex = 14;
            this.btConfirmaProduto.Text = "Confirmar Produto";
            this.btConfirmaProduto.UseVisualStyleBackColor = true;
            this.btConfirmaProduto.Click += new System.EventHandler(this.btConfirmaProduto_Click);
            // 
            // coxinha
            // 
            this.coxinha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coxinha.BackgroundImage")));
            this.coxinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coxinha.Location = new System.Drawing.Point(1115, 483);
            this.coxinha.Name = "coxinha";
            this.coxinha.Size = new System.Drawing.Size(186, 192);
            this.coxinha.TabIndex = 15;
            this.coxinha.TabStop = false;
            // 
            // btInsereProd
            // 
            this.btInsereProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsereProd.Location = new System.Drawing.Point(51, 645);
            this.btInsereProd.Name = "btInsereProd";
            this.btInsereProd.Size = new System.Drawing.Size(172, 60);
            this.btInsereProd.TabIndex = 16;
            this.btInsereProd.Text = "Inserir Novo Produto";
            this.btInsereProd.UseVisualStyleBackColor = true;
            this.btInsereProd.Click += new System.EventHandler(this.btInsereProd_Click);
            // 
            // btRelatorioVenda
            // 
            this.btRelatorioVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorioVenda.Location = new System.Drawing.Point(229, 645);
            this.btRelatorioVenda.Name = "btRelatorioVenda";
            this.btRelatorioVenda.Size = new System.Drawing.Size(172, 60);
            this.btRelatorioVenda.TabIndex = 16;
            this.btRelatorioVenda.Text = "Relatório de Venda";
            this.btRelatorioVenda.UseVisualStyleBackColor = true;
            this.btRelatorioVenda.Click += new System.EventHandler(this.btRelatorioVenda_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(1312, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(30, 30);
            this.btExit.TabIndex = 17;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(427, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 19;
            // 
            // FrameMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRelatorioVenda);
            this.Controls.Add(this.btInsereProd);
            this.Controls.Add(this.coxinha);
            this.Controls.Add(this.btConfirmaProduto);
            this.Controls.Add(this.btAdcConta);
            this.Controls.Add(this.tbNotinha);
            this.Controls.Add(this.lbQtde);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.tbQtde);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.lbTitPreco);
            this.Controls.Add(this.lbTitProduto);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.btFinalizarCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrameMercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Cantina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrameMercado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coxinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFinalizarCompra;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.Label lbTitProduto;
        private System.Windows.Forms.Label lbTitPreco;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbQtde;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label lbQtde;
        private System.Windows.Forms.TextBox tbNotinha;
        private System.Windows.Forms.Button btAdcConta;
        private System.Windows.Forms.Button btConfirmaProduto;
        private System.Windows.Forms.PictureBox coxinha;
        private System.Windows.Forms.Button btInsereProd;
        private System.Windows.Forms.Button btRelatorioVenda;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

