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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1WF1INSERT_Click(object sender, EventArgs e)
        {
            userINSERT ui = new userINSERT();
            ui.ShowDialog();
        }

        private void button1WF1UPDATE_Click(object sender, EventArgs e)
        {

        }

        private void button1WF1DELETE_Click(object sender, EventArgs e)
        {

        }

        private void button1WF1QUERY_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var user = User.GetUserByPrimaryKey(1);
            
        }
    }
}
