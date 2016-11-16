using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficaialDocument_2
{
    public partial class Save : Form
    {
        Search _callerForm;
        public Save(Search callingForm)
        {
            InitializeComponent();
            _callerForm = callingForm;
            _callerForm.Enabled = false;
        }

        private void Save_FormClosed(object sender, FormClosedEventArgs e)
        {
            _callerForm.Enabled = true;
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _callerForm.Enabled = true;
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            waiting w = new waiting();
            try
            {

                w.Show(this);
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = @"INSERT INTO acceptdocudemt (DocNo,No_,AcceptDate,From_,To_,Subject_,DocNo_rtn,RecieveDate,Recipient,RecordDate,note) 
VALUES (@DocNo,@No,@AcceptDate,@From,@To,@Subject,@DocNo_rtn,@RecieveDate,@Recipient,@RecordDate,@note)";
                comm.Parameters.AddWithValue("@DocNo", tbDocNo.Text);
                comm.Parameters.AddWithValue("@No", tbNo.Text);
                comm.Parameters.AddWithValue("@AcceptDate", datePick.Value.ToString("dd MMM yy", new CultureInfo("th-TH")));
                comm.Parameters.AddWithValue("@From", cbbFrom.Text);
                comm.Parameters.AddWithValue("@To", cbbTo.Text);
                comm.Parameters.AddWithValue("@Subject", tbSubject.Text);
                comm.Parameters.AddWithValue("@DocNo_rtn", tbDocNo_rtn.Text);
                comm.Parameters.AddWithValue("@RecieveDate", datePickRecieve.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us")));
                comm.Parameters.AddWithValue("@Recipient", cbbRecipient.Text);
                comm.Parameters.AddWithValue("@RecordDate", datePickRecordDate.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us")));
                comm.Parameters.AddWithValue("@note", tbNote.Text);
                comm.ExecuteNonQuery();
                w.Hide();
                MessageBox.Show("บันทึกสำเร็จ...");

            }
            catch
            {

                w.Hide();
            }

            conn.Close();
            init();
        }

        private void Save_Load(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            cbbFrom.Text = "";
            cbbTo.Text = "";
            tbNo.Text = "";
            tbSubject.Text = "";
            string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Max(DocNo) +1  AS DocNo FROM AcceptDocudemt ad";
                MySqlDataReader rd = cmd.ExecuteReader();
                tbDocNo.Text = "";
                if (rd.Read())
                {
                    tbDocNo.Text = rd["DocNo"].ToString();
                }
                rd.Close();
            }
            catch
            {


            }

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT ad.From_ FROM AcceptDocudemt ad";
                MySqlDataReader rd = cmd.ExecuteReader();
                cbbFrom.Items.Clear();
                while (rd.Read())
                {
                    cbbFrom.Items.Add(rd["From_"].ToString());
                }
                rd.Close();
            }
            catch
            {


            }

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT ad.To_ FROM AcceptDocudemt ad";
                MySqlDataReader rd = cmd.ExecuteReader();
                cbbTo.Items.Clear();
                while (rd.Read())
                {
                    cbbTo.Items.Add(rd["To_"].ToString());
                }
                rd.Close();
            }
            catch
            {


            }

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT ad.Recipient FROM AcceptDocudemt ad";

                MySqlDataReader rd = cmd.ExecuteReader();
                cbbRecipient.Items.Clear();
                while (rd.Read())
                {
                    cbbRecipient.Items.Add(rd["Recipient"].ToString());
                }
                rd.Close();
            }
            catch
            {

                con.Close();
            }
            con.Close();
        }

        private void tbDocNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        

        private string LeaveOnlyNumbers(String inString)
        {
            String tmp = inString;
            foreach (char c in inString.ToCharArray())
            {
                if (!IsDigit(c))
                {
                    tmp = tmp.Replace(c.ToString(), "");
                }
            }
            return tmp;
        }

        public bool IsDigit(char c)
        {
            return (c >= '0' && c <= '9');
        }

        private void tbDocNo_TextChanged(object sender, EventArgs e)
        {
            tbDocNo.Text = LeaveOnlyNumbers(tbDocNo.Text);
        }

        private void tbDocNo_rtn_TextChanged(object sender, EventArgs e)
        {
            tbDocNo_rtn.Text = LeaveOnlyNumbers(tbDocNo_rtn.Text);
        }

        private void tbDocNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
