using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public static class ProductCRUD
    {
        public static List<Product> cargarproductoscmb()
        {
            List <Product> lista= new List<Product>();
            try
            {
                string sql = "select idproduct,name from product";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Product pro=new Product();
                    pro.idProduct = Convert.ToInt32(fila[0].ToString());
                    pro.name= fila[1].ToString(); 
                    lista.Add(pro);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static List<Product> cargarproductos()
        {
            List <Product> lista= new List<Product>();
            try
            {
                string sql = "select pro.idproduct,bu.name,pro.name from product pro, business bu "+
                 "where pro.idbusiness=bu.idbusiness";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Product pro=new Product();
                    pro.idProduct = Convert.ToInt32(fila[0].ToString());
                    pro.name= fila[2].ToString();
                    pro.idBusiness = fila[1].ToString(); 
                    lista.Add(pro);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static void crearproducto(int id,string nombre)
        {
            try
            {
                string sql = String.Format("insert into product(idbusiness,name)"
                                           +"values({0},'{1}')", id, nombre);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Producto registrado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error, Verifica los datos");
            }
        }
        public static void Eliminarproducto(int id)
        {
            try
            {
                string sql = String.Format("delete from product where idproduct='{0}';",
                    id);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Se eliminó el producto y su informacion ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
    }
}