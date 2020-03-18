using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter("data.txt", true))
            { 
                stream.WriteLine($"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text}");
            }
        }
        List<Person> arr_of_persons = new List<Person>();
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            arr_of_persons.Clear();

            using (StreamReader stream = new StreamReader("data.txt"))
            {
                string[] str = new string[4];
                Person some_person = new Person();

                do
                {
                    str = stream.ReadLine().Split(' ');
                    some_person = new Person(str[0], str[1], str[2], str[3]);

                    arr_of_persons.Add(some_person);

                    listBox1.Items.Add($"{some_person.surname},\t {some_person.adress}");

                } while (!stream.EndOfStream);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr_of_persons.Sort((Person x, Person y) =>
            {
                return x.adress.CompareTo(y.adress);
            });

            listBox1.Items.Clear();

            foreach(Person i in arr_of_persons)
            {
                listBox1.Items.Add($"{i.surname},\t {i.adress}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter("data.txt"))
            {
                foreach (Person i in arr_of_persons)
                {
                    stream.WriteLine($"{i.name} {i.surname} {i.adress} {i.phone}");
                }
            }
        }
    }
    class Person
    {
        public string name;
        public string surname;
        public string adress;
        public string phone;

        public Person()
        {
            this.name = "none";
            this.surname = "none";
            this.adress = "none";
            this.phone = "none";
        }
        public Person(string name, string surname, string adress, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.phone = phone;
        }
    }

}
