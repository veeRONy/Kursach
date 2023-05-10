namespace Курсач.Views
{
    partial class MainView
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnConfs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.btnDB);
            this.panelMenu.Controls.Add(this.btnConfs);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 563);
            this.panelMenu.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::Курсач.Properties.Resources.info;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 222);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(237, 64);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "  Справка";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // btnDB
            // 
            this.btnDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDB.FlatAppearance.BorderSize = 0;
            this.btnDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDB.ForeColor = System.Drawing.Color.White;
            this.btnDB.Image = global::Курсач.Properties.Resources.database;
            this.btnDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDB.Location = new System.Drawing.Point(0, 158);
            this.btnDB.Name = "btnDB";
            this.btnDB.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDB.Size = new System.Drawing.Size(237, 64);
            this.btnDB.TabIndex = 2;
            this.btnDB.Text = "  База данных";
            this.btnDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDB.UseVisualStyleBackColor = false;
            // 
            // btnConfs
            // 
            this.btnConfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnConfs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfs.FlatAppearance.BorderSize = 0;
            this.btnConfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfs.ForeColor = System.Drawing.Color.White;
            this.btnConfs.Image = global::Курсач.Properties.Resources.users;
            this.btnConfs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfs.Location = new System.Drawing.Point(0, 94);
            this.btnConfs.Name = "btnConfs";
            this.btnConfs.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnConfs.Size = new System.Drawing.Size(237, 64);
            this.btnConfs.TabIndex = 1;
            this.btnConfs.Text = "  Конференции";
            this.btnConfs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfs.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 94);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 17, 0, 0);
            this.label1.Size = new System.Drawing.Size(207, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conferences++";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(237, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(844, 94);
            this.panelTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(53)))));
            this.labelTitle.Location = new System.Drawing.Point(47, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(177, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Конференции";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 563);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Программная система учета и проведения конференций";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnConfs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}