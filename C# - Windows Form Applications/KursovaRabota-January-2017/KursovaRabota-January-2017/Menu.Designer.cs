﻿namespace primer1
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.въвежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкНаДаннитеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВидМПСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеПоЕГНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.експортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Rosewood Std Regular", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(204, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данниToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.експортToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(714, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данниToolStripMenuItem
            // 
            this.данниToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въвежданеToolStripMenuItem,
            this.списъкНаДаннитеToolStripMenuItem});
            this.данниToolStripMenuItem.Name = "данниToolStripMenuItem";
            this.данниToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.данниToolStripMenuItem.Text = "Данни";
            // 
            // въвежданеToolStripMenuItem
            // 
            this.въвежданеToolStripMenuItem.Name = "въвежданеToolStripMenuItem";
            this.въвежданеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.въвежданеToolStripMenuItem.Text = "Въвеждане";
            this.въвежданеToolStripMenuItem.Click += new System.EventHandler(this.въвежданеToolStripMenuItem_Click);
            // 
            // списъкНаДаннитеToolStripMenuItem
            // 
            this.списъкНаДаннитеToolStripMenuItem.Name = "списъкНаДаннитеToolStripMenuItem";
            this.списъкНаДаннитеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.списъкНаДаннитеToolStripMenuItem.Text = "Списък на данните";
            this.списъкНаДаннитеToolStripMenuItem.Click += new System.EventHandler(this.списъкНаДаннитеToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВидМПСToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.търсенеПоЕГНToolStripMenuItem,
            this.toolStripMenuItem1});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // поВидМПСToolStripMenuItem
            // 
            this.поВидМПСToolStripMenuItem.Name = "поВидМПСToolStripMenuItem";
            this.поВидМПСToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.поВидМПСToolStripMenuItem.Text = "Справки по длъжност";
            this.поВидМПСToolStripMenuItem.Click += new System.EventHandler(this.поВидМПСToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.търсенеToolStripMenuItem.Text = "Работник с най-много часове";
            this.търсенеToolStripMenuItem.Click += new System.EventHandler(this.търсенеToolStripMenuItem_Click);
            // 
            // търсенеПоЕГНToolStripMenuItem
            // 
            this.търсенеПоЕГНToolStripMenuItem.Name = "търсенеПоЕГНToolStripMenuItem";
            this.търсенеПоЕГНToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.търсенеПоЕГНToolStripMenuItem.Text = "Търсене по ЕГН";
            this.търсенеПоЕГНToolStripMenuItem.Click += new System.EventHandler(this.търсенеПоЕГНToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(292, 26);
            this.toolStripMenuItem1.Text = "Търсене по име";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // експортToolStripMenuItem
            // 
            this.експортToolStripMenuItem.Name = "експортToolStripMenuItem";
            this.експортToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.експортToolStripMenuItem.Text = "Експорт";
            this.експортToolStripMenuItem.Click += new System.EventHandler(this.експортToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::KursovaRabota_January_2017.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(714, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Manager 2017";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem въвежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкНаДаннитеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem експортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВидМПСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеПоЕГНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

