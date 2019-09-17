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
    public partial class CoffeeShopListUi : Form
    {
        public CoffeeShopListUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string order = orderComboBox.Text;
            int productQuantity = Convert.ToInt32(quantityTextBox.Text);
            int ProAmount = 0;

            if (orderComboBox.Text == "Black-120")
            {
                ProAmount = 120;
            }
            else if (orderComboBox.Text == "Cold-100")
            {
                ProAmount = 100;
            }
            else if (orderComboBox.Text == "Hot-90")
            {
                ProAmount = 90;
            }
            else if (orderComboBox.Text == "Reguler-80")
            {
                ProAmount = 80;
            }

            int totalPrice = ProAmount * productQuantity;

            const int num = 1;
            List<string> name = new List<string> { };
            for (int i = 0; i < num; i++)

            {
                name.Add(CusNameTextBox.Text);
                name.Add(Convert.ToString(contactTextBox.Text));
                name.Add(addressTextBox.Text);
                name.Add(Convert.ToString(orderComboBox.SelectedItem));
                name.Add(Convert.ToString(quantityTextBox.Text));
                name.Add(Convert.ToString(totalPrice));

                resultRichTextBox.Text += "\n Customer Name: " + name + "\n" +
               "Contact Number: " + name + "\n" +
               "Address: " + name + "\n " +
               "Order Amount:" + name + "\n" +
               "Quantity Value: " + name + "\n" +
               "Total Price: " + name + "\n \n";
            }
        }
    }
}
