using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex re = new Regex(@"([a-zA-Z]|\d|\.)+@[a-zA-Z]+\.[a-z]+");
                if (re.IsMatch(textBox1.Text))
                {
                    label1.Text = "It's a valid email!";
                }
                else
                {
                    label1.Text = "This not a valid email";
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string first = textBox2.Text.ToLower();
            string second = textBox3.Text.ToLower();
            first = Regex.Replace(first, @"\s+", "");
            second = Regex.Replace(second, @"\s+", "");
            first = String.Concat(first.OrderBy(c => c));
            second = String.Concat(second.OrderBy(c => c));
            if (Equals(first, second))
            {
                label2.Text = "They are a proper anagram";
            }
            else
            {
                label2.Text = "These two are not anagrams";
            }
        }
    }
}
