using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery_App___Firebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("4.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("4.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("4.00");
                    listView1.Items.Add(item);

                }

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sausage Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("13.00");
                    listView1.Items.Add(item);

                }
            }


            //Pizza Topping Selection

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Extra Cheese Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Mushroom Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ham Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bacon Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ground Beef Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Jalapeno Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pineapple Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Dried Shrimps Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Anchovies Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Sun Dried Tomatoes Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Spinach Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }


            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Roasted Garlic Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Shredded Chicken Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.75");
                listView1.Items.Add(item);

            }

            //Drink Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke - Can");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke - Can");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea - Can");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ginger Ale - Can");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite - Can");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Root Beer - Can");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 1.45;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Bottled Water");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 1.25;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }

            //Other Items Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Wings");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);

            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Poutine");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);

            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);

            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);

            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }


            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("BBQ Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream Dip");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }


            double total = 0;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            hst = total * 0.13;
            totaldue = hst + total;
            string hstDisplay = hst.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");

            textBox8.Text = amount;
            textBox9.Text = hstDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage4");
            textBox22.Text = textBox12.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
