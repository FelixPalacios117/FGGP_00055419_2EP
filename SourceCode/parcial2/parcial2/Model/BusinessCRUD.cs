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
        public static List<Business> getGrafico()
        {
            List<Business> lista = new List<Business>();
            try
            {
                string sql = String.Format("SELECT b.name AS Negocio, sum(cp.cant) AS Total_pedidos "+
                "FROM BUSINESS b, (SELECT p.idBusiness, p.name, count(ap.idProduct) AS cant FROM PRODUCT p, APPORDER ap "+
                "WHERE p.idProduct = ap.idProduct GROUP BY p.idProduct ORDER BY p.name ASC) AS cp WHERE b.idBusiness = cp.idBusiness"+
                " GROUP BY b.idBusiness;");
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Business f = new Business();
                    f.name = fila[0].ToString();
                    f.idBusiness= Convert.ToInt32(fila[1].ToString());  
                    lista.Add(f);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo errores" + e);
            }
            return lista;
        }
        public static void Eliminarnegocio(int id)
        {
            try
            {
                string sql = String.Format("delete from business where idbusiness={0};",
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