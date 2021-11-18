using Datos.Entidades;
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

namespace DCPHONE.Forms
{
    public partial class MenuForm : Form
    {
        Producto p = new Producto();
        BDProductos BD = new BDProductos();


        public MenuForm()
        {
            InitializeComponent();
             
                
        }

        //private void BtnAgregar_Click(object sender, EventArgs e)
        //{
        //    AgregarForm Agf = new AgregarForm();
        //    Agf.Show();
        //    this.Hide();
        //    DtgvMostrarProductos.ClearSelection();
        //}

        public void mostrar()
        {
            //List<Producto> listamostrar = new List<Producto>();
            //listamostrar = BD.GetProductos();

            DtgvMostrarProductos.DataSource = BD.GetProductos();

            DtgvMostrarProductos.ClearSelection();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
         
            mostrar();
           DtgvMostrarProductos.ClearSelection();
        }

        //private void BtnEliminar_Click(object sender, EventArgs e)
        //{
         

        //    if (DtgvMostrarProductos.CurrentRow.Selected == false)
        //    {
        //        MessageBox.Show("Seleccione el producto que desea eliminar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        BD.Eliminar(DtgvMostrarProductos.CurrentRow.Index);
        //        mostrar();
        //        MessageBox.Show("Producto Eliminado  " ,"seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        DtgvMostrarProductos.Refresh();
        //        DtgvMostrarProductos.ClearSelection();
        //    }
        //}

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            AgregarForm Agf = new AgregarForm();
            Agf.Show();
            this.Hide();


        }

        private void DtgvMostrarProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if(this.DtgvMostrarProductos.Columns[e.ColumnIndex].Name== " ")
            {

                try
                {
                    if (Convert.ToInt32(e.Value) <= 20)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.BackColor = Color.Orange;

                        if (Convert.ToInt32(e.Value) <= 10)
                        {
                            e.CellStyle.ForeColor = Color.Aqua;
                            e.CellStyle.BackColor = Color.BlueViolet;

                        }


                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("  " + ex);
                }
               
                }
            } // Fin del primer if

        private void btnAgg_Click(object sender, EventArgs e)
        {
            AgregarForm Agf = new AgregarForm();
            Agf.Show();
            this.Hide();
            DtgvMostrarProductos.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DtgvMostrarProductos.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione el producto que desea eliminar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BD.Eliminar(DtgvMostrarProductos.CurrentRow.Index);
                mostrar();
                MessageBox.Show("Producto Eliminado  ", "seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DtgvMostrarProductos.Refresh();
                DtgvMostrarProductos.ClearSelection();
            }
        }
    }


     }

    



     
    



