using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Import
    {
        int id;
        int staff_id;
        Date received_date;
        double total;
        int supplier_id;
        bool deleted;

        public Import()
        {
        }

        public Import(int id, int staff_id, Date received_date, double total, int supplier_id, bool deleted)
        {
            this.id = id;
            this.staff_id = staff_id;
            this.received_date = received_date;
            this.total = total;
            this.supplier_id = supplier_id;
            this.deleted = deleted;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Staff_id
        {
            get { return staff_id;}
            set { staff_id = value; }
        }

        public Date Received_date
        {
            get { return received_date;}
            set { received_date = value; }
        }

        public double Total
        {
            get { return total;}
            set { total = value; }
        }

        public int Supplier_id
        {
            get { return supplier_id;}
            set { supplier_id = value; }
        }

        public bool Deleted
        {
            get { return deleted;}
            set { deleted = value; }
        }

        public override string ToString()
        {
            return id + " | " +
                staff_id + " | " +
                received_date + " | " +
                total + " | " +
                supplier_id;
        }
    }
}
