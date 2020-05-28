using System;

namespace parcial2
{
    public class AppOrder
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public string product { get;set; }
        public string address { get; set; }
        public string nombre { get; set; } 

        public AppOrder()
        {
            idOrder = 0;
            nombre = "";
            createDate = DateTime.Now;
            product = "";
            address = ""; 
        }
    }
}