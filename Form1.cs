using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Principal
{
    
    
    public partial class Form1 : Form
    {
        public float nota1, nota2, nota3, nota4, media;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            
            nota1 = float.Parse(textNota1.Text); //convertendo o campo text para float
            nota2 = float.Parse(textNota2.Text);
            nota3 = float.Parse(textNota3.Text);
            nota4 = float.Parse(textNota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) /4;//Operação

            txtMedia.Text = Convert.ToString(media);//convertendo o valor do resultado

            //condição IF
            if (media == 10)
            {
                LblSituation.Text = "Aprovado Parabéns!!";
            }
            if (media >= 7)
            {
                LblSituation.Text = "Aprovado";
            }
            else
            {
                LblSituation.Text = "Reprovado";
            }
        }
    }
}
