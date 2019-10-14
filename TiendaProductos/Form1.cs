using System;
using System.Collections.Generic;
using System.Drawing;
using Armas;
using System.Windows.Forms;

namespace TiendaProductos
{
    public partial class Form1 : Form
    {
        private Arma arma;
        private List<Arma> armas;
        private float costo;
        public Form1()
        {
            InitializeComponent();
            armas = new List<Arma>();
            arma = new Arma("Shuriken", 25, 10, "Juguete para niños y no tan niños");
            arma = new Arma("Uzi", 100, 5, "Réplica de plástico con estilo realista");
            arma = new Arma("Kunai Lazer", 50, 5, "Se ilumina en la obscuridad");
        }

        private void BtnComprarArmaBlanca_Click(object sender, EventArgs e)
        {
            
            armas.Add(arma);
            lstbProductosSelect.Items.Add(armas[0].Nombre);
            lbArmaBlanca.Text = armas[0].Descripcion;
            lbArmaBlanca.Visible = true;
            costo += armas[0].Precio;
            armas[0].Stock -= 1;
            lbCosto.Text = "$"+costo.ToString();
        }
    }
}
