using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testC
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                // выводим результат  
                MessageBox.Show(controller.Question(textBox.Text));
        }

    }
}