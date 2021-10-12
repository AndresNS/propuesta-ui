using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace propuesta_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rbBuscarProducto.Checked = true;

            deshabilitarCampos();
            this.btnEliminar.Enabled = false;
            this.btnGuardar.Enabled = false;
        }
        private void rbBuscarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarProducto.Checked)
            {
                deshabilitarCampos();
                limpiarCampos();
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.txtBuscar.Text = String.Empty;
                this.txtBuscar.Enabled = true;
                this.btnBuscar.Enabled = true;
            }
            else
            {
                limpiarCampos();
                habilitarCampos();
                this.txtID.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnGuardar.Text = "Crear Nuevo Producto";
                this.txtBuscar.Text = String.Empty;
                this.txtBuscar.Enabled = false;
                this.btnBuscar.Enabled = false;

            }
        }

        private void limpiarCampos()
        {
            this.txtID.Text = String.Empty;
            this.txtCampo1.Text = String.Empty;
            this.txtCampo2.Text = String.Empty;
            this.txtCampo3.Text = String.Empty;
        }

        private void deshabilitarCampos()
        {
            this.txtID.Enabled = false;
            this.txtCampo1.Enabled = false;
            this.txtCampo2.Enabled = false;
            this.txtCampo3.Enabled = false;
        }

        private void habilitarCampos()
        {
            this.txtID.Enabled = true;
            this.txtCampo1.Enabled = true;
            this.txtCampo2.Enabled = true;
            this.txtCampo3.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            this.txtID.Enabled = false;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = true;

            // Ir a buscar producto a la base de datos
            this.txtID.Text = this.txtBuscar.Text;
            this.txtCampo1.Text = "Datos del producto";
            this.txtCampo2.Text = "Más datos del producto";
            this.txtCampo3.Text = "Otros datos del producto";

            this.txtBuscar.Text = String.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deshabilitarCampos();
            limpiarCampos();

            if (this.btnGuardar.Text == "Guardar Cambios")
            {
                // Actualizacion de producto

                // Guardar nuevos datos en la base de datos

                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                MessageBox.Show("Producto Actualizado");
            }
            else
            {
                // Creacion de producto nuevo

                // Crear producto en la base de datos

                this.rbBuscarProducto.Checked = true;
                MessageBox.Show("Producto Creado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Aqui probablemente sea bueno mostrar un dialogo para 
            // confirmar si es que esta seguro de eliminar

            // Eliminar producto de la base de datos

            deshabilitarCampos();
            limpiarCampos();
            this.btnEliminar.Enabled = false;
            this.btnGuardar.Enabled = false;
            MessageBox.Show("Producto Eliminado");
        }
    }
}
