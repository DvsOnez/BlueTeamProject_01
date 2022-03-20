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
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdProduct.Location = new System.Drawing.Point(12, 4);
            this.grdProduct.MainView = this.grvProduct;
            this.grdProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(546, 325);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.UseEmbeddedNavigator = true;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProduct});
            // 
            // grvProduct
            // 
            this.grvProduct.DetailHeight = 467;
            this.grvProduct.GridControl = this.grdProduct;
            this.grvProduct.Name = "grvProduct";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(472, 337);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(379, 337);
            this.simpleButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(86, 31);
            this.simpleButton9.TabIndex = 12;
            this.simpleButton9.Text = "Remove";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(287, 337);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 337);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MenuGrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.png_clipart_menu_cafe_restaurant_wine_list_european_style_lace_menu_logo_food_chinese_style;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 381);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grdProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuGrv";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuGrv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProduct;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}