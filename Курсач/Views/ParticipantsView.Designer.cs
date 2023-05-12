namespace Курсач.Views
{
    partial class ParticipantsView
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
            this.tabControlPart = new System.Windows.Forms.TabControl();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnEditPart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.tbSearchPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePartDetail = new System.Windows.Forms.TabPage();
            this.tbPartEmail = new System.Windows.Forms.TextBox();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelPart = new System.Windows.Forms.Button();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPartSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.tabPageRegDetail = new System.Windows.Forms.TabPage();
            this.tabPageRegs = new System.Windows.Forms.TabPage();
            this.tbPART_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConfs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.btnSaveReg = new System.Windows.Forms.Button();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewConf_Part = new System.Windows.Forms.DataGridView();
            this.btnDeleteReg = new System.Windows.Forms.Button();
            this.tabControlPart.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.tabPagePartDetail.SuspendLayout();
            this.tabPageRegDetail.SuspendLayout();
            this.tabPageRegs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConf_Part)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPart
            // 
            this.tabControlPart.Controls.Add(this.tabPageParts);
            this.tabControlPart.Controls.Add(this.tabPagePartDetail);
            this.tabControlPart.Controls.Add(this.tabPageRegDetail);
            this.tabControlPart.Controls.Add(this.tabPageRegs);
            this.tabControlPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlPart.Location = new System.Drawing.Point(0, 0);
            this.tabControlPart.Name = "tabControlPart";
            this.tabControlPart.SelectedIndex = 0;
            this.tabControlPart.Size = new System.Drawing.Size(783, 450);
            this.tabControlPart.TabIndex = 2;
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.btnReg);
            this.tabPageParts.Controls.Add(this.dataGridViewParticipants);
            this.tabPageParts.Controls.Add(this.btnDeletePart);
            this.tabPageParts.Controls.Add(this.btnEditPart);
            this.tabPageParts.Controls.Add(this.btnAddPart);
            this.tabPageParts.Controls.Add(this.btnSearchPart);
            this.tabPageParts.Controls.Add(this.tbSearchPart);
            this.tabPageParts.Controls.Add(this.label1);
            this.tabPageParts.Location = new System.Drawing.Point(4, 27);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParts.Size = new System.Drawing.Size(775, 419);
            this.tabPageParts.TabIndex = 0;
            this.tabPageParts.Text = "Список участников";
            this.tabPageParts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
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
            this.dataGridViewParticipants.Size = new System.Drawing.Size(591, 306);
            this.dataGridViewParticipants.TabIndex = 9;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnDeletePart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletePart.Location = new System.Drawing.Point(618, 160);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(154, 33);
            this.btnDeletePart.TabIndex = 6;
            this.btnDeletePart.Text = "Удалить";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            // 
            // btnEditPart
            // 
            this.btnEditPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnEditPart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditPart.Location = new System.Drawing.Point(618, 121);
            this.btnEditPart.Name = "btnEditPart";
            this.btnEditPart.Size = new System.Drawing.Size(154, 33);
            this.btnEditPart.TabIndex = 5;
            this.btnEditPart.Text = "Редактировать";
            this.btnEditPart.UseVisualStyleBackColor = false;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnAddPart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPart.Location = new System.Drawing.Point(618, 82);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(154, 33);
            this.btnAddPart.TabIndex = 4;
            this.btnAddPart.Text = "Добавить";
            this.btnAddPart.UseVisualStyleBackColor = false;
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSearchPart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearchPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchPart.Location = new System.Drawing.Point(617, 42);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(89, 29);
            this.btnSearchPart.TabIndex = 2;
            this.btnSearchPart.Text = "ОК";
            this.btnSearchPart.UseVisualStyleBackColor = false;
            // 
            // tbSearchPart
            // 
            this.tbSearchPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchPart.Location = new System.Drawing.Point(21, 42);
            this.tbSearchPart.Name = "tbSearchPart";
            this.tbSearchPart.Size = new System.Drawing.Size(590, 27);
            this.tbSearchPart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск участников:";
            // 
            // tabPagePartDetail
            // 
            this.tabPagePartDetail.Controls.Add(this.tbPartEmail);
            this.tabPagePartDetail.Controls.Add(this.tbPartName);
            this.tabPagePartDetail.Controls.Add(this.tbPartID);
            this.tabPagePartDetail.Controls.Add(this.label6);
            this.tabPagePartDetail.Controls.Add(this.btnCancelPart);
            this.tabPagePartDetail.Controls.Add(this.btnSavePart);
            this.tabPagePartDetail.Controls.Add(this.label13);
            this.tabPagePartDetail.Controls.Add(this.label14);
            this.tabPagePartDetail.Controls.Add(this.tbPartSurname);
            this.tabPagePartDetail.Controls.Add(this.label15);
            this.tabPagePartDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPagePartDetail.Name = "tabPagePartDetail";
            this.tabPagePartDetail.Size = new System.Drawing.Size(825, 419);
            this.tabPagePartDetail.TabIndex = 4;
            this.tabPagePartDetail.Text = "Участник";
            this.tabPagePartDetail.UseVisualStyleBackColor = true;
            // 
            // tbPartEmail
            // 
            this.tbPartEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartEmail.Location = new System.Drawing.Point(244, 220);
            this.tbPartEmail.Name = "tbPartEmail";
            this.tbPartEmail.Size = new System.Drawing.Size(380, 27);
            this.tbPartEmail.TabIndex = 42;
            // 
            // tbPartName
            // 
            this.tbPartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartName.Location = new System.Drawing.Point(458, 138);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(166, 27);
            this.tbPartName.TabIndex = 41;
            // 
            // tbPartID
            // 
            this.tbPartID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartID.Location = new System.Drawing.Point(244, 68);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.ReadOnly = true;
            this.tbPartID.Size = new System.Drawing.Size(168, 27);
            this.tbPartID.TabIndex = 36;
            this.tbPartID.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(241, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID участника:";
            // 
            // btnCancelPart
            // 
            this.btnCancelPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnCancelPart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancelPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelPart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelPart.Location = new System.Drawing.Point(493, 285);
            this.btnCancelPart.Name = "btnCancelPart";
            this.btnCancelPart.Size = new System.Drawing.Size(131, 33);
            this.btnCancelPart.TabIndex = 31;
            this.btnCancelPart.Text = "Отмена";
            this.btnCancelPart.UseVisualStyleBackColor = false;
            // 
            // btnSavePart
            // 
            this.btnSavePart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSavePart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSavePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSavePart.Location = new System.Drawing.Point(245, 285);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(131, 33);
            this.btnSavePart.TabIndex = 30;
            this.btnSavePart.Text = "Сохранить";
            this.btnSavePart.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label13.Location = new System.Drawing.Point(454, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Имя:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label14.Location = new System.Drawing.Point(240, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Фамилия:";
            // 
            // tbPartSurname
            // 
            this.tbPartSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartSurname.Location = new System.Drawing.Point(244, 138);
            this.tbPartSurname.Name = "tbPartSurname";
            this.tbPartSurname.Size = new System.Drawing.Size(168, 27);
            this.tbPartSurname.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label15.Location = new System.Drawing.Point(240, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "E-mail:";
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReg.Location = new System.Drawing.Point(618, 199);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(154, 33);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "Зарегистрировать";
            this.btnReg.UseVisualStyleBackColor = false;
            // 
            // tabPageRegDetail
            // 
            this.tabPageRegDetail.Controls.Add(this.label7);
            this.tabPageRegDetail.Controls.Add(this.tbTopic);
            this.tabPageRegDetail.Controls.Add(this.btnCancelReg);
            this.tabPageRegDetail.Controls.Add(this.btnSaveReg);
            this.tabPageRegDetail.Controls.Add(this.label3);
            this.tabPageRegDetail.Controls.Add(this.cbConfs);
            this.tabPageRegDetail.Controls.Add(this.tbPART_ID);
            this.tabPageRegDetail.Controls.Add(this.label2);
            this.tabPageRegDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPageRegDetail.Name = "tabPageRegDetail";
            this.tabPageRegDetail.Size = new System.Drawing.Size(825, 419);
            this.tabPageRegDetail.TabIndex = 5;
            this.tabPageRegDetail.Text = "Регистрация";
            this.tabPageRegDetail.UseVisualStyleBackColor = true;
            // 
            // tabPageRegs
            // 
            this.tabPageRegs.Controls.Add(this.btnDeleteReg);
            this.tabPageRegs.Controls.Add(this.dataGridViewConf_Part);
            this.tabPageRegs.Location = new System.Drawing.Point(4, 27);
            this.tabPageRegs.Name = "tabPageRegs";
            this.tabPageRegs.Size = new System.Drawing.Size(825, 419);
            this.tabPageRegs.TabIndex = 6;
            this.tabPageRegs.Text = "Зарегистрированные участники";
            this.tabPageRegs.UseVisualStyleBackColor = true;
            // 
            // tbPART_ID
            // 
            this.tbPART_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPART_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPART_ID.Location = new System.Drawing.Point(306, 76);
            this.tbPART_ID.Name = "tbPART_ID";
            this.tbPART_ID.ReadOnly = true;
            this.tbPART_ID.Size = new System.Drawing.Size(168, 27);
            this.tbPART_ID.TabIndex = 38;
            this.tbPART_ID.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(302, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID участника:";
            // 
            // cbConfs
            // 
            this.cbConfs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbConfs.FormattingEnabled = true;
            this.cbConfs.Location = new System.Drawing.Point(306, 170);
            this.cbConfs.Name = "cbConfs";
            this.cbConfs.Size = new System.Drawing.Size(168, 26);
            this.cbConfs.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(302, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Выберите конференцию:";
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnCancelReg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancelReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelReg.Location = new System.Drawing.Point(517, 312);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(131, 33);
            this.btnCancelReg.TabIndex = 42;
            this.btnCancelReg.Text = "Отмена";
            this.btnCancelReg.UseVisualStyleBackColor = false;
            // 
            // btnSaveReg
            // 
            this.btnSaveReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSaveReg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveReg.Location = new System.Drawing.Point(306, 312);
            this.btnSaveReg.Name = "btnSaveReg";
            this.btnSaveReg.Size = new System.Drawing.Size(131, 33);
            this.btnSaveReg.TabIndex = 41;
            this.btnSaveReg.Text = "Сохранить";
            this.btnSaveReg.UseVisualStyleBackColor = false;
            // 
            // tbTopic
            // 
            this.tbTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTopic.Location = new System.Drawing.Point(306, 247);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(342, 27);
            this.tbTopic.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(302, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Тема доклада:";
            // 
            // dataGridViewConf_Part
            // 
            this.dataGridViewConf_Part.AllowUserToAddRows = false;
            this.dataGridViewConf_Part.AllowUserToDeleteRows = false;
            this.dataGridViewConf_Part.AllowUserToResizeRows = false;
            this.dataGridViewConf_Part.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConf_Part.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConf_Part.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewConf_Part.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewConf_Part.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewConf_Part.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConf_Part.Location = new System.Drawing.Point(25, 54);
            this.dataGridViewConf_Part.Name = "dataGridViewConf_Part";
            this.dataGridViewConf_Part.ReadOnly = true;
            this.dataGridViewConf_Part.RowHeadersWidth = 51;
            this.dataGridViewConf_Part.RowTemplate.Height = 24;
            this.dataGridViewConf_Part.Size = new System.Drawing.Size(577, 328);
            this.dataGridViewConf_Part.TabIndex = 10;
            // 
            // btnDeleteReg
            // 
            this.btnDeleteReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnDeleteReg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteReg.Location = new System.Drawing.Point(626, 54);
            this.btnDeleteReg.Name = "btnDeleteReg";
            this.btnDeleteReg.Size = new System.Drawing.Size(143, 36);
            this.btnDeleteReg.TabIndex = 12;
            this.btnDeleteReg.Text = "Удалить";
            this.btnDeleteReg.UseVisualStyleBackColor = false;
            // 
            // ParticipantsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.tabControlPart);
            this.Name = "ParticipantsView";
            this.Text = "ParticipantsView";
            this.tabControlPart.ResumeLayout(false);
            this.tabPageParts.ResumeLayout(false);
            this.tabPageParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.tabPagePartDetail.ResumeLayout(false);
            this.tabPagePartDetail.PerformLayout();
            this.tabPageRegDetail.ResumeLayout(false);
            this.tabPageRegDetail.PerformLayout();
            this.tabPageRegs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConf_Part)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPart;
        private System.Windows.Forms.TabPage tabPageParts;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnEditPart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.TextBox tbSearchPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPagePartDetail;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelPart;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPartSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPartEmail;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TabPage tabPageRegDetail;
        private System.Windows.Forms.Button btnCancelReg;
        private System.Windows.Forms.Button btnSaveReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbConfs;
        private System.Windows.Forms.TextBox tbPART_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageRegs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.Button btnDeleteReg;
        private System.Windows.Forms.DataGridView dataGridViewConf_Part;
    }
}