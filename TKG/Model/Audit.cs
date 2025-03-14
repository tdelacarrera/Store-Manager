using System;

namespace TKG
{
    internal class Audit
    {
        private int id;
        private String action;
        public Audit(int id, String action)
        {
            this.id = id;
            this.action = action;
        }
        public int Id { get => id; set => id = value; }
        public String Action { get => action; set => action = value; }
    }

}