namespace parcial2
{
    public class AppUser
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public bool Administrator { get; set; }

        public AppUser()
        {
            idUser = 0;
            fullname = "";
            Username = "";
            password = "";
            Administrator = false;
        }
    }
}