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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        Search _callerForm;
        public string id;
        public Edit(Search callingForm, string _id)
        {
            id = _id;
            InitializeComponent();
             _callerForm = callingForm;
            _callerForm.Enabled = false;
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            _callerForm.Enabled = true;
            this.Close();
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
                comm.CommandText = @"UPDATE acceptdocudemt set DocNo =@DocNo,No_=@No,AcceptDate=@AcceptDate,From_=@From,To_=@To,Subject_=@Subject,
DocNo_rtn=@DocNo_rtn,RecieveDate=@RecieveDate,Recipient=@Recipient,RecordDate=@RecordDate,note=@note where id = '"+id+"'";

                comm.Parameters.AddWithValue("@DocNo", tbDocNo.Text);
                comm.Parameters.AddWithValue("@No", tbNo.Text);
                comm.Parameters.AddWithValue("@AcceptDate", datePick.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us")));
                comm.Parameters.AddWithValue("@From", cbbFrom.Text);
                comm.Parameters.AddWithValue("@To", cbbTo.Text);
                comm.Parameters.AddWithValue("@Subject", tbSubject.Text);
                comm.Parameters.AddWithValue("@DocNo_rtn", tbDocNo_rtn.Text);
                comm.Parameters.AddWithValue("@RecieveDate", datePickRecieve.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us")));
                comm.Parameters.AddWithValue("@Recipient", cbbRecipient.Text);
                comm.Parameters.AddWithValue("@RecordDate", datePickRecordDate.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us")));
                comm.Parameters.AddWithValue("@note", tbNote.Text);
                comm.ExecuteNonQuery();
                w.Close();
                MessageBox.Show("บันทึกสำเร็จ...");

            }
            catch
            {
                w.Close();
                conn.Close();
            }
             
            conn.Close();
            _callerForm.Enabled = true;
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _callerForm.Enabled = true;
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
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
                con.Close();

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
                con.Close();

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

            
            
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM AcceptDocudemt ad where ad.id='"+id+"'";
                using (MySqlDataReader drd = cmd.ExecuteReader())
                {
                    if (drd.Read())
                    {
                        tbDocNo.Text = drd["DocNo"].ToString();
                        tbNo.Text = drd["No_"].ToString();
                        datePick.Value = Convert.ToDateTime(drd["AcceptDate"]);
                        datePickRecieve.Value = Convert.ToDateTime(drd["RecieveDate"]);
                        datePickRecordDate.Value = Convert.ToDateTime(drd["RecordDate"]);
                        cbbFrom.Text = drd["From_"].ToString();
                        cbbTo.Text = drd["To_"].ToString();
                        tbSubject.Text = drd["Subject_"].ToString();
                        tbDocNo_rtn.Text = drd["DocNo_rtn"].ToString();
                        cbbRecipient.Text = drd["Recipient"].ToString();
                        tbNote.Text = drd["note"].ToString();
                    }
                   
                
                }

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

        private void tbDocNo_rtn_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
