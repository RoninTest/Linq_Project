using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Project
{
    public partial class Form1 : Form
    {
        int[] numbers = { -9, -6, -5, 3, 8, 12, 25 };
        List<string> names = new List<string>();
        public Form1()
        {
            names.Add("Alieren");
            names.Add("Ahmet");
            names.Add("Canan");
            names.Add("Muge");
            names.Add("Fatma");
            names.Add("Ayşe");
            
            InitializeComponent();
        }

        private void btnAllNumbers_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null; //scope clear
            lstView.DataSource = numbers.ToList();
        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            //lambda expression
            //Foreach ile dolaşabileceğimiz gerneric bir ifade inerface***
            IEnumerable<int> picknegatifnumbers = numbers.Where(x => x < 0);

            lstView.DataSource = picknegatifnumbers.ToList();

        }

        private void btnPositiveNumbers_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            IEnumerable<int> positivenumbers = numbers.Where(x => x > 0);
            lstView.DataSource = positivenumbers.ToList();
            
        }

        private void btnEvenNumber_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            IEnumerable<int> evennumbers = numbers.Where(x => x % 2 == 0);
            lstView.DataSource = evennumbers.ToList();

        }

        private void btnOddNumber_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            IEnumerable<int> oddnumbers = numbers.Where(x => x % 2 != 0);
            lstView.DataSource = oddnumbers.ToList();
        }

        private void btnMaxNumber_Click(object sender, EventArgs e)
        {
            int maxnumber = numbers.Max();
            lstView.DataSource = null;
            
            MessageBox.Show("Max Number = " + maxnumber.ToString());
        }

        private void btnMinNumber_Click(object sender, EventArgs e)
        {
            int minnumber = numbers.Min();
            lstView.DataSource = null;
            MessageBox.Show("Min Number = " + minnumber.ToString());
        }

        private void btnHmn_Click(object sender, EventArgs e)
        {
            int HowManyNumber = numbers.Length;
            int HowMnayNumber2 = numbers.Count();
            
            MessageBox.Show("Lenght = "+ HowManyNumber.ToString() + "Count = " + HowMnayNumber2.ToString());
            
        }

        private void btnAlfbatik_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            var alfabetik = from x in names.OrderBy (x=>x)
                            select x;
            lstView.DataSource = alfabetik.ToList();

            //veya şunu kullanabilirsin
            /* lstView.DataSource =names.OrderByDescending(x=>x) .ToList()*/
}

        private void btnLenght_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            lstView.DataSource = names.Select(x => x.Length).ToList();


        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            lstView.DataSource = names.Where(x => x.Contains("A") || x.Contains("a")).ToList();
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            lstView.DataSource = null;
            lstView.DataSource = names.Where(x => x.StartsWith("A") || x.StartsWith("a")).ToList();
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            var see = orders.Select(x => new
            {
                SiparisNo = x.OrderID,
                Tarih=x.OrderDate,
                Musteri=x.Customer.ContactName,

            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = see.ToList();
        }

        private void btnOrderDates_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).
                                       Take(5).Select(x => new
                                       {
                                           x.OrderID,
                                           x.Customer.ContactName,
                                           x.OrderDate
                                       }).ToList(); 
        }

        private void btnFinPerson_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            var filter = orders.Where(x => x.Customer.ContactName == "Yang Wang").ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filter;
        }

        private void btnOrderNumber_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            var orderNumbers = orders.Count();
            dataGridView1.DataSource = null;
            MessageBox.Show(orderNumbers.ToString());
        }
    }
}
