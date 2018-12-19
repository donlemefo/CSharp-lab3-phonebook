using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> people = new List<Person>();

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = textBox1.Text;
            person.Email = textBox2.Text;
            person.PhoneNumber = textBox3.Text;
            person.Birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            person.Additional = textBox4.Text;
            people.Add(person);
            listBox1.Items.Add(person.FirstName);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = people[listBox1.SelectedIndex].FirstName; 
            textBox2.Text = people[listBox1.SelectedIndex].Email;
            textBox3.Text = people[listBox1.SelectedIndex].PhoneNumber;
            textBox4.Text = people[listBox1.SelectedIndex].Additional;
            dateTimePicker1.Value = DateTime.Parse(people[listBox1.SelectedIndex].Birthday);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            people[listBox1.SelectedIndex].FirstName = textBox1.Text;
            people[listBox1.SelectedIndex].Email = textBox2.Text; 
            people[listBox1.SelectedIndex].PhoneNumber = textBox3.Text; 
            people[listBox1.SelectedIndex].Additional = textBox4.Text; ;
            people[listBox1.SelectedIndex].Birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            people.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Additional { get; set; }
    }
}
