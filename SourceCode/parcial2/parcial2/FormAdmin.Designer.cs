using System.ComponentModel;

namespace parcial2
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridNegocio = new System.Windows.Forms.DataGridView();
            this.btnEliminarNeg = new System.Windows.Forms.Button();
            this.btnCrearNeg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContranuevarepetida = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContranueva = new System.Windows.Forms.TextBox();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridNegocio)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridProducto)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridOrders)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbTipo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnCrear);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.dataGridUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(892, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(574, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 41);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo de usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(552, 408);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(313, 36);
            this.cmbTipo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(583, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre completo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtName.Location = new System.Drawing.Point(546, 294);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 38);
            this.txtName.TabIndex = 18;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.Location = new System.Drawing.Point(544, 584);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(321, 48);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrear.Location = new System.Drawing.Point(545, 492);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(321, 48);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(635, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPassword.Location = new System.Drawing.Point(546, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(322, 38);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUser.Location = new System.Drawing.Point(545, 72);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(322, 38);
            this.txtUser.TabIndex = 12;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeColumns = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(16, 20);
            this.dataGridUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(503, 612);
            this.dataGridUsers.TabIndex = 0;
            this.dataGridUsers.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage2.Controls.Add(this.dataGridNegocio);
            this.tabPage2.Controls.Add(this.btnEliminarNeg);
            this.tabPage2.Controls.Add(this.btnCrearNeg);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(892, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Negocios";
            // 
            // dataGridNegocio
            // 
            this.dataGridNegocio.AllowUserToAddRows = false;
            this.dataGridNegocio.AllowUserToDeleteRows = false;
            this.dataGridNegocio.AllowUserToResizeColumns = false;
            this.dataGridNegocio.AllowUserToResizeRows = false;
            this.dataGridNegocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNegocio.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNegocio.Location = new System.Drawing.Point(16, 12);
            this.dataGridNegocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNegocio.Name = "dataGridNegocio";
            this.dataGridNegocio.ReadOnly = true;
            this.dataGridNegocio.RowTemplate.Height = 24;
            this.dataGridNegocio.Size = new System.Drawing.Size(503, 612);
            this.dataGridNegocio.TabIndex = 32;
            this.dataGridNegocio.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNegocio_CellClick);
            // 
            // btnEliminarNeg
            // 
            this.btnEliminarNeg.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarNeg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarNeg.Location = new System.Drawing.Point(539, 578);
            this.btnEliminarNeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarNeg.Name = "btnEliminarNeg";
            this.btnEliminarNeg.Size = new System.Drawing.Size(321, 48);
            this.btnEliminarNeg.TabIndex = 27;
            this.btnEliminarNeg.Text = "Eliminar";
            this.btnEliminarNeg.UseVisualStyleBackColor = false;
            this.btnEliminarNeg.Click += new System.EventHandler(this.btnEliminarNeg_Click);
            // 
            // btnCrearNeg
            // 
            this.btnCrearNeg.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearNeg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearNeg.Location = new System.Drawing.Point(539, 481);
            this.btnCrearNeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearNeg.Name = "btnCrearNeg";
            this.btnCrearNeg.Size = new System.Drawing.Size(321, 48);
            this.btnCrearNeg.TabIndex = 26;
            this.btnCrearNeg.Text = "Crear";
            this.btnCrearNeg.UseVisualStyleBackColor = false;
            this.btnCrearNeg.Click += new System.EventHandler(this.btnCrearNeg_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(637, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 41);
            this.label7.TabIndex = 25;
            this.label7.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(657, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 41);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDescripcion.Location = new System.Drawing.Point(539, 214);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(322, 195);
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNombre.Location = new System.Drawing.Point(541, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(322, 38);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbNegocios);
            this.tabPage3.Controls.Add(this.btnDeleteProduct);
            this.tabPage3.Controls.Add(this.btnAddProduct);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtNameProduct);
            this.tabPage3.Controls.Add(this.dataGridProducto);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 651);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(582, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 41);
            this.label5.TabIndex = 43;
            this.label5.Text = "Negocio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNegocios
            // 
            this.cmbNegocios.FormattingEnabled = true;
            this.cmbNegocios.Location = new System.Drawing.Point(558, 200);
            this.cmbNegocios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNegocios.Name = "cmbNegocios";
            this.cmbNegocios.Size = new System.Drawing.Size(313, 36);
            this.cmbNegocios.TabIndex = 42;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(550, 580);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(321, 48);
            this.btnDeleteProduct.TabIndex = 39;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddProduct.Location = new System.Drawing.Point(551, 488);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(321, 48);
            this.btnAddProduct.TabIndex = 38;
            this.btnAddProduct.Text = "Crear";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(667, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 41);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nombre";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNameProduct.Location = new System.Drawing.Point(551, 68);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(322, 38);
            this.txtNameProduct.TabIndex = 34;
            this.txtNameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AllowUserToAddRows = false;
            this.dataGridProducto.AllowUserToDeleteRows = false;
            this.dataGridProducto.AllowUserToResizeColumns = false;
            this.dataGridProducto.AllowUserToResizeRows = false;
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Location = new System.Drawing.Point(17, 16);
            this.dataGridProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.ReadOnly = true;
            this.dataGridProducto.RowTemplate.Height = 24;
            this.dataGridProducto.Size = new System.Drawing.Size(503, 612);
            this.dataGridProducto.TabIndex = 33;
            this.dataGridProducto.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducto_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage4.Controls.Add(this.dataGridOrders);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(892, 651);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ordenes";
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToDeleteRows = false;
            this.dataGridOrders.AllowUserToResizeColumns = false;
            this.dataGridOrders.AllowUserToResizeRows = false;
            this.dataGridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(25, 19);
            this.dataGridOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.ReadOnly = true;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(846, 612);
            this.dataGridOrders.TabIndex = 34;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txtContranuevarepetida);
            this.tabPage5.Controls.Add(this.btnCambiar);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.txtContranueva);
            this.tabPage5.Controls.Add(this.txtContraActual);
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(892, 651);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Cambiar contraseña";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(290, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(314, 41);
            this.label9.TabIndex = 28;
            this.label9.Text = "Repetir contraseña";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContranuevarepetida
            // 
            this.txtContranuevarepetida.Font = new System.Drawing.Font("Segoe UI", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtContranuevarepetida.Location = new System.Drawing.Point(284, 421);
            this.txtContranuevarepetida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContranuevarepetida.Multiline = true;
            this.txtContranuevarepetida.Name = "txtContranuevarepetida";
            this.txtContranuevarepetida.PasswordChar = '*';
            this.txtContranuevarepetida.Size = new System.Drawing.Size(322, 38);
            this.txtContranuevarepetida.TabIndex = 27;
            this.txtContranuevarepetida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCambiar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCambiar.Location = new System.Drawing.Point(285, 538);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(321, 48);
            this.btnCambiar.TabIndex = 26;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(290, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(315, 41);
            this.label11.TabIndex = 25;
            this.label11.Text = "Contraseña nueva";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(285, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 41);
            this.label12.TabIndex = 24;
            this.label12.Text = "Contraseña actual";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContranueva
            // 
            this.txtContranueva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtContranueva.Location = new System.Drawing.Point(284, 265);
            this.txtContranueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContranueva.Multiline = true;
            this.txtContranueva.Name = "txtContranueva";
            this.txtContranueva.PasswordChar = '*';
            this.txtContranueva.Size = new System.Drawing.Size(322, 38);
            this.txtContranueva.TabIndex = 23;
            this.txtContranueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContraActual
            // 
            this.txtContraActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtContraActual.Location = new System.Drawing.Point(285, 118);
            this.txtContraActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraActual.Multiline = true;
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.PasswordChar = '*';
            this.txtContraActual.Size = new System.Drawing.Size(322, 38);
            this.txtContraActual.TabIndex = 22;
            this.txtContraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage6.Location = new System.Drawing.Point(4, 37);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(892, 651);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Estadisticas";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(905, 694);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridNegocio)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridProducto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridOrders)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCrearNeg;
        private System.Windows.Forms.Button btnEliminarNeg;
        private System.Windows.Forms.DataGridView dataGridNegocio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNegocios;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtContranuevarepetida;
        private System.Windows.Forms.TextBox txtContranueva;
        private System.Windows.Forms.TextBox txtContraActual;
    }
}