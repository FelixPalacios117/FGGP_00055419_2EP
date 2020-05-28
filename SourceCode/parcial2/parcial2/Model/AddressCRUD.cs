using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public static class AddressCRUD
    {
        public static List<Address> cargardirecciones(int id)
        {
            List <Address> lista= new List<Address>();
            try
            {
                string sql =$"select idAddress,address from address where idUser={id}";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Address direccion=new Address();
                    direccion.idAddress = Convert.ToInt32(fila[0].ToString());
                    direccion.address= fila[1].ToString(); 
                    lista.Add(direccion);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static void creardireccion(string nombre,int id)
        {
            try
            {
                string sql = String.Format("insert into address(idUser,address)"
                                           +"values('{0}','{1}')",id, nombre);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Direccion registrada correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error, Verifica los datos"+e);
            }
        }
        public static void Eliminardireccion(int id,int iduser)
        {
            try
            {
                string sql = String.Format("delete from address where idaddress={0} and idUser={1};",
                    id,iduser);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Se elimino la direccion correctamente ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
        public static void modificardireccion(string usuario,int id)
        {
            try
            {
                string sql = String.Format(
                    "update address set address='{0}' where idaddress='{1}';",
                    usuario,id);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Datos modificados correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
    }
}