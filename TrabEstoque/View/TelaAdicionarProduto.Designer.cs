namespace TrabEstoque.View
{
    partial class TelaAdicionarProduto
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
            lblAddProd = new Label();
            lblPedeIdProd = new Label();
            txtIdProdAdd = new TextBox();
            btnConfirmaIdProdAdd = new Button();
            pnlDgv = new Panel();
            pnlDadosProdAdd = new Panel();
            btnVoltar = new Button();
            btnAddQuantidadeProd = new Button();
            txtQuantidadeASerAdd = new TextBox();
            lblPedeQuantidadeAdd = new Label();
            lblQuantidadeProd = new Label();
            lblPrecoProdAdd = new Label();
            lblProdEncontrado = new Label();
            lblNomeProdAdd = new Label();
            btnSairAddProd = new Button();
            pnlDgv.SuspendLayout();
            pnlDadosProdAdd.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddProd
            // 
            lblAddProd.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAddProd.Location = new Point(-3, -28);
            lblAddProd.Name = "lblAddProd";
            lblAddProd.Size = new Size(802, 110);
            lblAddProd.TabIndex = 0;
            lblAddProd.Text = "Adicionar produto no estoque";
            lblAddProd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPedeIdProd
            // 
            lblPedeIdProd.AutoSize = true;
            lblPedeIdProd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPedeIdProd.Location = new Point(215, 52);
            lblPedeIdProd.Name = "lblPedeIdProd";
            lblPedeIdProd.Size = new Size(377, 19);
            lblPedeIdProd.TabIndex = 1;
            lblPedeIdProd.Text = "Insira o id do produto que deseja adicionar no estoque";
            // 
            // txtIdProdAdd
            // 
            txtIdProdAdd.Location = new Point(297, 85);
            txtIdProdAdd.Name = "txtIdProdAdd";
            txtIdProdAdd.PlaceholderText = "Digite aqui...";
            txtIdProdAdd.Size = new Size(202, 23);
            txtIdProdAdd.TabIndex = 2;
            // 
            // btnConfirmaIdProdAdd
            // 
            btnConfirmaIdProdAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmaIdProdAdd.Location = new Point(400, 114);
            btnConfirmaIdProdAdd.Name = "btnConfirmaIdProdAdd";
            btnConfirmaIdProdAdd.Size = new Size(99, 23);
            btnConfirmaIdProdAdd.TabIndex = 3;
            btnConfirmaIdProdAdd.Text = "&Confirmar";
            btnConfirmaIdProdAdd.UseVisualStyleBackColor = true;
            btnConfirmaIdProdAdd.Click += btnConfirmaIdProdAdd_Click;
            // 
            // pnlDgv
            // 
            pnlDgv.Controls.Add(pnlDadosProdAdd);
            pnlDgv.Location = new Point(28, 144);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Size = new Size(736, 294);
            pnlDgv.TabIndex = 4;
            // 
            // pnlDadosProdAdd
            // 
            pnlDadosProdAdd.BackColor = SystemColors.ButtonHighlight;
            pnlDadosProdAdd.Controls.Add(btnVoltar);
            pnlDadosProdAdd.Controls.Add(btnAddQuantidadeProd);
            pnlDadosProdAdd.Controls.Add(txtQuantidadeASerAdd);
            pnlDadosProdAdd.Controls.Add(lblPedeQuantidadeAdd);
            pnlDadosProdAdd.Controls.Add(lblQuantidadeProd);
            pnlDadosProdAdd.Controls.Add(lblPrecoProdAdd);
            pnlDadosProdAdd.Controls.Add(lblProdEncontrado);
            pnlDadosProdAdd.Controls.Add(lblNomeProdAdd);
            pnlDadosProdAdd.Location = new Point(216, 13);
            pnlDadosProdAdd.Name = "pnlDadosProdAdd";
            pnlDadosProdAdd.Size = new Size(308, 252);
            pnlDadosProdAdd.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(50, 214);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(99, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "&Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAddQuantidadeProd
            // 
            btnAddQuantidadeProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuantidadeProd.Location = new Point(155, 214);
            btnAddQuantidadeProd.Name = "btnAddQuantidadeProd";
            btnAddQuantidadeProd.Size = new Size(100, 23);
            btnAddQuantidadeProd.TabIndex = 6;
            btnAddQuantidadeProd.Text = "&Adicionar";
            btnAddQuantidadeProd.UseVisualStyleBackColor = true;
            btnAddQuantidadeProd.Click += btnAddQuantidadeProd_Click;
            // 
            // txtQuantidadeASerAdd
            // 
            txtQuantidadeASerAdd.Location = new Point(101, 185);
            txtQuantidadeASerAdd.Name = "txtQuantidadeASerAdd";
            txtQuantidadeASerAdd.PlaceholderText = "Digite aqui...";
            txtQuantidadeASerAdd.Size = new Size(100, 23);
            txtQuantidadeASerAdd.TabIndex = 5;
            // 
            // lblPedeQuantidadeAdd
            // 
            lblPedeQuantidadeAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPedeQuantidadeAdd.Location = new Point(16, 155);
            lblPedeQuantidadeAdd.Name = "lblPedeQuantidadeAdd";
            lblPedeQuantidadeAdd.Size = new Size(273, 27);
            lblPedeQuantidadeAdd.TabIndex = 4;
            lblPedeQuantidadeAdd.Text = "Insira a quantidade que será adicionada";
            lblPedeQuantidadeAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuantidadeProd
            // 
            lblQuantidadeProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblQuantidadeProd.Location = new Point(16, 119);
            lblQuantidadeProd.Name = "lblQuantidadeProd";
            lblQuantidadeProd.Size = new Size(273, 23);
            lblQuantidadeProd.TabIndex = 3;
            // 
            // lblPrecoProdAdd
            // 
            lblPrecoProdAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPrecoProdAdd.Location = new Point(16, 80);
            lblPrecoProdAdd.Name = "lblPrecoProdAdd";
            lblPrecoProdAdd.Size = new Size(273, 23);
            lblPrecoProdAdd.TabIndex = 2;
            // 
            // lblProdEncontrado
            // 
            lblProdEncontrado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdEncontrado.Location = new Point(0, 0);
            lblProdEncontrado.Name = "lblProdEncontrado";
            lblProdEncontrado.Size = new Size(305, 36);
            lblProdEncontrado.TabIndex = 1;
            lblProdEncontrado.Text = "Produto selecionado";
            lblProdEncontrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProdAdd
            // 
            lblNomeProdAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeProdAdd.Location = new Point(16, 36);
            lblNomeProdAdd.Name = "lblNomeProdAdd";
            lblNomeProdAdd.Size = new Size(273, 23);
            lblNomeProdAdd.TabIndex = 0;
            // 
            // btnSairAddProd
            // 
            btnSairAddProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairAddProd.Location = new Point(295, 114);
            btnSairAddProd.Name = "btnSairAddProd";
            btnSairAddProd.Size = new Size(99, 23);
            btnSairAddProd.TabIndex = 5;
            btnSairAddProd.Text = "&Sair";
            btnSairAddProd.UseVisualStyleBackColor = true;
            btnSairAddProd.Click += btnSairAddProd_Click;
            // 
            // TelaAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSairAddProd);
            Controls.Add(pnlDgv);
            Controls.Add(btnConfirmaIdProdAdd);
            Controls.Add(txtIdProdAdd);
            Controls.Add(lblPedeIdProd);
            Controls.Add(lblAddProd);
            Name = "TelaAdicionarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaAdicionarProduto";
            pnlDgv.ResumeLayout(false);
            pnlDadosProdAdd.ResumeLayout(false);
            pnlDadosProdAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddProd;
        private Label lblPedeIdProd;
        private TextBox txtIdProdAdd;
        private Button btnConfirmaIdProdAdd;
        private Panel pnlDgv;
        private Button btnSairAddProd;
        private Panel pnlDadosProdAdd;
        private Label lblProdEncontrado;
        private Label lblNomeProdAdd;
        private TextBox txtQuantidadeASerAdd;
        private Label lblPedeQuantidadeAdd;
        private Label lblQuantidadeProd;
        private Label lblPrecoProdAdd;
        private Button btnAddQuantidadeProd;
        private Button btnVoltar;
    }
}