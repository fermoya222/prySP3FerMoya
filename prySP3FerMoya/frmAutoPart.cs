using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP3FerMoya
{
    public partial class frmAutoPart : Form
    {
        public frmAutoPart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mrcRegistro_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                e.Handled = true;
                return;
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // usamos los métodos de la clase 'Char', (IsLower y ToUpper)
                if (Char.IsLower(e.KeyChar)) // es una minúscula ?
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar); // convertir a mayúscula
                }
                // no es ni letra ni número y es distinto de Backspace ?
                if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // borrar la tecla
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
