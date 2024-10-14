using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.View;
using Supermarket_mvp.Models;
using Supermarker_mvp.Models;
using System.Security.AccessControl;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetcustomerListBildingSource(customerBindingSource);

            LoadAllCustomerList();

            this.view.Show();


        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            // se crea un objeto de la clase CustomerModel y se asignano los datos de las cajas de texto de la vista.

            var customer = new CustomerModel();
            customer.Id = Convert.ToInt32(view.customer_Id);
            customer.Document_Number = Convert.ToInt32(view.customer_Document_Number);
            customer.First_Name = view.customer_First_Name;
            customer.Last_Name = view.customer_Last_Name;
            customer.Address = view.customer_Address;
            customer.Birthday = view.customer_Birthday;
            customer.Phone_Number = Convert.ToInt32(view.customer_Phone_Number);
            customer.Email = view.customer_Email;


            try
            {
                new Common.ModelDataValidation().Validate(customer);
                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer edited successfully";

                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added successfully";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                // si ocurre una excepción se configura IsSuccesfull en false y a la propiedad Message de la vista se asigna el mensaje de la excepción

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.customer_Id = "0";
            view.customer_Document_Number = "";
            view.customer_First_Name = "";
            view.customer_Last_Name = "";
            view.customer_Address = "";
            view.customer_Birthday = "";
            view.customer_Phone_Number = "";
            view.customer_Email = "";
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto del datagridview que se encuentra seleccionado
            var customer = (CustomerModel)customerBindingSource.Current;

            // Se cambia el contenido de las cajas de texto por el objeto recuperado
            // del datagridview
            view.customer_Id = customer.Id.ToString();
            view.customer_Document_Number = customer.Document_Number.ToString();
            view.customer_First_Name = customer.First_Name;
            view.customer_Last_Name = customer.Last_Name;
            view.customer_Address = customer.Address;
            view.customer_Birthday = customer.Birthday;
            view.customer_Phone_Number = customer.Phone_Number.ToString();
            view.customer_Email = customer.Email;


            // Se establece el modo como edición
            view.IsEdit = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }
    }
}
