namespace E3239.Reports
{
    partial class TreeReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //try { Dispose(base); }
            //    catch
            //{}
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colportfolioTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolLabel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcolWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLabel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            // 
            // colportfolioTable
            // 
            this.colportfolioTable.FieldName = "portfolioTable";
            this.colportfolioTable.Name = "colportfolioTable";
            this.colportfolioTable.Visible = true;
            this.colportfolioTable.VisibleIndex = 1;
            // 
            // colcolCode
            // 
            this.colcolCode.FieldName = "colCode";
            this.colcolCode.Name = "colcolCode";
            this.colcolCode.Visible = true;
            this.colcolCode.VisibleIndex = 2;
            // 
            // colcolLabel
            // 
            this.colcolLabel.FieldName = "colLabel";
            this.colcolLabel.Name = "colcolLabel";
            this.colcolLabel.Visible = true;
            this.colcolLabel.VisibleIndex = 3;
            // 
            // colcolWeight
            // 
            this.colcolWeight.FieldName = "colWeight";
            this.colcolWeight.Name = "colcolWeight";
            this.colcolWeight.Visible = true;
            this.colcolWeight.VisibleIndex = 4;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 5;
            // 
            // colLabel
            // 
            this.colLabel.FieldName = "Label";
            this.colLabel.Name = "colLabel";
            this.colLabel.Visible = true;
            this.colLabel.VisibleIndex = 6;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TreeReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "10.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.TreeReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colportfolioTable;
        private DevExpress.XtraGrid.Columns.GridColumn colcolCode;
        private DevExpress.XtraGrid.Columns.GridColumn colcolLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colcolWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLabel;

    }
}
