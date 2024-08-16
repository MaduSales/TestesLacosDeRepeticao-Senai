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
    public partial class FrmTabuada : Form
    {
        public FrmTabuada()
        {
            InitializeComponent();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int numero, total = 0, i = 0;

            numero = Convert.ToInt32(txtNumero.Text);
            

            txtLista.Items.Clear(); 

            for (i = 0; i <= 10; i++)
            {
                total = i * numero;
                txtLista.Items.Add($"{numero}  x {i} = {total}"); // Não esqueça que, em uma LISTA, usa-se Items.Add()
            }
        }
    }
}
