namespace TrabEstoque.View
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnCadastrarProd = new Button();
            btnAddProd = new Button();
            btnRemoverProd = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Plum;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(1, -1);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(802, 111);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Controle de Estoque";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrarProd
            // 
            btnCadastrarProd.BackColor = SystemColors.ButtonHighlight;
            btnCadastrarProd.Cursor = Cursors.Hand;
            btnCadastrarProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarProd.Location = new Point(240, 122);
            btnCadastrarProd.Name = "btnCadastrarProd";
            btnCadastrarProd.Size = new Size(294, 71);
            btnCadastrarProd.TabIndex = 2;
            btnCadastrarProd.Text = "Cadastrar produto";
            btnCadastrarProd.UseVisualStyleBackColor = false;
            // 
            // btnAddProd
            // 
            btnAddProd.Cursor = Cursors.Hand;
            btnAddProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddProd.Location = new Point(240, 210);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(294, 71);
            btnAddProd.TabIndex = 3;
            btnAddProd.Text = "Adicionar produto";
            btnAddProd.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProd
            // 
            btnRemoverProd.Cursor = Cursors.Hand;
            btnRemoverProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRemoverProd.Location = new Point(240, 300);
            btnRemoverProd.Name = "btnRemoverProd";
            btnRemoverProd.Size = new Size(294, 71);
            btnRemoverProd.TabIndex = 4;
            btnRemoverProd.Text = "Remover produto";
            btnRemoverProd.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(248, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(248, 309);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 50);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(248, 133);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 50);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnRemoverProd);
            Controls.Add(btnAddProd);
            Controls.Add(btnCadastrarProd);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "TelaInicial";
            Text = "TelaInicial";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Button btnCadastrarProd;
        private Button btnAddProd;
        private Button btnRemoverProd;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}