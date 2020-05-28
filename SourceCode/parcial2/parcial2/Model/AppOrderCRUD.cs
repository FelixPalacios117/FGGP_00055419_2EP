using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace parcial2
{
    public static class AppOrderCRUD
    {
        public static List<AppOrder> cargarordenesespecificas(int id)
        {
            List <AppOrder> lista= new List<AppOrder>();
            try
            {
                string sql ="SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address"+
                " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au"+ 
                " WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser"+
                $" AND au.idUser ={id} ;";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    AppOrder ordenes=new AppOrder();
                    ordenes.idOrder= Convert.ToInt32(fila[0].ToString());
                    ordenes.createDate= Convert.ToDateTime(fila[1].ToString());
                    ordenes.product= fila[2].ToString();
                    ordenes.nombre = fila[3].ToString();
                    ordenes.address = fila[4].ToString(); 
                    lista.Add(ordenes);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static List<AppOrder> cargarordenes()
        {
            List <AppOrder> lista= new List<AppOrder>();
            try
            {
                string sql ="SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address"+
                " FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct"+
                " AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser;";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    AppOrder ordenes=new AppOrder();
                    ordenes.idOrder= Convert.ToInt32(fila[0].ToString());
                    ordenes.createDate= Convert.ToDateTime(fila[1].ToString());
                    ordenes.product= fila[2].ToString();
                    ordenes.nombre = fila[3].ToString();
                    ordenes.address = fila[4].ToString(); 
                    lista.Add(ordenes);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        public static void eliminarOrden(int id)
        {
            try
            {
                string sql = String.Format("delete from apporder where idorder={0};",
                    id);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Se elimino la orden correctamente ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
        public static void crearorden(DateTime fecha,int idproducto,int iddireccion)
        {
            try
            {
                string sql = String.Format("insert into apporder(createdate,idproduct,idaddress)"
                                           +"values('{0}',{1},{2})",fecha,idproducto, iddireccion);
                ConnectionDB.Executenonquery(sql);
                MessageBox.Show("Pedido registrado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error, Verifica los datos"+e);
            }
        }
    }
}