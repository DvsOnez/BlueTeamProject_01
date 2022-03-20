﻿namespace CoffeeShopForms
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
            this.grdCoffee = new DevExpress.XtraGrid.GridControl();
            this.grvCoffee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCoffee
            // 
            this.grdCoffee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdCoffee.Location = new System.Drawing.Point(2, 3);
            this.grdCoffee.MainView = this.grvCoffee;
            this.grdCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdCoffee.Name = "grdCoffee";
            this.grdCoffee.Size = new System.Drawing.Size(637, 597);
            this.grdCoffee.TabIndex = 0;
            this.grdCoffee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCoffee});
            // 
            // grvCoffee
            // 
            this.grvCoffee.DetailHeight = 467;
            this.grvCoffee.GridControl = this.grdCoffee;
            this.grvCoffee.Name = "grvCoffee";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(646, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(646, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.coffee_cover_v06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdCoffee);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Coffee";
            this.Text = "Coffee";
            this.Load += new System.EventHandler(this.Coffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoffee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCoffee;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCoffee;
        private Button button1;
        private Button button2;
    }
}