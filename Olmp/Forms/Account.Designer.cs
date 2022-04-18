namespace Olmp
{
    partial class Account
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
            this.panellLogo = new System.Windows.Forms.Panel();
            this.lbl_hi = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_stat = new System.Windows.Forms.Button();
            this.btn_addapp = new System.Windows.Forms.Button();
            this.btn_applist = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.lbl_hi);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(147, 0);
            this.panellLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(386, 292);
            this.panellLogo.TabIndex = 7;
            // 
            // lbl_hi
            // 
            this.lbl_hi.AutoSize = true;
            this.lbl_hi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_hi.Location = new System.Drawing.Point(10, 20);
            this.lbl_hi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(51, 20);
            this.lbl_hi.TabIndex = 0;
            this.lbl_hi.Text = "label1";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_exit);
            this.panelMenu.Controls.Add(this.btn_stat);
            this.panelMenu.Controls.Add(this.btn_addapp);
            this.panelMenu.Controls.Add(this.btn_applist);
            this.panelMenu.Controls.Add(this.btn_main);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(147, 292);
            this.panelMenu.TabIndex = 6;
            // 
            // btn_stat
            // 
            this.btn_stat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stat.FlatAppearance.BorderSize = 0;
            this.btn_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_stat.ForeColor = System.Drawing.Color.White;
            this.btn_stat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stat.Location = new System.Drawing.Point(0, 169);
            this.btn_stat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stat.Name = "btn_stat";
            this.btn_stat.Size = new System.Drawing.Size(147, 39);
            this.btn_stat.TabIndex = 6;
            this.btn_stat.Text = "Статистика";
            this.btn_stat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stat.UseVisualStyleBackColor = true;
            this.btn_stat.Click += new System.EventHandler(this.btn_stat_Click);
            // 
            // btn_addapp
            // 
            this.btn_addapp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addapp.FlatAppearance.BorderSize = 0;
            this.btn_addapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_addapp.ForeColor = System.Drawing.Color.White;
            this.btn_addapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addapp.Location = new System.Drawing.Point(0, 130);
            this.btn_addapp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addapp.Name = "btn_addapp";
            this.btn_addapp.Size = new System.Drawing.Size(147, 39);
            this.btn_addapp.TabIndex = 5;
            this.btn_addapp.Text = "Добавить приложение";
            this.btn_addapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addapp.UseVisualStyleBackColor = true;
            this.btn_addapp.Click += new System.EventHandler(this.btn_addapp_Click);
            // 
            // btn_applist
            // 
            this.btn_applist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_applist.FlatAppearance.BorderSize = 0;
            this.btn_applist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_applist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_applist.ForeColor = System.Drawing.Color.White;
            this.btn_applist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applist.Location = new System.Drawing.Point(0, 91);
            this.btn_applist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_applist.Name = "btn_applist";
            this.btn_applist.Size = new System.Drawing.Size(147, 39);
            this.btn_applist.TabIndex = 4;
            this.btn_applist.Text = "Список приложений";
            this.btn_applist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_applist.UseVisualStyleBackColor = true;
            this.btn_applist.Click += new System.EventHandler(this.btn_applist_Click);
            // 
            // btn_main
            // 
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_main.ForeColor = System.Drawing.Color.White;
            this.btn_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main.Location = new System.Drawing.Point(0, 52);
            this.btn_main.Margin = new System.Windows.Forms.Padding(2);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(147, 39);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "На главную";
            this.btn_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(147, 52);
            this.panelLogo.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 208);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(147, 39);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Выйти";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panellLogo.ResumeLayout(false);
            this.panellLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_applist;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbl_hi;
        private System.Windows.Forms.Button btn_stat;
        private System.Windows.Forms.Button btn_addapp;
        private System.Windows.Forms.Button btn_exit;
    }
}