using System;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                Double Altura = 0, Pesoideal = 0;
                Altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    Pesoideal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome + " seu peso ideal é: " + Pesoideal.ToString() + " Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    Pesoideal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome + " seu peso ideal é: " + Pesoideal.ToString() + " Kg", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informados", "Peso Idela", MessageBoxButtons.OK, MessageBoxIcon.Error);      
            }
            {

            }
        }
    }
}
