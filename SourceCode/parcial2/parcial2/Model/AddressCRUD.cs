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
        public static void crearnegocio(string nombre,string descripcion)
        {
            try
            {
                string sql = String.Format("insert into business(name,description)"
                                           +"values('{0}','{1}')", nombre, descripcion);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Negocio creado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error, Verifica los datos");
            }
        }
        public static void Eliminarnegocio(int id)
        {
            try
            {
                string sql = String.Format("delete from business where idbusiness='{0}';",
                    id);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Se eliminó el negocio y su informacion ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
    }
}