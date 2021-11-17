using Datos.Entidades;
using Datos.Enum;
using Infraestructura.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCPHONE
{
    public partial class AgregarForm : Form
    {
        BDProductos BD = new BDProductos();
        MenuForm MF = new MenuForm();

        public AgregarForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbModelos.Items.AddRange(Enum.GetValues(typeof(Modelos)).Cast<object>().ToArray());
        }



        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id =  BD.GetProductos().Last().Id +1,
                Nombre = txtnombre.Text,
                Descripcion = txtDescripcion.Text,
                Existencia = (int)nudExistencia.Value,
                Precio = nudPrecio.Value,
                FechaIngreso = dtpEntradaInv.Value,
                Modelos = (Modelos)cmbModelos.SelectedIndex
            };

            BD.Insertar(p);

            MessageBox.Show("Se agrego al Inventario Correctamente","Agregado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            MF.Show();
            MF.mostrar();
            this.Hide();
           

        }

        private void BtnGuardarUpdate_Click(object sender, EventArgs e)
        {

        }

        private void AgregarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MF.Show();
           MF.mostrar();
            this.Hide();
        }

        private void gpboxDatosprod_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbModelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }

}
