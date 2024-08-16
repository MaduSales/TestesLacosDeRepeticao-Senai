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
    public partial class FrmExemplo02 : Form
    {
        int inicio, fim;

        public FrmExemplo02()
        {
            InitializeComponent();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            inicio = Convert.ToInt32(txtInicio.Text);
            fim = Convert.ToInt32(txtFim.Text);

            txtLista.Items.Clear();

            do
            {
                txtLista.Items.Add(inicio);
                inicio++;
            }
            while (inicio <= fim);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            txtLista.Items.Clear();

            for (inicio = 0; inicio <= fim; inicio++)
            {
                txtLista.Items.Add(inicio);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
           inicio = Convert.ToInt32(txtInicio.Text);
           fim = Convert.ToInt32(txtFim.Text);

            txtLista.Items.Clear();

            while (inicio <= fim)
            {
                txtLista.Items.Add(inicio);
                inicio++;
            }



        }
    }
}
