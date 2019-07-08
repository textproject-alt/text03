using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Famliy:System.Collections.IEnumerable
        {
            string[] MyFamliy = { "父亲", "母亲", "弟弟", "妹妹" };
            public System.Collections.IEnumerator GetEnumerator()
            {
                for (int i = 0; i < MyFamliy.Length;i++ )
                {
                    yield return MyFamliy[i];
                }
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Famliy famliy = new Famliy();
            foreach(string str in famliy)
            {
                richTextBox1.Text += str + "\n";
            
            }
        }
    }
}
