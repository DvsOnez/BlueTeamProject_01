namespace CoffeeShopForms
{
    partial class MenuGrv
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
            this.BeveragePriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeverageMenuGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FoodPriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FoodGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeePriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeMenuGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(788, 421);
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
            // BeveragePriceGrid
            // 
            this.BeveragePriceGrid.Caption = "BPrice";
            this.BeveragePriceGrid.Name = "BeveragePriceGrid";
            this.BeveragePriceGrid.Visible = true;
            this.BeveragePriceGrid.VisibleIndex = 3;
            // 
            // BeverageMenuGrid
            // 
            this.BeverageMenuGrid.Caption = "Beverages";
            this.BeverageMenuGrid.Name = "BeverageMenuGrid";
            this.BeverageMenuGrid.Visible = true;
            this.BeverageMenuGrid.VisibleIndex = 2;
            // 
            // FoodPriceGrid
            // 
            this.FoodPriceGrid.Caption = "FPrice";
            this.FoodPriceGrid.Name = "FoodPriceGrid";
            this.FoodPriceGrid.Visible = true;
            this.FoodPriceGrid.VisibleIndex = 5;
            // 
            // FoodGrid
            // 
            this.FoodGrid.Caption = "Food";
            this.FoodGrid.Name = "FoodGrid";
            this.FoodGrid.Visible = true;
            this.FoodGrid.VisibleIndex = 4;
            // 
            // CoffeePriceGrid
            // 
            this.CoffeePriceGrid.Caption = "CPrice";
            this.CoffeePriceGrid.Name = "CoffeePriceGrid";
            this.CoffeePriceGrid.Visible = true;
            this.CoffeePriceGrid.VisibleIndex = 1;
            // 
            // CoffeeMenuGrid
            // 
            this.CoffeeMenuGrid.Caption = "Coffee";
            this.CoffeeMenuGrid.Name = "CoffeeMenuGrid";
            this.CoffeeMenuGrid.Visible = true;
            this.CoffeeMenuGrid.VisibleIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(474, 430);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Add";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(636, 430);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Remove";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(555, 430);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Edit";
            // 
            // MenuGrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.png_clipart_menu_cafe_restaurant_wine_list_european_style_lace_menu_logo_food_chinese_style;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MenuGrv";
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Button button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}