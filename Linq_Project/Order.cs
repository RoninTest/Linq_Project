using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<Order> GetOrders()
        {
            List<Order> liste = new List<Order>();
            string query = @"Select O.CustomerID,O.EmployeeID,O.OrderID,O.OrderDate,
                           (Select ContactName From Customers
                           where CustomerID = O.CustomerID) as ContactName
                           From Orders O";

            DataTable dt = GetDataTable(query);
            foreach (DataRow item in dt.Rows)
            {
                Order o = new Order();
                o.OrderID = (int)item["OrderID"];
                o.CustomerID =(string) item["CustomerID"];
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderDate = (DateTime) item["OrderDate"];
                o.Customer = new Customer();
                o.Customer.ContactName = (string) item["ContactName"];
                o.Customer.CustomerID = (string) item["CustomerID"];
                liste.Add(o);

            }
            return liste;
        }

        private DataTable GetDataTable(string query)
        {
            string connectionString = @"Data Source=RONIN;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount // Get Total Order
        {
            get { return Orders.Count; }
        }
    }
}
