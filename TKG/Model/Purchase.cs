namespace TKG
{
    internal class Purchase
    {
        private int id;
        private int number;
        private int user_id_user;
        private int user_type;
        public Purchase(int id, int number, int user_id_user, int user_type)
        {
            this.id = id;
            this.number = number;
            this.user_id_user = user_id_user;
            this.user_type = user_type;
        }
        public int Id { get => id; set => id = value; }
        public int Number { get => number; set => number = value; }
        public int User_id_user { get => user_id_user; set => user_id_user = value; }
      
        public int User_type { get => user_type; set => user_type = value; }
    }
}
