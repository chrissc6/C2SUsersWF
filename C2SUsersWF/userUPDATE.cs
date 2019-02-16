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
    public partial class userUPDATE : Form
    {
        public userUPDATE()
        {
            InitializeComponent();
        }

        User upuser = new User();
        public string dataUPK = "";
        public string dataUN;
        public string data2PW;
        public string data3FN;
        public string data4LN;
        public string data5PN;
        public string data6EM;
        public bool data7;
        public bool data8;
        //public string datacheck;



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

        private void checkBox1Rcb_CheckedChanged(object sender, EventArgs e)
        {
            if (data7 == true)
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
            if (dataUPK == "")
            {
                label10TEST.Text = "Update operation error: *blank User ID*";
                label12.Text = "^ This field cannot be left blank*";
                return;
            }
            
            int id = Int32.Parse(dataUPK);
            User userpk = User.GetUserByPrimaryKey(id);
            label12.Text = dataUPK.ToString();

            if(dataUN != null)
            {
                userpk.Username = dataUN;
            }
            if(data2PW != null)
            {
                userpk.Password = data2PW;
            }
            if (data3FN != null)
            {
                userpk.Firstname = data3FN;
            }
            if (data4LN != null)
            {
                userpk.Lastname = data4LN;
            }
            if (data5PN != null)
            {
                userpk.Phone = data5PN;
            }
            if (data6EM != null)
            {
                userpk.Email = data6EM;
            }
            if(data7 != userpk.IsReviewer)
            {
                userpk.IsReviewer = data7;
            }
            if(data8 != userpk.IsAdmin)
            {
                userpk.IsAdmin = data8;
            }

            var updateSuccess = User.UpdateUser(userpk);
            if (updateSuccess)
                label10TEST.Text = "Update successful";
            else
            {
                label10TEST.Text = "Update failed";
            }



            //string[] userinfo = { dataUN, data2PW, data3FN, data4LN, data5PN, data6EM };
            //string[] updateinfo = { userpk.Username, userpk.Password, userpk.Firstname, userpk.Lastname, userpk.Phone, userpk.Email };
            //string strpk = updateinfo[0];
            //bool[] userinfo2 = { data7, data8 };
            //List<string> checks = new List<string>() { userpk.Username, userpk.Password, userpk.Firstname, userpk.Lastname, userpk.Phone, userpk.Email };

            //foreach (var i in userinfo)
            //{
            //    int ele = Array.FindIndex(userinfo, idx => idx == i);
            //    int z = ele;
            //    strpk = updateinfo[z];
            //    //string result = Checker(i, strpk);
            //    if (i != null)
            //    {
            //        //strpk = i;
            //        updateinfo[z] = strpk;
            //        strpk = strpk.Replace(strpk, i);
            //        updateinfo[z] = strpk;
            //        //updateinfo[z] = updateinfo[z].Replace(strpk, i);
            //        //checks.RemoveAt(z);
            //        //checks.Insert(z, i);
            //        //checks.Add(strpk);
            //    }
            //    else
            //    {
            //        continue;
            //    }

            //}
            //userpk.Username = userpk.Username;


            ////string newdata = userpk.ToString();
            //var updateSuccess = User.UpdateUser(userpk);
            //if (updateSuccess)
            //    label10TEST.Text = "Update successful";
            //else
            //{
            //    label10TEST.Text = "Update failed";
            //}





            ////string resultc = string.Join("", updateinfo.ToArray());
            ////label10TEST.Text = resultc.ToString();
        }

        private void textBox1USERid_TextChanged(object sender, EventArgs e)
        {
            dataUPK = textBox1USERid.Text;
        }

        private string Checker(string col, string val)
        {

            if (col != null)
            {
                val = col;
                //upuser.Username = dataUN;
                //upuser.Password = data2PW;
                //upuser.Firstname = data3FN;
                //upuser.Lastname = data4LN;
                //upuser.Phone = data5PN;
                //upuser.Email = data6EM;
                //upuser.IsReviewer = data7;
                //upuser.IsAdmin = data8;

                return val;
            }
            else
            {
                return null;
            }




        }
    }
}
