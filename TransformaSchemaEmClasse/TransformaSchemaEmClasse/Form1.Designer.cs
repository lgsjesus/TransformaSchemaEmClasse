namespace TransformaSchemaEmClasse
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBD = new System.Windows.Forms.ComboBox();
            this.richtxtSchema = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTxtResult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco de Dados";
            // 
            // comboBD
            // 
            this.comboBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBD.FormattingEnabled = true;
            this.comboBD.Items.AddRange(new object[] {
            "Oracle",
            "Sql Server"});
            this.comboBD.Location = new System.Drawing.Point(105, 16);
            this.comboBD.Name = "comboBD";
            this.comboBD.Size = new System.Drawing.Size(187, 21);
            this.comboBD.TabIndex = 1;
            // 
            // richtxtSchema
            // 
            this.richtxtSchema.Location = new System.Drawing.Point(105, 60);
            this.richtxtSchema.Name = "richtxtSchema";
            this.richtxtSchema.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richtxtSchema.Size = new System.Drawing.Size(651, 221);
            this.richtxtSchema.TabIndex = 2;
            this.richtxtSchema.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Schema DDL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Classe C#";
            // 
            // richTxtResult
            // 
            this.richTxtResult.Location = new System.Drawing.Point(105, 339);
            this.richTxtResult.Name = "richTxtResult";
            this.richTxtResult.ReadOnly = true;
            this.richTxtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTxtResult.Size = new System.Drawing.Size(651, 251);
            this.richTxtResult.TabIndex = 4;
            this.richTxtResult.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTxtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richtxtSchema);
            this.Controls.Add(this.comboBD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Transforma DDL em Classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBD;
        private System.Windows.Forms.RichTextBox richtxtSchema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTxtResult;
        private System.Windows.Forms.Button button1;
    }
}

