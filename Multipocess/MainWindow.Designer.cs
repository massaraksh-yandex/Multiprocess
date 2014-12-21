namespace MultipocessRape
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numWriters = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.terminateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timeEventName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.operationNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.timerNumeric = new System.Windows.Forms.NumericUpDown();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьФайлДляСлеженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симуляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьВсеПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWriters)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numWriters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numWriters
            // 
            this.numWriters.Location = new System.Drawing.Point(188, 16);
            this.numWriters.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numWriters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWriters.Name = "numWriters";
            this.numWriters.Size = new System.Drawing.Size(120, 20);
            this.numWriters.TabIndex = 2;
            this.numWriters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число процессов";
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(6, 19);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(142, 23);
            this.actionButton.TabIndex = 7;
            this.actionButton.Text = "Запустить симуляцию";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // terminateButton
            // 
            this.terminateButton.Location = new System.Drawing.Point(154, 19);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(153, 23);
            this.terminateButton.TabIndex = 1;
            this.terminateButton.Text = "Завершить приложения";
            this.terminateButton.UseVisualStyleBackColor = true;
            this.terminateButton.Click += new System.EventHandler(this.terminateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.timeEventName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.operationNumeric);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.timerNumeric);
            this.groupBox2.Controls.Add(this.openFileButton);
            this.groupBox2.Controls.Add(this.fileNameText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 182);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(178, 151);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(129, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Вызвать приложения";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Имя события синхронизации";
            // 
            // timeEventName
            // 
            this.timeEventName.Location = new System.Drawing.Point(178, 125);
            this.timeEventName.Name = "timeEventName";
            this.timeEventName.Size = new System.Drawing.Size(129, 20);
            this.timeEventName.TabIndex = 15;
            this.timeEventName.Text = "TIME_WAIT_EVENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Длина операции записи";
            // 
            // operationNumeric
            // 
            this.operationNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.operationNumeric.Location = new System.Drawing.Point(178, 99);
            this.operationNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.operationNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.operationNumeric.Name = "operationNumeric";
            this.operationNumeric.Size = new System.Drawing.Size(129, 20);
            this.operationNumeric.TabIndex = 13;
            this.operationNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Интервал таймера";
            // 
            // timerNumeric
            // 
            this.timerNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timerNumeric.Location = new System.Drawing.Point(178, 73);
            this.timerNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timerNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timerNumeric.Name = "timerNumeric";
            this.timerNumeric.Size = new System.Drawing.Size(129, 20);
            this.timerNumeric.TabIndex = 4;
            this.timerNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(178, 11);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(129, 23);
            this.openFileButton.TabIndex = 9;
            this.openFileButton.Text = "Выбрать...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // fileNameText
            // 
            this.fileNameText.Location = new System.Drawing.Point(9, 38);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.ReadOnly = true;
            this.fileNameText.Size = new System.Drawing.Size(298, 20);
            this.fileNameText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Файл для наблюдения";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.actionButton);
            this.groupBox3.Controls.Add(this.terminateButton);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 51);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьФайлДляСлеженияToolStripMenuItem,
            this.симуляцияToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.файлToolStripMenuItem.Text = "Симуляция";
            // 
            // выбратьФайлДляСлеженияToolStripMenuItem
            // 
            this.выбратьФайлДляСлеженияToolStripMenuItem.Name = "выбратьФайлДляСлеженияToolStripMenuItem";
            this.выбратьФайлДляСлеженияToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выбратьФайлДляСлеженияToolStripMenuItem.Text = "Выбрать файл для слежения";
            this.выбратьФайлДляСлеженияToolStripMenuItem.Click += new System.EventHandler(this.выбратьФайлДляСлеженияToolStripMenuItem_Click);
            // 
            // симуляцияToolStripMenuItem
            // 
            this.симуляцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.завершитьВсеПриложенияToolStripMenuItem});
            this.симуляцияToolStripMenuItem.Name = "симуляцияToolStripMenuItem";
            this.симуляцияToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.симуляцияToolStripMenuItem.Text = "Симуляция";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.startToolStripMenuItem.Text = "Запустить";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // завершитьВсеПриложенияToolStripMenuItem
            // 
            this.завершитьВсеПриложенияToolStripMenuItem.Name = "завершитьВсеПриложенияToolStripMenuItem";
            this.завершитьВсеПриложенияToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.завершитьВсеПриложенияToolStripMenuItem.Text = "Завершить все приложения";
            this.завершитьВсеПриложенияToolStripMenuItem.Click += new System.EventHandler(this.завершитьВсеПриложенияToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Multiprocess example";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWriters)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numWriters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Button terminateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox fileNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timerNumeric;
        private System.Windows.Forms.NumericUpDown operationNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox timeEventName;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьФайлДляСлеженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симуляцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьВсеПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
    }
}

