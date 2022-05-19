using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GithubActionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Sum(1, 2));
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
