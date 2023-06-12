namespace ASPS_2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox_red_names = new ListBox();
            listBox_blue_names = new ListBox();
            listBox_files_weigt = new ListBox();
            button_add_file_weigth = new Button();
            button_add_sportsmen = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button_timer_start = new Button();
            button_timer_stop = new Button();
            button_resore_timer = new Button();
            panel3 = new Panel();
            textBox_reset_timer_min = new TextBox();
            textBox_reset_timer_sec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            button_red_plus_1 = new Button();
            button_red_plus_2 = new Button();
            button_red_plus_3 = new Button();
            button_red_plus_4 = new Button();
            button_red_minus_4 = new Button();
            button_red_minus_3 = new Button();
            button_red_minus_2 = new Button();
            button_red_minus_1 = new Button();
            button_red_advantec = new Button();
            button_red_winner = new Button();
            button_red_diqual_1 = new Button();
            button_red_diqual_2 = new Button();
            button_red_diqual_3 = new Button();
            panel5 = new Panel();
            button_blue_disqual_3 = new Button();
            button_blue_disqual_2 = new Button();
            button_blue_disqual_1 = new Button();
            button_blue_winner = new Button();
            button_blue_advantec = new Button();
            button_blue_minus_4 = new Button();
            button_blue_minus_3 = new Button();
            button_blue_minus_2 = new Button();
            button_blue_minus_1 = new Button();
            button_blue_plus_4 = new Button();
            button_blue_plus_3 = new Button();
            button_blue_plus_2 = new Button();
            button_blue_plus_1 = new Button();
            panel6 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // listBox_red_names
            // 
            listBox_red_names.BackColor = Color.Red;
            listBox_red_names.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_red_names.ForeColor = SystemColors.MenuText;
            listBox_red_names.FormattingEnabled = true;
            listBox_red_names.ItemHeight = 15;
            listBox_red_names.Location = new Point(12, 12);
            listBox_red_names.Name = "listBox_red_names";
            listBox_red_names.Size = new Size(194, 259);
            listBox_red_names.TabIndex = 0;
            // 
            // listBox_blue_names
            // 
            listBox_blue_names.BackColor = SystemColors.HotTrack;
            listBox_blue_names.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_blue_names.FormattingEnabled = true;
            listBox_blue_names.ItemHeight = 15;
            listBox_blue_names.Location = new Point(212, 12);
            listBox_blue_names.Name = "listBox_blue_names";
            listBox_blue_names.Size = new Size(194, 259);
            listBox_blue_names.TabIndex = 1;
            // 
            // listBox_files_weigt
            // 
            listBox_files_weigt.FormattingEnabled = true;
            listBox_files_weigt.ItemHeight = 15;
            listBox_files_weigt.Location = new Point(412, 12);
            listBox_files_weigt.Name = "listBox_files_weigt";
            listBox_files_weigt.Size = new Size(123, 259);
            listBox_files_weigt.TabIndex = 2;
            // 
            // button_add_file_weigth
            // 
            button_add_file_weigth.Location = new Point(412, 276);
            button_add_file_weigth.Name = "button_add_file_weigth";
            button_add_file_weigth.Size = new Size(122, 52);
            button_add_file_weigth.TabIndex = 3;
            button_add_file_weigth.Text = "Добавить файлы весов";
            button_add_file_weigth.UseVisualStyleBackColor = true;
            // 
            // button_add_sportsmen
            // 
            button_add_sportsmen.Location = new Point(12, 276);
            button_add_sportsmen.Name = "button_add_sportsmen";
            button_add_sportsmen.Size = new Size(394, 52);
            button_add_sportsmen.TabIndex = 4;
            button_add_sportsmen.Text = "Добавить спортсменов включить монитор";
            button_add_sportsmen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(12, 334);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 199);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button_timer_start);
            panel2.Location = new Point(412, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(119, 199);
            panel2.TabIndex = 6;
            // 
            // button_timer_start
            // 
            button_timer_start.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_timer_start.Location = new Point(3, 3);
            button_timer_start.Name = "button_timer_start";
            button_timer_start.Size = new Size(109, 67);
            button_timer_start.TabIndex = 0;
            button_timer_start.Text = "FIGHT";
            button_timer_start.UseVisualStyleBackColor = true;
            // 
            // button_timer_stop
            // 
            button_timer_stop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_timer_stop.Location = new Point(52, 1);
            button_timer_stop.Name = "button_timer_stop";
            button_timer_stop.Size = new Size(54, 26);
            button_timer_stop.TabIndex = 1;
            button_timer_stop.Text = "PAUSE";
            button_timer_stop.UseVisualStyleBackColor = true;
            // 
            // button_resore_timer
            // 
            button_resore_timer.Location = new Point(1, 2);
            button_resore_timer.Name = "button_resore_timer";
            button_resore_timer.Size = new Size(103, 41);
            button_resore_timer.TabIndex = 2;
            button_resore_timer.Text = "Сбросить таймер";
            button_resore_timer.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox_reset_timer_sec);
            panel3.Controls.Add(textBox_reset_timer_min);
            panel3.Controls.Add(button_resore_timer);
            panel3.Location = new Point(4, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(108, 74);
            panel3.TabIndex = 3;
            // 
            // textBox_reset_timer_min
            // 
            textBox_reset_timer_min.HideSelection = false;
            textBox_reset_timer_min.Location = new Point(4, 46);
            textBox_reset_timer_min.Name = "textBox_reset_timer_min";
            textBox_reset_timer_min.Size = new Size(20, 23);
            textBox_reset_timer_min.TabIndex = 3;
            textBox_reset_timer_min.Text = "5";
            textBox_reset_timer_min.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_reset_timer_sec
            // 
            textBox_reset_timer_sec.Location = new Point(52, 46);
            textBox_reset_timer_sec.Name = "textBox_reset_timer_sec";
            textBox_reset_timer_sec.Size = new Size(25, 23);
            textBox_reset_timer_sec.TabIndex = 4;
            textBox_reset_timer_sec.Text = "32";
            textBox_reset_timer_sec.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(21, 12);
            label1.TabIndex = 5;
            label1.Text = "мин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 57);
            label2.Name = "label2";
            label2.Size = new Size(18, 12);
            label2.TabIndex = 6;
            label2.Text = "сек";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(button_red_diqual_3);
            panel4.Controls.Add(button_red_diqual_2);
            panel4.Controls.Add(button_red_diqual_1);
            panel4.Controls.Add(button_red_winner);
            panel4.Controls.Add(button_red_advantec);
            panel4.Controls.Add(button_red_minus_4);
            panel4.Controls.Add(button_red_minus_3);
            panel4.Controls.Add(button_red_minus_2);
            panel4.Controls.Add(button_red_minus_1);
            panel4.Controls.Add(button_red_plus_4);
            panel4.Controls.Add(button_red_plus_3);
            panel4.Controls.Add(button_red_plus_2);
            panel4.Controls.Add(button_red_plus_1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 183);
            panel4.TabIndex = 0;
            // 
            // button_red_plus_1
            // 
            button_red_plus_1.FlatStyle = FlatStyle.System;
            button_red_plus_1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_plus_1.Location = new Point(3, 6);
            button_red_plus_1.Name = "button_red_plus_1";
            button_red_plus_1.Size = new Size(34, 29);
            button_red_plus_1.TabIndex = 1;
            button_red_plus_1.Text = "+1";
            button_red_plus_1.UseVisualStyleBackColor = true;
            // 
            // button_red_plus_2
            // 
            button_red_plus_2.FlatStyle = FlatStyle.System;
            button_red_plus_2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_plus_2.Location = new Point(43, 6);
            button_red_plus_2.Name = "button_red_plus_2";
            button_red_plus_2.Size = new Size(34, 29);
            button_red_plus_2.TabIndex = 2;
            button_red_plus_2.Text = "+2";
            button_red_plus_2.UseVisualStyleBackColor = true;
            // 
            // button_red_plus_3
            // 
            button_red_plus_3.FlatStyle = FlatStyle.System;
            button_red_plus_3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_plus_3.Location = new Point(83, 6);
            button_red_plus_3.Name = "button_red_plus_3";
            button_red_plus_3.Size = new Size(34, 29);
            button_red_plus_3.TabIndex = 3;
            button_red_plus_3.Text = "+3";
            button_red_plus_3.UseVisualStyleBackColor = true;
            // 
            // button_red_plus_4
            // 
            button_red_plus_4.FlatStyle = FlatStyle.System;
            button_red_plus_4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_plus_4.Location = new Point(123, 6);
            button_red_plus_4.Name = "button_red_plus_4";
            button_red_plus_4.Size = new Size(34, 29);
            button_red_plus_4.TabIndex = 4;
            button_red_plus_4.Text = "+4";
            button_red_plus_4.UseVisualStyleBackColor = true;
            // 
            // button_red_minus_4
            // 
            button_red_minus_4.FlatStyle = FlatStyle.System;
            button_red_minus_4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_minus_4.Location = new Point(123, 38);
            button_red_minus_4.Name = "button_red_minus_4";
            button_red_minus_4.Size = new Size(34, 29);
            button_red_minus_4.TabIndex = 8;
            button_red_minus_4.Text = "-4";
            button_red_minus_4.UseVisualStyleBackColor = true;
            // 
            // button_red_minus_3
            // 
            button_red_minus_3.FlatStyle = FlatStyle.System;
            button_red_minus_3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_minus_3.Location = new Point(83, 38);
            button_red_minus_3.Name = "button_red_minus_3";
            button_red_minus_3.Size = new Size(34, 29);
            button_red_minus_3.TabIndex = 7;
            button_red_minus_3.Text = "-3";
            button_red_minus_3.UseVisualStyleBackColor = true;
            // 
            // button_red_minus_2
            // 
            button_red_minus_2.FlatStyle = FlatStyle.System;
            button_red_minus_2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_minus_2.Location = new Point(43, 38);
            button_red_minus_2.Name = "button_red_minus_2";
            button_red_minus_2.Size = new Size(34, 29);
            button_red_minus_2.TabIndex = 6;
            button_red_minus_2.Text = "-2";
            button_red_minus_2.UseVisualStyleBackColor = true;
            // 
            // button_red_minus_1
            // 
            button_red_minus_1.FlatStyle = FlatStyle.System;
            button_red_minus_1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_red_minus_1.Location = new Point(3, 38);
            button_red_minus_1.Name = "button_red_minus_1";
            button_red_minus_1.Size = new Size(34, 29);
            button_red_minus_1.TabIndex = 5;
            button_red_minus_1.Text = "-1";
            button_red_minus_1.UseVisualStyleBackColor = true;
            // 
            // button_red_advantec
            // 
            button_red_advantec.Location = new Point(3, 107);
            button_red_advantec.Name = "button_red_advantec";
            button_red_advantec.Size = new Size(154, 34);
            button_red_advantec.TabIndex = 1;
            button_red_advantec.Text = "Advantec";
            button_red_advantec.UseVisualStyleBackColor = true;
            // 
            // button_red_winner
            // 
            button_red_winner.Location = new Point(3, 146);
            button_red_winner.Name = "button_red_winner";
            button_red_winner.Size = new Size(154, 34);
            button_red_winner.TabIndex = 9;
            button_red_winner.Text = "WINNER";
            button_red_winner.UseVisualStyleBackColor = true;
            // 
            // button_red_diqual_1
            // 
            button_red_diqual_1.Location = new Point(3, 73);
            button_red_diqual_1.Name = "button_red_diqual_1";
            button_red_diqual_1.Size = new Size(45, 30);
            button_red_diqual_1.TabIndex = 1;
            button_red_diqual_1.Text = "DIS1";
            button_red_diqual_1.UseVisualStyleBackColor = true;
            // 
            // button_red_diqual_2
            // 
            button_red_diqual_2.Enabled = false;
            button_red_diqual_2.Location = new Point(58, 73);
            button_red_diqual_2.Name = "button_red_diqual_2";
            button_red_diqual_2.Size = new Size(45, 30);
            button_red_diqual_2.TabIndex = 10;
            button_red_diqual_2.Text = "DIS2";
            button_red_diqual_2.UseVisualStyleBackColor = true;
            // 
            // button_red_diqual_3
            // 
            button_red_diqual_3.Enabled = false;
            button_red_diqual_3.Location = new Point(112, 73);
            button_red_diqual_3.Name = "button_red_diqual_3";
            button_red_diqual_3.Size = new Size(45, 30);
            button_red_diqual_3.TabIndex = 11;
            button_red_diqual_3.Text = "DIS3";
            button_red_diqual_3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(button_blue_disqual_3);
            panel5.Controls.Add(button_blue_disqual_2);
            panel5.Controls.Add(button_blue_disqual_1);
            panel5.Controls.Add(button_blue_winner);
            panel5.Controls.Add(button_blue_advantec);
            panel5.Controls.Add(button_blue_minus_4);
            panel5.Controls.Add(button_blue_minus_3);
            panel5.Controls.Add(button_blue_minus_2);
            panel5.Controls.Add(button_blue_minus_1);
            panel5.Controls.Add(button_blue_plus_4);
            panel5.Controls.Add(button_blue_plus_3);
            panel5.Controls.Add(button_blue_plus_2);
            panel5.Controls.Add(button_blue_plus_1);
            panel5.Location = new Point(219, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(168, 183);
            panel5.TabIndex = 1;
            // 
            // button_blue_disqual_3
            // 
            button_blue_disqual_3.Enabled = false;
            button_blue_disqual_3.Location = new Point(112, 73);
            button_blue_disqual_3.Name = "button_blue_disqual_3";
            button_blue_disqual_3.Size = new Size(45, 30);
            button_blue_disqual_3.TabIndex = 11;
            button_blue_disqual_3.Text = "DIS3";
            button_blue_disqual_3.UseVisualStyleBackColor = true;
            // 
            // button_blue_disqual_2
            // 
            button_blue_disqual_2.Enabled = false;
            button_blue_disqual_2.Location = new Point(58, 73);
            button_blue_disqual_2.Name = "button_blue_disqual_2";
            button_blue_disqual_2.Size = new Size(45, 30);
            button_blue_disqual_2.TabIndex = 10;
            button_blue_disqual_2.Text = "DIS2";
            button_blue_disqual_2.UseVisualStyleBackColor = true;
            // 
            // button_blue_disqual_1
            // 
            button_blue_disqual_1.Location = new Point(3, 73);
            button_blue_disqual_1.Name = "button_blue_disqual_1";
            button_blue_disqual_1.Size = new Size(45, 30);
            button_blue_disqual_1.TabIndex = 1;
            button_blue_disqual_1.Text = "DIS1";
            button_blue_disqual_1.UseVisualStyleBackColor = true;
            // 
            // button_blue_winner
            // 
            button_blue_winner.Location = new Point(3, 146);
            button_blue_winner.Name = "button_blue_winner";
            button_blue_winner.Size = new Size(154, 34);
            button_blue_winner.TabIndex = 9;
            button_blue_winner.Text = "WINNER";
            button_blue_winner.UseVisualStyleBackColor = true;
            // 
            // button_blue_advantec
            // 
            button_blue_advantec.Location = new Point(3, 107);
            button_blue_advantec.Name = "button_blue_advantec";
            button_blue_advantec.Size = new Size(154, 34);
            button_blue_advantec.TabIndex = 1;
            button_blue_advantec.Text = "Advantec";
            button_blue_advantec.UseVisualStyleBackColor = true;
            // 
            // button_blue_minus_4
            // 
            button_blue_minus_4.FlatStyle = FlatStyle.System;
            button_blue_minus_4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_minus_4.Location = new Point(123, 38);
            button_blue_minus_4.Name = "button_blue_minus_4";
            button_blue_minus_4.Size = new Size(34, 29);
            button_blue_minus_4.TabIndex = 8;
            button_blue_minus_4.Text = "-4";
            button_blue_minus_4.UseVisualStyleBackColor = true;
            // 
            // button_blue_minus_3
            // 
            button_blue_minus_3.FlatStyle = FlatStyle.System;
            button_blue_minus_3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_minus_3.Location = new Point(83, 38);
            button_blue_minus_3.Name = "button_blue_minus_3";
            button_blue_minus_3.Size = new Size(34, 29);
            button_blue_minus_3.TabIndex = 7;
            button_blue_minus_3.Text = "-3";
            button_blue_minus_3.UseVisualStyleBackColor = true;
            // 
            // button_blue_minus_2
            // 
            button_blue_minus_2.FlatStyle = FlatStyle.System;
            button_blue_minus_2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_minus_2.Location = new Point(43, 38);
            button_blue_minus_2.Name = "button_blue_minus_2";
            button_blue_minus_2.Size = new Size(34, 29);
            button_blue_minus_2.TabIndex = 6;
            button_blue_minus_2.Text = "-2";
            button_blue_minus_2.UseVisualStyleBackColor = true;
            // 
            // button_blue_minus_1
            // 
            button_blue_minus_1.FlatStyle = FlatStyle.System;
            button_blue_minus_1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_minus_1.Location = new Point(3, 38);
            button_blue_minus_1.Name = "button_blue_minus_1";
            button_blue_minus_1.Size = new Size(34, 29);
            button_blue_minus_1.TabIndex = 5;
            button_blue_minus_1.Text = "-1";
            button_blue_minus_1.UseVisualStyleBackColor = true;
            // 
            // button_blue_plus_4
            // 
            button_blue_plus_4.FlatStyle = FlatStyle.System;
            button_blue_plus_4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_plus_4.Location = new Point(123, 6);
            button_blue_plus_4.Name = "button_blue_plus_4";
            button_blue_plus_4.Size = new Size(34, 29);
            button_blue_plus_4.TabIndex = 4;
            button_blue_plus_4.Text = "+4";
            button_blue_plus_4.UseVisualStyleBackColor = true;
            // 
            // button_blue_plus_3
            // 
            button_blue_plus_3.FlatStyle = FlatStyle.System;
            button_blue_plus_3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_plus_3.Location = new Point(83, 6);
            button_blue_plus_3.Name = "button_blue_plus_3";
            button_blue_plus_3.Size = new Size(34, 29);
            button_blue_plus_3.TabIndex = 3;
            button_blue_plus_3.Text = "+3";
            button_blue_plus_3.UseVisualStyleBackColor = true;
            // 
            // button_blue_plus_2
            // 
            button_blue_plus_2.FlatStyle = FlatStyle.System;
            button_blue_plus_2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_plus_2.Location = new Point(43, 6);
            button_blue_plus_2.Name = "button_blue_plus_2";
            button_blue_plus_2.Size = new Size(34, 29);
            button_blue_plus_2.TabIndex = 2;
            button_blue_plus_2.Text = "+2";
            button_blue_plus_2.UseVisualStyleBackColor = true;
            // 
            // button_blue_plus_1
            // 
            button_blue_plus_1.FlatStyle = FlatStyle.System;
            button_blue_plus_1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_blue_plus_1.Location = new Point(3, 6);
            button_blue_plus_1.Name = "button_blue_plus_1";
            button_blue_plus_1.Size = new Size(34, 29);
            button_blue_plus_1.TabIndex = 1;
            button_blue_plus_1.Text = "+1";
            button_blue_plus_1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(button_timer_stop);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(3, 76);
            panel6.Name = "panel6";
            panel6.Size = new Size(108, 30);
            panel6.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 4);
            label3.Name = "label3";
            label3.Size = new Size(15, 17);
            label3.TabIndex = 0;
            label3.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 3);
            label4.Name = "label4";
            label4.Size = new Size(11, 17);
            label4.TabIndex = 1;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 4);
            label5.Name = "label5";
            label5.Size = new Size(22, 17);
            label5.TabIndex = 2;
            label5.Text = "60";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 539);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_add_sportsmen);
            Controls.Add(button_add_file_weigth);
            Controls.Add(listBox_files_weigt);
            Controls.Add(listBox_blue_names);
            Controls.Add(listBox_red_names);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "ASPS_2023 v1.0";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_red_names;
        private ListBox listBox_blue_names;
        private ListBox listBox_files_weigt;
        private Button button_add_file_weigth;
        private Button button_add_sportsmen;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox_reset_timer_sec;
        private TextBox textBox_reset_timer_min;
        private Button button_resore_timer;
        private Button button_timer_stop;
        private Button button_timer_start;
        private Label label2;
        private Label label1;
        private Button button_red_diqual_1;
        private Panel panel4;
        private Button button_red_winner;
        private Button button_red_advantec;
        private Button button_red_minus_4;
        private Button button_red_minus_3;
        private Button button_red_minus_2;
        private Button button_red_minus_1;
        private Button button_red_plus_4;
        private Button button_red_plus_3;
        private Button button_red_plus_2;
        private Button button_red_plus_1;
        private Button button_red_diqual_3;
        private Button button_red_diqual_2;
        private Panel panel5;
        private Button button_blue_disqual_3;
        private Button button_blue_disqual_2;
        private Button button_blue_disqual_1;
        private Button button_blue_winner;
        private Button button_blue_advantec;
        private Button button_blue_minus_4;
        private Button button_blue_minus_3;
        private Button button_blue_minus_2;
        private Button button_blue_minus_1;
        private Button button_blue_plus_4;
        private Button button_blue_plus_3;
        private Button button_blue_plus_2;
        private Button button_blue_plus_1;
        private Panel panel6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}