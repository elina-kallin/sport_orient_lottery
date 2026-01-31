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
            buttonGenerate = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            checkedListBoxGroups = new CheckedListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            labelNumber = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            labelSurname = new Label();
            labelName = new Label();
            labelGroupName = new Label();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonAllGroups
            // 
            radioButtonAllGroups.AutoSize = true;
            radioButtonAllGroups.Checked = true;
            radioButtonAllGroups.Dock = DockStyle.Fill;
            radioButtonAllGroups.Location = new Point(134, 4);
            radioButtonAllGroups.Margin = new Padding(4);
            radioButtonAllGroups.Name = "radioButtonAllGroups";
            radioButtonAllGroups.Size = new Size(191, 48);
            radioButtonAllGroups.TabIndex = 0;
            radioButtonAllGroups.TabStop = true;
            radioButtonAllGroups.Text = "По всем группам";
            radioButtonAllGroups.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonAllGroups.UseVisualStyleBackColor = true;
            radioButtonAllGroups.CheckedChanged += radioButtonAllGroups_CheckedChanged;
            // 
            // radioButtonRangeGroups
            // 
            radioButtonRangeGroups.AutoSize = true;
            radioButtonRangeGroups.Dock = DockStyle.Fill;
            radioButtonRangeGroups.Location = new Point(134, 60);
            radioButtonRangeGroups.Margin = new Padding(4);
            radioButtonRangeGroups.Name = "radioButtonRangeGroups";
            radioButtonRangeGroups.Size = new Size(191, 49);
            radioButtonRangeGroups.TabIndex = 1;
            radioButtonRangeGroups.Text = "Фильтр групп";
            radioButtonRangeGroups.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonRangeGroups.UseVisualStyleBackColor = true;
            radioButtonRangeGroups.Click += radioButtonRangeGroups_CheckedChanged;
            // 
            // checkBoxOnlyWins
            // 
            checkBoxOnlyWins.AutoSize = true;
            checkBoxOnlyWins.Location = new Point(1018, 4);
            checkBoxOnlyWins.Margin = new Padding(4);
            checkBoxOnlyWins.Name = "checkBoxOnlyWins";
            checkBoxOnlyWins.Size = new Size(206, 27);
            checkBoxOnlyWins.TabIndex = 2;
            checkBoxOnlyWins.Text = "Только победители";
            checkBoxOnlyWins.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.DarkSlateBlue;
            buttonGenerate.Dock = DockStyle.Right;
            buttonGenerate.ForeColor = SystemColors.ButtonHighlight;
            buttonGenerate.Location = new Point(3, 117);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(206, 60);
            buttonGenerate.TabIndex = 7;
            buttonGenerate.Text = "Сгенерировать";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 405F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 224F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(checkedListBoxGroups, 1, 0);
            tableLayoutPanel.Controls.Add(checkBoxOnlyWins, 4, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1238, 119);
            tableLayoutPanel.TabIndex = 8;
            // 
            // checkedListBoxGroups
            // 
            checkedListBoxGroups.CheckOnClick = true;
            checkedListBoxGroups.Dock = DockStyle.Fill;
            checkedListBoxGroups.FormattingEnabled = true;
            checkedListBoxGroups.Location = new Point(445, 3);
            checkedListBoxGroups.Name = "checkedListBoxGroups";
            checkedListBoxGroups.Size = new Size(399, 113);
            checkedListBoxGroups.TabIndex = 3;
            checkedListBoxGroups.SelectedIndexChanged += checkedListBoxGroups_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0458717F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.87156F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3119259F));
            tableLayoutPanel3.Controls.Add(radioButtonRangeGroups, 1, 1);
            tableLayoutPanel3.Controls.Add(radioButtonAllGroups, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(436, 113);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(labelNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 138);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.045226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.2211037F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.73367F));
            tableLayoutPanel1.Size = new Size(1238, 398);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonGenerate);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(1017, 215);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(218, 180);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(415, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(406, 30);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Helvetica Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 0;
            label3.Text = "номер";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.BackColor = SystemColors.Control;
            labelNumber.Dock = DockStyle.Fill;
            labelNumber.Font = new Font("Helvetica", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumber.Location = new Point(415, 36);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(406, 176);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.23645F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.76355F));
            tableLayoutPanel4.Controls.Add(label1, 0, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 2);
            tableLayoutPanel4.Controls.Add(labelSurname, 1, 0);
            tableLayoutPanel4.Controls.Add(labelName, 1, 1);
            tableLayoutPanel4.Controls.Add(labelGroupName, 1, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(415, 215);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel4.Size = new Size(406, 180);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 55);
            label1.Name = "label1";
            label1.Size = new Size(132, 55);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 110);
            label2.Name = "label2";
            label2.Size = new Size(132, 70);
            label2.TabIndex = 1;
            label2.Text = "группа";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Dock = DockStyle.Fill;
            labelSurname.Location = new Point(141, 0);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(262, 55);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Фамилия";
            labelSurname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(141, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(262, 55);
            labelName.TabIndex = 3;
            labelName.Text = "Имя";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGroupName
            // 
            labelGroupName.AutoSize = true;
            labelGroupName.Dock = DockStyle.Fill;
            labelGroupName.Location = new Point(141, 110);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new Size(262, 70);
            labelGroupName.TabIndex = 4;
            labelGroupName.Text = "группа";
            labelGroupName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1238, 536);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += FormMain_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBoxOnlyWins;
        private RadioButton radioButtonRangeGroups;
        private RadioButton radioButtonAllGroups;
        private Button buttonGenerate;
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelNumber;
        private CheckedListBox checkedListBoxGroups;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label labelSurname;
        private Label labelName;
        private Label labelGroupName;
    }
}
