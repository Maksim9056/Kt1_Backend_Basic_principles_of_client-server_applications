namespace Kt1_Backend_Basic_principles_of_client_server_applications.Model
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(long id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
        public User() { }

    }
}
