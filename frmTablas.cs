﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLuna_NEPTUNO
{
    public partial class frmTablas : Form
    {
        public frmTablas()
        {
            InitializeComponent();
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            clsBaseDeDatos.MostrarTablas(cmbTablas, cadenaConexion, dgvTablas);
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();
            cadenaConexion = clsBaseDeDatos.ListarTablas(cmbTablas, dgvTablas, txtBaseDatos);
            if (cadenaConexion != "")
            {
                lblBaseDatos.Enabled = true;
                lblTabla.Enabled = true;
                cmbTablas.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }
    }
}
