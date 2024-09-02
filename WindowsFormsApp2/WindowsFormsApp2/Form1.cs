using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmJuegoBolita : Form
    {
        private Random random;
        private int jugada;

        public frmJuegoBolita()
        {
            InitializeComponent();
            random = new Random();
            jugada = 0;
        }

        private void lblJugar_Click(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 4);
            lblBuscalabolita.Text = randomNumber.ToString();
            jugada++;
            lblJugada.Text = jugada.ToString();
            pbxFeliz1.Visible = false;
            pbxFeliz2.Visible = false;
            pbxFeliz3.Visible = false;
            pbxVaso1.Visible = true;
            pbxVaso2.Visible = true;
            pbxVaso3.Visible = true;
            pbxTriste1.Visible = false;
            pbxTriste2.Visible = false;
            pbxTriste3.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int vaso = 1;
            if (vaso == Convert.ToInt32(lblBuscalabolita.Text))
            {
                pbxFeliz1.Visible = true;
                dgvResultado.Rows.Add(jugada.ToString(), 10, txtJugador.Text);
            }
            else
            {
                dgvResultado.Rows.Add(jugada.ToString(), 0, txtJugador.Text);
                pbxFeliz1.Visible = false;
                pbxTriste1.Visible = true;
            }
        }

        private void btnVaso2_Click(object sender, EventArgs e)
        {
            int vaso = 2;
            if (vaso == Convert.ToInt32(lblBuscalabolita.Text))
            {
                pbxFeliz2.Visible = true;
                dgvResultado.Rows.Add(jugada.ToString(), 10, txtJugador.Text);
            }
            else
            {
                dgvResultado.Rows.Add(jugada.ToString(), 0, txtJugador.Text);
                pbxFeliz2.Visible = false;
                pbxTriste2.Visible = true;
            }
        }

        private void btnVaso3_Click(object sender, EventArgs e)
        {
            int vaso = 3;
            if (vaso == Convert.ToInt32(lblBuscalabolita.Text))
            {
                pbxFeliz3.Visible = true;
                dgvResultado.Rows.Add(jugada.ToString(), 10, txtJugador.Text);
            }
            else
            {
                dgvResultado.Rows.Add(jugada.ToString(), 0, txtJugador.Text);
                pbxFeliz3.Visible = false;
                pbxTriste3.Visible = true;
            }
        }

        private void txtJugador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

