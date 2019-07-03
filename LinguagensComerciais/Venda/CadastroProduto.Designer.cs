namespace Venda
{
    partial class CadastroProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.validadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fabricacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.margemNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.precoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.produtoTextBox = new System.Windows.Forms.TextBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margemNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limparButton);
            this.groupBox1.Controls.Add(this.removerButton);
            this.groupBox1.Controls.Add(this.editarButton);
            this.groupBox1.Controls.Add(this.buscarButton);
            this.groupBox1.Controls.Add(this.salvarButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // removerButton
            // 
            this.removerButton.Enabled = false;
            this.removerButton.Image = global::Venda.Properties.Resources.remover;
            this.removerButton.Location = new System.Drawing.Point(210, 14);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(43, 35);
            this.removerButton.TabIndex = 1;
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Visible = false;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.idTextBox);
            this.groupBox2.Controls.Add(this.labelDescricao);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(this.validadeNumericUpDown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fabricacaoDateTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.margemNumericUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.precoNumericUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.produtoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(199, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(120, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 176);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 12;
            this.labelDescricao.Text = "Descrição";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(9, 192);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(310, 20);
            this.descricaoTextBox.TabIndex = 11;
            // 
            // validadeNumericUpDown
            // 
            this.validadeNumericUpDown.Location = new System.Drawing.Point(199, 133);
            this.validadeNumericUpDown.Name = "validadeNumericUpDown";
            this.validadeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.validadeNumericUpDown.TabIndex = 10;
            this.validadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Validade";
            // 
            // fabricacaoDateTimePicker
            // 
            this.fabricacaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fabricacaoDateTimePicker.Location = new System.Drawing.Point(9, 133);
            this.fabricacaoDateTimePicker.Name = "fabricacaoDateTimePicker";
            this.fabricacaoDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.fabricacaoDateTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fabricação";
            // 
            // margemNumericUpDown
            // 
            this.margemNumericUpDown.Location = new System.Drawing.Point(199, 78);
            this.margemNumericUpDown.Name = "margemNumericUpDown";
            this.margemNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.margemNumericUpDown.TabIndex = 6;
            this.margemNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Margem";
            // 
            // precoNumericUpDown
            // 
            this.precoNumericUpDown.DecimalPlaces = 2;
            this.precoNumericUpDown.Location = new System.Drawing.Point(9, 78);
            this.precoNumericUpDown.Name = "precoNumericUpDown";
            this.precoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.precoNumericUpDown.TabIndex = 4;
            this.precoNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // produtoTextBox
            // 
            this.produtoTextBox.Location = new System.Drawing.Point(9, 32);
            this.produtoTextBox.Name = "produtoTextBox";
            this.produtoTextBox.Size = new System.Drawing.Size(120, 20);
            this.produtoTextBox.TabIndex = 0;
            // 
            // limparButton
            // 
            this.limparButton.Image = global::Venda.Properties.Resources.limpar;
            this.limparButton.Location = new System.Drawing.Point(71, 14);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(40, 35);
            this.limparButton.TabIndex = 17;
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Enabled = false;
            this.editarButton.Image = global::Venda.Properties.Resources.botao_editar_1_1;
            this.editarButton.Location = new System.Drawing.Point(141, 14);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(39, 35);
            this.editarButton.TabIndex = 16;
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Visible = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::Venda.Properties.Resources.busca;
            this.buscarButton.Location = new System.Drawing.Point(9, 14);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(41, 35);
            this.buscarButton.TabIndex = 15;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Visible = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Image = global::Venda.Properties.Resources.salvar;
            this.salvarButton.Location = new System.Drawing.Point(280, 14);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(39, 35);
            this.salvarButton.TabIndex = 0;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margemNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precoNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown validadeNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fabricacaoDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown margemNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown precoNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox produtoTextBox;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button limparButton;
    }
}