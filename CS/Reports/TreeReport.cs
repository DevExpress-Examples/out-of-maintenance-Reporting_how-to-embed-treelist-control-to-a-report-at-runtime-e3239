using System;
using System.Windows;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using System.Data;
using DevExpress.XtraTreeList;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace E3239.Reports {
    public partial class TreeReport : XtraReport {

        DataTable dt;
        TreeList treeList = new TreeList();

        public TreeReport() {
            InitializeComponent();
        }

        public TreeReport(DataTable dt) {
            this.dt = dt;
            InitializeComponent();
        }

        void TreeReport_BeforePrint(object sender, PrintEventArgs e) {
            UpdateTreeList(treeList);
        }

        void UpdateTreeList(TreeList treeList) {
            if (treeList != null) {
                WinControlContainer wcc = new WinControlContainer();
                treeList.Parent = new Form();
                Detail.Controls.Add(wcc);
                wcc.WinControl = treeList;

                treeList.KeyFieldName = "uniqueID";
                treeList.ParentFieldName = "parentID";
                treeList.DataSource = dt;
                treeList.ExpandAll();
                treeList.ForceInitialize();
            }
        }
    }
}
