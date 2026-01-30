namespace LotterySportOrient.Views
{
    partial class FormLoadFile
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
            buttonLoadFile = new Button();
            openFileDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.BackColor = Color.MidnightBlue;
            buttonLoadFile.Dock = DockStyle.Fill;
            buttonLoadFile.ForeColor = SystemColors.ButtonHighlight;
            buttonLoadFile.Location = new Point(183, 85);
            buttonLoadFile.Margin = new Padding(4, 3, 4, 3);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(172, 76);
            buttonLoadFile.TabIndex = 0;
            buttonLoadFile.Text = "Загрузить json";
            buttonLoadFile.UseVisualStyleBackColor = false;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.fon2;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(buttonLoadFile, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(540, 247);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FormLoadFile
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 247);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(558, 294);
            MinimizeBox = false;
            MinimumSize = new Size(558, 294);
            Name = "FormLoadFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Загрузите файл";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoadFile;
        private OpenFileDialog openFileDialog;
        private TableLayoutPanel tableLayoutPanel1;
    }
}