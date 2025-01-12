using CSharpEgitimiKampi601.Entities;
using CSharpEgitimiKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimiKampi601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerOperations customerOperations = new CustomerOperations();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = Convert.ToDecimal(txtCustomerBalance.Text),
                CustomerShoppingCount = Convert.ToInt32(txtCustomerShoppingCount.Text)
            };

            customerOperations.AddCustomer(customer);
            MessageBox.Show("Customer added successfully.");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerOperations.GetAllCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerId = txtCustomerId.Text,
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = Convert.ToDecimal(txtCustomerBalance.Text),
                CustomerShoppingCount = Convert.ToInt32(txtCustomerShoppingCount.Text)
            };
            customerOperations.UpdateCustomer(customer);
            MessageBox.Show("Customer updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);
            MessageBox.Show("Customer deleted successfully.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            var customer = customerOperations.GetCustomerById(customerId);
            dataGridView1.DataSource = new List<Customer> { customer };
        }
    }
}
