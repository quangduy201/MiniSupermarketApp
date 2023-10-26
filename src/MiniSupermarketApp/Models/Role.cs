using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Role
    {
        int id;
        string name;
        bool deleted;

        public Role()
        {
        }

        public Role(int id, string name, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.deleted = deleted;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public override string ToString()
        {
            return id + " | " +
                name;
        }
    }
}
