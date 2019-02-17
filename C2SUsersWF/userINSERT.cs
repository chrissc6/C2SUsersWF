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
        User newuser = new User();
        string dataUN = "";
        string data2PW = "";
        string data3FN = "";
        string data4LN = "";
        string data5PN = "";
        string data6EM = "";
        bool data7 = false;
        bool data8 = false;

        private void textBox1UN_TextChanged(object sender, EventArgs e)
        {
            dataUN = textBox1UN.Text;
        }

        private void textBox1PW_TextChanged(object sender, EventArgs e)
        {
            data2PW = $"{textBox1PW.Text}";
        }

        private void textBox1FN_TextChanged(object sender, EventArgs e)
        {
            data3FN = $"{textBox1FN.Text}";
        }

        private void textBox1LN_TextChanged(object sender, EventArgs e)
        {
            data4LN = $"{textBox1LN.Text}";
        }

        private void textBox1PN_TextChanged(object sender, EventArgs e)
        {
            data5PN = $"{textBox1PN.Text}";
        }

        private void textBox1Em_TextChanged(object sender, EventArgs e)
        {
            data6EM = $"{textBox1Em.Text}";
        }

        private void checkBox1Rcb_CheckedChanged_1(object sender, EventArgs e)
        {
            if(data7 == true)
            {
                data7 = false;
            }
            else
            {
                data7 = true;
            }
            
        }

        private void checkBox1Acb_CheckedChanged(object sender, EventArgs e)
        {
            if (data8 == true)
            {
                data8 = false;
            }
            else
            {
                data8 = true;
            }

        }

        private void button1SUBMIT_Click(object sender, EventArgs e)
        {
            //var user = new User(0, "xxxgdidsjh6", "sd", "userhx", "usesrx", "5135551234", "info@user.com", true, true);
            //string newdata = dataUN + data2PW + data3FN + data4LN + data5PN + data6EM + data7 + data8;

            if(dataUN == "" || data2PW == "")
            {
                label10TEST.Text = "Insert operation error: *blank fields*";
                label10WARun.Text = "< This field cannot be left blank*";
                label10.Text = "< This field cannot be left blank*";
                return;
            }

            newuser.Username = dataUN;
            newuser.Password = data2PW;
            newuser.Firstname = data3FN;
            newuser.Lastname = data4LN;
            newuser.Phone = data5PN;
            newuser.Email = data6EM;
            newuser.IsReviewer = data7;
            newuser.IsAdmin = data8;
            string newdata = newuser.ToString();
            var user = new User(0, dataUN, data2PW, data3FN, data4LN, data5PN, data6EM, data7, data8);
            var returnCode = User.InsertUser(user);
            if (returnCode)
            {
                label10TEST.Text = "Insert successful";
                label10WARun.Text = "";
                label10.Text = "";
            }
            else
            {
                label10TEST.Text = "Insert failed: *Username not unique, or Connection failed*";
                label10WARun.Text = "< Username already in use*";
            }



            //label10TEST.Text = newdata;
            //this.Close();
            //var user = new User();
            //user.Email
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
