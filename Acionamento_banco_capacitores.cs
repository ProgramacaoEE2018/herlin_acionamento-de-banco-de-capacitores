using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Acionamento_Capacitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double tensao;
            double frequencia;
            double potenciaativa;
            double potenciareativa;
            double fatordepotencia;
            double total;
            double angulofinal;
            double potenciareativafinal;
            double horariofuncionamento;
            tensao = Convert.ToDouble(txttensao.Text);
            frequencia = Convert.ToDouble(txtfrequencia.Text);
            potenciaativa = Convert.ToDouble(txtpotenciaativa.Text);
            potenciareativa = Convert.ToDouble(txtpotenciareativa.Text);
            fatordepotencia = Convert.ToDouble(txtfatordepotencia.Text);
            horariofuncionamento = Convert.ToDouble(txthorariofuncionamento.Text);
            if (horariofuncionamento >5)
            {
                angulofinal = Math.Acos(fatordepotencia);
                potenciareativafinal = Math.Tan(angulofinal) * potenciaativa;
                total = 1000000000 * (potenciareativa - potenciareativafinal) / (2 * tensao * tensao * frequencia * Math.PI);
                lblcapacitancia.Text = total.ToString();
            }
        }
    }
}
