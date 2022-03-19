namespace CoffeeShopForms
{
    partial class Food
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
            this.QuantityGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FoodGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(614, 446);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.QuantityGrid,
            this.PriceGrid,
            this.FoodGrid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // QuantityGrid
            // 
            this.QuantityGrid.Caption = "Quantity";
            this.QuantityGrid.Name = "QuantityGrid";
            this.QuantityGrid.Visible = true;
            this.QuantityGrid.VisibleIndex = 2;
            // 
            // PriceGrid
            // 
            this.PriceGrid.Caption = "Price";
            this.PriceGrid.Name = "PriceGrid";
            this.PriceGrid.Visible = true;
            this.PriceGrid.VisibleIndex = 1;
            // 
            // FoodGrid
            // 
            this.FoodGrid.Caption = "Food";
            this.FoodGrid.Name = "FoodGrid";
            this.FoodGrid.Visible = true;
            this.FoodGrid.VisibleIndex = 0;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Tomato;
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(622, 212);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(114, 69);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(622, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.jailbirds_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.gridControl1);
            this.Name = "Food";
            this.Text = "Food";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button ADD;
        private Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityGrid;
        private DevExpress.XtraGrid.Columns.GridColumn PriceGrid;
        private DevExpress.XtraGrid.Columns.GridColumn FoodGrid;
    }
}