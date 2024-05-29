namespace Sistema_Principal
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
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNota4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSituation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(118, 73);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(100, 22);
            this.textNota1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota1";
            // 
            // BtnResultado
            // 
            this.BtnResultado.Location = new System.Drawing.Point(21, 249);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(100, 28);
            this.BtnResultado.TabIndex = 2;
            this.BtnResultado.Text = "Verificar";
            this.BtnResultado.UseVisualStyleBackColor = true;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click);
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(118, 123);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(100, 22);
            this.textNota2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota2";
            // 
            // textNota3
            // 
            this.textNota3.Location = new System.Drawing.Point(337, 73);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(100, 22);
            this.textNota3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota3";
            // 
            // textNota4
            // 
            this.textNota4.Location = new System.Drawing.Point(337, 123);
            this.textNota4.Name = "textNota4";
            this.textNota4.Size = new System.Drawing.Size(100, 22);
            this.textNota4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota4";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(212, 182);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 22);
            this.txtMedia.TabIndex = 9;
            this.txtMedia.TextChanged += new System.EventHandler(this.txtMedia_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Média";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Situação:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblSituation
            // 
            this.LblSituation.AutoSize = true;
            this.LblSituation.Location = new System.Drawing.Point(230, 249);
            this.LblSituation.Name = "LblSituation";
            this.LblSituation.Size = new System.Drawing.Size(0, 16);
            this.LblSituation.TabIndex = 12;
            this.LblSituation.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(72, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Digite o nome do aluno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblSituation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNota4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNota1);
            this.Name = "Form1";
            this.Text = "Sistema Escola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnResultado;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNota4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSituation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}

