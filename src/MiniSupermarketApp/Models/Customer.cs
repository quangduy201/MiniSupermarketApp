using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Customer
    {
        int id;
        string name;
        bool gender;
        Date birthday;
        string phone;
        bool membership;
        Date signed_up_date;
        int point;
        bool deleted;

        public Customer()
        {
        }

        public Customer(int id, string name, bool gender, Date birthday, string phone, bool membership, Date signed_up_date, int point, bool deleted)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
            this.phone = phone;
            this.membership = membership;
            this.signed_up_date = signed_up_date;
            this.point = point;
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

        public bool Membership
        {
            get { return membership; }
            set { membership = value; }
        }

        public Date Signed_up_date
        {
            get { return signed_up_date; }
            set { signed_up_date = value;}
        }

        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public override string ToString()
        {
            string gender1 = gender ? "Nam" : "Nữ";
            string membership1 = membership ? "Có" : "Không";
            return id + " | " +
                name + " | " +
                gender1 + " | " +
                birthday + " | " +
                phone + " | " +
                membership1 + " | " +
                signed_up_date + " | " +
                point;
        }
    }
}
