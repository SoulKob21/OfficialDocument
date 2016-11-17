using Microsoft.Reporting.WinForms;
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
    public partial class Report : Form
    {
        Search _callerForm;
        public string strQuery;
        public Report(Search callingForm, string _strQuery)
        {
            InitializeComponent();
            strQuery = _strQuery;
            //_callerForm = callingForm;
            //_callerForm.Enabled = false;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            
            ReportParameter[] _date = new ReportParameter[3];
            _date[0] = new ReportParameter("Day", d.Day.ToString(), false);
            _date[1] = new ReportParameter("Month", thaiMonth[Convert.ToInt16(d.Month) - 1].ToString(), false);
            _date[2] = new ReportParameter("Year", (d.Year+543).ToString(), false);
            this.reportViewer1.LocalReport.SetParameters(_date);
            DataSet1 dsDoc = GetData();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dsDoc.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

        }
        private string[] thaiMonth = { "มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม" };


        private DataSet1 GetData()
        {
            DataSet1 dsDoc = new DataSet1();
            string constr = @"SERVER=navyserver;DATABASE=navdb;UID=root;";
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = strQuery;
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                sda.Fill(dsDoc, "DataTable1");

            }
            catch
            {


            }
            return dsDoc;
        }


        private void Report_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //_callerForm.Enabled = true;
            this.Close();
        }
    }
}
