using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.View
{
    internal interface ICustomerView
    {
        string customer_Id { get; set; }
        string customer_Document_Number { get; set; }
        string customer_First_Name { get; set; }
        string customer_Last_Name { get; set; }
        string customer_Address { get; set; }
        string customer_Birthday { get; set; }
        string customer_Phone_Number { get; set; }
        string customer_Email { get; set; }

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

        void SetcustomerListBildingSource(BindingSource customerList);
        void Show();
    }
}
