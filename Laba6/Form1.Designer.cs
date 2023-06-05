namespace Laba6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fareComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usedTrafficTextBox = new System.Windows.Forms.TextBox();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fareNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.farePriceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.fareListBox = new System.Windows.Forms.ListBox();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДОБАВЛЕНИЕ КЛИЕНТА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(313, 202);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(307, 29);
            this.nameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тариф";
            // 
            // fareComboBox
            // 
            this.fareComboBox.FormattingEnabled = true;
            this.fareComboBox.Location = new System.Drawing.Point(313, 247);
            this.fareComboBox.Name = "fareComboBox";
            this.fareComboBox.Size = new System.Drawing.Size(307, 32);
            this.fareComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Использовано трафика (МБайт)";
            // 
            // usedTrafficTextBox
            // 
            this.usedTrafficTextBox.Location = new System.Drawing.Point(313, 292);
            this.usedTrafficTextBox.Name = "usedTrafficTextBox";
            this.usedTrafficTextBox.Size = new System.Drawing.Size(307, 29);
            this.usedTrafficTextBox.TabIndex = 6;
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(16, 332);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(199, 28);
            this.discountCheckBox.TabIndex = 8;
            this.discountCheckBox.Text = "Полагается скидка";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            this.discountCheckBox.CheckedChanged += new System.EventHandler(this.discountCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Размер скидки";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Enabled = false;
            this.discountTextBox.Location = new System.Drawing.Point(313, 360);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(272, 29);
            this.discountTextBox.TabIndex = 10;
            this.discountTextBox.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "ДОБАВЛЕНИЕ ТАРИФА";
            // 
            // fareNameTextBox
            // 
            this.fareNameTextBox.Location = new System.Drawing.Point(313, 41);
            this.fareNameTextBox.Name = "fareNameTextBox";
            this.fareNameTextBox.Size = new System.Drawing.Size(307, 29);
            this.fareNameTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Название";
            // 
            // farePriceTextBox
            // 
            this.farePriceTextBox.Location = new System.Drawing.Point(313, 76);
            this.farePriceTextBox.Name = "farePriceTextBox";
            this.farePriceTextBox.Size = new System.Drawing.Size(307, 29);
            this.farePriceTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Стоимость  (руб./МБайт)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(604, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить тариф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(604, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить клиента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(604, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Посчитать суммарную стоимость услуг";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Суммарная стоимость услуг:";
            // 
            // fareListBox
            // 
            this.fareListBox.FormattingEnabled = true;
            this.fareListBox.ItemHeight = 24;
            this.fareListBox.Location = new System.Drawing.Point(640, 41);
            this.fareListBox.Name = "fareListBox";
            this.fareListBox.Size = new System.Drawing.Size(993, 244);
            this.fareListBox.TabIndex = 20;
            // 
            // clientListBox
            // 
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 24;
            this.clientListBox.Location = new System.Drawing.Point(640, 295);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(993, 340);
            this.clientListBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(591, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 649);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.fareListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.farePriceTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fareNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discountCheckBox);
            this.Controls.Add(this.usedTrafficTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fareComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fareComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usedTrafficTextBox;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fareNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox farePriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox fareListBox;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.Label label10;
    }
}

