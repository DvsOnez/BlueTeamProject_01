namespace CoffeeShopForms
{
    partial class Menu
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
            this.CoffeeMenuGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeePriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FoodGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FoodPriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeverageMenuGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeveragePriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(798, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BeveragePriceGrid,
            this.BeverageMenuGrid,
            this.FoodPriceGrid,
            this.FoodGrid,
            this.CoffeePriceGrid,
            this.CoffeeMenuGrid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CoffeeMenuGrid
            // 
            this.CoffeeMenuGrid.Caption = "Coffee";
            this.CoffeeMenuGrid.Name = "CoffeeMenuGrid";
            this.CoffeeMenuGrid.Visible = true;
            this.CoffeeMenuGrid.VisibleIndex = 0;
            // 
            // CoffeePriceGrid
            // 
            this.CoffeePriceGrid.Caption = "CPrice";
            this.CoffeePriceGrid.Name = "CoffeePriceGrid";
            this.CoffeePriceGrid.Visible = true;
            this.CoffeePriceGrid.VisibleIndex = 1;
            // 
            // FoodGrid
            // 
            this.FoodGrid.Caption = "Food";
            this.FoodGrid.Name = "FoodGrid";
            this.FoodGrid.Visible = true;
            this.FoodGrid.VisibleIndex = 4;
            // 
            // FoodPriceGrid
            // 
            this.FoodPriceGrid.Caption = "FPrice";
            this.FoodPriceGrid.Name = "FoodPriceGrid";
            this.FoodPriceGrid.Visible = true;
            this.FoodPriceGrid.VisibleIndex = 5;
            // 
            // BeverageMenuGrid
            // 
            this.BeverageMenuGrid.Caption = "Beverages";
            this.BeverageMenuGrid.Name = "BeverageMenuGrid";
            this.BeverageMenuGrid.Visible = true;
            this.BeverageMenuGrid.VisibleIndex = 2;
            // 
            // BeveragePriceGrid
            // 
            this.BeveragePriceGrid.Caption = "BPrice";
            this.BeveragePriceGrid.Name = "BeveragePriceGrid";
            this.BeveragePriceGrid.Visible = true;
            this.BeveragePriceGrid.VisibleIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.png_clipart_menu_cafe_restaurant_wine_list_european_style_lace_menu_logo_food_chinese_style;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BeveragePriceGrid;
        private DevExpress.XtraGrid.Columns.GridColumn BeverageMenuGrid;
        private DevExpress.XtraGrid.Columns.GridColumn FoodPriceGrid;
        private DevExpress.XtraGrid.Columns.GridColumn FoodGrid;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeePriceGrid;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeMenuGrid;
    }
}