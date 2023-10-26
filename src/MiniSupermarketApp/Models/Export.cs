using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Export
    {
        int id;
        int staff_id;
        Date invoice_date;
        double total;
        string reason;
        bool deleted;

        public Export()
        {
        }

        public Export(int id, int staff_id, Date invoice_date, double total, string reason, bool deleted)
        {
            this.id = id;
            this.staff_id = staff_id;
            this.invoice_date = invoice_date;
            this.total = total;
            this.reason = reason;
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

        public Date Invoice_date
        {
            get { return invoice_date;}
            set { invoice_date = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
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
                invoice_date + " | " +
                total + " | " +
                reason;
        }
    }
}
