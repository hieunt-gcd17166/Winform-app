using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            Email.Text = ClientsData.Current.EmailI;
            FirName.Text = ClientsData.Current.Firstname + " " + ClientsData.Current.Lastname;
            Age.Text = ClientsData.Current.Aged;
            Country.Text = ClientsData.Current.Countried;
            Phon.Text = ClientsData.Current.Phone;
            Cardn.Text = ClientsData.Current.Visa;
            Amount.Text = (ClientsData.Current.AmountI).ToString() + "$";
            TableIntial();
        }
        public void TableIntial()
        {
            ClientsLogs.GetLogs(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            (new PayMent("Deposit")).ShowDialog();
            string Temp = (ClientsData.Current.AmountI).ToString() + "$";
            if (Temp != Amount.Text)
            {
                dataGridView1.Rows.Add("Deposit To The Account : ", PayMent.Value.ToString() + "$");
                ClientsLogs.AddLog("Deposit To The Account : ", PayMent.Value.ToString() + "$");
                Amount.Text = Temp;
                ClientsData.UpdateAccount();
            }
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            (new PayMent("Withdrawal")).ShowDialog();
            string Temp = (ClientsData.Current.AmountI).ToString() + "$";
            if (Temp != Amount.Text)
            {
                dataGridView1.Rows.Add("Withdrawal From The Account : ", PayMent.Value.ToString() + "$");
                ClientsLogs.AddLog("Withdrawal From The Account : ", PayMent.Value.ToString() + "$");
                Amount.Text = Temp;
                ClientsData.UpdateAccount();
            }
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            (new PaymentService()).ShowDialog();
            string Temp = (ClientsData.Current.AmountI).ToString() + "$";
            if (Temp != Amount.Text)
            {
                dataGridView1.Rows.Add("Payment For " + PayMent.Pay + " : ", PayMent.Value.ToString() + "$");
                ClientsLogs.AddLog("Payment For " + PayMent.Pay + " : ", PayMent.Value.ToString() + "$");
                Amount.Text = Temp;
                ClientsData.UpdateAccount();

            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete Your Account ?!", "Confirmation",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClientsData.DeleteAccount();
                this.Close();
            }
        }
    }
}
