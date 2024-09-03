using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRegiaoEstado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboEstados.Text == "SP" || cboEstados.Text == "RJ" || cboEstados.Text == "MG" || cboEstados.Text == "ES")
            {
                cboSudeste.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblSudeste.Text = cboEstados.Items.Count.ToString();
                cboSudeste.Sorted = true;
            }

            if (cboEstados.Text == "PR" || cboEstados.Text == "RS" || cboEstados.Text == "MG" || cboEstados.Text == "SC")
            {
                cboSul.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblSul.Text = cboEstados.Items.Count.ToString();
                cboSudeste.Sorted = true;
            }

            if (cboEstados.Text == "MT" || cboEstados.Text == "GO" || cboEstados.Text == "MS")
            {
                cboCentro.Items.Add(cboEstados.Text);
                cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                lblEstados.Text = cboEstados.Items.Count.ToString();
                lblCentro.Text = cboEstados.Items.Count.ToString();
                cboCentro.Sorted = true;
            }
        }

        private void cboNordeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCentro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSudeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
