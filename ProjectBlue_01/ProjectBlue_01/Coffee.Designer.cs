namespace CoffeeShopForms
{
    partial class Coffee
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
            this.CoffeeGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriceGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(557, 448);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CoffeeGrid,
            this.PriceGrid,
            this.QuantityGrid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CoffeeGrid
            // 
            this.CoffeeGrid.Caption = "Coffee";
            this.CoffeeGrid.Name = "CoffeeGrid";
            this.CoffeeGrid.Visible = true;
            this.CoffeeGrid.VisibleIndex = 0;
            // 
            // PriceGrid
            // 
            this.PriceGrid.Caption = "Price";
            this.PriceGrid.Name = "PriceGrid";
            this.PriceGrid.Visible = true;
            this.PriceGrid.VisibleIndex = 1;
            // 
            // QuantityGrid
            // 
            this.QuantityGrid.Caption = "Quantity";
            this.QuantityGrid.Name = "QuantityGrid";
            this.QuantityGrid.Visible = true;
            this.QuantityGrid.VisibleIndex = 2;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Sienna;
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(565, 222);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(115, 74);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(565, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.coffee_cover_v06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.gridControl1);
            this.Name = "Coffee";
            this.Text = "Coffee";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button ADD;
        private Button button2;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeGrid;
        private DevExpress.XtraGrid.Columns.GridColumn PriceGrid;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityGrid;
    }
}