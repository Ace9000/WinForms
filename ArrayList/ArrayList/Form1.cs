using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList namelist = new System.Collections.ArrayList() {123, 223.2, true, "Ace" };

            namelist.Add ("Aceee");
            namelist.Add(998);
            namelist.Add("AceeAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(namelist.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList() { 123, 223.2, true, "Ace" };

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(namelist.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList() { 123, 223.2, true, "Ace" };

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            Int32 r;
            Int32.TryParse(listBox1.Text, out r);
            Text = namelist[r].ToString();

            //listBox1.Items.Clear();
            //listBox1.Items.AddRange(namelist.ToArray());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList() { 123, 223.2, true, "Ace" };

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            //namelist[0] = "gggggg";
            //return;

            Int32 r;
            Int32.TryParse(listBox1.Text, out r);
            namelist[r] = "Test";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };*/

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            Int32 r;
            Int32.TryParse(listBox1.Text, out r);

            namelist.RemoveAt(r);
        }

        private void btnGetSize_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };*/

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            Text = namelist.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };*/

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            Int32 c;
            c = namelist.Count;
            Text = c.ToString();

            listBox1.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                listBox1.Items.Add(namelist[i].ToString());

                //namelist[i] = "Item" + i.ToString();
            }
           
            for (int i = 0; i < c; i++)
            {
                string dt;

               dt =  namelist[i].GetType().ToString();
               listBox1.Items.Add(dt);

                if (namelist[i].GetType() == typeof(ArrayList.Form1))
                {
                    listBox1.Items.Add("I have found the form");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };*/

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            listBox1.Items.Clear();
            foreach (Object item in namelist) // Get array list item
            {
                listBox1.Items.Add(item.ToString());

                //    string dt;

                //    dt = item.GetType().ToString();
                //    listBox1.Items.Add(dt);

                //    if (item.GetType() == typeof(ArrayList.Form1))
                //    {
                //        listBox1.Items.Add("I have found the form");
                //    }
            }

            foreach (Object item in namelist) //get array list type
            {
                
                string dt;

                dt = item.GetType().ToString();
                listBox1.Items.Add(dt);

                if (item.GetType() == typeof(string))
                {
                    listBox1.Items.Add("I have found the form");
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add("AAAceee");
            namelist.Add(9978);
            namelist.Add("eAceee");

            string[] nn = { "Acee", "Ana" };
            namelist.Add(nn);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(namelist.ToArray());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add(558);
            namelist.Add(9978);
            namelist.Add(47);
            namelist.Add(74);
            namelist.Add(85);
            namelist.Add(22);

            //int[] nn = { 45, 89 };
            //namelist.Add(nn);
            namelist.Sort();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(namelist.ToArray());
        }
        private void button10_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add(558);
            namelist.Add(9978);
            namelist.Add(47);
            namelist.Add(74);
            namelist.Add(85);
            namelist.Add(22);

            //int[] nn = { 45, 89 };
            //namelist.Add(nn);
            namelist.Reverse();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(namelist.ToArray());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add("Ace");
            namelist.Add("Maj");
            namelist.Add("Juni");
            namelist.Add("Maj");
            namelist.Add("Dekemvri");
            namelist.Add("Oktomvri");

            string[] target_namelist = new string[namelist.Count];
            namelist.CopyTo(target_namelist);
            
        }
        private void button13_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add("Ace");
            namelist.Add("Maj");
            namelist.Add("Juni");
            namelist.Add("Maj");
            namelist.Add("Dekemvri");
            namelist.Add("Oktomvri");

            namelist.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add("Ace");
            namelist.Add("Maj");
            namelist.Add("Juni");
            namelist.Add("Maj");
            namelist.Add("Dekemvri");
            namelist.Add("Oktomvri");

            namelist.Insert(3, "Test");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var namelist = new System.Collections.ArrayList(); //{ 123, 223.2, true, "Ace" };

            namelist.Add("Ace");
            namelist.Add("Maj");
            namelist.Add("Juni");
            namelist.Add("Maj");
            namelist.Add("Dekemvri");
            namelist.Add("Oktomvri");

            Boolean r;
            r = namelist.Contains(txtSearch.Text);

            if(r == true)
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
