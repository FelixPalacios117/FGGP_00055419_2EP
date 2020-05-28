using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class FormUser : Form
    {
        public int idcliente,id_direccion,id_orden;
        public FormUser()
        {
            InitializeComponent();
            id_direccion =id_orden= 0;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            cargar();
            dataGridAddress.Columns[1].Visible = false;
            cargarcmb(); 
        }

        void cargar()
        {
            dataGridAddress.DataSource = AddressCRUD.cargardirecciones(idcliente);
            dataGridOrders.DataSource = AppOrderCRUD.cargarordenesespecificas(idcliente);
        }

        void cargarcmb()
        {
            cmbDireccion.DataSource = AddressCRUD.cargardirecciones(idcliente);
            cmbDireccion.ValueMember = "idAddress";
            cmbDireccion.DisplayMember = "address";
            cmbProducto.DataSource = ProductCRUD.cargarproductoscmb();
            cmbProducto.DisplayMember = "name";
            cmbProducto.ValueMember = "idProduct";
        }
        void limpiar()
        {
            txtAddress.Clear();
            id_orden = 0;
            id_direccion = 0;
            txtNueva.Clear();
            txtRepetir.Clear();
            txtActual.Clear();
        }

        private void dataGridAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAddress.Text = dataGridAddress.CurrentRow.Cells[2].Value.ToString();
                id_direccion = Convert.ToInt32(dataGridAddress.CurrentRow.Cells[0].Value.ToString()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay datos");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("No puedes dejar campos vacios");
            }
            else
            { 
                AddressCRUD.creardireccion(txtAddress.Text,idcliente);
                cargar();
                cargarcmb();
                limpiar(); 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id_direccion== 0)
            {
                MessageBox.Show("Selecciona una direccion a eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar esta direccion?","Aviso",
                    MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    AddressCRUD.Eliminardireccion(id_direccion,idcliente);
                    cargar();
                    cargarcmb();
                } 
                limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("No dejes campos vacios");
            }
            else
            {
                if (id_direccion == 0)
                {
                    MessageBox.Show("Selecciona una direccion que desees modificar");
                }
                else
                {
                    AddressCRUD.modificardireccion(txtAddress.Text,id_direccion);
                    cargar();
                    limpiar();
                    cargarcmb();
                }
            }
        } 

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (id_orden == 0)
            {
                MessageBox.Show("Selecciona una orden a eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar esta orden?","Aviso",
                    MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    AppOrderCRUD.eliminarOrden(id_orden);
                    cargar();
                    cargarcmb();
                    limpiar();
                }  
            }
        }

        private void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                id_orden= Convert.ToInt32(dataGridOrders.CurrentRow.Cells[0].Value.ToString()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay datos");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            DateTime fecha=DateTime.Now;
            int producto = Convert.ToInt32(cmbProducto.SelectedValue.ToString());
            int direccion = Convert.ToInt32(cmbDireccion.SelectedValue.ToString());
            AppOrderCRUD.crearorden(fecha,producto,direccion);
            cargar();
            cargarcmb(); 
            limpiar();
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Sesion cerrada con exito");
            FormLogin nuevo=new FormLogin();
            nuevo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRepetir.Text.Trim().Equals("") || txtNueva.Text.Trim().Equals("") ||
                txtActual.Text.Trim().Equals(""))
            {
                MessageBox.Show("No puedes dejar campos vacios");
            }
            else
            {
                if (txtRepetir.Text.Equals(txtNueva.Text))
                {
                    if (!AppUserCRUD.compararcontraseña(txtActual.Text,idcliente))
                    {
                        MessageBox.Show("Contraseña actual incorrecta");
                    }
                    else
                    {
                        if (txtRepetir.Text.Equals(txtActual.Text))
                        {
                            MessageBox.Show("La contraseña actual y la antigua deben ser diferentes");
                        }
                        else
                        {
                            AppUserCRUD.modificarpassword(txtNueva.Text,idcliente);
                            limpiar();   
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña nueva debe ser igual en ambos campos");
                }   
            }
        }
    }
}