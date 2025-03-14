using System;

namespace TKG
{
    internal class User
    {
        private int id;
        private String name;
        private String email;
        private String rut;
        private String username;
        private String password;
        public static String current_user_username;
        public static int current_user_id;
        public static int current_user_type;
        private int state;
        private int user_type_id;

        public User(int id, string name, string email, String rut, string username, string password, int state, int user_type_id)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.rut = rut;
            this.username = username;
            this.password = password;
            this.state = state;
            this.user_type_id = user_type_id;
        }
        public int Id { get => id; set => id = value; }
        public String Name { get => name; set => name = value; }
        public String Email { get => email; set => email = value; }
        public String Rut { get => rut; set => rut = value; }
        public String Username { get => username; set => username = value; }
        public String Password { get => password; set => password = value; }
        public int State { get => state; set => state = value; }
        public int User_type_id { get => user_type_id; set => user_type_id = value; }
    }
}
