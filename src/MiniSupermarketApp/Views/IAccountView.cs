using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarketApp.Views
{
    public interface IAccountView
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        int StaffID { get; set; }
        int RoleID { get; set; }
        DateTime Last_signed_in { get; set; }
        Boolean Deleted { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPetListBindingSource(BindingSource petList);
        void Show();
    }
}
