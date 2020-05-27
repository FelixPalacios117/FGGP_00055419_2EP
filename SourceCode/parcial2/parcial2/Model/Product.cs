namespace parcial2
{
    public class Product
    {
        public int idProduct{ get; set; }
        public string idBusiness { get; set; }
        public string name { get; set; }

        public Product()
        {
            idProduct = 0;
            idBusiness = "";
            name = "";
        }
    }
}