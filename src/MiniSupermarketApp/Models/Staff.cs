using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Staff
    {
        int id;
        string name;
        bool gender;
        Date birthday;
        string phone;
        string address;
        string email;
        Date entry_date;
        bool deleted;

        public Staff()
        {
        }

        public Staff(int id, string name, bool gender, Date birthday, string phone, string address, string email, Date entry_date, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.entry_date = entry_date;
            this.deleted = deleted;
        }

        public int Id
        {
            get { return id; } 
            set {  id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Date Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Date Entry_date
        {
            get { return entry_date; }
            set { entry_date = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        public override string ToString()
        {
            string gender1 = gender ? "Nam" : "Nữ";
            return id + " | " +
                name + " | " +
                gender1 + " | " +
                birthday + " | " +
                phone + " | " +
                address + " | " +
                email + " | " +
                entry_date;
        }
    }
}
