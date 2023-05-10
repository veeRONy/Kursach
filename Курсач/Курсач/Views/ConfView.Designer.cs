namespace Курсач.Views
{
    partial class ConfView
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
            this.tabControlDB = new System.Windows.Forms.TabControl();
            this.tabPageConfs = new System.Windows.Forms.TabPage();
            this.dataGridViewConfs = new System.Windows.Forms.DataGridView();
            this.btnShowParticipants = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchConf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageParticipants = new System.Windows.Forms.TabPage();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            this.btnEditParticipant = new System.Windows.Forms.Button();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.btnSearchParticipant = new System.Windows.Forms.Button();
            this.tbSearchParticipant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageOrgDetail = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageParticipantDetail = new System.Windows.Forms.TabPage();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageConfDetail = new System.Windows.Forms.TabPage();
            this.tbConfTime = new System.Windows.Forms.MaskedTextBox();
            this.tbConfDate = new System.Windows.Forms.MaskedTextBox();
            this.tbConfMax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbConfOrg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConfID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelConf = new System.Windows.Forms.Button();
            this.btnSaveConf = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbConfAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbConfTopic = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControlDB.SuspendLayout();
            this.tabPageConfs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfs)).BeginInit();
            this.tabPageParticipants.SuspendLayout();
            this.tabPageOrgDetail.SuspendLayout();
            this.tabPageParticipantDetail.SuspendLayout();
            this.tabPageConfDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDB
            // 
            this.tabControlDB.Controls.Add(this.tabPageConfs);
            this.tabControlDB.Controls.Add(this.tabPageParticipants);
            this.tabControlDB.Controls.Add(this.tabPageOrgDetail);
            this.tabControlDB.Controls.Add(this.tabPageParticipantDetail);
            this.tabControlDB.Controls.Add(this.tabPageConfDetail);
            this.tabControlDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlDB.Location = new System.Drawing.Point(0, 0);
            this.tabControlDB.Name = "tabControlDB";
            this.tabControlDB.SelectedIndex = 0;
            this.tabControlDB.Size = new System.Drawing.Size(837, 501);
            this.tabControlDB.TabIndex = 1;
            // 
            // tabPageConfs
            // 
            this.tabPageConfs.Controls.Add(this.dataGridViewConfs);
            this.tabPageConfs.Controls.Add(this.btnShowParticipants);
            this.tabPageConfs.Controls.Add(this.btnDelete);
            this.tabPageConfs.Controls.Add(this.btnEdit);
            this.tabPageConfs.Controls.Add(this.btnAdd);
            this.tabPageConfs.Controls.Add(this.btnSearch);
            this.tabPageConfs.Controls.Add(this.tbSearchConf);
            this.tabPageConfs.Controls.Add(this.label1);
            this.tabPageConfs.Location = new System.Drawing.Point(4, 27);
            this.tabPageConfs.Name = "tabPageConfs";
            this.tabPageConfs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfs.Size = new System.Drawing.Size(829, 470);
            this.tabPageConfs.TabIndex = 0;
            this.tabPageConfs.Text = "Список конференций";
            this.tabPageConfs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConfs
            // 
            this.dataGridViewConfs.AllowUserToAddRows = false;
            this.dataGridViewConfs.AllowUserToDeleteRows = false;
            this.dataGridViewConfs.AllowUserToResizeColumns = false;
            this.dataGridViewConfs.AllowUserToResizeRows = false;
            this.dataGridViewConfs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConfs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConfs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewConfs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewConfs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewConfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfs.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewConfs.Name = "dataGridViewConfs";
            this.dataGridViewConfs.ReadOnly = true;
            this.dataGridViewConfs.RowHeadersWidth = 51;
            this.dataGridViewConfs.RowTemplate.Height = 24;
            this.dataGridViewConfs.Size = new System.Drawing.Size(645, 357);
            this.dataGridViewConfs.TabIndex = 9;
            // 
            // btnShowParticipants
            // 
            this.btnShowParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnShowParticipants.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnShowParticipants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowParticipants.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowParticipants.Location = new System.Drawing.Point(672, 199);
            this.btnShowParticipants.Name = "btnShowParticipants";
            this.btnShowParticipants.Size = new System.Drawing.Size(154, 58);
            this.btnShowParticipants.TabIndex = 7;
            this.btnShowParticipants.Text = "Просмотреть\r\nучастников";
            this.btnShowParticipants.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(672, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(672, 121);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 33);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(672, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(617, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "ОК";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearchConf
            // 
            this.tbSearchConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchConf.Location = new System.Drawing.Point(21, 42);
            this.tbSearchConf.Name = "tbSearchConf";
            this.tbSearchConf.Size = new System.Drawing.Size(590, 27);
            this.tbSearchConf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск конференции:";
            // 
            // tabPageParticipants
            // 
            this.tabPageParticipants.Controls.Add(this.btnBack);
            this.tabPageParticipants.Controls.Add(this.dataGridViewParticipants);
            this.tabPageParticipants.Controls.Add(this.btnDeleteParticipant);
            this.tabPageParticipants.Controls.Add(this.btnEditParticipant);
            this.tabPageParticipants.Controls.Add(this.btnAddParticipant);
            this.tabPageParticipants.Controls.Add(this.btnSearchParticipant);
            this.tabPageParticipants.Controls.Add(this.tbSearchParticipant);
            this.tabPageParticipants.Controls.Add(this.label2);
            this.tabPageParticipants.Location = new System.Drawing.Point(4, 27);
            this.tabPageParticipants.Name = "tabPageParticipants";
            this.tabPageParticipants.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParticipants.Size = new System.Drawing.Size(829, 470);
            this.tabPageParticipants.TabIndex = 1;
            this.tabPageParticipants.Text = "Список участников";
            this.tabPageParticipants.UseVisualStyleBackColor = true;
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnDeleteParticipant.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteParticipant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteParticipant.Location = new System.Drawing.Point(672, 160);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(154, 33);
            this.btnDeleteParticipant.TabIndex = 13;
            this.btnDeleteParticipant.Text = "Удалить";
            this.btnDeleteParticipant.UseVisualStyleBackColor = false;
            // 
            // btnEditParticipant
            // 
            this.btnEditParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnEditParticipant.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditParticipant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditParticipant.Location = new System.Drawing.Point(672, 121);
            this.btnEditParticipant.Name = "btnEditParticipant";
            this.btnEditParticipant.Size = new System.Drawing.Size(154, 33);
            this.btnEditParticipant.TabIndex = 12;
            this.btnEditParticipant.Text = "Редактировать";
            this.btnEditParticipant.UseVisualStyleBackColor = false;
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnAddParticipant.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAddParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddParticipant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddParticipant.Location = new System.Drawing.Point(672, 82);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(154, 33);
            this.btnAddParticipant.TabIndex = 11;
            this.btnAddParticipant.Text = "Добавить";
            this.btnAddParticipant.UseVisualStyleBackColor = false;
            // 
            // btnSearchParticipant
            // 
            this.btnSearchParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSearchParticipant.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearchParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchParticipant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchParticipant.Location = new System.Drawing.Point(617, 42);
            this.btnSearchParticipant.Name = "btnSearchParticipant";
            this.btnSearchParticipant.Size = new System.Drawing.Size(89, 29);
            this.btnSearchParticipant.TabIndex = 9;
            this.btnSearchParticipant.Text = "ОК";
            this.btnSearchParticipant.UseVisualStyleBackColor = false;
            // 
            // tbSearchParticipant
            // 
            this.tbSearchParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchParticipant.Location = new System.Drawing.Point(21, 42);
            this.tbSearchParticipant.Name = "tbSearchParticipant";
            this.tbSearchParticipant.Size = new System.Drawing.Size(590, 27);
            this.tbSearchParticipant.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск участников:";
            // 
            // tabPageOrgDetail
            // 
            this.tabPageOrgDetail.Controls.Add(this.button10);
            this.tabPageOrgDetail.Controls.Add(this.button9);
            this.tabPageOrgDetail.Controls.Add(this.textBox5);
            this.tabPageOrgDetail.Controls.Add(this.label5);
            this.tabPageOrgDetail.Controls.Add(this.textBox4);
            this.tabPageOrgDetail.Controls.Add(this.label4);
            this.tabPageOrgDetail.Controls.Add(this.textBox3);
            this.tabPageOrgDetail.Controls.Add(this.label3);
            this.tabPageOrgDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPageOrgDetail.Name = "tabPageOrgDetail";
            this.tabPageOrgDetail.Size = new System.Drawing.Size(829, 470);
            this.tabPageOrgDetail.TabIndex = 2;
            this.tabPageOrgDetail.Text = "Организатор";
            this.tabPageOrgDetail.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(461, 282);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 33);
            this.button10.TabIndex = 9;
            this.button10.Text = "Отмена";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(246, 282);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 33);
            this.button9.TabIndex = 8;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(246, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 27);
            this.textBox5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(242, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(246, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(346, 27);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(242, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-mail:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(246, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 27);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(242, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия:";
            // 
            // tabPageParticipantDetail
            // 
            this.tabPageParticipantDetail.Controls.Add(this.textBox11);
            this.tabPageParticipantDetail.Controls.Add(this.label11);
            this.tabPageParticipantDetail.Controls.Add(this.button11);
            this.tabPageParticipantDetail.Controls.Add(this.button12);
            this.tabPageParticipantDetail.Controls.Add(this.textBox8);
            this.tabPageParticipantDetail.Controls.Add(this.label8);
            this.tabPageParticipantDetail.Controls.Add(this.textBox9);
            this.tabPageParticipantDetail.Controls.Add(this.label9);
            this.tabPageParticipantDetail.Controls.Add(this.textBox10);
            this.tabPageParticipantDetail.Controls.Add(this.label10);
            this.tabPageParticipantDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPageParticipantDetail.Name = "tabPageParticipantDetail";
            this.tabPageParticipantDetail.Size = new System.Drawing.Size(811, 454);
            this.tabPageParticipantDetail.TabIndex = 3;
            this.tabPageParticipantDetail.Text = "Участник";
            this.tabPageParticipantDetail.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(237, 292);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(346, 27);
            this.textBox11.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label11.Location = new System.Drawing.Point(233, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Тема доклада:";
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(452, 349);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 33);
            this.button11.TabIndex = 19;
            this.button11.Text = "Отмена";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Location = new System.Drawing.Point(237, 349);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 33);
            this.button12.TabIndex = 18;
            this.button12.Text = "Сохранить";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(237, 132);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(166, 27);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(233, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Имя:";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(237, 212);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(346, 27);
            this.textBox9.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label9.Location = new System.Drawing.Point(233, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "E-mail:";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(237, 52);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(166, 27);
            this.textBox10.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label10.Location = new System.Drawing.Point(233, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Фамилия:";
            // 
            // tabPageConfDetail
            // 
            this.tabPageConfDetail.Controls.Add(this.tbConfTime);
            this.tabPageConfDetail.Controls.Add(this.tbConfDate);
            this.tabPageConfDetail.Controls.Add(this.tbConfMax);
            this.tabPageConfDetail.Controls.Add(this.label17);
            this.tabPageConfDetail.Controls.Add(this.tbConfOrg);
            this.tabPageConfDetail.Controls.Add(this.label7);
            this.tabPageConfDetail.Controls.Add(this.tbConfID);
            this.tabPageConfDetail.Controls.Add(this.label6);
            this.tabPageConfDetail.Controls.Add(this.btnCancelConf);
            this.tabPageConfDetail.Controls.Add(this.btnSaveConf);
            this.tabPageConfDetail.Controls.Add(this.label13);
            this.tabPageConfDetail.Controls.Add(this.label14);
            this.tabPageConfDetail.Controls.Add(this.tbConfAddress);
            this.tabPageConfDetail.Controls.Add(this.label15);
            this.tabPageConfDetail.Controls.Add(this.tbConfTopic);
            this.tabPageConfDetail.Controls.Add(this.label16);
            this.tabPageConfDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPageConfDetail.Name = "tabPageConfDetail";
            this.tabPageConfDetail.Size = new System.Drawing.Size(829, 470);
            this.tabPageConfDetail.TabIndex = 4;
            this.tabPageConfDetail.Text = "Конференция";
            this.tabPageConfDetail.UseVisualStyleBackColor = true;
            // 
            // tbConfTime
            // 
            this.tbConfTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfTime.Location = new System.Drawing.Point(459, 200);
            this.tbConfTime.Mask = "00:00";
            this.tbConfTime.Name = "tbConfTime";
            this.tbConfTime.Size = new System.Drawing.Size(166, 27);
            this.tbConfTime.TabIndex = 42;
            this.tbConfTime.ValidatingType = typeof(System.DateTime);
            // 
            // tbConfDate
            // 
            this.tbConfDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfDate.Location = new System.Drawing.Point(245, 200);
            this.tbConfDate.Mask = "00/00/0000";
            this.tbConfDate.Name = "tbConfDate";
            this.tbConfDate.Size = new System.Drawing.Size(167, 27);
            this.tbConfDate.TabIndex = 41;
            this.tbConfDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbConfMax
            // 
            this.tbConfMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfMax.Location = new System.Drawing.Point(246, 344);
            this.tbConfMax.Name = "tbConfMax";
            this.tbConfMax.Size = new System.Drawing.Size(159, 27);
            this.tbConfMax.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label17.Location = new System.Drawing.Point(241, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Макс. количество:";
            // 
            // tbConfOrg
            // 
            this.tbConfOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfOrg.Location = new System.Drawing.Point(459, 60);
            this.tbConfOrg.Name = "tbConfOrg";
            this.tbConfOrg.Size = new System.Drawing.Size(166, 27);
            this.tbConfOrg.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(455, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID организатора:";
            // 
            // tbConfID
            // 
            this.tbConfID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfID.Location = new System.Drawing.Point(245, 60);
            this.tbConfID.Name = "tbConfID";
            this.tbConfID.ReadOnly = true;
            this.tbConfID.Size = new System.Drawing.Size(168, 27);
            this.tbConfID.TabIndex = 36;
            this.tbConfID.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(242, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID конференции:";
            // 
            // btnCancelConf
            // 
            this.btnCancelConf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnCancelConf.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancelConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelConf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelConf.Location = new System.Drawing.Point(494, 396);
            this.btnCancelConf.Name = "btnCancelConf";
            this.btnCancelConf.Size = new System.Drawing.Size(131, 33);
            this.btnCancelConf.TabIndex = 31;
            this.btnCancelConf.Text = "Отмена";
            this.btnCancelConf.UseVisualStyleBackColor = false;
            // 
            // btnSaveConf
            // 
            this.btnSaveConf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSaveConf.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveConf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveConf.Location = new System.Drawing.Point(245, 396);
            this.btnSaveConf.Name = "btnSaveConf";
            this.btnSaveConf.Size = new System.Drawing.Size(131, 33);
            this.btnSaveConf.TabIndex = 30;
            this.btnSaveConf.Text = "Сохранить";
            this.btnSaveConf.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label13.Location = new System.Drawing.Point(455, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Время:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label14.Location = new System.Drawing.Point(242, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Дата:";
            // 
            // tbConfAddress
            // 
            this.tbConfAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfAddress.Location = new System.Drawing.Point(246, 270);
            this.tbConfAddress.Name = "tbConfAddress";
            this.tbConfAddress.Size = new System.Drawing.Size(379, 27);
            this.tbConfAddress.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label15.Location = new System.Drawing.Point(242, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Адрес:";
            // 
            // tbConfTopic
            // 
            this.tbConfTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConfTopic.Location = new System.Drawing.Point(245, 130);
            this.tbConfTopic.Name = "tbConfTopic";
            this.tbConfTopic.Size = new System.Drawing.Size(380, 27);
            this.tbConfTopic.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label16.Location = new System.Drawing.Point(242, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Тема:";
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            this.dataGridViewParticipants.AllowUserToResizeColumns = false;
            this.dataGridViewParticipants.AllowUserToResizeRows = false;
            this.dataGridViewParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.ReadOnly = true;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(645, 357);
            this.dataGridViewParticipants.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(672, 199);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 33);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // ConfView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 501);
            this.Controls.Add(this.tabControlDB);
            this.Name = "ConfView";
            this.Text = "База данных";
            this.tabControlDB.ResumeLayout(false);
            this.tabPageConfs.ResumeLayout(false);
            this.tabPageConfs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfs)).EndInit();
            this.tabPageParticipants.ResumeLayout(false);
            this.tabPageParticipants.PerformLayout();
            this.tabPageOrgDetail.ResumeLayout(false);
            this.tabPageOrgDetail.PerformLayout();
            this.tabPageParticipantDetail.ResumeLayout(false);
            this.tabPageParticipantDetail.PerformLayout();
            this.tabPageConfDetail.ResumeLayout(false);
            this.tabPageConfDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDB;
        private System.Windows.Forms.TabPage tabPageConfs;
        private System.Windows.Forms.DataGridView dataGridViewConfs;
        private System.Windows.Forms.Button btnShowParticipants;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageParticipants;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.Button btnEditParticipant;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Button btnSearchParticipant;
        private System.Windows.Forms.TextBox tbSearchParticipant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageOrgDetail;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageParticipantDetail;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageConfDetail;
        private System.Windows.Forms.MaskedTextBox tbConfTime;
        private System.Windows.Forms.MaskedTextBox tbConfDate;
        private System.Windows.Forms.TextBox tbConfMax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbConfOrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbConfID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelConf;
        private System.Windows.Forms.Button btnSaveConf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbConfAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbConfTopic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
    }
}