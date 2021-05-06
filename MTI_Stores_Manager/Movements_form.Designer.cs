namespace MTI_Stores_Manager
{
    partial class Movements_form
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmb_type = new System.Windows.Forms.ComboBox();
            this.Cmb_stores = new System.Windows.Forms.ComboBox();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.reciever = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.place = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Mvt_number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_items = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_unites = new MetroFramework.Controls.MetroComboBox();
            this.Txt_qty = new System.Windows.Forms.NumericUpDown();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvItems.ColumnHeadersHeight = 35;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.store_id,
            this.unit_id,
            this.Item_id,
            this.item_name,
            this.qty,
            this.unit_name,
            this.unit_qty});
            this.dgvItems.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvItems.Location = new System.Drawing.Point(409, 134);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.RowTemplate.Height = 32;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.ShowEditingIcon = false;
            this.dgvItems.Size = new System.Drawing.Size(783, 394);
            this.dgvItems.TabIndex = 16;
            // 
            // num
            // 
            this.num.FillWeight = 49.04704F;
            this.num.HeaderText = "م";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // store_id
            // 
            this.store_id.HeaderText = "store";
            this.store_id.Name = "store_id";
            this.store_id.ReadOnly = true;
            this.store_id.Visible = false;
            // 
            // unit_id
            // 
            this.unit_id.HeaderText = "unit";
            this.unit_id.Name = "unit_id";
            this.unit_id.ReadOnly = true;
            this.unit_id.Visible = false;
            // 
            // Item_id
            // 
            this.Item_id.HeaderText = "item_id";
            this.Item_id.Name = "Item_id";
            this.Item_id.ReadOnly = true;
            this.Item_id.Visible = false;
            // 
            // item_name
            // 
            this.item_name.FillWeight = 203.0457F;
            this.item_name.HeaderText = "الصنف";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.FillWeight = 74.6328F;
            this.qty.HeaderText = "الكمية";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // unit_name
            // 
            this.unit_name.FillWeight = 73.27445F;
            this.unit_name.HeaderText = "الوحدة";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            // 
            // unit_qty
            // 
            this.unit_qty.HeaderText = "unit_qty";
            this.unit_qty.Name = "unit_qty";
            this.unit_qty.ReadOnly = true;
            this.unit_qty.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_type);
            this.groupBox1.Controls.Add(this.Cmb_stores);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.reciever);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.place);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.Mvt_number);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 329);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأذن";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Cmb_type
            // 
            this.Cmb_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_type.FormattingEnabled = true;
            this.Cmb_type.Items.AddRange(new object[] {
            "صادر",
            "وارد",
            "إفتتاحي"});
            this.Cmb_type.Location = new System.Drawing.Point(37, 81);
            this.Cmb_type.Name = "Cmb_type";
            this.Cmb_type.Size = new System.Drawing.Size(227, 37);
            this.Cmb_type.TabIndex = 36;
            this.Cmb_type.SelectionChangeCommitted += new System.EventHandler(this.Cmb_stores_SelectionChangeCommitted);
            // 
            // Cmb_stores
            // 
            this.Cmb_stores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_stores.FormattingEnabled = true;
            this.Cmb_stores.Location = new System.Drawing.Point(37, 133);
            this.Cmb_stores.Name = "Cmb_stores";
            this.Cmb_stores.Size = new System.Drawing.Size(227, 37);
            this.Cmb_stores.TabIndex = 36;
            this.Cmb_stores.SelectionChangeCommitted += new System.EventHandler(this.Cmb_stores_SelectionChangeCommitted);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(37, 271);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(227, 35);
            this.date.TabIndex = 34;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(284, 275);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 25);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "التاريخ";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(284, 228);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 25);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "الصارف";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // reciever
            // 
            // 
            // 
            // 
            this.reciever.CustomButton.Image = null;
            this.reciever.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.reciever.CustomButton.Name = "";
            this.reciever.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.reciever.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.reciever.CustomButton.TabIndex = 1;
            this.reciever.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reciever.CustomButton.UseSelectable = true;
            this.reciever.CustomButton.Visible = false;
            this.reciever.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.reciever.Lines = new string[0];
            this.reciever.Location = new System.Drawing.Point(37, 228);
            this.reciever.MaxLength = 32767;
            this.reciever.Name = "reciever";
            this.reciever.PasswordChar = '\0';
            this.reciever.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reciever.SelectedText = "";
            this.reciever.SelectionLength = 0;
            this.reciever.SelectionStart = 0;
            this.reciever.ShortcutsEnabled = true;
            this.reciever.Size = new System.Drawing.Size(227, 23);
            this.reciever.TabIndex = 32;
            this.reciever.UseSelectable = true;
            this.reciever.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.reciever.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(284, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 25);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "الجهة";
            // 
            // place
            // 
            // 
            // 
            // 
            this.place.CustomButton.Image = null;
            this.place.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.place.CustomButton.Name = "";
            this.place.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.place.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.place.CustomButton.TabIndex = 1;
            this.place.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.place.CustomButton.UseSelectable = true;
            this.place.CustomButton.Visible = false;
            this.place.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.place.Lines = new string[0];
            this.place.Location = new System.Drawing.Point(37, 185);
            this.place.MaxLength = 32767;
            this.place.Name = "place";
            this.place.PasswordChar = '\0';
            this.place.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.place.SelectedText = "";
            this.place.SelectionLength = 0;
            this.place.SelectionStart = 0;
            this.place.ShortcutsEnabled = true;
            this.place.Size = new System.Drawing.Size(227, 23);
            this.place.TabIndex = 30;
            this.place.UseSelectable = true;
            this.place.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.place.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(284, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 25);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "المخزن";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(284, 87);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 25);
            this.metroLabel9.TabIndex = 27;
            this.metroLabel9.Text = "نوع الأذن";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(284, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 25);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "رقم الأذن";
            // 
            // Mvt_number
            // 
            // 
            // 
            // 
            this.Mvt_number.CustomButton.Image = null;
            this.Mvt_number.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.Mvt_number.CustomButton.Name = "";
            this.Mvt_number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Mvt_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Mvt_number.CustomButton.TabIndex = 1;
            this.Mvt_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Mvt_number.CustomButton.UseSelectable = true;
            this.Mvt_number.CustomButton.Visible = false;
            this.Mvt_number.Enabled = false;
            this.Mvt_number.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Mvt_number.Lines = new string[0];
            this.Mvt_number.Location = new System.Drawing.Point(37, 39);
            this.Mvt_number.MaxLength = 32767;
            this.Mvt_number.Name = "Mvt_number";
            this.Mvt_number.PasswordChar = '\0';
            this.Mvt_number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Mvt_number.SelectedText = "";
            this.Mvt_number.SelectionLength = 0;
            this.Mvt_number.SelectionStart = 0;
            this.Mvt_number.ShortcutsEnabled = true;
            this.Mvt_number.Size = new System.Drawing.Size(227, 23);
            this.Mvt_number.TabIndex = 26;
            this.Mvt_number.UseSelectable = true;
            this.Mvt_number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Mvt_number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(409, 83);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 25);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "الصنف";
            // 
            // Cmb_items
            // 
            this.Cmb_items.FormattingEnabled = true;
            this.Cmb_items.ItemHeight = 23;
            this.Cmb_items.Location = new System.Drawing.Point(480, 83);
            this.Cmb_items.Name = "Cmb_items";
            this.Cmb_items.Size = new System.Drawing.Size(200, 29);
            this.Cmb_items.TabIndex = 31;
            this.Cmb_items.UseSelectable = true;
            this.Cmb_items.SelectionChangeCommitted += new System.EventHandler(this.Cmb_items_SelectionChangeCommitted);
            this.Cmb_items.SelectedValueChanged += new System.EventHandler(this.Cmb_items_SelectedValueChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(687, 83);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 25);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "الوحدة";
            // 
            // Cmb_unites
            // 
            this.Cmb_unites.FormattingEnabled = true;
            this.Cmb_unites.ItemHeight = 23;
            this.Cmb_unites.Location = new System.Drawing.Point(754, 83);
            this.Cmb_unites.Name = "Cmb_unites";
            this.Cmb_unites.Size = new System.Drawing.Size(132, 29);
            this.Cmb_unites.TabIndex = 33;
            this.Cmb_unites.UseSelectable = true;
            // 
            // Txt_qty
            // 
            this.Txt_qty.DecimalPlaces = 2;
            this.Txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_qty.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Txt_qty.Location = new System.Drawing.Point(956, 83);
            this.Txt_qty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Txt_qty.Name = "Txt_qty";
            this.Txt_qty.Size = new System.Drawing.Size(89, 29);
            this.Txt_qty.TabIndex = 34;
            this.Txt_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(892, 83);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 25);
            this.metroLabel8.TabIndex = 35;
            this.metroLabel8.Text = "الكمية";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(205, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 100);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "حفظ";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(58, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 100);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.White;
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "جديد";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(1050, 83);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(75, 35);
            this.btn_AddItem.TabIndex = 40;
            this.btn_AddItem.Text = "إضافة";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(1131, 83);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(61, 35);
            this.btn_remove.TabIndex = 40;
            this.btn_remove.Text = "حذف";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton1.Location = new System.Drawing.Point(58, 535);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(286, 100);
            this.metroButton1.TabIndex = 41;
            this.metroButton1.Text = "حفظ وطباعة";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Movements_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1225, 658);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.Txt_qty);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.Cmb_unites);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.Cmb_items);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movable = false;
            this.Name = "Movements_form";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "الأذونات";
            this.Load += new System.EventHandler(this.Movements_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox reciever;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox place;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Mvt_number;
        private MetroFramework.Controls.MetroDateTime date;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox Cmb_items;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox Cmb_unites;
        private System.Windows.Forms.NumericUpDown Txt_qty;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ComboBox Cmb_stores;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ComboBox Cmb_type;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_qty;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}