using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListProject
{
    public partial class MainForm : Form
    {
        private SinglyLinkedList linkedList;

        public MainForm()
        {
            InitializeComponent();
            linkedList = new SinglyLinkedList();
        }


        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            linkedList.AddNodeToTheList(Convert.ToInt32(textBox1.Text));
        }

        private void buttonDisplayElement_Click(object sender, EventArgs e)
        {
            var result = linkedList.GetMth(Convert.ToInt32(textBox2.Text));

            textBox3.Text = result.ToString();

        }
    }
}
