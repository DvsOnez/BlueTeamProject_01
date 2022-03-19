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
            this.CoffeePriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeMenuGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BeveragePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeverageGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FoodGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(345, 458);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CoffeePriceGrid,
            this.CoffeeMenuGrid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CoffeePriceGrid
            // 
            this.CoffeePriceGrid.Caption = "Price";
            this.CoffeePriceGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            this.simpleButton1.Location = new System.Drawing.Point(108, 467);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Add";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(891, 467);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Remove";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(972, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(270, 467);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Edit";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(351, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(345, 458);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BeveragePrice,
            this.BeverageGrid});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // BeveragePrice
            // 
            this.BeveragePrice.Caption = "Price";
            this.BeveragePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BeveragePrice.Name = "BeveragePrice";
            this.BeveragePrice.Visible = true;
            this.BeveragePrice.VisibleIndex = 1;
            // 
            // BeverageGrid
            // 
            this.BeverageGrid.Caption = "Beverage";
            this.BeverageGrid.Name = "BeverageGrid";
            this.BeverageGrid.Visible = true;
            this.BeverageGrid.VisibleIndex = 0;
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(702, 3);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(345, 458);
            this.gridControl3.TabIndex = 6;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FoodPrice,
            this.FoodGrid});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // FoodPrice
            // 
            this.FoodPrice.Caption = "Price";
            this.FoodPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Visible = true;
            this.FoodPrice.VisibleIndex = 1;
            // 
            // FoodGrid
            // 
            this.FoodGrid.Caption = "Food";
            this.FoodGrid.Name = "FoodGrid";
            this.FoodGrid.Visible = true;
            this.FoodGrid.VisibleIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(459, 467);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Add";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(621, 467);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 8;
            this.simpleButton5.Text = "Edit";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(972, 467);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 9;
            this.simpleButton6.Text = "Edit";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(810, 467);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(75, 23);
            this.simpleButton7.TabIndex = 10;
            this.simpleButton7.Text = "Add";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(540, 467);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(75, 23);
            this.simpleButton8.TabIndex = 11;
            this.simpleButton8.Text = "Remove";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(189, 467);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(75, 23);
            this.simpleButton9.TabIndex = 12;
            this.simpleButton9.Text = "Remove";
            // 
            // MenuGrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.png_clipart_menu_cafe_restaurant_wine_list_european_style_lace_menu_logo_food_chinese_style;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 522);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MenuGrv";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeePriceGrid;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeMenuGrid;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Button button1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn BeveragePrice;
        private DevExpress.XtraGrid.Columns.GridColumn BeverageGrid;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn FoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn FoodGrid;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
    }
}