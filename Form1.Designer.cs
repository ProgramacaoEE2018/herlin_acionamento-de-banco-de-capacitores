namespace Trabalho_Acionamento_Capacitor
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
            this.tensao = new System.Windows.Forms.Label();
            this.frequencia = new System.Windows.Forms.Label();
            this.potenciaativa = new System.Windows.Forms.Label();
            this.potenciareativa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txttensao = new System.Windows.Forms.TextBox();
            this.txtpotenciaativa = new System.Windows.Forms.TextBox();
            this.txtpotenciareativa = new System.Windows.Forms.TextBox();
            this.txtfrequencia = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.capacitancia = new System.Windows.Forms.Label();
            this.fatordepotencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tensao
            // 
            this.tensao.AutoSize = true;
            this.tensao.Location = new System.Drawing.Point(490, 51);
            this.tensao.Name = "tensao";
            this.tensao.Size = new System.Drawing.Size(100, 13);
            this.tensao.TabIndex = 0;
            this.tensao.Text = "Tensão de Linha(V)";
            // 
            // frequencia
            // 
            this.frequencia.AutoSize = true;
            this.frequencia.Location = new System.Drawing.Point(490, 77);
            this.frequencia.Name = "frequencia";
            this.frequencia.Size = new System.Drawing.Size(79, 13);
            this.frequencia.TabIndex = 1;
            this.frequencia.Text = "Frequência(Hz)";
            // 
            // potenciaativa
            // 
            this.potenciaativa.AutoSize = true;
            this.potenciaativa.Location = new System.Drawing.Point(490, 107);
            this.potenciaativa.Name = "potenciaativa";
            this.potenciaativa.Size = new System.Drawing.Size(138, 13);
            this.potenciaativa.TabIndex = 2;
            this.potenciaativa.Text = "Média Potência Ativa(KWh)";
            // 
            // potenciareativa
            // 
            this.potenciareativa.AutoSize = true;
            this.potenciareativa.Location = new System.Drawing.Point(472, 137);
            this.potenciareativa.Name = "potenciareativa";
            this.potenciareativa.Size = new System.Drawing.Size(151, 13);
            this.potenciareativa.TabIndex = 3;
            this.potenciareativa.Text = "Média Potência Reativa(KWh)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(629, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txttensao
            // 
            this.txttensao.Location = new System.Drawing.Point(629, 44);
            this.txttensao.Name = "txttensao";
            this.txttensao.Size = new System.Drawing.Size(100, 20);
            this.txttensao.TabIndex = 5;
            // 
            // txtpotenciaativa
            // 
            this.txtpotenciaativa.Location = new System.Drawing.Point(629, 105);
            this.txtpotenciaativa.Name = "txtpotenciaativa";
            this.txtpotenciaativa.Size = new System.Drawing.Size(100, 20);
            this.txtpotenciaativa.TabIndex = 6;
            // 
            // txtpotenciareativa
            // 
            this.txtpotenciareativa.Location = new System.Drawing.Point(629, 134);
            this.txtpotenciareativa.Name = "txtpotenciareativa";
            this.txtpotenciareativa.Size = new System.Drawing.Size(100, 20);
            this.txtpotenciareativa.TabIndex = 7;
            // 
            // txtfrequencia
            // 
            this.txtfrequencia.Location = new System.Drawing.Point(629, 74);
            this.txtfrequencia.Name = "txtfrequencia";
            this.txtfrequencia.Size = new System.Drawing.Size(100, 20);
            this.txtfrequencia.TabIndex = 8;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(525, 217);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(670, 217);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // capacitancia
            // 
            this.capacitancia.AutoSize = true;
            this.capacitancia.Location = new System.Drawing.Point(522, 274);
            this.capacitancia.Name = "capacitancia";
            this.capacitancia.Size = new System.Drawing.Size(69, 13);
            this.capacitancia.TabIndex = 11;
            this.capacitancia.Text = "Capacitância";
            // 
            // fatordepotencia
            // 
            this.fatordepotencia.AutoSize = true;
            this.fatordepotencia.Location = new System.Drawing.Point(490, 179);
            this.fatordepotencia.Name = "fatordepotencia";
            this.fatordepotencia.Size = new System.Drawing.Size(124, 13);
            this.fatordepotencia.TabIndex = 12;
            this.fatordepotencia.Text = "Fator de Potência(>0,95)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fatordepotencia);
            this.Controls.Add(this.capacitancia);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtfrequencia);
            this.Controls.Add(this.txtpotenciareativa);
            this.Controls.Add(this.txtpotenciaativa);
            this.Controls.Add(this.txttensao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.potenciareativa);
            this.Controls.Add(this.potenciaativa);
            this.Controls.Add(this.frequencia);
            this.Controls.Add(this.tensao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tensao;
        private System.Windows.Forms.Label frequencia;
        private System.Windows.Forms.Label potenciaativa;
        private System.Windows.Forms.Label potenciareativa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txttensao;
        private System.Windows.Forms.TextBox txtpotenciaativa;
        private System.Windows.Forms.TextBox txtpotenciareativa;
        private System.Windows.Forms.TextBox txtfrequencia;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label capacitancia;
        private System.Windows.Forms.Label fatordepotencia;
    }
}

