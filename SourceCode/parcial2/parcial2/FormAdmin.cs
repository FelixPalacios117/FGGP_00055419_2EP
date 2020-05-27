using System;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public partial class FormAdmin : Form
    {
        public int id,id_negocio,id_producto;
        public FormAdmin()
        {
            InitializeComponent();
            id = id_negocio =id_producto= 0;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            cargardatos();
            dataGridUsers.Columns[1].Visible = false;
            dataGridUsers.Columns[3].Visible = false;
            dataGridUsers.Columns[4].Width = 60; 
            String[] combo={"Administrador","Normal"}; 
            cmbTipo.DataSource = combo;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNegocios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNegocios.ValueMember = "idBusiness";
            cmbNegocios.DisplayMember="name"; 
        }

        void cargardatos()
        {
            dataGridUsers.DataSource = AppUserCRUD.cargarusuarios();   
            dataGridNegocio.DataSource = BusinessCRUD.cargarnegocios();
            cmbNegocios.DataSource = BusinessCRUD.cargarnegocioscombobox();
            dataGridProducto.DataSource = ProductCRUD.cargarproductos();
        }
        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridUsers.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
            txtUser.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text= dataGridUsers.CurrentRow.Cells[3].Value.ToString(); 
            bool tipo = Convert.ToBoolean(dataGridUsers.CurrentRow.Cells[4].Value.ToString());
            if (tipo)
            {
                cmbTipo.SelectedIndex = 0;
            }
            else
            {
                cmbTipo.SelectedIndex = 1;
            } 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool tipo = false;
            if (txtName.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals("") || txtUser.Text.Trim().Equals("")){
                MessageBox.Show("No puedes dejar campos vacios "); 
            }
            else {
                if (txtUser.Text.Equals(txtPassword.Text))
                {
                    if (cmbTipo.SelectedIndex== 0)
                    {
                        tipo = true;
                    }
                    AppUserCRUD.crearusuario(txtName.Text, txtUser.Text,txtPassword.Text ,tipo);
                    cargardatos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("El usuario y la contraseña deben ser iguales");
                }
            }
        }

        void limpiar()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtUser.Clear();
            id_negocio = 0;
            txtDescripcion.Clear();
            txtNombre.Clear();
            id = 0;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecciona un usuario a eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar este usuario?","Aviso",
                    MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    AppUserCRUD.Eliminarusuario(id);
                   cargardatos();
                } 
                limpiar();
            }
        }

        private void dataGridNegocio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = dataGridNegocio.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = dataGridNegocio.CurrentRow.Cells[1].Value.ToString();
            id_negocio = Convert.ToInt32(dataGridNegocio.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnCrearNeg_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Equals("") || txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("No puedes dejar campos vacios");
            }
            else
            {
                String descripcion = txtDescripcion.Text;
                BusinessCRUD.crearnegocio(txtNombre.Text, descripcion);
                cargardatos();
                limpiar(); 
            }
        }

        private void btnEliminarNeg_Click(object sender, EventArgs e)
        {
            if (id_negocio == 0)
            {
                MessageBox.Show("Selecciona un negocio a eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar este negocio?","Aviso",
                    MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    BusinessCRUD.Eliminarnegocio(id_negocio);
                    cargardatos();
                } 
                limpiar();
            }
        }

        private void dataGridProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_producto = Convert.ToInt32(dataGridProducto.CurrentRow.Cells[0].Value.ToString());
            cmbNegocios.SelectedItem = dataGridProducto.CurrentRow.Cells[1].Value.ToString();
            txtNameProduct.Text = dataGridProducto.CurrentRow.Cells[2].Value.ToString();
        } 

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtNameProduct.Text.Trim().Equals(""))
            {
                MessageBox.Show("No puedes dejar campos vacios");
            }
            else
            {
                int idn = Convert.ToInt32(cmbNegocios.SelectedValue.ToString());
                MessageBox.Show(idn.ToString());
                ProductCRUD.crearproducto(idn,txtNameProduct.Text);
                cargardatos();
                limpiar(); 
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (id_producto == 0)
            {
                MessageBox.Show("Selecciona un producto a eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar este producto?","Aviso",
                    MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    ProductCRUD.Eliminarproducto(id_producto);
                    cargardatos();
                } 
                limpiar();
            }
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Sesion cerrada con exito");
            FormLogin nuevo=new FormLogin();
            nuevo.Show();
            this.Hide();
        }
    }
}