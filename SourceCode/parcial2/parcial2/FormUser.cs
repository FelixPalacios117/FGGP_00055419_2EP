using System;
using System.Windows.Forms;

namespace parcial2
{
    public partial class FormUser : Form
    {
        public int idcliente;
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            dataGridAddress.DataSource = AddressCRUD.cargardirecciones(idcliente);
        }

        private void dataGridAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAddress.Text = dataGridAddress.CurrentRow.Cells[1].Value.ToString();
        }
    }
}