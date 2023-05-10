namespace Курсач.Views
{
    partial class OrgView
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
            this.tabControlOrgs = new System.Windows.Forms.TabControl();
            this.tabPageOrgs = new System.Windows.Forms.TabPage();
            this.dataGridViewOrgs = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrg = new System.Windows.Forms.Button();
            this.btnEditOrg = new System.Windows.Forms.Button();
            this.btnAddOrg = new System.Windows.Forms.Button();
            this.btnSearchOrg = new System.Windows.Forms.Button();
            this.tbSearchOrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageOrgDetail = new System.Windows.Forms.TabPage();
            this.tbConf_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOrgID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelOrg = new System.Windows.Forms.Button();
            this.btnSaveOrg = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbOrgName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrgSurname = new System.Windows.Forms.TextBox();
            this.tbOrgEmail = new System.Windows.Forms.TextBox();
            this.tabControlOrgs.SuspendLayout();
            this.tabPageOrgs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrgs)).BeginInit();
            this.tabPageOrgDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOrgs
            // 
            this.tabControlOrgs.Controls.Add(this.tabPageOrgs);
            this.tabControlOrgs.Controls.Add(this.tabPageOrgDetail);
            this.tabControlOrgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOrgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlOrgs.Location = new System.Drawing.Point(0, 0);
            this.tabControlOrgs.Name = "tabControlOrgs";
            this.tabControlOrgs.SelectedIndex = 0;
            this.tabControlOrgs.Size = new System.Drawing.Size(835, 483);
            this.tabControlOrgs.TabIndex = 2;
            // 
            // tabPageOrgs
            // 
            this.tabPageOrgs.Controls.Add(this.dataGridViewOrgs);
            this.tabPageOrgs.Controls.Add(this.btnDeleteOrg);
            this.tabPageOrgs.Controls.Add(this.btnEditOrg);
            this.tabPageOrgs.Controls.Add(this.btnAddOrg);
            this.tabPageOrgs.Controls.Add(this.btnSearchOrg);
            this.tabPageOrgs.Controls.Add(this.tbSearchOrg);
            this.tabPageOrgs.Controls.Add(this.label1);
            this.tabPageOrgs.Location = new System.Drawing.Point(4, 27);
            this.tabPageOrgs.Name = "tabPageOrgs";
            this.tabPageOrgs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrgs.Size = new System.Drawing.Size(827, 452);
            this.tabPageOrgs.TabIndex = 0;
            this.tabPageOrgs.Text = "Список организаторов";
            this.tabPageOrgs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrgs
            // 
            this.dataGridViewOrgs.AllowUserToAddRows = false;
            this.dataGridViewOrgs.AllowUserToDeleteRows = false;
            this.dataGridViewOrgs.AllowUserToResizeColumns = false;
            this.dataGridViewOrgs.AllowUserToResizeRows = false;
            this.dataGridViewOrgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrgs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrgs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewOrgs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewOrgs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOrgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrgs.Location = new System.Drawing.Point(21, 82);
            this.dataGridViewOrgs.Name = "dataGridViewOrgs";
            this.dataGridViewOrgs.ReadOnly = true;
            this.dataGridViewOrgs.RowHeadersWidth = 51;
            this.dataGridViewOrgs.RowTemplate.Height = 24;
            this.dataGridViewOrgs.Size = new System.Drawing.Size(643, 339);
            this.dataGridViewOrgs.TabIndex = 9;
            // 
            // btnDeleteOrg
            // 
            this.btnDeleteOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnDeleteOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteOrg.Location = new System.Drawing.Point(670, 160);
            this.btnDeleteOrg.Name = "btnDeleteOrg";
            this.btnDeleteOrg.Size = new System.Drawing.Size(154, 33);
            this.btnDeleteOrg.TabIndex = 6;
            this.btnDeleteOrg.Text = "Удалить";
            this.btnDeleteOrg.UseVisualStyleBackColor = false;
            // 
            // btnEditOrg
            // 
            this.btnEditOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnEditOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnEditOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditOrg.Location = new System.Drawing.Point(670, 121);
            this.btnEditOrg.Name = "btnEditOrg";
            this.btnEditOrg.Size = new System.Drawing.Size(154, 33);
            this.btnEditOrg.TabIndex = 5;
            this.btnEditOrg.Text = "Редактировать";
            this.btnEditOrg.UseVisualStyleBackColor = false;
            // 
            // btnAddOrg
            // 
            this.btnAddOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnAddOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAddOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOrg.Location = new System.Drawing.Point(670, 82);
            this.btnAddOrg.Name = "btnAddOrg";
            this.btnAddOrg.Size = new System.Drawing.Size(154, 33);
            this.btnAddOrg.TabIndex = 4;
            this.btnAddOrg.Text = "Добавить";
            this.btnAddOrg.UseVisualStyleBackColor = false;
            // 
            // btnSearchOrg
            // 
            this.btnSearchOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSearchOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSearchOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchOrg.Location = new System.Drawing.Point(617, 42);
            this.btnSearchOrg.Name = "btnSearchOrg";
            this.btnSearchOrg.Size = new System.Drawing.Size(89, 29);
            this.btnSearchOrg.TabIndex = 2;
            this.btnSearchOrg.Text = "ОК";
            this.btnSearchOrg.UseVisualStyleBackColor = false;
            // 
            // tbSearchOrg
            // 
            this.tbSearchOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchOrg.Location = new System.Drawing.Point(21, 42);
            this.tbSearchOrg.Name = "tbSearchOrg";
            this.tbSearchOrg.Size = new System.Drawing.Size(590, 27);
            this.tbSearchOrg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск организаторов:";
            // 
            // tabPageOrgDetail
            // 
            this.tabPageOrgDetail.Controls.Add(this.tbOrgEmail);
            this.tabPageOrgDetail.Controls.Add(this.tbOrgName);
            this.tabPageOrgDetail.Controls.Add(this.label2);
            this.tabPageOrgDetail.Controls.Add(this.label3);
            this.tabPageOrgDetail.Controls.Add(this.tbOrgSurname);
            this.tabPageOrgDetail.Controls.Add(this.tbConf_ID);
            this.tabPageOrgDetail.Controls.Add(this.label7);
            this.tabPageOrgDetail.Controls.Add(this.tbOrgID);
            this.tabPageOrgDetail.Controls.Add(this.label6);
            this.tabPageOrgDetail.Controls.Add(this.btnCancelOrg);
            this.tabPageOrgDetail.Controls.Add(this.btnSaveOrg);
            this.tabPageOrgDetail.Controls.Add(this.label14);
            this.tabPageOrgDetail.Controls.Add(this.tbCompany);
            this.tabPageOrgDetail.Controls.Add(this.label15);
            this.tabPageOrgDetail.Location = new System.Drawing.Point(4, 27);
            this.tabPageOrgDetail.Name = "tabPageOrgDetail";
            this.tabPageOrgDetail.Size = new System.Drawing.Size(827, 452);
            this.tabPageOrgDetail.TabIndex = 4;
            this.tabPageOrgDetail.Text = "Организатор";
            this.tabPageOrgDetail.UseVisualStyleBackColor = true;
            // 
            // tbConf_ID
            // 
            this.tbConf_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConf_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConf_ID.Location = new System.Drawing.Point(458, 51);
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
            this.label7.Location = new System.Drawing.Point(454, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID конференции:";
            // 
            // tbOrgID
            // 
            this.tbOrgID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOrgID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrgID.Location = new System.Drawing.Point(244, 51);
            this.tbOrgID.Name = "tbOrgID";
            this.tbOrgID.ReadOnly = true;
            this.tbOrgID.Size = new System.Drawing.Size(168, 27);
            this.tbOrgID.TabIndex = 36;
            this.tbOrgID.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(241, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID организатора:";
            // 
            // btnCancelOrg
            // 
            this.btnCancelOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnCancelOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancelOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelOrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelOrg.Location = new System.Drawing.Point(493, 335);
            this.btnCancelOrg.Name = "btnCancelOrg";
            this.btnCancelOrg.Size = new System.Drawing.Size(131, 33);
            this.btnCancelOrg.TabIndex = 31;
            this.btnCancelOrg.Text = "Отмена";
            this.btnCancelOrg.UseVisualStyleBackColor = false;
            // 
            // btnSaveOrg
            // 
            this.btnSaveOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.btnSaveOrg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSaveOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveOrg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveOrg.Location = new System.Drawing.Point(245, 335);
            this.btnSaveOrg.Name = "btnSaveOrg";
            this.btnSaveOrg.Size = new System.Drawing.Size(131, 33);
            this.btnSaveOrg.TabIndex = 30;
            this.btnSaveOrg.Text = "Сохранить";
            this.btnSaveOrg.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label14.Location = new System.Drawing.Point(241, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "E-mail:";
            // 
            // tbCompany
            // 
            this.tbCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCompany.Location = new System.Drawing.Point(245, 261);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(379, 27);
            this.tbCompany.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label15.Location = new System.Drawing.Point(241, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Организация:";
            // 
            // tbOrgName
            // 
            this.tbOrgName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrgName.Location = new System.Drawing.Point(458, 121);
            this.tbOrgName.Name = "tbOrgName";
            this.tbOrgName.Size = new System.Drawing.Size(166, 27);
            this.tbOrgName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(454, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(241, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Фамилия:";
            // 
            // tbOrgSurname
            // 
            this.tbOrgSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOrgSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrgSurname.Location = new System.Drawing.Point(245, 121);
            this.tbOrgSurname.Name = "tbOrgSurname";
            this.tbOrgSurname.Size = new System.Drawing.Size(168, 27);
            this.tbOrgSurname.TabIndex = 43;
            // 
            // tbOrgEmail
            // 
            this.tbOrgEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOrgEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrgEmail.Location = new System.Drawing.Point(245, 191);
            this.tbOrgEmail.Name = "tbOrgEmail";
            this.tbOrgEmail.Size = new System.Drawing.Size(379, 27);
            this.tbOrgEmail.TabIndex = 47;
            // 
            // OrgView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 483);
            this.Controls.Add(this.tabControlOrgs);
            this.Name = "OrgView";
            this.Text = "OrgView";
            this.tabControlOrgs.ResumeLayout(false);
            this.tabPageOrgs.ResumeLayout(false);
            this.tabPageOrgs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrgs)).EndInit();
            this.tabPageOrgDetail.ResumeLayout(false);
            this.tabPageOrgDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOrgs;
        private System.Windows.Forms.TabPage tabPageOrgs;
        private System.Windows.Forms.DataGridView dataGridViewOrgs;
        private System.Windows.Forms.Button btnDeleteOrg;
        private System.Windows.Forms.Button btnEditOrg;
        private System.Windows.Forms.Button btnAddOrg;
        private System.Windows.Forms.Button btnSearchOrg;
        private System.Windows.Forms.TextBox tbSearchOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageOrgDetail;
        private System.Windows.Forms.TextBox tbConf_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrgID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelOrg;
        private System.Windows.Forms.Button btnSaveOrg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbOrgEmail;
        private System.Windows.Forms.TextBox tbOrgName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrgSurname;
    }
}