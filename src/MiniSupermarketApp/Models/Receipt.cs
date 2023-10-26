using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Receipt
    {
        int id;
        int staff_id;
        int customer_id;
        Date invoice_date;
        double total;
        double received;
        double excess;
        bool deleted;

        public Receipt()
        {
        }

        public Receipt(int id, int staff_id, int customer_id, Date invoice_date, double total, double received, double excess, bool deleted)
        {
            this.id = id;
            this.staff_id = staff_id;
            this.customer_id = customer_id;
            this.invoice_date = invoice_date;
            this.total = total;
            this.received = received;
            this.excess = excess;
            this.deleted = deleted;
        }

        public int Id
        {
            get { return id; } 
            set {  id = value; }
        }

        public int Staff_id
        {
            get { return staff_id;}
            set { staff_id = value; }
        }

        public int Customer_id
        {
            get { return customer_id;}
            set { customer_id = value; }
        }

        public Date Invoice_date
        {
            get { return invoice_date;}
            set { invoice_date = value; }
        }

        public double Total
        {
            get { return total;}
            set { total = value; }
        }

        public double Received
        {
            get { return received;}
            set { received = value; }
        }

        public double Excess
        {
            get { return excess;}
            set { excess = value; }
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
                customer_id + " | " +
                invoice_date + " | " +
                total + " | " +
                received + " | " +
                excess;
        }
    }
}
