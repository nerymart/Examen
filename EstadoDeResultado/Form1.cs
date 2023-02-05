using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoDeResultado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalDeduccion = int.Parse(tex2.Text) + int.Parse(tex3.Text);
            int ventaN = int.Parse(tex2.Text) - totalDeduccion;
            int inv = int.Parse(tex7.Text);
            int comprasTotales= int.Parse(tex8.Text) + int.Parse(tex9.Text);
            int deduccionSCompra = int.Parse(tex11.Text) + int.Parse(tex12.Text);
            int comprasNeta = comprasTotales - deduccionSCompra;
            int disponible = inv + comprasNeta;

            int inventarioFinal = comprasNeta - disponible;
            int costoDeVenta = disponible + inventarioFinal;

            int utilidadBruta = ventaN - costoDeVenta;

            int gastosDeVenta = int.Parse(text21.Text) + int.Parse(tex22.Text) + int.Parse(text23.Text) + int.Parse(tex24.Text) + int.Parse(tex25.Text);

            int gastoAdministrativo = int.Parse(tex28.Text) + int.Parse(tex29.Text) + int.Parse(tex30.Text) + int.Parse(tex31.Text);
            int gastoFinanciero = int.Parse(tex34.Text) + int.Parse(tex35.Text);
            int productoFinanciero = int.Parse(tex38.Text) + int.Parse(tex39.Text);
            int total = gastoAdministrativo + gastoFinanciero + productoFinanciero;

            int totalUtilidadOperativa = utilidadBruta - total;

            int otrosProductos = int.Parse(tex46.Text) + int.Parse(tex47.Text);
            int otrosGasto = int.Parse(tex50.Text) + int.Parse(tex51.Text);
            int totalOtrosGasto = otrosProductos - otrosGasto;
            int utilidadAntesDeImpuesto = totalUtilidadOperativa + totalOtrosGasto;


            int totales = (int)(utilidadAntesDeImpuesto * 0.30);
            int utilidadNeta = utilidadAntesDeImpuesto - totales;
            mostrar.Text = utilidadNeta.ToString();

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tex51_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex50_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex47_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex46_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tex39_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tex38_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex35_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tex34_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tex31_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tex30_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex29_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tex28_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tex22_TextChanged(object sender, EventArgs e)
        {

        }

        private void text23_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex24_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex25_TextChanged(object sender, EventArgs e)
        {

        }

        private void text21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tex16_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex12_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tex9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tex8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Compras_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tex4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tex3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label34_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
