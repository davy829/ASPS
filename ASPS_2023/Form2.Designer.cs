namespace ASPS_2023
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label_score_red = new Label();
            label_weight = new Label();
            label_red_name = new Label();
            panel2 = new Panel();
            label_score_blue = new Label();
            label_blue_name = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label_score_red);
            panel1.Controls.Add(label_weight);
            panel1.Controls.Add(label_red_name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 198);
            panel1.TabIndex = 0;
            // 
            // label_score_red
            // 
            label_score_red.AutoSize = true;
            label_score_red.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            label_score_red.Location = new Point(594, 87);
            label_score_red.Name = "label_score_red";
            label_score_red.Size = new Size(255, 183);
            label_score_red.TabIndex = 2;
            label_score_red.Text = "00";
            // 
            // label_weight
            // 
            label_weight.AutoSize = true;
            label_weight.BackColor = Color.Transparent;
            label_weight.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label_weight.Location = new Point(365, 0);
            label_weight.Name = "label_weight";
            label_weight.Size = new Size(181, 86);
            label_weight.TabIndex = 1;
            label_weight.Text = "62кг.";
            // 
            // label_red_name
            // 
            label_red_name.AutoSize = true;
            label_red_name.BackColor = Color.Transparent;
            label_red_name.Font = new Font("Arial", 54.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_red_name.Location = new Point(3, 87);
            label_red_name.Name = "label_red_name";
            label_red_name.Size = new Size(151, 86);
            label_red_name.TabIndex = 0;
            label_red_name.Text = "red";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label_score_blue);
            panel2.Controls.Add(label_blue_name);
            panel2.Location = new Point(12, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 198);
            panel2.TabIndex = 1;
            // 
            // label_score_blue
            // 
            label_score_blue.AutoSize = true;
            label_score_blue.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            label_score_blue.Location = new Point(594, 17);
            label_score_blue.Name = "label_score_blue";
            label_score_blue.Size = new Size(255, 183);
            label_score_blue.TabIndex = 3;
            label_score_blue.Text = "00";
            // 
            // label_blue_name
            // 
            label_blue_name.AutoSize = true;
            label_blue_name.Font = new Font("Arial", 54.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_blue_name.Location = new Point(0, 57);
            label_blue_name.Name = "label_blue_name";
            label_blue_name.Size = new Size(188, 86);
            label_blue_name.TabIndex = 0;
            label_blue_name.Text = "blue";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(385, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 144);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 84.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(132, 14);
            label3.Name = "label3";
            label3.Size = new Size(181, 130);
            label3.TabIndex = 2;
            label3.Text = "59";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 84.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 4);
            label2.Name = "label2";
            label2.Size = new Size(93, 130);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 84.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(118, 130);
            label1.TabIndex = 0;
            label1.Text = "4";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contest";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        public Label label3;
        public Label label1;
        public Label label_red_name;
        public Label label_blue_name;
        public Label label_weight;
        public Label label_score_red;
        public Label label_score_blue;
        public System.Windows.Forms.Timer timer1;
    }
}