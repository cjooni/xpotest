﻿using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace xpotest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource2.Fill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            CustomSqlQuery query1 = new CustomSqlQuery();
            query1.Name = "Query1";
            query1.Sql = $"select client_cd  코드 " +
                         $"      ,client_nm  코드명 " +
                         $"      ,office      " +
                         $"  from client01m00 " +
                         $" where client_cd = @p_client_cd";

            QueryParameter param = new QueryParameter();
            param.Name = "p_client_cd";
            param.Type = typeof(string);
            param.Value = "0000000001";


            query1.Parameters.Add(param);
            sqlDataSource2.Queries.Add(query1);

            
            sqlDataSource2.Fill();

            DataTable dt = new DataTable();

            ITable src = sqlDataSource2.Result[0];


            DataTable dest = new DataTable("Query1");
            foreach (IColumn column in src.Columns)
                dest.Columns.Add(column.Name, column.Type);
            foreach (IRow row in src)
                dest.Rows.Add(row.ToArray());

            
        //    npgsqlDataAdapter1.InsertCommand.Transaction

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            nCon.Open();
            nCon.

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 3255;
            b = 120;

            c = a * b;

            MessageBox.Show(c.ToString());
        }
    }
}
