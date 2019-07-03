namespace Venda
{
    partial class FormVenda
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
            this.exibirVendasGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exibirVendasGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exibirVendasGridView1
            // 
            this.exibirVendasGridView1.AllowUserToOrderColumns = true;
            this.exibirVendasGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exibirVendasGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exibirVendasGridView1.Location = new System.Drawing.Point(12, 50);
            this.exibirVendasGridView1.Name = "exibirVendasGridView1";
            this.exibirVendasGridView1.RowHeadersWidth = 50;
            this.exibirVendasGridView1.Size = new System.Drawing.Size(467, 357);
            this.exibirVendasGridView1.TabIndex = 0;
            this.exibirVendasGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exibirVendasGridView1_CellContentClick);
            // 
            // btnConsultarVendas
            // 
            this.btnConsultarVendas.Image = global::Venda.Properties.Resources.busca;
            this.btnConsultarVendas.Location = new System.Drawing.Point(12, 12);
            this.btnConsultarVendas.Name = "btnConsultarVendas";
            this.btnConsultarVendas.Size = new System.Drawing.Size(59, 32);
            this.btnConsultarVendas.TabIndex = 1;
            this.btnConsultarVendas.UseVisualStyleBackColor = true;
            this.btnConsultarVendas.Click += new System.EventHandler(this.btnConsultarVendas_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 410);
            this.Controls.Add(this.btnConsultarVendas);
            this.Controls.Add(this.exibirVendasGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVenda";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.exibirVendasGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView exibirVendasGridView1;
        private System.Windows.Forms.Button btnConsultarVendas;
    }
}