using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public static class BusinessCRUD
    {
        public static List<Business> cargarnegocios()
        {
            List <Business> lista= new List<Business>();
            try
            {
                string sql = "select * from business";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Business negocio=new Business();
                    negocio.idBusiness = Convert.ToInt32(fila[0].ToString());
                    negocio.name = fila[1].ToString();
                    negocio.description = fila[2].ToString(); 
                    lista.Add(negocio);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static List<Business> cargarnegocioscombobox()
        {
            List <Business> lista= new List<Business>();
            try
            {
                string sql = "select idbusiness,name from business";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Business negocio=new Business();
                    negocio.idBusiness = Convert.ToInt32(fila[0].ToString());
                    negocio.name = fila[1].ToString(); 
                    lista.Add(negocio);
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