namespace TrabEstoque.View
{
    partial class TelaCadastroProduto
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
            lblCadastroProd = new Label();
            panelCadastroProd = new Panel();
            lblInformaQueOsCamposSaoObrigatorios = new Label();
            lblIndicaQuantidade = new Label();
            lblIndicaPreco = new Label();
            lblIndicaCampoNome = new Label();
            btnSairCadastro = new Button();
            btnConfirmar = new Button();
            txtPrecoProd = new TextBox();
            txtQuantidadeProd = new TextBox();
            txtNomeProd = new TextBox();
            lblInfosCadastro = new Label();
            panelCadastroProd.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadastroProd
            // 
            lblCadastroProd.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblCadastroProd.Location = new Point(-3, 9);
            lblCadastroProd.Name = "lblCadastroProd";
            lblCadastroProd.Size = new Size(804, 119);
            lblCadastroProd.TabIndex = 0;
            lblCadastroProd.Text = "Cadastrar novo produto";
            lblCadastroProd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCadastroProd
            // 
            panelCadastroProd.BackColor = SystemColors.ButtonHighlight;
            panelCadastroProd.Controls.Add(lblInformaQueOsCamposSaoObrigatorios);
            panelCadastroProd.Controls.Add(lblIndicaQuantidade);
            panelCadastroProd.Controls.Add(lblIndicaPreco);
            panelCadastroProd.Controls.Add(lblIndicaCampoNome);
            panelCadastroProd.Controls.Add(btnSairCadastro);
            panelCadastroProd.Controls.Add(btnConfirmar);
            panelCadastroProd.Controls.Add(txtPrecoProd);
            panelCadastroProd.Controls.Add(txtQuantidadeProd);
            panelCadastroProd.Controls.Add(txtNomeProd);
            panelCadastroProd.Location = new Point(237, 154);
            panelCadastroProd.Name = "panelCadastroProd";
            panelCadastroProd.Size = new Size(329, 203);
            panelCadastroProd.TabIndex = 1;
            // 
            // lblInformaQueOsCamposSaoObrigatorios
            // 
            lblInformaQueOsCamposSaoObrigatorios.AutoSize = true;
            lblInformaQueOsCamposSaoObrigatorios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformaQueOsCamposSaoObrigatorios.ForeColor = SystemColors.ControlDarkDark;
            lblInformaQueOsCamposSaoObrigatorios.Location = new Point(64, 8);
            lblInformaQueOsCamposSaoObrigatorios.Name = "lblInformaQueOsCamposSaoObrigatorios";
            lblInformaQueOsCamposSaoObrigatorios.Size = new Size(206, 15);
            lblInformaQueOsCamposSaoObrigatorios.TabIndex = 2;
            lblInformaQueOsCamposSaoObrigatorios.Text = "* Todos os campos são obrigatórios *";
            // 
            // lblIndicaQuantidade
            // 
            lblIndicaQuantidade.AutoSize = true;
            lblIndicaQuantidade.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndicaQuantidade.Location = new Point(179, 83);
            lblIndicaQuantidade.Name = "lblIndicaQuantidade";
            lblIndicaQuantidade.Size = new Size(79, 17);
            lblIndicaQuantidade.TabIndex = 7;
            lblIndicaQuantidade.Text = "Quantidade";
            // 
            // lblIndicaPreco
            // 
            lblIndicaPreco.AutoSize = true;
            lblIndicaPreco.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndicaPreco.Location = new Point(29, 83);
            lblIndicaPreco.Name = "lblIndicaPreco";
            lblIndicaPreco.Size = new Size(42, 17);
            lblIndicaPreco.TabIndex = 6;
            lblIndicaPreco.Text = "Preço";
            // 
            // lblIndicaCampoNome
            // 
            lblIndicaCampoNome.AutoSize = true;
            lblIndicaCampoNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndicaCampoNome.Location = new Point(28, 32);
            lblIndicaCampoNome.Name = "lblIndicaCampoNome";
            lblIndicaCampoNome.Size = new Size(45, 17);
            lblIndicaCampoNome.TabIndex = 5;
            lblIndicaCampoNome.Text = "Nome";
            // 
            // btnSairCadastro
            // 
            btnSairCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairCadastro.Location = new Point(29, 152);
            btnSairCadastro.Name = "btnSairCadastro";
            btnSairCadastro.Size = new Size(125, 36);
            btnSairCadastro.TabIndex = 4;
            btnSairCadastro.Text = "&Sair";
            btnSairCadastro.UseVisualStyleBackColor = true;
            btnSairCadastro.Click += btnSairCadastro_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(179, 152);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(125, 36);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Location = new Point(29, 103);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(125, 23);
            txtPrecoProd.TabIndex = 2;
            // 
            // txtQuantidadeProd
            // 
            txtQuantidadeProd.Location = new Point(179, 103);
            txtQuantidadeProd.Name = "txtQuantidadeProd";
            txtQuantidadeProd.Size = new Size(125, 23);
            txtQuantidadeProd.TabIndex = 1;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(28, 52);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(275, 23);
            txtNomeProd.TabIndex = 0;
            // 
            // lblInfosCadastro
            // 
            lblInfosCadastro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfosCadastro.Location = new Point(237, 96);
            lblInfosCadastro.Name = "lblInfosCadastro";
            lblInfosCadastro.Size = new Size(329, 22);
            lblInfosCadastro.TabIndex = 0;
            lblInfosCadastro.Text = "Insira os dados do produto a ser adicionado";
            lblInfosCadastro.TextAlign = ContentAlignment.TopCenter;
            // 
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfosCadastro);
            Controls.Add(panelCadastroProd);
            Controls.Add(lblCadastroProd);
            Name = "TelaCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroProduto";
            panelCadastroProd.ResumeLayout(false);
            panelCadastroProd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCadastroProd;
        private Panel panelCadastroProd;
        private Label lblInfosCadastro;
        private TextBox txtNomeProd;
        private TextBox txtPrecoProd;
        private TextBox txtQuantidadeProd;
        private Button btnSairCadastro;
        private Button btnConfirmar;
        private Label lblIndicaCampoNome;
        private Label lblIndicaQuantidade;
        private Label lblIndicaPreco;
        private Label lblInformaQueOsCamposSaoObrigatorios;
    }
}