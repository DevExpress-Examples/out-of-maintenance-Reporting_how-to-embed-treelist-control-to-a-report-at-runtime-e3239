using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraReports.UI;


namespace E3239 {
    public partial class Form1 : Form {
        DataTable dt = new DataTable("TreeTable");
        TreeList treeList = new TreeList();

        public Form1() {
            InitializeComponent();

            LoadData();
            InitializeTreeList();
        }

        private void LoadData() {
            dt.Columns.Add("uniqueID", typeof(int));
            dt.Columns.Add("parentID", typeof(int));
            dt.Columns.Add("PositionNode", typeof(object));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Level", typeof(float));
            dt.Columns.Add("Position", typeof(float));

            for (int i = 0; i < 10; i++) {
                DataRow dr = dt.NewRow();
                dr["uniqueID"] = i;
                dr["parentID"] = i / 3;
                dr["Code"] = "code" + i;
                dr["Level"] = dr["Position"] = i;
                dt.Rows.Add(dr);
            }
        }

        private void InitializeTreeList() {
            Controls.Add(treeList);
            treeList.Dock = DockStyle.Fill;
            treeList.DataSource = dt;
            treeList.ParentFieldName = "parentID";
            treeList.KeyFieldName = "uniqueID";
            treeList.ExpandAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Reports.TreeReport rep = new Reports.TreeReport(treeList.DataSource as DataTable);
            rep.ShowPreview();
        }
    }
}