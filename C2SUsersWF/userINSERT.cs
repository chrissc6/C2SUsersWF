using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpToSql;

namespace C2SUsersWF
{
    public partial class userINSERT : Form
    {
        public userINSERT()
        {
            InitializeComponent();
        }

        private void textBox1UN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1PW_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1FN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1LN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1PN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1Em_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1Rcb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1Acb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1SUBMIT_Click(object sender, EventArgs e)
        {
            string data = "";

            textBox1UN.Text += data.ToString();

            var user = new User();
            user.Email
        }
    }
}
