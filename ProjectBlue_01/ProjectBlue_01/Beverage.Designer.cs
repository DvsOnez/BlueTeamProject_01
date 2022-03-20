namespace CoffeeShopForms
{
    partial class Beverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beverage));
            this.BeverageGrid = new DevExpress.XtraGrid.GridControl();
            this.BeverageGrv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CallBeverages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CallPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CallQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BeverageGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeverageGrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // BeverageGrid
            // 
            this.BeverageGrid.Location = new System.Drawing.Point(0, 0);
            this.BeverageGrid.MainView = this.BeverageGrv;
            this.BeverageGrid.Name = "BeverageGrid";
            this.BeverageGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.BeverageGrid.Size = new System.Drawing.Size(542, 441);
            this.BeverageGrid.TabIndex = 0;
            this.BeverageGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BeverageGrv});
            // 
            // BeverageGrv
            // 
            this.BeverageGrv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CallBeverages,
            this.CallPrice,
            this.CallQuantity});
            this.BeverageGrv.CustomizationFormBounds = new System.Drawing.Rectangle(2543, 342, 264, 272);
            this.BeverageGrv.GridControl = this.BeverageGrid;
            this.BeverageGrv.Name = "BeverageGrv";
            this.BeverageGrv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.CallPrice, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // CallBeverages
            // 
            this.CallBeverages.Caption = "Beverages";
            this.CallBeverages.Name = "CallBeverages";
            this.CallBeverages.Visible = true;
            this.CallBeverages.VisibleIndex = 0;
            // 
            // CallPrice
            // 
            this.CallPrice.Caption = "Price";
            this.CallPrice.Name = "CallPrice";
            this.CallPrice.Visible = true;
            this.CallPrice.VisibleIndex = 1;
            // 
            // CallQuantity
            // 
            this.CallQuantity.Caption = "Quantity";
            this.CallQuantity.Name = "CallQuantity";
            this.CallQuantity.Visible = true;
            this.CallQuantity.VisibleIndex = 2;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(548, 245);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(114, 71);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(548, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Beverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.BeverageGrid);
            this.Name = "Beverage";
            this.Text = "Beverages";
            this.Load += new System.EventHandler(this.Beverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BeverageGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeverageGrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl BeverageGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView BeverageGrv;
        private DevExpress.XtraGrid.Columns.GridColumn CallBeverages;
        private DevExpress.XtraGrid.Columns.GridColumn CallPrice;
        private DevExpress.XtraGrid.Columns.GridColumn CallQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private Button ADD;
        private Button button2;
    }
}