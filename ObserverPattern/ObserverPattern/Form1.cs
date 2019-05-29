using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form1 : Form
    {
        public Counter counter;
        public Form1()
        {
            counter = new Counter();
            InitializeComponent();
            FormText formtext = new FormText();
            formtext.Show();
            counter.RegisterObserver(formtext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter.Decrement();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter.Increment();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            counter.Decrement();
        }
    }
}
