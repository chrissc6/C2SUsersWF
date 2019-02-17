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
    public partial class userDELETE : Form
    {
        public userDELETE()
        {
            InitializeComponent();
        }

        public string dataUPK = "";

        private void textBox1USERid_TextChanged_1(object sender, EventArgs e)
        {
            dataUPK = textBox1USERid.Text;
        }

        private void button1SUBMIT_Click(object sender, EventArgs e)
        {
            if (dataUPK == "")
            {
                label10TEST.Text = "Delete operation error: *blank User ID*";
                label12.Text = "^ This field cannot be left blank*";
                return;
            }



            int Id = Int32.Parse(dataUPK);

            User userpk = User.GetUserByPrimaryKey(Id);

            label10TEST.Text = "Delete operation pending...";
            label12.Text = $"{Id}";

            if (userpk != null)
            {
                string un = userpk.Username;
                if (un == null)
                {
                    label10UN.Text = "NULL";
                }
                else
                {
                    label10UN.Text = un.ToString();
                }

                string pw = userpk.Password;
                if (pw == null)
                {
                    label13PW.Text = "NULL";
                }
                else
                {
                    label13PW.Text = pw.ToString();
                }

                string fn = userpk.Firstname;
                if (fn == null)
                {
                    label14FN.Text = "NULL";
                }
                else
                {
                    label14FN.Text = fn.ToString();
                }

                string ln = userpk.Lastname;
                if (ln == null)
                {
                    label15LN.Text = "NULL";
                }
                else
                {
                    label15LN.Text = ln.ToString();
                }

                string pn = userpk.Phone;
                if (pn == null)
                {
                    label16PN.Text = "NULL";
                }
                else
                {
                    label16PN.Text = pn.ToString();
                }

                string em = userpk.Email;
                if (em == null)
                {
                    label17EM.Text = "NULL";
                }
                else
                {
                    label17EM.Text = em.ToString();
                }

                bool rev = userpk.IsReviewer;
                if (!rev)
                {
                    label18Rcb.Text = "No";
                }
                else
                {
                    label18Rcb.Text = "Yes";
                }

                bool adm = userpk.IsAdmin;
                if (!adm)
                {
                    label19Acb.Text = "No";
                }
                else
                {
                    label19Acb.Text = "Yes";
                }

                var confirm = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var deleteSuccess = User.DeleteUser(Id);
                    if (!deleteSuccess)
                    {
                        label10TEST.Text = "Delete operation failed";
                    }
                    else
                    {
                        label10TEST.Text = "Delete operation successful";
                    }

                }
                else
                {
                    label10TEST.Text = "Delete operation cancelled";
                }
            }
            else
            {
                label10TEST.Text = "Delete failed: *No user by that id, or Connection failed*";
                return;
            }

            
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
