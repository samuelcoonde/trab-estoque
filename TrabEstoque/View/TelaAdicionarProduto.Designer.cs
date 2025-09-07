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
            SuspendLayout();
            // 
            // lblAddProd
            // 
            lblAddProd.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAddProd.Location = new Point(-2, -9);
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
            lblPedeIdProd.Location = new Point(213, 82);
            lblPedeIdProd.Name = "lblPedeIdProd";
            lblPedeIdProd.Size = new Size(377, 19);
            lblPedeIdProd.TabIndex = 1;
            lblPedeIdProd.Text = "Insira o id do produto que deseja adicionar no estoque";
            // 
            // txtIdProdAdd
            // 
            txtIdProdAdd.Location = new Point(252, 115);
            txtIdProdAdd.Name = "txtIdProdAdd";
            txtIdProdAdd.PlaceholderText = "Digite aqui";
            txtIdProdAdd.Size = new Size(105, 23);
            txtIdProdAdd.TabIndex = 2;
            // 
            // btnConfirmaIdProdAdd
            // 
            btnConfirmaIdProdAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmaIdProdAdd.Location = new Point(420, 114);
            btnConfirmaIdProdAdd.Name = "btnConfirmaIdProdAdd";
            btnConfirmaIdProdAdd.Size = new Size(105, 23);
            btnConfirmaIdProdAdd.TabIndex = 3;
            btnConfirmaIdProdAdd.Text = "&Confirmar";
            btnConfirmaIdProdAdd.UseVisualStyleBackColor = true;
            btnConfirmaIdProdAdd.Click += btnConfirmaIdProdAdd_Click;
            // 
            // pnlDgv
            // 
            pnlDgv.Location = new Point(29, 156);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Size = new Size(736, 294);
            pnlDgv.TabIndex = 4;
            // 
            // TelaAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDgv);
            Controls.Add(btnConfirmaIdProdAdd);
            Controls.Add(txtIdProdAdd);
            Controls.Add(lblPedeIdProd);
            Controls.Add(lblAddProd);
            Name = "TelaAdicionarProduto";
            Text = "TelaAdicionarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddProd;
        private Label lblPedeIdProd;
        private TextBox txtIdProdAdd;
        private Button btnConfirmaIdProdAdd;
        private Panel pnlDgv;
    }
}