﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmMantenimientoDePeliculas : Form
    {
        controlador cn = new controlador();

        public frmMantenimientoDePeliculas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            var frmEA = new frmEdiciónCartelera();
            frmEA.Show();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string nom = txtNom.Text;
            string clas= cmbClasi.Text;
            string gen = cmbGenero.Text;
            string sub = cmbSub.Text;
            string idio = txtIdioma.Text;
            string preci = txtPrecio.Text;
            string sinop = txtSinopsis.Text;

            /*MessageBox.Show("Param: nom:"+nom+
                "\nclas:"+clas+
                "\ngen:" + gen +
                "\nsub:" + sub +
                "\nidio:" + idio +
                "\npreci:" + preci +
                "\nsinop:"+sinop
                );*/

            if (cn.ingresoPeliculas(nom, clas, gen, sub, idio, preci, sinop))
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Error de ingreso");
            }

            txtNom.Text = "";
            cmbClasi.Text = "";
            cmbGenero.Text = "";
            cmbSub.Text = "";
            txtIdioma.Text = "";
            txtPrecio.Text = "";
            txtSinopsis.Text = "";
        

        }

        private void frmMantenimientoDePeliculas_Load(object sender, EventArgs e) //bloqueo de comboBox
        {
            cmbClasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSub.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var frmC = new frmConsultaPeliculas();
            frmC.Show();
            this.Hide();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            var frmModif = new frmModificacionPeliculas();
            frmModif.Show();
            this.Hide();
        }
    }
}
