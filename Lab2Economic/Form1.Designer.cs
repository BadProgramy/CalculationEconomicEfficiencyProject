namespace Lab2Economic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.теорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теорияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.чистыйПриведенныйДоходNPVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коэффициентВозвратаИнвестицийROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексДоходностиPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.срокОкупаемостиPBPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внутреннююНормуДоходностиIRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.теорияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чистыйПриведенныйДоходNPVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.коэффициентВозвратаИнвестицииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексДоходностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.срокОкупаемостиPBPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.внутреннююНормуДоходностиIRRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.теорияToolStripMenuItem,
            this.теорияToolStripMenuItem2,
            this.теорияToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // теорияToolStripMenuItem
            // 
            this.теорияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            this.теорияToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.теорияToolStripMenuItem.Text = "Ввести данные";
            this.теорияToolStripMenuItem.Click += new System.EventHandler(this.теорияToolStripMenuItem_Click);
            // 
            // теорияToolStripMenuItem1
            // 
            this.теорияToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чистыйПриведенныйДоходNPVToolStripMenuItem,
            this.коэффициентВозвратаИнвестицийROIToolStripMenuItem,
            this.индексДоходностиPIToolStripMenuItem,
            this.срокОкупаемостиPBPToolStripMenuItem,
            this.внутреннююНормуДоходностиIRRToolStripMenuItem});
            this.теорияToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.теорияToolStripMenuItem1.Name = "теорияToolStripMenuItem1";
            this.теорияToolStripMenuItem1.Size = new System.Drawing.Size(82, 25);
            this.теорияToolStripMenuItem1.Text = "Задание";
            // 
            // чистыйПриведенныйДоходNPVToolStripMenuItem
            // 
            this.чистыйПриведенныйДоходNPVToolStripMenuItem.Name = "чистыйПриведенныйДоходNPVToolStripMenuItem";
            this.чистыйПриведенныйДоходNPVToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.чистыйПриведенныйДоходNPVToolStripMenuItem.Text = "Чистый приведенный доход NPV";
            this.чистыйПриведенныйДоходNPVToolStripMenuItem.Click += new System.EventHandler(this.чистыйПриведенныйДоходNPVToolStripMenuItem_Click);
            // 
            // коэффициентВозвратаИнвестицийROIToolStripMenuItem
            // 
            this.коэффициентВозвратаИнвестицийROIToolStripMenuItem.Name = "коэффициентВозвратаИнвестицийROIToolStripMenuItem";
            this.коэффициентВозвратаИнвестицийROIToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.коэффициентВозвратаИнвестицийROIToolStripMenuItem.Text = "Коэффициент возврата инвестиций ROI";
            this.коэффициентВозвратаИнвестицийROIToolStripMenuItem.Click += new System.EventHandler(this.коэффициентВозвратаИнвестицийROIToolStripMenuItem_Click);
            // 
            // индексДоходностиPIToolStripMenuItem
            // 
            this.индексДоходностиPIToolStripMenuItem.Name = "индексДоходностиPIToolStripMenuItem";
            this.индексДоходностиPIToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.индексДоходностиPIToolStripMenuItem.Text = "Индекс доходности PI";
            this.индексДоходностиPIToolStripMenuItem.Click += new System.EventHandler(this.индексДоходностиPIToolStripMenuItem_Click);
            // 
            // срокОкупаемостиPBPToolStripMenuItem
            // 
            this.срокОкупаемостиPBPToolStripMenuItem.Name = "срокОкупаемостиPBPToolStripMenuItem";
            this.срокОкупаемостиPBPToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.срокОкупаемостиPBPToolStripMenuItem.Text = "Срок окупаемости PBP";
            this.срокОкупаемостиPBPToolStripMenuItem.Click += new System.EventHandler(this.срокОкупаемостиPBPToolStripMenuItem_Click);
            // 
            // внутреннююНормуДоходностиIRRToolStripMenuItem
            // 
            this.внутреннююНормуДоходностиIRRToolStripMenuItem.Name = "внутреннююНормуДоходностиIRRToolStripMenuItem";
            this.внутреннююНормуДоходностиIRRToolStripMenuItem.Size = new System.Drawing.Size(366, 26);
            this.внутреннююНормуДоходностиIRRToolStripMenuItem.Text = "Внутреннюю норму доходности IRR.";
            this.внутреннююНормуДоходностиIRRToolStripMenuItem.Click += new System.EventHandler(this.внутреннююНормуДоходностиIRRToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(561, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Чистый приведенный доход NPV = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(203, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Коэффициент возврата инвестиций ROI =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Индекс доходности PI =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(151, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Срок окупаемости PBP =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(213, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Внутреннюю норму доходности IRR =";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 159);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Переменная";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Подобранная ставка дисконтирования = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(234, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "?";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(313, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 358);
            this.panel1.TabIndex = 15;
            // 
            // теорияToolStripMenuItem2
            // 
            this.теорияToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чистыйПриведенныйДоходNPVToolStripMenuItem1,
            this.коэффициентВозвратаИнвестицииToolStripMenuItem,
            this.индексДоходностиToolStripMenuItem,
            this.срокОкупаемостиPBPToolStripMenuItem1,
            this.внутреннююНормуДоходностиIRRToolStripMenuItem1});
            this.теорияToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.теорияToolStripMenuItem2.Name = "теорияToolStripMenuItem2";
            this.теорияToolStripMenuItem2.Size = new System.Drawing.Size(73, 25);
            this.теорияToolStripMenuItem2.Text = "Теория";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
            // 
            // чистыйПриведенныйДоходNPVToolStripMenuItem1
            // 
            this.чистыйПриведенныйДоходNPVToolStripMenuItem1.Name = "чистыйПриведенныйДоходNPVToolStripMenuItem1";
            this.чистыйПриведенныйДоходNPVToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.чистыйПриведенныйДоходNPVToolStripMenuItem1.Text = "Чистый приведенный доход NPV";
            this.чистыйПриведенныйДоходNPVToolStripMenuItem1.Click += new System.EventHandler(this.чистыйПриведенныйДоходNPVToolStripMenuItem1_Click);
            // 
            // коэффициентВозвратаИнвестицииToolStripMenuItem
            // 
            this.коэффициентВозвратаИнвестицииToolStripMenuItem.Name = "коэффициентВозвратаИнвестицииToolStripMenuItem";
            this.коэффициентВозвратаИнвестицииToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.коэффициентВозвратаИнвестицииToolStripMenuItem.Text = "Коэффициент возврата инвестиции ROI";
            this.коэффициентВозвратаИнвестицииToolStripMenuItem.Click += new System.EventHandler(this.коэффициентВозвратаИнвестицииToolStripMenuItem_Click);
            // 
            // индексДоходностиToolStripMenuItem
            // 
            this.индексДоходностиToolStripMenuItem.Name = "индексДоходностиToolStripMenuItem";
            this.индексДоходностиToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.индексДоходностиToolStripMenuItem.Text = "Индекс доходности PI";
            this.индексДоходностиToolStripMenuItem.Click += new System.EventHandler(this.индексДоходностиToolStripMenuItem_Click);
            // 
            // срокОкупаемостиPBPToolStripMenuItem1
            // 
            this.срокОкупаемостиPBPToolStripMenuItem1.Name = "срокОкупаемостиPBPToolStripMenuItem1";
            this.срокОкупаемостиPBPToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.срокОкупаемостиPBPToolStripMenuItem1.Text = "Срок окупаемости PBP ";
            this.срокОкупаемостиPBPToolStripMenuItem1.Click += new System.EventHandler(this.срокОкупаемостиPBPToolStripMenuItem1_Click);
            // 
            // внутреннююНормуДоходностиIRRToolStripMenuItem1
            // 
            this.внутреннююНормуДоходностиIRRToolStripMenuItem1.Name = "внутреннююНормуДоходностиIRRToolStripMenuItem1";
            this.внутреннююНормуДоходностиIRRToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.внутреннююНормуДоходностиIRRToolStripMenuItem1.Text = "Внутреннюю норму доходности IRR.";
            this.внутреннююНормуДоходностиIRRToolStripMenuItem1.Click += new System.EventHandler(this.внутреннююНормуДоходностиIRRToolStripMenuItem1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(235, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(509, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Программная система расчета показателей";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(390, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "Перейти к решению";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(248, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(475, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "экономической эффективности проекта ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(966, 472);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Расчет показателей экономической эффективности проекта";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem чистыйПриведенныйДоходNPVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коэффициентВозвратаИнвестицийROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексДоходностиPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem срокОкупаемостиPBPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внутреннююНормуДоходностиIRRToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem чистыйПриведенныйДоходNPVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem коэффициентВозвратаИнвестицииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексДоходностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem срокОкупаемостиPBPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem внутреннююНормуДоходностиIRRToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

