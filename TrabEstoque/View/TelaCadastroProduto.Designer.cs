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
            panelCadastroProd.Controls.Add(btnSairCadastro);
            panelCadastroProd.Controls.Add(btnConfirmar);
            panelCadastroProd.Controls.Add(txtPrecoProd);
            panelCadastroProd.Controls.Add(txtQuantidadeProd);
            panelCadastroProd.Controls.Add(txtNomeProd);
            panelCadastroProd.Location = new Point(237, 154);
            panelCadastroProd.Name = "panelCadastroProd";
            panelCadastroProd.Size = new Size(329, 171);
            panelCadastroProd.TabIndex = 1;
            // 
            // btnSairCadastro
            // 
            btnSairCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairCadastro.Location = new Point(29, 117);
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
            btnConfirmar.Location = new Point(179, 117);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(125, 36);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Location = new Point(29, 78);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.PlaceholderText = "Preço";
            txtPrecoProd.Size = new Size(125, 23);
            txtPrecoProd.TabIndex = 2;
            // 
            // txtQuantidadeProd
            // 
            txtQuantidadeProd.Location = new Point(179, 78);
            txtQuantidadeProd.Name = "txtQuantidadeProd";
            txtQuantidadeProd.PlaceholderText = "Quantidade";
            txtQuantidadeProd.Size = new Size(125, 23);
            txtQuantidadeProd.TabIndex = 1;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(29, 31);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.PlaceholderText = "Nome";
            txtNomeProd.Size = new Size(275, 23);
            txtNomeProd.TabIndex = 0;
            // 
            // lblInfosCadastro
            // 
            lblInfosCadastro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfosCadastro.Location = new Point(237, 109);
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
    }
}