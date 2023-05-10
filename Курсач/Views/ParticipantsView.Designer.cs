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
            this.tbConf_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelPart = new System.Windows.Forms.Button();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPartSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPartTopic = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.tbPartEmail = new System.Windows.Forms.TextBox();
            this.tabControlPart.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.tabPagePartDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPart
            // 
            this.tabControlPart.Controls.Add(this.tabPageParts);
            this.tabControlPart.Controls.Add(this.tabPagePartDetail);
            this.tabControlPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlPart.Location = new System.Drawing.Point(0, 0);
            this.tabControlPart.Name = "tabControlPart";
            this.tabControlPart.SelectedIndex = 0;
            this.tabControlPart.Size = new System.Drawing.Size(800, 450);
            this.tabControlPart.TabIndex = 2;
            // 
            // tabPageParts
            // 
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
            this.tabPageParts.Size = new System.Drawing.Size(792, 419);
            this.tabPageParts.TabIndex = 0;
            this.tabPageParts.Text = "Список участников";
            this.tabPageParts.UseVisualStyleBackColor = true;
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
            this.dataGridViewParticipants.Size = new System.Drawing.Size(608, 306);
            this.dataGridViewParticipants.TabIndex = 9;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnDeletePart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletePart.Location = new System.Drawing.Point(635, 160);
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
            this.btnEditPart.Location = new System.Drawing.Point(635, 121);
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
            this.btnAddPart.Location = new System.Drawing.Point(635, 82);
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
            this.tabPagePartDetail.Controls.Add(this.tbConf_ID);
            this.tabPagePartDetail.Controls.Add(this.label7);
            this.tabPagePartDetail.Controls.Add(this.tbPartID);
            this.tabPagePartDetail.Controls.Add(this.label6);
            this.tabPagePartDetail.Controls.Add(this.btnCancelPart);
            this.tabPagePartDetail.Controls.Add(this.btnSavePart);
            this.tabPagePartDetail.Controls.Add(this.label13);
            this.tabPagePartDetail.Controls.Add(this.label14);
            this.tabPagePartDetail.Controls.Add(this.tbPartSurname);
            this.tabPagePartDetail.Controls.Add(this.label15);
            this.tabPagePartDetail.Controls.Add(this.tbPartTopic);
            this.tabPagePartDetail.Controls.Add(this.label16);
            this.tabPagePartDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPagePartDetail.Name = "tabPagePartDetail";
            this.tabPagePartDetail.Size = new System.Drawing.Size(792, 419);
            this.tabPagePartDetail.TabIndex = 4;
            this.tabPagePartDetail.Text = "Участник";
            this.tabPagePartDetail.UseVisualStyleBackColor = true;
            // 
            // tbConf_ID
            // 
            this.tbConf_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConf_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConf_ID.Location = new System.Drawing.Point(441, 34);
            this.tbConf_ID.Name = "tbConf_ID";
            this.tbConf_ID.Size = new System.Drawing.Size(166, 27);
            this.tbConf_ID.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(437, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID конференции:";
            // 
            // tbPartID
            // 
            this.tbPartID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartID.Location = new System.Drawing.Point(227, 34);
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
            this.label6.Location = new System.Drawing.Point(224, 11);
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
            this.btnCancelPart.Location = new System.Drawing.Point(476, 309);
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
            this.btnSavePart.Location = new System.Drawing.Point(227, 309);
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
            this.label13.Location = new System.Drawing.Point(437, 81);
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
            this.label14.Location = new System.Drawing.Point(223, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Фамилия:";
            // 
            // tbPartSurname
            // 
            this.tbPartSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartSurname.Location = new System.Drawing.Point(227, 104);
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
            this.label15.Location = new System.Drawing.Point(224, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "E-mail:";
            // 
            // tbPartTopic
            // 
            this.tbPartTopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartTopic.Location = new System.Drawing.Point(227, 174);
            this.tbPartTopic.Name = "tbPartTopic";
            this.tbPartTopic.Size = new System.Drawing.Size(380, 27);
            this.tbPartTopic.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label16.Location = new System.Drawing.Point(224, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Тема доклада:";
            // 
            // tbPartName
            // 
            this.tbPartName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartName.Location = new System.Drawing.Point(441, 104);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(166, 27);
            this.tbPartName.TabIndex = 41;
            // 
            // tbPartEmail
            // 
            this.tbPartEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartEmail.Location = new System.Drawing.Point(227, 244);
            this.tbPartEmail.Name = "tbPartEmail";
            this.tbPartEmail.Size = new System.Drawing.Size(380, 27);
            this.tbPartEmail.TabIndex = 42;
            // 
            // ParticipantsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPart);
            this.Name = "ParticipantsView";
            this.Text = "ParticipantsView";
            this.tabControlPart.ResumeLayout(false);
            this.tabPageParts.ResumeLayout(false);
            this.tabPageParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.tabPagePartDetail.ResumeLayout(false);
            this.tabPagePartDetail.PerformLayout();
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
        private System.Windows.Forms.TextBox tbConf_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelPart;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPartSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPartTopic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbPartEmail;
        private System.Windows.Forms.TextBox tbPartName;
    }
}