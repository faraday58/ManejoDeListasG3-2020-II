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
        private byte indice;
        public Form1()
        {
            InitializeComponent();
            armas = new List<Arma>();
            
        }

        private void BtnComprarArmaBlanca_Click(object sender, EventArgs e)
        {
            eligeCompra(sender);
            
        }

        private void eligeCompra(object sender)
        {
            Button botonPress =(Button)sender;

            if (botonPress == btnComprarArmaBlanca)
            {
                armas.Add(new Arma("Shuriken", 25, 10, "Juguete para niños y no tan niños"));
                lstbProductosSelect.Items.Add(armas[indice].Nombre);
                lbArmaBlanca.Text = armas[indice].Descripcion;
                lbArmaBlanca.Visible = true;
                costo += armas[indice].Precio;
                armas[indice].Stock -= 1;
                lbCosto.Text = "$" + costo.ToString();
                indice++;

            }else if(botonPress == btnComprarArmaFuego)
            {
                armas.Add(new Arma("Uzi", 100, 5, "Réplica de plástico con estilo realista"));
                lstbProductosSelect.Items.Add(armas[indice].Nombre);
                lbArmaFuego.Text = armas[indice].Descripcion;
                lbArmaFuego.Visible = true;
                costo += armas[indice].Precio;
                armas[indice].Stock -= 1;
                lbCosto.Text = "$" + costo.ToString();
                indice++;

            }else if(botonPress == btnArmaLazer)
            {
                armas.Add(new Arma("Kunai Lazer", 50, 5, "Se ilumina en la obscuridad"));
                lstbProductosSelect.Items.Add(armas[indice].Nombre);
                lbArmaLazer.Text = armas[indice].Descripcion;
                lbArmaLazer.Visible = true;
                costo += armas[indice].Precio;
                armas[indice].Stock -= 1;
                lbCosto.Text = "$" + costo.ToString();
                indice++;


            }


        }



    }
}
