namespace Medication_Reminder_App
{
    partial class FrmMedReminder
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedReminder));
            lblMedReminder = new Label();
            lblMedName = new Label();
            lblMedId = new Label();
            lblDosage = new Label();
            lblFreq = new Label();
            lblStDt = new Label();
            lblEnDt = new Label();
            txtMedName = new TextBox();
            txtMedId = new TextBox();
            txtDosage = new TextBox();
            txtStDt = new TextBox();
            txtEnDt = new TextBox();
            cmbFrequency = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            reminderTimer = new System.Windows.Forms.Timer(components);
            lblDashBoard = new Label();
            btnAddMed = new Button();
            lblMyMeds = new Label();
            lblMedLog = new Label();
            lblSelectmed = new Label();
            lblNotes = new Label();
            dgvMedsNRemind = new DataGridView();
            ColMedicationName = new DataGridViewTextBoxColumn();
            ColDosage = new DataGridViewTextBoxColumn();
            ColReminder = new DataGridViewTextBoxColumn();
            txtNotes = new TextBox();
            btnMarkTaken = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedsNRemind).BeginInit();
            SuspendLayout();
            // 
            // lblMedReminder
            // 
            lblMedReminder.AutoSize = true;
            lblMedReminder.Font = new Font("Times New Roman", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMedReminder.ForeColor = Color.DarkSlateBlue;
            lblMedReminder.Location = new Point(216, 20);
            lblMedReminder.Name = "lblMedReminder";
            lblMedReminder.Size = new Size(343, 43);
            lblMedReminder.TabIndex = 0;
            lblMedReminder.Text = "Medication Reminder";
            // 
            // lblMedName
            // 
            lblMedName.AutoSize = true;
            lblMedName.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMedName.ForeColor = Color.SlateBlue;
            lblMedName.Location = new Point(63, 116);
            lblMedName.Name = "lblMedName";
            lblMedName.Size = new Size(146, 20);
            lblMedName.TabIndex = 1;
            lblMedName.Text = "Medication Name: ";
            // 
            // lblMedId
            // 
            lblMedId.AutoSize = true;
            lblMedId.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMedId.ForeColor = Color.SlateBlue;
            lblMedId.Location = new Point(405, 120);
            lblMedId.Name = "lblMedId";
            lblMedId.Size = new Size(53, 20);
            lblMedId.TabIndex = 2;
            lblMedId.Text = "RX #: ";
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDosage.ForeColor = Color.SlateBlue;
            lblDosage.Location = new Point(388, 177);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(72, 20);
            lblDosage.TabIndex = 3;
            lblDosage.Text = "Dosage: ";
            // 
            // lblFreq
            // 
            lblFreq.AutoSize = true;
            lblFreq.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFreq.ForeColor = Color.SlateBlue;
            lblFreq.Location = new Point(63, 178);
            lblFreq.Name = "lblFreq";
            lblFreq.Size = new Size(94, 20);
            lblFreq.TabIndex = 4;
            lblFreq.Text = "Frequency: ";
            // 
            // lblStDt
            // 
            lblStDt.AutoSize = true;
            lblStDt.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
            lblStDt.ForeColor = Color.SlateBlue;
            lblStDt.Location = new Point(63, 240);
            lblStDt.Name = "lblStDt";
            lblStDt.Size = new Size(92, 20);
            lblStDt.TabIndex = 5;
            lblStDt.Text = "Start Date: ";
            // 
            // lblEnDt
            // 
            lblEnDt.AutoSize = true;
            lblEnDt.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnDt.ForeColor = Color.SlateBlue;
            lblEnDt.Location = new Point(372, 241);
            lblEnDt.Name = "lblEnDt";
            lblEnDt.Size = new Size(86, 20);
            lblEnDt.TabIndex = 6;
            lblEnDt.Text = "End Date: ";
            // 
            // txtMedName
            // 
            txtMedName.Location = new Point(216, 116);
            txtMedName.Name = "txtMedName";
            txtMedName.Size = new Size(140, 27);
            txtMedName.TabIndex = 7;
            txtMedName.TextChanged += txtMedName_TextChanged;
            // 
            // txtMedId
            // 
            txtMedId.Location = new Point(461, 116);
            txtMedId.Name = "txtMedId";
            txtMedId.Size = new Size(140, 27);
            txtMedId.TabIndex = 8;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(466, 173);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(140, 27);
            txtDosage.TabIndex = 10;
            // 
            // txtStDt
            // 
            txtStDt.Location = new Point(163, 237);
            txtStDt.Name = "txtStDt";
            txtStDt.Size = new Size(169, 27);
            txtStDt.TabIndex = 11;
            // 
            // txtEnDt
            // 
            txtEnDt.Location = new Point(466, 237);
            txtEnDt.Name = "txtEnDt";
            txtEnDt.Size = new Size(140, 27);
            txtEnDt.TabIndex = 12;
            // 
            // cmbFrequency
            // 
            cmbFrequency.FormattingEnabled = true;
            cmbFrequency.Items.AddRange(new object[] { "Once A Day", "Twice A Day", "Three times A day" });
            cmbFrequency.Location = new Point(163, 178);
            cmbFrequency.Name = "cmbFrequency";
            cmbFrequency.Size = new Size(169, 27);
            cmbFrequency.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.AntiqueWhite;
            monthCalendar1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar1.ForeColor = SystemColors.MenuText;
            monthCalendar1.Location = new Point(655, 69);
            monthCalendar1.Margin = new Padding(10, 9, 10, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 14;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // reminderTimer
            // 
            reminderTimer.Interval = 3000;
            reminderTimer.Tick += ReminderTimer_Tick;
            // 
            // lblDashBoard
            // 
            lblDashBoard.AutoSize = true;
            lblDashBoard.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = Color.SlateBlue;
            lblDashBoard.Location = new Point(216, 69);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(323, 20);
            lblDashBoard.TabIndex = 15;
            lblDashBoard.Text = "Your daily medication reminder dashboard";
            // 
            // btnAddMed
            // 
            btnAddMed.BackColor = Color.FromArgb(176, 160, 255);
            btnAddMed.FlatStyle = FlatStyle.Popup;
            btnAddMed.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddMed.Location = new Point(242, 291);
            btnAddMed.Name = "btnAddMed";
            btnAddMed.Size = new Size(271, 28);
            btnAddMed.TabIndex = 16;
            btnAddMed.Text = "Add Medication";
            btnAddMed.UseVisualStyleBackColor = false;
            // 
            // lblMyMeds
            // 
            lblMyMeds.AutoSize = true;
            lblMyMeds.Font = new Font("Times New Roman", 13.2F, FontStyle.Italic);
            lblMyMeds.ForeColor = Color.DarkSlateBlue;
            lblMyMeds.Location = new Point(19, 338);
            lblMyMeds.Name = "lblMyMeds";
            lblMyMeds.Size = new Size(154, 25);
            lblMyMeds.TabIndex = 17;
            lblMyMeds.Text = "My Medications";
            // 
            // lblMedLog
            // 
            lblMedLog.AutoSize = true;
            lblMedLog.Font = new Font("Times New Roman", 13.2F, FontStyle.Italic);
            lblMedLog.ForeColor = Color.DarkSlateBlue;
            lblMedLog.Location = new Point(21, 533);
            lblMedLog.Name = "lblMedLog";
            lblMedLog.Size = new Size(151, 25);
            lblMedLog.TabIndex = 18;
            lblMedLog.Text = "Medication Log";
            // 
            // lblSelectmed
            // 
            lblSelectmed.AutoSize = true;
            lblSelectmed.ForeColor = Color.SlateBlue;
            lblSelectmed.Location = new Point(63, 568);
            lblSelectmed.Name = "lblSelectmed";
            lblSelectmed.Size = new Size(254, 19);
            lblSelectmed.TabIndex = 19;
            lblSelectmed.Text = "Select a medication to log as taken";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Times New Roman", 12.2F, FontStyle.Italic);
            lblNotes.ForeColor = Color.SlateBlue;
            lblNotes.Location = new Point(35, 691);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(58, 23);
            lblNotes.TabIndex = 21;
            lblNotes.Text = "Notes";
            // 
            // dgvMedsNRemind
            // 
            dgvMedsNRemind.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvMedsNRemind.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedsNRemind.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMedsNRemind.BackgroundColor = Color.BlanchedAlmond;
            dgvMedsNRemind.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMedsNRemind.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMedsNRemind.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedsNRemind.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedsNRemind.ColumnHeadersVisible = false;
            dgvMedsNRemind.Columns.AddRange(new DataGridViewColumn[] { ColMedicationName, ColDosage, ColReminder });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMedsNRemind.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMedsNRemind.Location = new Point(181, 369);
            dgvMedsNRemind.MaximumSize = new Size(450, 146);
            dgvMedsNRemind.MinimumSize = new Size(378, 33);
            dgvMedsNRemind.Name = "dgvMedsNRemind";
            dgvMedsNRemind.RowHeadersVisible = false;
            dgvMedsNRemind.RowHeadersWidth = 51;
            dgvMedsNRemind.Size = new Size(378, 33);
            dgvMedsNRemind.TabIndex = 24;
            // 
            // ColMedicationName
            // 
            ColMedicationName.HeaderText = "Medication";
            ColMedicationName.MinimumWidth = 6;
            ColMedicationName.Name = "ColMedicationName";
            // 
            // ColDosage
            // 
            ColDosage.HeaderText = "Dosage";
            ColDosage.MinimumWidth = 6;
            ColDosage.Name = "ColDosage";
            // 
            // ColReminder
            // 
            ColReminder.HeaderText = "Next Reminder";
            ColReminder.MinimumWidth = 6;
            ColReminder.Name = "ColReminder";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.BlanchedAlmond;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Location = new Point(208, 715);
            txtNotes.MinimumSize = new Size(331, 148);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(331, 148);
            txtNotes.TabIndex = 25;
            // 
            // btnMarkTaken
            // 
            btnMarkTaken.BackColor = Color.FromArgb(176, 160, 255);
            btnMarkTaken.FlatStyle = FlatStyle.Popup;
            btnMarkTaken.Font = new Font("Times New Roman", 11.2F, FontStyle.Italic);
            btnMarkTaken.Location = new Point(199, 619);
            btnMarkTaken.Name = "btnMarkTaken";
            btnMarkTaken.Size = new Size(340, 29);
            btnMarkTaken.TabIndex = 26;
            btnMarkTaken.Text = "Log Medication";
            btnMarkTaken.UseVisualStyleBackColor = false;
            // 
            // FrmMedReminder
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(987, 922);
            Controls.Add(btnMarkTaken);
            Controls.Add(txtNotes);
            Controls.Add(dgvMedsNRemind);
            Controls.Add(lblNotes);
            Controls.Add(lblSelectmed);
            Controls.Add(lblMedLog);
            Controls.Add(lblMyMeds);
            Controls.Add(btnAddMed);
            Controls.Add(lblDashBoard);
            Controls.Add(monthCalendar1);
            Controls.Add(cmbFrequency);
            Controls.Add(txtEnDt);
            Controls.Add(txtStDt);
            Controls.Add(txtDosage);
            Controls.Add(txtMedId);
            Controls.Add(txtMedName);
            Controls.Add(lblEnDt);
            Controls.Add(lblStDt);
            Controls.Add(lblFreq);
            Controls.Add(lblDosage);
            Controls.Add(lblMedId);
            Controls.Add(lblMedName);
            Controls.Add(lblMedReminder);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMedReminder";
            Text = "Medication Reminder";
            ((System.ComponentModel.ISupportInitialize)dgvMedsNRemind).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedReminder;
        private Label lblMedName;
        private Label lblMedId;
        private Label lblDosage;
        private Label lblFreq;
        private Label lblStDt;
        private Label lblEnDt;
        private TextBox txtMedName;
        private TextBox txtMedId;
        private TextBox txtDosage;
        private TextBox txtStDt;
        private TextBox txtEnDt;
        private ComboBox cmbFrequency;
        private MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer reminderTimer;
        private Label lblDashBoard;
        private Button btnAddMed;
        private Label lblMyMeds;
        private Label lblMedLog;
        private Label lblSelectmed;
        private Label lblNotes;
        private DataGridView dgvMedsNRemind;
        private DataGridViewTextBoxColumn ColMedicationName;
        private DataGridViewTextBoxColumn ColDosage;
        private DataGridViewTextBoxColumn ColReminder;
        private TextBox txtNotes;
        private Button btnMarkTaken;
    }
}
