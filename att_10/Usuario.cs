namespace att_10
{
    public class Usuario
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
        public Usuario(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }
    }
}