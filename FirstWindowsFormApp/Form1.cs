using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormApp
{
    public partial class Form1 : Form
    {
        
        List<string> teams = new List<string>() { "Tom", "Jerry", "Bob", "Teena", "Lina", "Piku", "Dave" };
       
        public Form1()
        {
            InitializeComponent();
            foreach (var item in teams)
                listBox1.Items.Add(item);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count!=0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
            }
       
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                int index = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(index);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);                
            }
            
            listBox1.Items.Clear();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }

            listBox2.Items.Clear();
        }
    }
}
