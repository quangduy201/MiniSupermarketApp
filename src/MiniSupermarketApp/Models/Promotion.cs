﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarketApp.Models
{
    class Promotion
    {
        int id;
        Date start_date;
        Date end_date;
        bool status;
        bool deleted;

        public Promotion()
        {
        }

        public Promotion(int id, Date start_date, Date end_date, bool status, bool deleted)
        {
            this.id = id;
            this.start_date = start_date;
            this.end_date = end_date;
            this.status = status;
            this.deleted = deleted;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Date Start_date
        {
            get { return start_date; }
            set { start_date = value; }
        }

        public Date End_date
        {
            get { return end_date; }
            set { end_date = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

        public override string ToString()
        {
            string status1 = status ? "Ngưng áp dụng" : "Đang áp dụng";
            return id + " | " +
                start_date + " | " +
                end_date + " | " +
                status1;
        }
    }
}
