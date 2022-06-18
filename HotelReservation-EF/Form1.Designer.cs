
namespace HotelReservation_EF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.roomReservedListBox = new System.Windows.Forms.ListBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.roomOccupiedListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rsrvDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.srchDataGridView = new System.Windows.Forms.DataGridView();
            this.tabReservation = new System.Windows.Forms.TabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtAptNo = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnFinalizeBill = new System.Windows.Forms.Button();
            this.checkBoxFoodSupplyStat = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckIn = new System.Windows.Forms.CheckBox();
            this.btnFoodAndMenu = new System.Windows.Forms.Button();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNoOfGuests = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsrvDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchDataGridView)).BeginInit();
            this.tabReservation.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.metroPanel5);
            this.tabPage4.Controls.Add(this.metroPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1051, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Room Availibility";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(401, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(428, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Room#| Type | ID# | Name | Phone # |  Entry | Depart";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Reserved";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Occupied";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.roomReservedListBox);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(529, 75);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(516, 433);
            this.metroPanel5.TabIndex = 1;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // roomReservedListBox
            // 
            this.roomReservedListBox.FormattingEnabled = true;
            this.roomReservedListBox.ItemHeight = 25;
            this.roomReservedListBox.Location = new System.Drawing.Point(3, 3);
            this.roomReservedListBox.Name = "roomReservedListBox";
            this.roomReservedListBox.Size = new System.Drawing.Size(510, 429);
            this.roomReservedListBox.TabIndex = 2;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.roomOccupiedListBox);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(6, 75);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(517, 433);
            this.metroPanel4.TabIndex = 0;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // roomOccupiedListBox
            // 
            this.roomOccupiedListBox.FormattingEnabled = true;
            this.roomOccupiedListBox.ItemHeight = 25;
            this.roomOccupiedListBox.Location = new System.Drawing.Point(3, 3);
            this.roomOccupiedListBox.Name = "roomOccupiedListBox";
            this.roomOccupiedListBox.Size = new System.Drawing.Size(511, 429);
            this.roomOccupiedListBox.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rsrvDataGridView);
            this.tabPage3.Controls.Add(this.menuStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1051, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservation Adv. View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rsrvDataGridView
            // 
            this.rsrvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rsrvDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rsrvDataGridView.Location = new System.Drawing.Point(3, 36);
            this.rsrvDataGridView.Name = "rsrvDataGridView";
            this.rsrvDataGridView.RowHeadersWidth = 62;
            this.rsrvDataGridView.RowTemplate.Height = 33;
            this.rsrvDataGridView.Size = new System.Drawing.Size(1045, 475);
            this.rsrvDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.srchDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Universal Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::HotelReservation_EF.Properties.Resources.ic_action_search__3_;
            this.btnSearch.Location = new System.Drawing.Point(682, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(262, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(414, 31);
            this.txtSearch.TabIndex = 1;
            // 
            // srchDataGridView
            // 
            this.srchDataGridView.AllowUserToAddRows = false;
            this.srchDataGridView.AllowUserToDeleteRows = false;
            this.srchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srchDataGridView.Location = new System.Drawing.Point(6, 106);
            this.srchDataGridView.Name = "srchDataGridView";
            this.srchDataGridView.ReadOnly = true;
            this.srchDataGridView.RowHeadersWidth = 62;
            this.srchDataGridView.RowTemplate.Height = 33;
            this.srchDataGridView.Size = new System.Drawing.Size(1039, 402);
            this.srchDataGridView.TabIndex = 0;
            // 
            // tabReservation
            // 
            this.tabReservation.Controls.Add(this.metroPanel3);
            this.tabReservation.Controls.Add(this.metroPanel1);
            this.tabReservation.Controls.Add(this.metroPanel2);
            this.tabReservation.Location = new System.Drawing.Point(4, 34);
            this.tabReservation.Name = "tabReservation";
            this.tabReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservation.Size = new System.Drawing.Size(1051, 514);
            this.tabReservation.TabIndex = 0;
            this.tabReservation.Text = "Reservation";
            this.tabReservation.UseVisualStyleBackColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.btnDelete);
            this.metroPanel3.Controls.Add(this.btnUpdate);
            this.metroPanel3.Controls.Add(this.btnNew);
            this.metroPanel3.Controls.Add(this.lstReservations);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(743, 6);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(302, 502);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(293, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(7, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(293, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(7, 337);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(293, 34);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 25;
            this.lstReservations.Location = new System.Drawing.Point(6, 0);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(296, 329);
            this.lstReservations.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.txtState);
            this.metroPanel1.Controls.Add(this.txtZipcode);
            this.metroPanel1.Controls.Add(this.txtAptNo);
            this.metroPanel1.Controls.Add(this.txtCity);
            this.metroPanel1.Controls.Add(this.txtStreet);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.txtPhone);
            this.metroPanel1.Controls.Add(this.txtGender);
            this.metroPanel1.Controls.Add(this.txtBirthDay);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.txtLName);
            this.metroPanel1.Controls.Add(this.txtFName);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(343, 502);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(15, 420);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(150, 31);
            this.txtState.TabIndex = 16;
            this.txtState.Text = "State";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(171, 420);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(150, 31);
            this.txtZipcode.TabIndex = 15;
            this.txtZipcode.Text = "Zipcode";
            // 
            // txtAptNo
            // 
            this.txtAptNo.Location = new System.Drawing.Point(15, 383);
            this.txtAptNo.Name = "txtAptNo";
            this.txtAptNo.Size = new System.Drawing.Size(150, 31);
            this.txtAptNo.TabIndex = 14;
            this.txtAptNo.Text = "Apt./Suite";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(171, 383);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 31);
            this.txtCity.TabIndex = 13;
            this.txtCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(15, 346);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(306, 31);
            this.txtStreet.TabIndex = 12;
            this.txtStreet.Text = "Street Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 31);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 222);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 31);
            this.txtPhone.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(15, 160);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(150, 31);
            this.txtGender.TabIndex = 9;
            this.txtGender.Text = "Male/Female";
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(15, 98);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(306, 31);
            this.txtBirthDay.TabIndex = 7;
            this.txtBirthDay.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Birthday";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(171, 36);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(150, 31);
            this.txtLName.TabIndex = 4;
            this.txtLName.Text = "Last";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(15, 36);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(150, 31);
            this.txtFName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.btnSubmit);
            this.metroPanel2.Controls.Add(this.btnFinalizeBill);
            this.metroPanel2.Controls.Add(this.checkBoxFoodSupplyStat);
            this.metroPanel2.Controls.Add(this.checkBoxCheckIn);
            this.metroPanel2.Controls.Add(this.btnFoodAndMenu);
            this.metroPanel2.Controls.Add(this.txtDepartureDate);
            this.metroPanel2.Controls.Add(this.txtEntryDate);
            this.metroPanel2.Controls.Add(this.txtRoomNo);
            this.metroPanel2.Controls.Add(this.txtFloor);
            this.metroPanel2.Controls.Add(this.txtRoomType);
            this.metroPanel2.Controls.Add(this.txtNoOfGuests);
            this.metroPanel2.Controls.Add(this.label9);
            this.metroPanel2.Controls.Add(this.label8);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(355, 6);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(384, 502);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(5, 418);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(373, 34);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnFinalizeBill
            // 
            this.btnFinalizeBill.Location = new System.Drawing.Point(5, 377);
            this.btnFinalizeBill.Name = "btnFinalizeBill";
            this.btnFinalizeBill.Size = new System.Drawing.Size(373, 34);
            this.btnFinalizeBill.TabIndex = 13;
            this.btnFinalizeBill.Text = "Finalize Bill";
            this.btnFinalizeBill.UseVisualStyleBackColor = true;
            this.btnFinalizeBill.Click += new System.EventHandler(this.btnFinalizeBill_Click);
            // 
            // checkBoxFoodSupplyStat
            // 
            this.checkBoxFoodSupplyStat.AutoSize = true;
            this.checkBoxFoodSupplyStat.Location = new System.Drawing.Point(27, 321);
            this.checkBoxFoodSupplyStat.Name = "checkBoxFoodSupplyStat";
            this.checkBoxFoodSupplyStat.Size = new System.Drawing.Size(203, 29);
            this.checkBoxFoodSupplyStat.TabIndex = 12;
            this.checkBoxFoodSupplyStat.Text = "Food/Supply Status?";
            this.checkBoxFoodSupplyStat.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckIn
            // 
            this.checkBoxCheckIn.AutoSize = true;
            this.checkBoxCheckIn.Location = new System.Drawing.Point(27, 284);
            this.checkBoxCheckIn.Name = "checkBoxCheckIn";
            this.checkBoxCheckIn.Size = new System.Drawing.Size(112, 29);
            this.checkBoxCheckIn.TabIndex = 10;
            this.checkBoxCheckIn.Text = "Check in?";
            this.checkBoxCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnFoodAndMenu
            // 
            this.btnFoodAndMenu.Location = new System.Drawing.Point(18, 234);
            this.btnFoodAndMenu.Name = "btnFoodAndMenu";
            this.btnFoodAndMenu.Size = new System.Drawing.Size(352, 34);
            this.btnFoodAndMenu.TabIndex = 9;
            this.btnFoodAndMenu.Text = "Food and menu";
            this.btnFoodAndMenu.UseVisualStyleBackColor = true;
            this.btnFoodAndMenu.Click += new System.EventHandler(this.btnFoodAndMenu_Click);
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(26, 197);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(150, 31);
            this.txtDepartureDate.TabIndex = 8;
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.Location = new System.Drawing.Point(26, 135);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.Size = new System.Drawing.Size(150, 31);
            this.txtEntryDate.TabIndex = 7;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(193, 73);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(150, 31);
            this.txtRoomNo.TabIndex = 6;
            this.txtRoomNo.Text = "#";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(26, 73);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(150, 31);
            this.txtFloor.TabIndex = 5;
            this.txtFloor.Text = "Floor";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(193, 36);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(150, 31);
            this.txtRoomType.TabIndex = 4;
            this.txtRoomType.Text = "Room Type";
            // 
            // txtNoOfGuests
            // 
            this.txtNoOfGuests.Location = new System.Drawing.Point(26, 36);
            this.txtNoOfGuests.Name = "txtNoOfGuests";
            this.txtNoOfGuests.Size = new System.Drawing.Size(150, 31);
            this.txtNoOfGuests.TabIndex = 3;
            this.txtNoOfGuests.Text = "#No. of guests";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Departure";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Entry Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Your Choices";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabReservation);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(23, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 604);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsrvDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srchDataGridView)).EndInit();
            this.tabReservation.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabReservation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox lstReservations;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtAptNo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtBirthDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnFinalizeBill;
        private System.Windows.Forms.CheckBox checkBoxFoodSupplyStat;
        private System.Windows.Forms.CheckBox checkBoxCheckIn;
        private System.Windows.Forms.Button btnFoodAndMenu;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtEntryDate;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNoOfGuests;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView srchDataGridView;
        private System.Windows.Forms.DataGridView rsrvDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
    }
}

