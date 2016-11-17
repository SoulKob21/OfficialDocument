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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void menuSearch_Click(object sender, EventArgs e)
        {

        }

        //public void menuRecord_Click(object sender, EventArgs e)
        //{
        //    Save f = new Save(this);
        //    f.ShowDialog();
        //}

        private void menuReport_Click(object sender, EventArgs e)
        {
            waiting w = new waiting();
            w.Show(this);
            string qry = "";
            if (cbs.Checked == true)
            {
                qry = "SELECT DocNo,No_,AcceptDate,From_,To_,Subject_ FROM AcceptDocudemt";
            }
            else
            {
                string sql = "";


                if (cbDateBook.Checked == true)
                {
                    string dateBook = datePick.Value.ToString("dd MMM yy", new CultureInfo("th-TH"));
                    sql += " AND ad.AcceptDate = '" + dateBook + "'";
                }
                if (cbRecieve.Checked == true)
                {
                    string dateRecieve = datePickRecieve.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us"));
                    sql += " AND ad.RecieveDate = '" + dateRecieve + "'";
                }
               
                if(comboBox1.Text != "ทั้งหมด")
                {
                    sql += " AND ad.type = '" + comboBox1.Text + "'";
                }
                qry = "SELECT  *  FROM AcceptDocudemt ad where ad.DocNo LIKE '%" + tbDocNo.Text + "%' AND ad.DocNo_rtn LIKE '%" + tbDocNo_rtn.Text + "%' AND ad.From_ LIKE '%" + cbbFrom.Text + "%' AND ad.To_ LIKE '%" + cbbTo.Text + "%' AND ad.Subject_ LIKE '%" + tbSubject.Text + "%' AND ad.Recipient LIKE '%" + cbbRecipient.Text + "%'";
                qry += sql;
            }
            w.Close();
            Report f = new Report(this, qry);
            f.ShowDialog();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            waiting w = new waiting();
            w.Show(this);
            string qry = "";
            if (cbs.Checked == true)
            {
                qry = "SELECT DocNo,No_,AcceptDate,From_,To_,Subject_ FROM AcceptDocudemt";
            }
            else
            {
                string sql = "";


                if (cbDateBook.Checked == true)
                {
                    string dateBook = datePick.Value.ToString("dd MMM yy", new CultureInfo("th-TH"));
                    sql += " AND ad.AcceptDate = '" + dateBook + "' ";
                }
                if (cbRecieve.Checked == true)
                {
                    string dateRecieve = datePickRecieve.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us"));
                    sql += " AND ad.RecieveDate = '" + dateRecieve + "' ";
                }

                if (comboBox1.Text != "ทั้งหมด")
                {
                    sql += " AND ad.type = '" + comboBox1.Text + "' ";
                }
                qry = "SELECT  *  FROM AcceptDocudemt ad where ad.DocNo LIKE '%" + tbDocNo.Text + "%' AND ad.DocNo_rtn LIKE '%" + tbDocNo_rtn.Text + "%' AND ad.From_ LIKE '%" + cbbFrom.Text + "%' AND ad.To_ LIKE '%" + cbbTo.Text + "%' AND ad.Subject_ LIKE '%" + tbSubject.Text + "%' AND ad.Recipient LIKE '%" + cbbRecipient.Text + "%'";
                qry += sql;
            }
            w.Close();
            Report f = new Report(this, qry);
            f.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Edit f = new Edit(this, id);

            f.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการที่จะลบข้อมูล?", "", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
                MySqlConnection conn = new MySqlConnection(constr);
                conn.Open();

                waiting w = new waiting();
                try
                {

                    w.Show(this);
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "DELETE FROM acceptdocudemt where id = '" + dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "'";
                    comm.ExecuteNonQuery();
                    w.Close();
                    MessageBox.Show("ลบสำเร็จ...");
                    getData();
                }
                catch
                {
                    conn.Close();
                    w.Close();
                }
                conn.Close();
            }

        }

        private void cbDateBook_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateBook.Checked == true)
            {
                datePick.Enabled = true;
            }
            else
            {
                datePick.Enabled = false;
            }
        }

        private void cbRecieve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRecieve.Checked == true)
            {
                datePickRecieve.Enabled = true;
            }
            else
            {
                datePickRecieve.Enabled = false;
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "ทั้งหมด";
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
            con.Close();
            //getData();
        }

        public void getData()
        {
            waiting w = new waiting();
            w.Show(this);
            string qryOther = "";
            
            if (cbs.Checked == true)
            {
                if (comboBox1.Text == "กพ.")
                {
                    qryOther += "where ad.type = 'กพ.'";
                }
                else if(comboBox1.Text == "คป.")
                {
                    qryOther += "where ad.type = 'คป.'";
                }
                string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
                MySqlConnection con = new MySqlConnection(constr);
                con.Open();
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM AcceptDocudemt ad" + qryOther;
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "ทะเบียนรับ กพ.";
                    dataGridView1.Columns[1].HeaderText = "ทะเบียนรับ ศฝท.";
                    dataGridView1.Columns[2].HeaderText = "ที่";
                    dataGridView1.Columns[3].HeaderText = "ลงวันที่";
                    dataGridView1.Columns[4].HeaderText = "จาก";
                    dataGridView1.Columns[5].HeaderText = "ถึง";
                    dataGridView1.Columns[6].HeaderText = "เรื่อง";
                    dataGridView1.Columns[7].HeaderText = "วันที่รับ";
                    dataGridView1.Columns[8].HeaderText = "ผู้รับ";
                    dataGridView1.Columns[9].HeaderText = "วันที่บันทึก";
                    dataGridView1.Columns[10].HeaderText = "หมายเหตุ";
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].HeaderText = "หน่วยงาน";
                    w.Close();
                }
                catch
                {
                    w.Close();
                    con.Close();
                }
                con.Close();
            }
            else
            {
                if (comboBox1.Text == "กพ.")
                {
                    qryOther += " and ad.type = 'กพ.'";
                }
                else if (comboBox1.Text == "คป.")
                {
                    qryOther += " and ad.type = 'คป.'";
                }
                string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
                MySqlConnection con = new MySqlConnection(constr);
                con.Open();
                try
                {
                    string allSql = "SELECT * FROM AcceptDocudemt ad where ad.DocNo LIKE '%" + tbDocNo.Text + "%' " +
                    " AND ad.From_ LIKE '%" + cbbFrom.Text + "%' AND ad.Subject_ LIKE '%" + tbSubject.Text + "%' " +
                   " AND ad.DocNo_rtn LIKE '%" + tbDocNo_rtn.Text + "%'  AND ad.Recipient LIKE '%" + cbbRecipient.Text + "%'" +
                   " AND ad.To_ LIKE '%" + cbbTo.Text + "%' " + qryOther;
                    string sql = "";


                    if (cbDateBook.Checked == true)
                    {
                        string dateBook = datePick.Value.ToString("dd MMM yy", new CultureInfo("th-TH"));
                        sql += " AND ad.AcceptDate = '" + dateBook + "'";
                    }
                    if (cbRecieve.Checked == true)
                    {
                        string dateRecieve = datePickRecieve.Value.ToString("yyyy-MM-dd", new CultureInfo("en-us"));
                        sql += " AND ad.RecieveDate = '" + dateRecieve + "'";
                    }
                    allSql += sql;
                    MySqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = allSql;
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "ทะเบียนรับ กพ.";
                    dataGridView1.Columns[1].HeaderText = "ทะเบียนรับ ศฝท.";
                    dataGridView1.Columns[2].HeaderText = "ที่";
                    dataGridView1.Columns[3].HeaderText = "ลงวันที่";
                    dataGridView1.Columns[4].HeaderText = "จาก";
                    dataGridView1.Columns[5].HeaderText = "ถึง";
                    dataGridView1.Columns[6].HeaderText = "เรื่อง";
                    dataGridView1.Columns[7].HeaderText = "วันที่รับ";
                    dataGridView1.Columns[8].HeaderText = "ผู้รับ";
                    dataGridView1.Columns[9].HeaderText = "วันที่บันทึก";
                    dataGridView1.Columns[10].HeaderText = "หมายเหตุ";
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].HeaderText = "หน่วยงาน";
                    w.Close();
                }
                catch
                {
                    w.Close();
                    con.Close();
                }
                
                con.Close();
            }
        }

        private void MenuItemGP_Click(object sender, EventArgs e)
        {
            Save f = new Save(this,"กพ.");
            f.ShowDialog();
        }

        private void MenuItemKP_Click(object sender, EventArgs e)
        {
            Save f = new Save(this, "คป.");
            f.ShowDialog();
        }
        

    }
}
