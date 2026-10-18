
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Medication_Reminder_App
{
    public partial class FrmMedReminder : Form
    {
        private List<Medication> medications = new List<Medication>();
        private List<Reminders> reminders = new List<Reminders>();
        private List<UserMedicationLog> medicationLogs =
            new List<UserMedicationLog>();

        private int nextReminderId = 1;
        private int nextLogId = 1;

        public FrmMedReminder()
        {
            InitializeComponent();

            reminderTimer.Interval = 30000;
            reminderTimer.Tick -= ReminderTimer_Tick;
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();

            btnAddMed.Click -= btnAddMed_Click;
            btnAddMed.Click += btnAddMed_Click;

            btnMarkTaken.Click -= btnMarkTaken_Click;
            btnMarkTaken.Click += btnMarkTaken_Click;

            dgvMedsNRemind.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMedsNRemind.MultiSelect = false;
            dgvMedsNRemind.ReadOnly = true;
            dgvMedsNRemind.AllowUserToAddRows = false;

            dgvMedsNRemind.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedsNRemind.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;
            dgvMedsNRemind.AllowUserToAddRows = false;
            dgvMedsNRemind.ColumnHeadersVisible = false;
            dgvMedsNRemind.RowHeadersVisible = false;
            dgvMedsNRemind.ScrollBars = ScrollBars.Both;
        }



        private void btnAddMed_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMedId.Text, out int medicationId) ||
                medicationId <= 0)
            {
                MessageBox.Show("Enter a valid medication ID greater than zero.");
                return;
            }

            if (medications.Any(m => m.MedicationId == medicationId))
            {
                MessageBox.Show("That medication ID is already being used.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMedName.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text) ||
                string.IsNullOrWhiteSpace(cmbFrequency.Text))
            {
                MessageBox.Show("Enter the medication name, dosage, and frequency.");
                return;
            }

            if (!DateTime.TryParse(txtStDt.Text, out DateTime startDate) ||
                !DateTime.TryParse(txtEnDt.Text, out DateTime endDate))
            {
                MessageBox.Show("Enter valid start and end dates.");
                return;
            }

            try
            {
                Medication medication = new Medication(
                    medicationId,
                    txtMedName.Text.Trim(),
                    txtDosage.Text.Trim(),
                    cmbFrequency.Text.Trim(),
                    startDate,
                    endDate);

                List<TimeSpan> reminderTimes = new List<TimeSpan>();

                string frequency = cmbFrequency.Text.ToLowerInvariant();

                if (frequency.Contains("3") || frequency.Contains("three"))
                {
                    reminderTimes.Add(new TimeSpan(8, 0, 0));
                    reminderTimes.Add(new TimeSpan(14, 0, 0));
                    reminderTimes.Add(new TimeSpan(20, 0, 0));
                }
                else if (frequency.Contains("2") ||
                         frequency.Contains("twice"))
                {
                    reminderTimes.Add(new TimeSpan(8, 0, 0));
                    reminderTimes.Add(new TimeSpan(20, 0, 0));
                }
                else
                {
                    reminderTimes.Add(new TimeSpan(8, 0, 0));
                }

                List<Reminders> newReminders =
                    Reminders.CreateDailyReminders(
                        medicationId, reminderTimes, nextReminderId);

                nextReminderId += newReminders.Count;

                medications.Add(medication);
                reminders.AddRange(newReminders);

                dgvMedsNRemind.Rows.Add(
                    medication.Name,
                    medication.Dosage,
                    string.Join(", ", reminderTimes.Select(
                        time => DateTime.Today.Add(time).ToString("h:mm tt"))));

                dgvMedsNRemind.Rows[
                    dgvMedsNRemind.Rows.Count - 1].Tag = medication;

                int desiredHeight =
                    dgvMedsNRemind.Rows.Count * dgvMedsNRemind.RowTemplate.Height;

                dgvMedsNRemind.Height = Math.Min(desiredHeight, 300);

                MessageBox.Show("Medication added successfully.");

                txtMedId.Clear();
                txtMedName.Clear();
                txtDosage.Clear();
                txtStDt.Clear();
                txtEnDt.Clear();
                cmbFrequency.SelectedIndex = -1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Medication");
            }
        }

        private void btnMarkTaken_Click(object sender, EventArgs e)
        {
            if (dgvMedsNRemind.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a medication first.");
                return;
            }

            Medication medication =
                dgvMedsNRemind.SelectedRows[0].Tag as Medication;

            if (medication == null)
            {
                MessageBox.Show("The selected medication could not be found.");
                return;
            }

            string notes = txtNotes.Text.Trim();

            UserMedicationLog log = new UserMedicationLog(
                nextLogId,
                medication.MedicationId,
                notes,
                DateTime.Now);

            log.LogMedicationTaken(medication.MedicationId);

            medicationLogs.Add(log);
            nextLogId++;

            MessageBox.Show(
                medication.Name + " was marked as taken at " +
                log.TakenTime.ToString("g") + ".");

            txtNotes.Clear();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            foreach (Reminders reminder in reminders)
            {
                Medication medication = medications.FirstOrDefault(
                    m => m.MedicationId == reminder.MedicationId);

                if (medication != null &&
                    reminder.CheckReminders(medication))
                {
                    MessageBox.Show(
                        "Time to take your medication:\n" +
                        medication.Name + " - " + medication.Dosage,
                        "Medication Reminder",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            reminderTimer.Stop();
            base.OnFormClosed(e);
        }

        private void monthCalendar1_DateChanged(
            object sender, DateRangeEventArgs e)
        {
            txtStDt.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            // No action is needed while the user types the medication name.
        }
    }
}
