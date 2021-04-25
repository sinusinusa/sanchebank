namespace bankapp
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
            this.clients = new System.Windows.Forms.ListBox();
            this.banksum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.all = new System.Windows.Forms.Button();
            this.creditors = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.skipday = new System.Windows.Forms.Button();
            this.skipmonth = new System.Windows.Forms.Button();
            this.deposits = new System.Windows.Forms.ListBox();
            this.credits = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.summ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.creditdeposit = new System.Windows.Forms.ListBox();
            this.ok = new System.Windows.Forms.Button();
            this.percents = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clients
            // 
            this.clients.FormattingEnabled = true;
            this.clients.ItemHeight = 16;
            this.clients.Location = new System.Drawing.Point(843, 77);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(337, 500);
            this.clients.TabIndex = 0;
            this.clients.SelectedIndexChanged += new System.EventHandler(this.clients_SelectedIndexChanged);
            // 
            // banksum
            // 
            this.banksum.Location = new System.Drawing.Point(143, 37);
            this.banksum.Name = "banksum";
            this.banksum.Size = new System.Drawing.Size(138, 22);
            this.banksum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Средства банка =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сортировать клиентов:";
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(758, 49);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(109, 23);
            this.all.TabIndex = 15;
            this.all.Text = "По счёту";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // creditors
            // 
            this.creditors.Location = new System.Drawing.Point(873, 49);
            this.creditors.Name = "creditors";
            this.creditors.Size = new System.Drawing.Size(109, 23);
            this.creditors.TabIndex = 16;
            this.creditors.Text = "Кредиторы";
            this.creditors.UseVisualStyleBackColor = true;
            this.creditors.Click += new System.EventHandler(this.creditors_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(1005, 20);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(175, 23);
            this.sort.TabIndex = 17;
            this.sort.Text = "Сорт. по депозитам";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Фамилия Имя Отчество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Идентификатор:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Депозиты:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Непогашенные кредиты:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(136, 125);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 24;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(190, 153);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(196, 22);
            this.name.TabIndex = 25;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 641);
            this.splitter1.TabIndex = 30;
            this.splitter1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(520, 39);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // skipday
            // 
            this.skipday.Location = new System.Drawing.Point(520, 258);
            this.skipday.Name = "skipday";
            this.skipday.Size = new System.Drawing.Size(163, 23);
            this.skipday.TabIndex = 32;
            this.skipday.Text = "Пропустить день";
            this.skipday.UseVisualStyleBackColor = true;
            this.skipday.Click += new System.EventHandler(this.skipday_Click);
            // 
            // skipmonth
            // 
            this.skipmonth.Location = new System.Drawing.Point(520, 295);
            this.skipmonth.Name = "skipmonth";
            this.skipmonth.Size = new System.Drawing.Size(163, 23);
            this.skipmonth.TabIndex = 33;
            this.skipmonth.Text = "Пропустить 30 дней";
            this.skipmonth.UseVisualStyleBackColor = true;
            this.skipmonth.Click += new System.EventHandler(this.skipmonth_Click);
            // 
            // deposits
            // 
            this.deposits.FormattingEnabled = true;
            this.deposits.ItemHeight = 16;
            this.deposits.Location = new System.Drawing.Point(15, 246);
            this.deposits.Name = "deposits";
            this.deposits.Size = new System.Drawing.Size(365, 52);
            this.deposits.TabIndex = 34;
            // 
            // credits
            // 
            this.credits.FormattingEnabled = true;
            this.credits.ItemHeight = 16;
            this.credits.Location = new System.Drawing.Point(15, 334);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(365, 52);
            this.credits.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Расчётный счёт:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(386, 125);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(100, 22);
            this.money.TabIndex = 37;
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(15, 431);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(146, 22);
            this.summ.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Создать кредит/депозит:";
            // 
            // creditdeposit
            // 
            this.creditdeposit.FormattingEnabled = true;
            this.creditdeposit.ItemHeight = 16;
            this.creditdeposit.Items.AddRange(new object[] {
            "кредит",
            "депозит"});
            this.creditdeposit.Location = new System.Drawing.Point(167, 431);
            this.creditdeposit.Name = "creditdeposit";
            this.creditdeposit.Size = new System.Drawing.Size(120, 36);
            this.creditdeposit.TabIndex = 40;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(421, 431);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 23);
            this.ok.TabIndex = 41;
            this.ok.Text = "Одобряем";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // percents
            // 
            this.percents.FormattingEnabled = true;
            this.percents.ItemHeight = 16;
            this.percents.Location = new System.Drawing.Point(293, 431);
            this.percents.Name = "percents";
            this.percents.Size = new System.Drawing.Size(120, 20);
            this.percents.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Погасить кредит/вывести депозит:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Перейти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1005, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Сорт. по кредитам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Повеление временем";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(334, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "Для начала работы выберите клиента из списка";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(12, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(564, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Для открытия формы управления счетами и кредитами для клиента нажмите сюда";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(319, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Одобрение кредитов и депозитов для клиента";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(192, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(330, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Введите сумму, действие и нажмите \"Одобряем\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1210, 641);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percents);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.creditdeposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.deposits);
            this.Controls.Add(this.skipmonth);
            this.Controls.Add(this.skipday);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.creditors);
            this.Controls.Add(this.all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banksum);
            this.Controls.Add(this.clients);
            this.Name = "Form1";
            this.Text = "SanChe Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clients;
        private System.Windows.Forms.TextBox banksum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button creditors;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button skipday;
        private System.Windows.Forms.Button skipmonth;
        private System.Windows.Forms.ListBox deposits;
        private System.Windows.Forms.ListBox credits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox summ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox creditdeposit;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ListBox percents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

