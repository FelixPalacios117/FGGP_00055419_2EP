using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Equals("") || txtUser.Text.Trim().Equals(""))
            {
                MessageBox.Show("No puedes dejar campos vacios");
            }
            else
            {
                if (AppUserCRUD.iniciarsesion(txtUser.Text, txtPassword.Text) != 0)
                {
                    switch (AppUserCRUD.tipo)
                    {
                        case true:
                            MessageBox.Show("Bienvenido administrador :"+txtUser.Text);
                            FormAdmin admin=new FormAdmin();
                            admin.Show();
                            this.Hide();
                            break;
                        case false:
                            MessageBox.Show("Bienvenido usuario : "+txtUser.Text);
                            FormUser usuarionormal=new FormUser();
                            usuarionormal.idcliente = AppUserCRUD.id_obtenido;
                            usuarionormal.Show();
                            this.Hide();
                            break;
                    } 
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }   
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}