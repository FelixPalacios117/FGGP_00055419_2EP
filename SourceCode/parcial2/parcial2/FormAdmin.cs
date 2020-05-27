using System;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public partial class FormAdmin : Form
    {
        public int id;
        public FormAdmin()
        {
            InitializeComponent();
            id = 0;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataGridUsers.DataSource = AppUserCRUD.cargarusuarios();
            dataGridUsers.Columns[1].Visible = false;
            dataGridUsers.Columns[3].Visible = false;
            dataGridUsers.Columns[4].Width = 60;
            String[] combo={"Administrador","Normal"}; 
            cmbTipo.DataSource = combo;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    dataGridUsers.DataSource = AppUserCRUD.cargarusuarios();
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
                if (MessageBox.Show("Estas seguro que seas eliminar este usuario?","Aviso",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    AppUserCRUD.Eliminarusuario(id);
                    dataGridUsers.DataSource = AppUserCRUD.cargarusuarios();
                } 
                limpiar();
            }
        }
    }
}