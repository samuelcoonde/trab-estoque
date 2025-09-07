namespace TrabEstoque.View
{
    partial class TelaRetirarProduto
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
            label1 = new Label();
            lblPedeIdProdRetirar = new Label();
            txtIdProdASerRetirado = new TextBox();
            btnSairRetirarProd = new Button();
            btnConfirmarIdProdRetirar = new Button();
            pnlDgvRetirar = new Panel();
            pnlDadosProdRetirar = new Panel();
            btnVoltarR = new Button();
            btnRetirarQuantidadeProd = new Button();
            txtQuantidadeASerRetirada = new TextBox();
            lblPedeQuantidadeRetirar = new Label();
            lblQuantidadeProdRetirar = new Label();
            lblPrecoProdRetirar = new Label();
            lblNomeProdRetirar = new Label();
            lblProdutoRetirarEncontrado = new Label();
            pnlDgvRetirar.SuspendLayout();
            pnlDadosProdRetirar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(-3, -28);
            label1.Name = "label1";
            label1.Size = new Size(802, 110);
            label1.TabIndex = 0;
            label1.Text = "Retirar produto do estoque";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPedeIdProdRetirar
            // 
            lblPedeIdProdRetirar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPedeIdProdRetirar.Location = new Point(215, 52);
            lblPedeIdProdRetirar.Name = "lblPedeIdProdRetirar";
            lblPedeIdProdRetirar.Size = new Size(361, 23);
            lblPedeIdProdRetirar.TabIndex = 1;
            lblPedeIdProdRetirar.Text = "Insira o id do produto que deseja retirar do estoque";
            lblPedeIdProdRetirar.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtIdProdASerRetirado
            // 
            txtIdProdASerRetirado.Location = new Point(297, 85);
            txtIdProdASerRetirado.Name = "txtIdProdASerRetirado";
            txtIdProdASerRetirado.PlaceholderText = "Digite aqui...";
            txtIdProdASerRetirado.Size = new Size(202, 23);
            txtIdProdASerRetirado.TabIndex = 2;
            // 
            // btnSairRetirarProd
            // 
            btnSairRetirarProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairRetirarProd.Location = new Point(295, 114);
            btnSairRetirarProd.Name = "btnSairRetirarProd";
            btnSairRetirarProd.Size = new Size(99, 23);
            btnSairRetirarProd.TabIndex = 3;
            btnSairRetirarProd.Text = "&Sair";
            btnSairRetirarProd.UseVisualStyleBackColor = true;
            btnSairRetirarProd.Click += btnSairRetirarProd_Click;
            // 
            // btnConfirmarIdProdRetirar
            // 
            btnConfirmarIdProdRetirar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarIdProdRetirar.Location = new Point(400, 114);
            btnConfirmarIdProdRetirar.Name = "btnConfirmarIdProdRetirar";
            btnConfirmarIdProdRetirar.Size = new Size(99, 23);
            btnConfirmarIdProdRetirar.TabIndex = 4;
            btnConfirmarIdProdRetirar.Text = "&Confirmar";
            btnConfirmarIdProdRetirar.UseVisualStyleBackColor = true;
            btnConfirmarIdProdRetirar.Click += btnConfirmarIdProdRetirar_Click;
            // 
            // pnlDgvRetirar
            // 
            pnlDgvRetirar.Controls.Add(pnlDadosProdRetirar);
            pnlDgvRetirar.Location = new Point(28, 144);
            pnlDgvRetirar.Name = "pnlDgvRetirar";
            pnlDgvRetirar.Size = new Size(736, 294);
            pnlDgvRetirar.TabIndex = 5;
            // 
            // pnlDadosProdRetirar
            // 
            pnlDadosProdRetirar.BackColor = SystemColors.ButtonHighlight;
            pnlDadosProdRetirar.Controls.Add(btnVoltarR);
            pnlDadosProdRetirar.Controls.Add(btnRetirarQuantidadeProd);
            pnlDadosProdRetirar.Controls.Add(txtQuantidadeASerRetirada);
            pnlDadosProdRetirar.Controls.Add(lblPedeQuantidadeRetirar);
            pnlDadosProdRetirar.Controls.Add(lblQuantidadeProdRetirar);
            pnlDadosProdRetirar.Controls.Add(lblPrecoProdRetirar);
            pnlDadosProdRetirar.Controls.Add(lblNomeProdRetirar);
            pnlDadosProdRetirar.Controls.Add(lblProdutoRetirarEncontrado);
            pnlDadosProdRetirar.Location = new Point(216, 13);
            pnlDadosProdRetirar.Name = "pnlDadosProdRetirar";
            pnlDadosProdRetirar.Size = new Size(308, 252);
            pnlDadosProdRetirar.TabIndex = 0;
            // 
            // btnVoltarR
            // 
            btnVoltarR.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVoltarR.Location = new Point(50, 214);
            btnVoltarR.Name = "btnVoltarR";
            btnVoltarR.Size = new Size(99, 23);
            btnVoltarR.TabIndex = 7;
            btnVoltarR.Text = "&Voltar";
            btnVoltarR.UseVisualStyleBackColor = true;
            btnVoltarR.Click += btnVoltarR_Click;
            // 
            // btnRetirarQuantidadeProd
            // 
            btnRetirarQuantidadeProd.AccessibleRole = AccessibleRole.TitleBar;
            btnRetirarQuantidadeProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirarQuantidadeProd.Location = new Point(155, 214);
            btnRetirarQuantidadeProd.Name = "btnRetirarQuantidadeProd";
            btnRetirarQuantidadeProd.Size = new Size(100, 23);
            btnRetirarQuantidadeProd.TabIndex = 6;
            btnRetirarQuantidadeProd.Text = "&Retirar";
            btnRetirarQuantidadeProd.UseVisualStyleBackColor = true;
            btnRetirarQuantidadeProd.Click += btnRetirarQuantidadeProd_Click;
            // 
            // txtQuantidadeASerRetirada
            // 
            txtQuantidadeASerRetirada.Location = new Point(101, 185);
            txtQuantidadeASerRetirada.Name = "txtQuantidadeASerRetirada";
            txtQuantidadeASerRetirada.PlaceholderText = "Digite aqui...";
            txtQuantidadeASerRetirada.Size = new Size(100, 23);
            txtQuantidadeASerRetirada.TabIndex = 5;
            // 
            // lblPedeQuantidadeRetirar
            // 
            lblPedeQuantidadeRetirar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPedeQuantidadeRetirar.Location = new Point(-1, 160);
            lblPedeQuantidadeRetirar.Name = "lblPedeQuantidadeRetirar";
            lblPedeQuantidadeRetirar.Size = new Size(316, 27);
            lblPedeQuantidadeRetirar.TabIndex = 4;
            lblPedeQuantidadeRetirar.Text = "Insira a quantidade de produto que será retirado";
            lblPedeQuantidadeRetirar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantidadeProdRetirar
            // 
            lblQuantidadeProdRetirar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblQuantidadeProdRetirar.Location = new Point(16, 119);
            lblQuantidadeProdRetirar.Name = "lblQuantidadeProdRetirar";
            lblQuantidadeProdRetirar.Size = new Size(273, 23);
            lblQuantidadeProdRetirar.TabIndex = 3;
            // 
            // lblPrecoProdRetirar
            // 
            lblPrecoProdRetirar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPrecoProdRetirar.Location = new Point(16, 80);
            lblPrecoProdRetirar.Name = "lblPrecoProdRetirar";
            lblPrecoProdRetirar.Size = new Size(273, 23);
            lblPrecoProdRetirar.TabIndex = 2;
            // 
            // lblNomeProdRetirar
            // 
            lblNomeProdRetirar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNomeProdRetirar.Location = new Point(16, 36);
            lblNomeProdRetirar.Name = "lblNomeProdRetirar";
            lblNomeProdRetirar.Size = new Size(273, 23);
            lblNomeProdRetirar.TabIndex = 1;
            // 
            // lblProdutoRetirarEncontrado
            // 
            lblProdutoRetirarEncontrado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblProdutoRetirarEncontrado.Location = new Point(0, 0);
            lblProdutoRetirarEncontrado.Name = "lblProdutoRetirarEncontrado";
            lblProdutoRetirarEncontrado.Size = new Size(305, 36);
            lblProdutoRetirarEncontrado.TabIndex = 0;
            lblProdutoRetirarEncontrado.Text = "Produto selecionado";
            lblProdutoRetirarEncontrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaRetirarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDgvRetirar);
            Controls.Add(btnConfirmarIdProdRetirar);
            Controls.Add(btnSairRetirarProd);
            Controls.Add(txtIdProdASerRetirado);
            Controls.Add(lblPedeIdProdRetirar);
            Controls.Add(label1);
            Name = "TelaRetirarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaRetirarProduto";
            pnlDgvRetirar.ResumeLayout(false);
            pnlDadosProdRetirar.ResumeLayout(false);
            pnlDadosProdRetirar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPedeIdProdRetirar;
        private TextBox txtIdProdASerRetirado;
        private Button btnSairRetirarProd;
        private Button btnConfirmarIdProdRetirar;
        private Panel pnlDgvRetirar;
        private Panel pnlDadosProdRetirar;
        private Label lblProdutoRetirarEncontrado;
        private Label lblQuantidadeProdRetirar;
        private Label lblPrecoProdRetirar;
        private Label lblNomeProdRetirar;
        private Button btnVoltarR;
        private Button btnRetirarQuantidadeProd;
        private TextBox txtQuantidadeASerRetirada;
        private Label lblPedeQuantidadeRetirar;
    }
}