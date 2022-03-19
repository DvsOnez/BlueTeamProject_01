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
            this.EmpPositionGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpIDGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpNameGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpSalaryGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(785, 413);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmpPositionGrid,
            this.EmpIDGrid,
            this.EmpNameGrid,
            this.EmpSalaryGrid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // EmpPositionGrid
            // 
            this.EmpPositionGrid.Caption = "EmpPosition";
            this.EmpPositionGrid.Name = "EmpPositionGrid";
            this.EmpPositionGrid.Visible = true;
            this.EmpPositionGrid.VisibleIndex = 2;
            // 
            // EmpIDGrid
            // 
            this.EmpIDGrid.Caption = "EmpID";
            this.EmpIDGrid.Name = "EmpIDGrid";
            this.EmpIDGrid.Visible = true;
            this.EmpIDGrid.VisibleIndex = 1;
            // 
            // EmpNameGrid
            // 
            this.EmpNameGrid.Caption = "EmpName";
            this.EmpNameGrid.Name = "EmpNameGrid";
            this.EmpNameGrid.Visible = true;
            this.EmpNameGrid.VisibleIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(536, 423);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Add";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(617, 423);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Remove";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmpSalaryGrid
            // 
            this.EmpSalaryGrid.Caption = "EmpSalary";
            this.EmpSalaryGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.EmpSalaryGrid.Name = "EmpSalaryGrid";
            this.EmpSalaryGrid.Visible = true;
            this.EmpSalaryGrid.VisibleIndex = 3;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources._6179a7473854b15e11196ea6_shutterstock_1389455627;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn EmpSalaryGrid;
    }
}