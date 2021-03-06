﻿using System;
using System.Windows.Forms;
using DevExpress.DataAccess.UI.Sql;

namespace WinFormsSqlDataSource {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (sqlDataSource1.Queries[0].EditQuery(new EditQueryContext())) {
                sqlDataSource1.Fill();

                this.gridView1.Columns.Clear();

                this.gridControl1.DataSource = null;
                this.gridControl1.DataMember = null;

                this.gridControl1.DataSource = sqlDataSource1;
                this.gridControl1.DataMember = sqlDataSource1.Queries[0].Name;
            }
        }
    }
}
