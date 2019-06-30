namespace Venda
{
    partial class FormExibir
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
            this.components = new System.ComponentModel.Container();
            this.exibirTodosDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incluirButton = new System.Windows.Forms.Button();
            this.trabalhoLCDataSet = new Venda.TrabalhoLCDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Venda.TrabalhoLCDataSetTableAdapters.ProdutosTableAdapter();
            this.removerButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exibirTodosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoLCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exibirTodosDataGridView
            // 
            this.exibirTodosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exibirTodosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Descricacao,
            this.Margem,
            this.Preco,
            this.Fabricacao,
            this.Validade});
            this.exibirTodosDataGridView.Location = new System.Drawing.Point(10, 5);
            this.exibirTodosDataGridView.Name = "exibirTodosDataGridView";
            this.exibirTodosDataGridView.ReadOnly = true;
            this.exibirTodosDataGridView.Size = new System.Drawing.Size(745, 482);
            this.exibirTodosDataGridView.TabIndex = 0;
            this.exibirTodosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exibirTodosDataGridView_CellContentClick);
            this.exibirTodosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exibirTodosDataGridView_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricacao
            // 
            this.Descricacao.HeaderText = "Descrição";
            this.Descricacao.Name = "Descricacao";
            this.Descricacao.ReadOnly = true;
            // 
            // Margem
            // 
            this.Margem.HeaderText = "Margem";
            this.Margem.Name = "Margem";
            this.Margem.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Fabricacao
            // 
            this.Fabricacao.HeaderText = "Fabricação";
            this.Fabricacao.Name = "Fabricacao";
            this.Fabricacao.ReadOnly = true;
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Validade";
            this.Validade.Name = "Validade";
            this.Validade.ReadOnly = true;
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(761, 406);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(75, 23);
            this.incluirButton.TabIndex = 1;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            this.incluirButton.Click += new System.EventHandler(this.incluirButton_Click);
            // 
            // trabalhoLCDataSet
            // 
            this.trabalhoLCDataSet.DataSetName = "TrabalhoLCDataSet";
            this.trabalhoLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.trabalhoLCDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(761, 435);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(75, 23);
            this.removerButton.TabIndex = 4;
            this.removerButton.Text = "Remover";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(761, 464);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 5;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 495);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.exibirTodosDataGridView);
            this.Name = "FormExibir";
            this.Text = "Tabela de Produtos";
            this.Load += new System.EventHandler(this.FormExibir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exibirTodosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoLCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView exibirTodosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.Button incluirButton;
        private TrabalhoLCDataSet trabalhoLCDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private TrabalhoLCDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button editarButton;
    }
}