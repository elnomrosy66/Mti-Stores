namespace MTI_Stores_Manager
{
    partial class selectStoreForm
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
            this.Cmb_stores = new MetroFramework.Controls.MetroComboBox();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Cmb_stores
            // 
            this.Cmb_stores.FormattingEnabled = true;
            this.Cmb_stores.ItemHeight = 23;
            this.Cmb_stores.Items.AddRange(new object[] {
            "وارد",
            "صادر",
            "إفتتاحي",
            "تحت الطلب"});
            this.Cmb_stores.Location = new System.Drawing.Point(141, 117);
            this.Cmb_stores.Name = "Cmb_stores";
            this.Cmb_stores.Size = new System.Drawing.Size(219, 29);
            this.Cmb_stores.TabIndex = 55;
            this.Cmb_stores.UseSelectable = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(170, 166);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(172, 75);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrint.UseCustomBackColor = true;
            this.btnPrint.UseCustomForeColor = true;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.UseStyleColors = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // selectStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 250);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Cmb_stores);
            this.Movable = false;
            this.Name = "selectStoreForm";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إختيار مخزن";
            this.Load += new System.EventHandler(this.selectStoreForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox Cmb_stores;
        private MetroFramework.Controls.MetroButton btnPrint;
    }
}