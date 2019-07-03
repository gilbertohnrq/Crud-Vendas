namespace Venda
{
    partial class Options
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.removerButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nomeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nomeLabel.Location = new System.Drawing.Point(12, 9);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(59, 20);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Produto";
            this.nomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // removerButton
            // 
            this.removerButton.Image = global::Venda.Properties.Resources.remover;
            this.removerButton.Location = new System.Drawing.Point(176, 48);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(50, 39);
            this.removerButton.TabIndex = 1;
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Image = global::Venda.Properties.Resources.botao_editar_1_1;
            this.editarButton.Location = new System.Drawing.Point(118, 48);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(52, 39);
            this.editarButton.TabIndex = 0;
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 99);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.editarButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Label nomeLabel;
    }
}