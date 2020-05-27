using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public class AppUserCRUD
    {
        public static int id_obtenido=0;
        public static bool tipo = false;//false normal,true admin
        public static int iniciarsesion(string usuario, string contraseña)
        {
            DataTable dt = null; 
            try
            {
                string sql = 
                    $"select idUser,userType from appuser where username='{usuario}' and password='{contraseña}'";
                dt = ConnectionDB.ExecuteQuery(sql);
                if (dt != null)
                {
                    foreach (DataRow var in dt.Rows)
                    {
                        id_obtenido = Convert.ToInt32(var[0]);
                        tipo = Convert.ToBoolean(var[1].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error" + e);
            } 
            return id_obtenido;
        }
        public static List<AppUser> cargarusuarios()
        {
            List <AppUser> lista= new List<AppUser>();
            try
            {
                string sql = "select * from appuser";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    AppUser usu=new AppUser();
                    usu.idUser = Convert.ToInt32(fila[0].ToString());
                    usu.Username = fila[2].ToString();
                    usu.fullname = fila[1].ToString();
                    usu.password = fila[3].ToString();
                    usu.Administrator = Convert.ToBoolean(fila[4].ToString()); 
                    lista.Add(usu);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static void crearusuario(string nombre,string usuario,string contra,bool admin)
        {
            try
            {
                string sql = String.Format("insert into appuser(fullname,username,password,userType)"
                                           + "values('{0}','{1}','{2}','{3}')", nombre,usuario, contra, admin);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Usuario creado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
        public static void Eliminarusuario(int id)
        {
            try
            {
                string sql = String.Format("delete from appuser where idUser='{0}';",
                    id);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Se eliminó el usuario y su informacion ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
    }
}