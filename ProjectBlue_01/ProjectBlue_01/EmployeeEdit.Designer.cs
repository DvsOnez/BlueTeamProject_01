namespace CoffeeShopForms
{
    partial class EmployeeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmpNameGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpIDGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpPositionGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(795, 434);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmpPositionGrid,
            this.EmpIDGrid,
            this.EmpNameGrid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // EmpNameGrid
            // 
            this.EmpNameGrid.Caption = "EmpName";
            this.EmpNameGrid.Name = "EmpNameGrid";
            this.EmpNameGrid.Visible = true;
            this.EmpNameGrid.VisibleIndex = 0;
            // 
            // EmpIDGrid
            // 
            this.EmpIDGrid.Caption = "EmpID";
            this.EmpIDGrid.Name = "EmpIDGrid";
            this.EmpIDGrid.Visible = true;
            this.EmpIDGrid.VisibleIndex = 1;
            // 
            // EmpPositionGrid
            // 
            this.EmpPositionGrid.Caption = "EmpPosition";
            this.EmpPositionGrid.Name = "EmpPositionGrid";
            this.EmpPositionGrid.Visible = true;
            this.EmpPositionGrid.VisibleIndex = 2;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources._6179a7473854b15e11196ea6_shutterstock_1389455627;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "EmployeeEdit";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn EmpPositionGrid;
        private DevExpress.XtraGrid.Columns.GridColumn EmpIDGrid;
        private DevExpress.XtraGrid.Columns.GridColumn EmpNameGrid;
    }
}