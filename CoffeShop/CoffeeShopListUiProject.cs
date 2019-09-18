using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeeShopListUiProject : Form
    {
        int price = 0, index = 0;
        List<String> cuntomerNames = new List<string>();
        List<string> contactNumbers = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> queintites = new List<int>();
        List<int> totalPice = new List<int>();

        public CoffeeShopListUiProject()
        {
            InitializeComponent();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "";
            for (int j = 0; j < cuntomerNames.Count(); j++)
            {

                resultRichTextBox.Text += "Name : " + cuntomerNames[j] + "\nContact No : " + contactNumbers[j] + "\nAddress : " + addresses[j] + "\nOrder : " + orders[j] + "\nTotal Price : " + totalPice[j] + "\n\n";


            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "";

            cusNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string customerName = cusNameTextBox.Text;
            string contactNumber = contactTextBox.Text;
            string address = addressTextBox.Text;
            string orderItem = orderComboBox.Text;
            string queintity = quantityTextBox.Text;

            if (customerName == "" || contactNumber == "" || address == "" || orderItem == "" || queintity == "")

            {
                MessageBox.Show("Please: fill up all info failed !");
                return;
            }
            else if (Convert.ToInt32(quantityTextBox.Text) == 0)
            {
                MessageBox.Show("Select Item");
                return;
            }
            else if (orderItem == "Select an item")
            {
                MessageBox.Show("Please, Select an item");
                return;
            }
            for (int i = 0; i < contactNumbers.Count(); i++)
            {
                if (contactNumber == contactNumbers[i])
                {
                    MessageBox.Show("Contact no. already exist");
                    return;
                }

            }

           
                if (orderItem == "Black")
                {
                    price = 120;
                }
                else if (orderItem == "Cold")
                {
                    price = 100;
                }
                else if (orderItem == "Hot")
                {
                    price = 90;
                }
                else
                {
                    price = 80;
                }

            int totalPrice = price * Convert.ToInt32(queintity);


            cuntomerNames.Add(customerName);
            contactNumbers.Add(contactNumber);
            addresses.Add(address);
            orders.Add(orderItem);
            queintites.Add(Convert.ToInt32(queintity));
            totalPice.Add(totalPrice);

            resultRichTextBox.Text = "";
            for (int j = index; j <= index; j++)
            {
                resultRichTextBox.Text = "Name : " + cuntomerNames[j] +
                                                 "\nContact No : " + contactNumbers[j] +
                                                 "\nAddress : " + addresses[j] +
                                                 "\nOrder : " + orders[j] +
                                                 "\nQuantity : " + queintites[j] +
                                                 "\nTotal Price : " + totalPice[j] + "\n\n";
            }
            index++;
        }
        
        
    }
}
