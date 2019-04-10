namespace DatabaseManager_lite
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_DatabaseLogin = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_testCon = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_displayData = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_reloadTable = new System.Windows.Forms.Button();
            this.numericUpDown_limit = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label_CurrentId = new System.Windows.Forms.Label();
            this.button_removeEntity = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.txt_mod_prof = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_mod_state = new System.Windows.Forms.ComboBox();
            this.txt_mod_edu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTime_mod_dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mod_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.checkBox_exited = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nameSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_inputData = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.txt_add_prof = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_add_state = new System.Windows.Forms.ComboBox();
            this.txt_add_edu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTime_add_dob = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.txt_add_phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_mod_phone = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_DatabaseLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_displayData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_limit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_inputData.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_DatabaseLogin);
            this.tabControl1.Controls.Add(this.tabPage_displayData);
            this.tabControl1.Controls.Add(this.tabPage_inputData);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1501, 719);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_DatabaseLogin
            // 
            this.tabPage_DatabaseLogin.Controls.Add(this.groupBox1);
            this.tabPage_DatabaseLogin.Location = new System.Drawing.Point(4, 29);
            this.tabPage_DatabaseLogin.Name = "tabPage_DatabaseLogin";
            this.tabPage_DatabaseLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DatabaseLogin.Size = new System.Drawing.Size(1493, 686);
            this.tabPage_DatabaseLogin.TabIndex = 0;
            this.tabPage_DatabaseLogin.Text = "Csatlakozás";
            this.tabPage_DatabaseLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_testCon);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1480, 676);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL szerver információi";
            // 
            // btn_testCon
            // 
            this.btn_testCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testCon.Location = new System.Drawing.Point(597, 485);
            this.btn_testCon.Name = "btn_testCon";
            this.btn_testCon.Size = new System.Drawing.Size(281, 115);
            this.btn_testCon.TabIndex = 3;
            this.btn_testCon.Text = "Csatlakozás tesztelése";
            this.btn_testCon.UseVisualStyleBackColor = true;
            this.btn_testCon.Click += new System.EventHandler(this.Btn_testCon_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(597, 409);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(281, 53);
            this.txt_pass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jelszó";
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(597, 291);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(281, 53);
            this.txt_login.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(597, 172);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(281, 53);
            this.txt_address.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szerver cím (Ha üres, akkor localhost)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login név (Ha üres, akkor root)";
            // 
            // tabPage_displayData
            // 
            this.tabPage_displayData.Controls.Add(this.groupBox4);
            this.tabPage_displayData.Controls.Add(this.groupBox3);
            this.tabPage_displayData.Controls.Add(this.groupBox2);
            this.tabPage_displayData.Controls.Add(this.dataGridView1);
            this.tabPage_displayData.Location = new System.Drawing.Point(4, 29);
            this.tabPage_displayData.Name = "tabPage_displayData";
            this.tabPage_displayData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_displayData.Size = new System.Drawing.Size(1493, 686);
            this.tabPage_displayData.TabIndex = 1;
            this.tabPage_displayData.Text = "Adatok megjelenítése";
            this.tabPage_displayData.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_reloadTable);
            this.groupBox4.Controls.Add(this.numericUpDown_limit);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(1049, 511);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 169);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SQL Beállítások";
            // 
            // button_reloadTable
            // 
            this.button_reloadTable.Location = new System.Drawing.Point(124, 135);
            this.button_reloadTable.Name = "button_reloadTable";
            this.button_reloadTable.Size = new System.Drawing.Size(214, 31);
            this.button_reloadTable.TabIndex = 14;
            this.button_reloadTable.Text = "Táblázat újralekérdezése";
            this.button_reloadTable.UseVisualStyleBackColor = true;
            this.button_reloadTable.Click += new System.EventHandler(this.Button_reloadTable_Click);
            // 
            // numericUpDown_limit
            // 
            this.numericUpDown_limit.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_limit.Location = new System.Drawing.Point(348, 43);
            this.numericUpDown_limit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_limit.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_limit.Name = "numericUpDown_limit";
            this.numericUpDown_limit.Size = new System.Drawing.Size(84, 26);
            this.numericUpDown_limit.TabIndex = 13;
            this.numericUpDown_limit.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_limit.ValueChanged += new System.EventHandler(this.NumericUpDown_limit_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 40);
            this.label13.TabIndex = 0;
            this.label13.Text = "Maximum lekérdezések\r\n(Ezt a keresés funkció felül fogja írni!)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_mod_phone);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label_CurrentId);
            this.groupBox3.Controls.Add(this.button_removeEntity);
            this.groupBox3.Controls.Add(this.button_modify);
            this.groupBox3.Controls.Add(this.txt_mod_prof);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBox_mod_state);
            this.groupBox3.Controls.Add(this.txt_mod_edu);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dateTime_mod_dob);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_mod_name);
            this.groupBox3.Location = new System.Drawing.Point(391, 511);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(652, 169);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adatmódosítás";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 20);
            this.label20.TabIndex = 15;
            this.label20.Text = "ID:";
            // 
            // label_CurrentId
            // 
            this.label_CurrentId.AutoSize = true;
            this.label_CurrentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentId.Location = new System.Drawing.Point(296, 140);
            this.label_CurrentId.Name = "label_CurrentId";
            this.label_CurrentId.Size = new System.Drawing.Size(24, 25);
            this.label_CurrentId.TabIndex = 14;
            this.label_CurrentId.Text = "0";
            // 
            // button_removeEntity
            // 
            this.button_removeEntity.Location = new System.Drawing.Point(413, 131);
            this.button_removeEntity.Name = "button_removeEntity";
            this.button_removeEntity.Size = new System.Drawing.Size(220, 37);
            this.button_removeEntity.TabIndex = 12;
            this.button_removeEntity.Text = "Kiléptetés";
            this.button_removeEntity.UseVisualStyleBackColor = true;
            this.button_removeEntity.Click += new System.EventHandler(this.Button_removeEntity_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(6, 131);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(220, 37);
            this.button_modify.TabIndex = 11;
            this.button_modify.Text = "Módosítás";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.Button_modify_Click);
            // 
            // txt_mod_prof
            // 
            this.txt_mod_prof.Location = new System.Drawing.Point(434, 61);
            this.txt_mod_prof.Name = "txt_mod_prof";
            this.txt_mod_prof.Size = new System.Drawing.Size(199, 26);
            this.txt_mod_prof.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Szakma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Státusz";
            // 
            // comboBox_mod_state
            // 
            this.comboBox_mod_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mod_state.FormattingEnabled = true;
            this.comboBox_mod_state.Items.AddRange(new object[] {
            "Munkába",
            "Munkanélküli"});
            this.comboBox_mod_state.Location = new System.Drawing.Point(434, 91);
            this.comboBox_mod_state.Name = "comboBox_mod_state";
            this.comboBox_mod_state.Size = new System.Drawing.Size(199, 28);
            this.comboBox_mod_state.TabIndex = 10;
            // 
            // txt_mod_edu
            // 
            this.txt_mod_edu.Location = new System.Drawing.Point(434, 29);
            this.txt_mod_edu.Name = "txt_mod_edu";
            this.txt_mod_edu.Size = new System.Drawing.Size(199, 26);
            this.txt_mod_edu.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Végzettség";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Telefonszám";
            // 
            // dateTime_mod_dob
            // 
            this.dateTime_mod_dob.Location = new System.Drawing.Point(111, 61);
            this.dateTime_mod_dob.Name = "dateTime_mod_dob";
            this.dateTime_mod_dob.Size = new System.Drawing.Size(200, 26);
            this.dateTime_mod_dob.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Születési idő";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Név";
            // 
            // txt_mod_name
            // 
            this.txt_mod_name.Location = new System.Drawing.Point(111, 29);
            this.txt_mod_name.Name = "txt_mod_name";
            this.txt_mod_name.Size = new System.Drawing.Size(200, 26);
            this.txt_mod_name.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_search);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker_to);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker_from);
            this.groupBox2.Controls.Add(this.checkBox_exited);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_nameSearch);
            this.groupBox2.Location = new System.Drawing.Point(4, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(266, 102);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(109, 58);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Dátum lekérdezése";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Eddig";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(60, 134);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_to.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ettől";
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(60, 102);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_from.TabIndex = 2;
            this.dateTimePicker_from.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // checkBox_exited
            // 
            this.checkBox_exited.AutoSize = true;
            this.checkBox_exited.Location = new System.Drawing.Point(199, 52);
            this.checkBox_exited.Name = "checkBox_exited";
            this.checkBox_exited.Size = new System.Drawing.Size(176, 24);
            this.checkBox_exited.TabIndex = 1;
            this.checkBox_exited.Text = "Kilépettek mutatása";
            this.checkBox_exited.UseVisualStyleBackColor = true;
            this.checkBox_exited.CheckedChanged += new System.EventHandler(this.CheckBox_exited_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Név keresés";
            // 
            // txt_nameSearch
            // 
            this.txt_nameSearch.Location = new System.Drawing.Point(17, 52);
            this.txt_nameSearch.Name = "txt_nameSearch";
            this.txt_nameSearch.Size = new System.Drawing.Size(125, 26);
            this.txt_nameSearch.TabIndex = 0;
            this.txt_nameSearch.TextChanged += new System.EventHandler(this.Txt_nameSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1481, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // tabPage_inputData
            // 
            this.tabPage_inputData.Controls.Add(this.groupBox5);
            this.tabPage_inputData.Location = new System.Drawing.Point(4, 29);
            this.tabPage_inputData.Name = "tabPage_inputData";
            this.tabPage_inputData.Size = new System.Drawing.Size(1493, 686);
            this.tabPage_inputData.TabIndex = 2;
            this.tabPage_inputData.Text = "Adatfelvétel";
            this.tabPage_inputData.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_add_phone);
            this.groupBox5.Controls.Add(this.button_add);
            this.groupBox5.Controls.Add(this.txt_add_prof);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.comboBox_add_state);
            this.groupBox5.Controls.Add(this.txt_add_edu);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.dateTime_add_dob);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txt_add_name);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1487, 680);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adatfelvétel";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(587, 550);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(311, 96);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Felvétel";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // txt_add_prof
            // 
            this.txt_add_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_prof.Location = new System.Drawing.Point(1010, 221);
            this.txt_add_prof.Name = "txt_add_prof";
            this.txt_add_prof.Size = new System.Drawing.Size(400, 53);
            this.txt_add_prof.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(840, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 46);
            this.label14.TabIndex = 10;
            this.label14.Text = "Szakma";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(851, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 46);
            this.label15.TabIndex = 9;
            this.label15.Text = "Státusz";
            // 
            // comboBox_add_state
            // 
            this.comboBox_add_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_add_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_add_state.FormattingEnabled = true;
            this.comboBox_add_state.Items.AddRange(new object[] {
            "Munkába",
            "Munkanélküli"});
            this.comboBox_add_state.Location = new System.Drawing.Point(1010, 309);
            this.comboBox_add_state.Name = "comboBox_add_state";
            this.comboBox_add_state.Size = new System.Drawing.Size(400, 54);
            this.comboBox_add_state.TabIndex = 5;
            // 
            // txt_add_edu
            // 
            this.txt_add_edu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_edu.Location = new System.Drawing.Point(1010, 125);
            this.txt_add_edu.Name = "txt_add_edu";
            this.txt_add_edu.Size = new System.Drawing.Size(400, 53);
            this.txt_add_edu.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(785, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(219, 46);
            this.label16.TabIndex = 6;
            this.label16.Text = "Végzettség";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(53, 317);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(248, 46);
            this.label17.TabIndex = 4;
            this.label17.Text = "Telefonszám";
            // 
            // dateTime_add_dob
            // 
            this.dateTime_add_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_add_dob.Location = new System.Drawing.Point(307, 219);
            this.dateTime_add_dob.Name = "dateTime_add_dob";
            this.dateTime_add_dob.Size = new System.Drawing.Size(400, 53);
            this.dateTime_add_dob.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(247, 46);
            this.label18.TabIndex = 2;
            this.label18.Text = "Születési idő";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(211, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 46);
            this.label19.TabIndex = 1;
            this.label19.Text = "Név";
            // 
            // txt_add_name
            // 
            this.txt_add_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_name.Location = new System.Drawing.Point(307, 129);
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(400, 53);
            this.txt_add_name.TabIndex = 0;
            // 
            // txt_add_phone
            // 
            this.txt_add_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_phone.Location = new System.Drawing.Point(307, 314);
            this.txt_add_phone.Mask = "(+00) 00 000 0000";
            this.txt_add_phone.Name = "txt_add_phone";
            this.txt_add_phone.Size = new System.Drawing.Size(334, 53);
            this.txt_add_phone.TabIndex = 11;
            // 
            // txt_mod_phone
            // 
            this.txt_mod_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mod_phone.Location = new System.Drawing.Point(112, 93);
            this.txt_mod_phone.Mask = "(+00) 00 000 0000";
            this.txt_mod_phone.Name = "txt_mod_phone";
            this.txt_mod_phone.Size = new System.Drawing.Size(141, 26);
            this.txt_mod_phone.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 744);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nyilvántartás";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_DatabaseLogin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_displayData.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_limit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_inputData.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_DatabaseLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_displayData;
        private System.Windows.Forms.Button btn_testCon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_mod_edu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime_mod_dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mod_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.CheckBox checkBox_exited;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nameSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.TextBox txt_mod_prof;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_mod_state;
        private System.Windows.Forms.Button button_reloadTable;
        private System.Windows.Forms.NumericUpDown numericUpDown_limit;
        private System.Windows.Forms.Button button_removeEntity;
        private System.Windows.Forms.TabPage tabPage_inputData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox txt_add_prof;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_add_state;
        private System.Windows.Forms.TextBox txt_add_edu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTime_add_dob;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_add_name;
        private System.Windows.Forms.Label label_CurrentId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.MaskedTextBox txt_add_phone;
        private System.Windows.Forms.MaskedTextBox txt_mod_phone;
    }
}

