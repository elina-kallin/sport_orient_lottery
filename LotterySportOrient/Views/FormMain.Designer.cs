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
            tableLayoutPanel = new TableLayoutPanel();
            checkedListBoxGroups = new CheckedListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            buttonDeleteFilters = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonGenerate = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            labelNumber = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelSurname = new Label();
            labelName = new Label();
            labelGroupName = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            listBoxStackResults = new ListBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonAllGroups
            // 
            radioButtonAllGroups.AutoSize = true;
            radioButtonAllGroups.Checked = true;
            radioButtonAllGroups.Dock = DockStyle.Fill;
            radioButtonAllGroups.Location = new Point(63, 4);
            radioButtonAllGroups.Margin = new Padding(4);
            radioButtonAllGroups.Name = "radioButtonAllGroups";
            radioButtonAllGroups.Size = new Size(332, 68);
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
            radioButtonRangeGroups.Location = new Point(63, 80);
            radioButtonRangeGroups.Margin = new Padding(4);
            radioButtonRangeGroups.Name = "radioButtonRangeGroups";
            radioButtonRangeGroups.Size = new Size(332, 69);
            radioButtonRangeGroups.TabIndex = 1;
            radioButtonRangeGroups.Text = "Фильтр групп";
            radioButtonRangeGroups.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonRangeGroups.UseVisualStyleBackColor = true;
            radioButtonRangeGroups.Click += radioButtonRangeGroups_CheckedChanged;
            // 
            // checkBoxOnlyWins
            // 
            checkBoxOnlyWins.AutoSize = true;
            checkBoxOnlyWins.Location = new Point(4, 4);
            checkBoxOnlyWins.Margin = new Padding(4);
            checkBoxOnlyWins.Name = "checkBoxOnlyWins";
            checkBoxOnlyWins.Size = new Size(206, 27);
            checkBoxOnlyWins.TabIndex = 2;
            checkBoxOnlyWins.Text = "Только победители";
            checkBoxOnlyWins.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 556F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(checkedListBoxGroups, 1, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanel6, 2, 0);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1238, 159);
            tableLayoutPanel.TabIndex = 8;
            // 
            // checkedListBoxGroups
            // 
            checkedListBoxGroups.CheckOnClick = true;
            checkedListBoxGroups.Dock = DockStyle.Fill;
            checkedListBoxGroups.FormattingEnabled = true;
            checkedListBoxGroups.Location = new Point(408, 3);
            checkedListBoxGroups.Name = "checkedListBoxGroups";
            checkedListBoxGroups.Size = new Size(550, 153);
            checkedListBoxGroups.TabIndex = 3;
            checkedListBoxGroups.SelectedIndexChanged += checkedListBoxGroups_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7869673F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.2130356F));
            tableLayoutPanel3.Controls.Add(radioButtonRangeGroups, 1, 1);
            tableLayoutPanel3.Controls.Add(radioButtonAllGroups, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(399, 153);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(buttonDeleteFilters, 0, 2);
            tableLayoutPanel6.Controls.Add(checkBoxOnlyWins, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(964, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel6.Size = new Size(271, 153);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // buttonDeleteFilters
            // 
            buttonDeleteFilters.Location = new Point(3, 101);
            buttonDeleteFilters.Name = "buttonDeleteFilters";
            buttonDeleteFilters.Size = new Size(207, 49);
            buttonDeleteFilters.TabIndex = 0;
            buttonDeleteFilters.Text = "Сбросить фильтры";
            buttonDeleteFilters.UseVisualStyleBackColor = true;
            buttonDeleteFilters.Click += buttonDeleteFilters_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.9563828F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.66882F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2940235F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(labelNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 165);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.045226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.603775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.5013466F));
            tableLayoutPanel1.Size = new Size(1238, 371);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonGenerate);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(1017, 245);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(218, 123);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.DarkSlateBlue;
            buttonGenerate.Dock = DockStyle.Right;
            buttonGenerate.ForeColor = SystemColors.ButtonHighlight;
            buttonGenerate.Location = new Point(3, 60);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(206, 60);
            buttonGenerate.TabIndex = 7;
            buttonGenerate.Text = "Сгенерировать";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(411, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(547, 27);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Helvetica Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 0);
            label3.Name = "label3";
            label3.Size = new Size(176, 27);
            label3.TabIndex = 0;
            label3.Text = "номер";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.BackColor = SystemColors.Control;
            labelNumber.Dock = DockStyle.Fill;
            labelNumber.Font = new Font("Helvetica Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumber.Location = new Point(411, 33);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(547, 209);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "0";
            labelNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(labelSurname, 0, 0);
            tableLayoutPanel4.Controls.Add(labelName, 0, 1);
            tableLayoutPanel4.Controls.Add(labelGroupName, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(411, 245);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(547, 123);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Dock = DockStyle.Fill;
            labelSurname.Location = new Point(3, 0);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(541, 41);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Фамилия";
            labelSurname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(3, 41);
            labelName.Name = "labelName";
            labelName.Size = new Size(541, 41);
            labelName.TabIndex = 3;
            labelName.Text = "Имя";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGroupName
            // 
            labelGroupName.AutoSize = true;
            labelGroupName.Dock = DockStyle.Fill;
            labelGroupName.Location = new Point(3, 82);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new Size(541, 41);
            labelGroupName.TabIndex = 4;
            labelGroupName.Text = "группа";
            labelGroupName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.681592F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.3184052F));
            tableLayoutPanel5.Controls.Add(listBoxStackResults, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 36);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(402, 203);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // listBoxStackResults
            // 
            listBoxStackResults.BorderStyle = BorderStyle.None;
            listBoxStackResults.Dock = DockStyle.Fill;
            listBoxStackResults.FormattingEnabled = true;
            listBoxStackResults.HorizontalScrollbar = true;
            listBoxStackResults.ImeMode = ImeMode.NoControl;
            listBoxStackResults.ItemHeight = 23;
            listBoxStackResults.Location = new Point(58, 3);
            listBoxStackResults.Name = "listBoxStackResults";
            listBoxStackResults.Size = new Size(341, 197);
            listBoxStackResults.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.9303484F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.06965F));
            tableLayoutPanel7.Controls.Add(label1, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(402, 27);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 27);
            label1.TabIndex = 4;
            label1.Text = "стек номеров";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBoxOnlyWins;
        private RadioButton radioButtonRangeGroups;
        private RadioButton radioButtonAllGroups;
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckedListBox checkedListBoxGroups;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelSurname;
        private Label labelName;
        private Label labelGroupName;
        private Button buttonDeleteFilters;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonGenerate;
        private Label label1;
        private ListBox listBoxStackResults;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelNumber;
        private TableLayoutPanel tableLayoutPanel7;
    }
}
