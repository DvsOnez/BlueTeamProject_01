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
            this.grdFood = new DevExpress.XtraGrid.GridControl();
            this.grvFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFood
            // 
            this.grdFood.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdFood.Location = new System.Drawing.Point(2, 3);
            this.grdFood.MainView = this.grvFood;
            this.grdFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdFood.Name = "grdFood";
            this.grdFood.Size = new System.Drawing.Size(702, 595);
            this.grdFood.TabIndex = 0;
            this.grdFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvFood});
            // 
            // grvFood
            // 
            this.grvFood.DetailHeight = 467;
            this.grvFood.GridControl = this.grdFood;
            this.grvFood.Name = "grvFood";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Tomato;
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(711, 283);
            this.ADD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(130, 92);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(711, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.jailbirds_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.grdFood);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdFood;
        private DevExpress.XtraGrid.Views.Grid.GridView grvFood;
        private Button ADD;
        private Button button1;
    }
}