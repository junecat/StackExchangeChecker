using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackExchangeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pn.TitleText = $"titleText at {DateTime.Now.ToLongTimeString()}";
            pn.ContentText = $"В штатовской версии из фильма вырезаны многие сцены насилия, секса и обнаженки. К сожалению. Будем искать полную версию {DateTime.Now.ToLongTimeString()}";
            pn.Delay = 3600000;
            pn.Popup();
        }
    }
}
