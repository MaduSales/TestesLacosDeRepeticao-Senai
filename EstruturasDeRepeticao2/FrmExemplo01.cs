using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasDeRepeticao2
{
    public partial class FrmExemplo01 : Form
    {
        //int numero = 0;
        int i = 0;
        public FrmExemplo01()
        {
            InitializeComponent();
            
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            txtLista.Items.Clear();

            while (i <= 20)
            {
                txtLista.Items.Add(i);
                i++;
            }
            MessageBox.Show("Fim da execução WHILE!");
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            txtLista.Items.Clear();

            do
            {
                txtLista.Items.Add(i);
                i++;
            }
            while (i <= 20);
            MessageBox.Show("Fim da execução DO WHILE!");
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            
            int i;
            txtLista.Items.Clear();

            for (i = 0; i <= 20; i++)
            {
                txtLista.Items.Add(i);
            }

            MessageBox.Show("Fim da execução do laço FOR");
        }
    }
}
