using System;

namespace parcial2
{
    public class AppOrder
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }

        public AppOrder()
        {
            idOrder = 0;
            createDate = DateTime.Now;
            idProduct = 0;
            idAddress = 0;
        }
    }
}