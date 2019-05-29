using ObserverPattern.Observer;
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
    public partial class FormText : Form, IObserver
    {
        public FormText()
        {
            InitializeComponent();
        }

        void IObserver.Update(int Count)
        {
            SetText(Count);
        }

        private void SetText(int count)
        {
            lblText.Text = count.ToString();
        }
    }
}
