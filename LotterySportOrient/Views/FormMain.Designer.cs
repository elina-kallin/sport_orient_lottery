namespace LotterySportOrient
{
    partial class FormMain
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
            radioButtonAllGroups = new RadioButton();
            radioButtonRangeGroups = new RadioButton();
            checkBoxOnlyWins = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // radioButtonAllGroups
            // 
            radioButtonAllGroups.AutoSize = true;
            radioButtonAllGroups.Checked = true;
            radioButtonAllGroups.Location = new Point(13, 16);
            radioButtonAllGroups.Margin = new Padding(4, 4, 4, 4);
            radioButtonAllGroups.Name = "radioButtonAllGroups";
            radioButtonAllGroups.Size = new Size(184, 27);
            radioButtonAllGroups.TabIndex = 0;
            radioButtonAllGroups.TabStop = true;
            radioButtonAllGroups.Text = "По всем группам";
            radioButtonAllGroups.UseVisualStyleBackColor = true;
            // 
            // radioButtonRangeGroups
            // 
            radioButtonRangeGroups.AutoSize = true;
            radioButtonRangeGroups.Location = new Point(239, 16);
            radioButtonRangeGroups.Margin = new Padding(4, 4, 4, 4);
            radioButtonRangeGroups.Name = "radioButtonRangeGroups";
            radioButtonRangeGroups.Size = new Size(155, 27);
            radioButtonRangeGroups.TabIndex = 1;
            radioButtonRangeGroups.Text = "Из диапазона";
            radioButtonRangeGroups.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnlyWins
            // 
            checkBoxOnlyWins.AutoSize = true;
            checkBoxOnlyWins.Location = new Point(840, 65);
            checkBoxOnlyWins.Margin = new Padding(4, 4, 4, 4);
            checkBoxOnlyWins.Name = "checkBoxOnlyWins";
            checkBoxOnlyWins.Size = new Size(206, 27);
            checkBoxOnlyWins.TabIndex = 2;
            checkBoxOnlyWins.Text = "Только победители";
            checkBoxOnlyWins.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(619, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Bold", 10.2F);
            label1.Location = new Point(520, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 4;
            label1.Text = "от группы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica Bold", 10.2F);
            label2.Location = new Point(796, 16);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 6;
            label2.Text = "до группы";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(895, 8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fon2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1058, 536);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(radioButtonAllGroups);
            Controls.Add(checkBoxOnlyWins);
            Controls.Add(radioButtonRangeGroups);
            DoubleBuffered = true;
            Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxOnlyWins;
        private RadioButton radioButtonRangeGroups;
        private RadioButton radioButtonAllGroups;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
    }
}
