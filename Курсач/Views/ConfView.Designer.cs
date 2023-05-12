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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchConf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageConfDetail = new System.Windows.Forms.TabPage();
            this.tbConfTime = new System.Windows.Forms.MaskedTextBox();
            this.tbConfDate = new System.Windows.Forms.MaskedTextBox();
            this.tbConfMax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.cbOrgs = new System.Windows.Forms.ComboBox();
            this.tabControlDB.SuspendLayout();
            this.tabPageConfs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfs)).BeginInit();
            this.tabPageConfDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDB
            // 
            this.tabControlDB.Controls.Add(this.tabPageConfs);
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
            // tabPageConfDetail
            // 
            this.tabPageConfDetail.Controls.Add(this.cbOrgs);
            this.tabPageConfDetail.Controls.Add(this.tbConfTime);
            this.tabPageConfDetail.Controls.Add(this.tbConfDate);
            this.tabPageConfDetail.Controls.Add(this.tbConfMax);
            this.tabPageConfDetail.Controls.Add(this.label17);
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
            this.tbConfMax.Size = new System.Drawing.Size(167, 27);
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
            // cbOrgs
            // 
            this.cbOrgs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOrgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOrgs.FormatString = "N0";
            this.cbOrgs.FormattingEnabled = true;
            this.cbOrgs.Location = new System.Drawing.Point(459, 59);
            this.cbOrgs.Name = "cbOrgs";
            this.cbOrgs.Size = new System.Drawing.Size(166, 28);
            this.cbOrgs.TabIndex = 45;
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
            this.tabPageConfDetail.ResumeLayout(false);
            this.tabPageConfDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDB;
        private System.Windows.Forms.TabPage tabPageConfs;
        private System.Windows.Forms.DataGridView dataGridViewConfs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageConfDetail;
        private System.Windows.Forms.MaskedTextBox tbConfTime;
        private System.Windows.Forms.MaskedTextBox tbConfDate;
        private System.Windows.Forms.TextBox tbConfMax;
        private System.Windows.Forms.Label label17;
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
        private System.Windows.Forms.ComboBox cbOrgs;
    }
}