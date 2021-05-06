namespace MTI_Stores_Manager
{
    partial class movements_show_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMovements = new System.Windows.Forms.DataGridView();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvMvtHeader = new System.Windows.Forms.DataGridView();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_types = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.DFrom = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DTo = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnShowAll = new MetroFramework.Controls.MetroButton();
            this.rbtAapproved = new MetroFramework.Controls.MetroRadioButton();
            this.rptPinding = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMvtHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovements
            // 
            this.dgvMovements.AllowUserToAddRows = false;
            this.dgvMovements.AllowUserToDeleteRows = false;
            this.dgvMovements.AllowUserToResizeRows = false;
            this.dgvMovements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovements.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMovements.ColumnHeadersHeight = 35;
            this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMovements.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMovements.Location = new System.Drawing.Point(828, 133);
            this.dgvMovements.MultiSelect = false;
            this.dgvMovements.Name = "dgvMovements";
            this.dgvMovements.ReadOnly = true;
            this.dgvMovements.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMovements.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovements.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovements.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovements.RowTemplate.Height = 32;
            this.dgvMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovements.ShowEditingIcon = false;
            this.dgvMovements.Size = new System.Drawing.Size(564, 503);
            this.dgvMovements.TabIndex = 41;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(169, 57);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(116, 23);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvMvtHeader
            // 
            this.dgvMvtHeader.AllowUserToAddRows = false;
            this.dgvMvtHeader.AllowUserToDeleteRows = false;
            this.dgvMvtHeader.AllowUserToResizeRows = false;
            this.dgvMvtHeader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMvtHeader.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMvtHeader.ColumnHeadersHeight = 35;
            this.dgvMvtHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMvtHeader.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMvtHeader.Location = new System.Drawing.Point(23, 133);
            this.dgvMvtHeader.MultiSelect = false;
            this.dgvMvtHeader.Name = "dgvMvtHeader";
            this.dgvMvtHeader.ReadOnly = true;
            this.dgvMvtHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMvtHeader.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMvtHeader.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMvtHeader.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMvtHeader.RowTemplate.Height = 32;
            this.dgvMvtHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMvtHeader.ShowEditingIcon = false;
            this.dgvMvtHeader.Size = new System.Drawing.Size(786, 503);
            this.dgvMvtHeader.TabIndex = 52;
            this.dgvMvtHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMvtHeader_CellClick);
            this.dgvMvtHeader.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMvtHeader_CellFormatting);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(40, 55);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(125, 25);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "بحث برقم الإذن";
            // 
            // Cmb_types
            // 
            this.Cmb_types.FormattingEnabled = true;
            this.Cmb_types.ItemHeight = 23;
            this.Cmb_types.Items.AddRange(new object[] {
            "وارد",
            "صادر",
            "إفتتاحي"});
            this.Cmb_types.Location = new System.Drawing.Point(379, 52);
            this.Cmb_types.Name = "Cmb_types";
            this.Cmb_types.Size = new System.Drawing.Size(139, 29);
            this.Cmb_types.TabIndex = 54;
            this.Cmb_types.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(294, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 25);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "نوع الإذن";
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAccept.Location = new System.Drawing.Point(1186, 36);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 67);
            this.btnAccept.TabIndex = 56;
            this.btnAccept.Text = "قبول الطلب";
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPrint.Location = new System.Drawing.Point(1298, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 67);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DFrom
            // 
            this.DFrom.Location = new System.Drawing.Point(721, 51);
            this.DFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.DFrom.Name = "DFrom";
            this.DFrom.Size = new System.Drawing.Size(134, 29);
            this.DFrom.TabIndex = 57;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(682, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 25);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "من";
            // 
            // DTo
            // 
            this.DTo.Location = new System.Drawing.Point(901, 51);
            this.DTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.DTo.Name = "DTo";
            this.DTo.Size = new System.Drawing.Size(134, 29);
            this.DTo.TabIndex = 57;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(861, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 25);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "إلي";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(1052, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(73, 38);
            this.metroButton1.TabIndex = 59;
            this.metroButton1.Text = "بحث";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // btnShowAll
            // 
            this.btnShowAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnShowAll.Location = new System.Drawing.Point(640, 89);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(169, 38);
            this.btnShowAll.TabIndex = 60;
            this.btnShowAll.Text = "عرض الكل";
            this.btnShowAll.UseSelectable = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // rbtAapproved
            // 
            this.rbtAapproved.AutoSize = true;
            this.rbtAapproved.Checked = true;
            this.rbtAapproved.Location = new System.Drawing.Point(523, 58);
            this.rbtAapproved.Name = "rbtAapproved";
            this.rbtAapproved.Size = new System.Drawing.Size(71, 15);
            this.rbtAapproved.TabIndex = 61;
            this.rbtAapproved.TabStop = true;
            this.rbtAapproved.Text = "تم الصرف";
            this.rbtAapproved.UseSelectable = true;
            this.rbtAapproved.CheckedChanged += new System.EventHandler(this.rbtAapproved_CheckedChanged);
            // 
            // rptPinding
            // 
            this.rptPinding.AutoSize = true;
            this.rptPinding.Location = new System.Drawing.Point(601, 58);
            this.rptPinding.Name = "rptPinding";
            this.rptPinding.Size = new System.Drawing.Size(76, 15);
            this.rptPinding.TabIndex = 62;
            this.rptPinding.Text = "تحت الطب";
            this.rptPinding.UseSelectable = true;
            // 
            // movements_show_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1427, 650);
            this.Controls.Add(this.rptPinding);
            this.Controls.Add(this.rbtAapproved);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.DTo);
            this.Controls.Add(this.DFrom);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Cmb_types);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dgvMvtHeader);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvMovements);
            this.Movable = false;
            this.Name = "movements_show_form";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إذن";
            this.Load += new System.EventHandler(this.movements_show_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMvtHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMovements;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMvtHeader;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox Cmb_types;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroDateTime DFrom;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime DTo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnShowAll;
        private MetroFramework.Controls.MetroRadioButton rbtAapproved;
        private MetroFramework.Controls.MetroRadioButton rptPinding;
    }
}