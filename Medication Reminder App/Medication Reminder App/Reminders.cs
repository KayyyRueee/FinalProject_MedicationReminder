using System;
using System.Collections.Generic;


namespace Medication_Reminder_App
{
    internal class Reminders
    {
        private int ReminderId { get; set; }
        public int MedicationId { get; set; }
        public DateTime ReminderTime { get; set; }
        private bool IsActive { get; set; }
        private DateTime? LastTriggeredDate { get; set; }   //Helps the app remember whether the reminder was triggered

        public Reminders(int reminderId, int medicationId,
                            DateTime reminderTime, bool isActive)
        {
            if (reminderId <= 0)
                throw new ArgumentException("Reminder ID must be greater than zero.");
            if (medicationId <= 0)
                throw new ArgumentException("Medication ID must be greater than zero.");

            this.ReminderId = reminderId;
            this.MedicationId = medicationId;
            this.ReminderTime = reminderTime;
            this.IsActive = isActive;
            this.LastTriggeredDate = null;
        }

        public bool CheckReminders(Medication medication)
        {
            if (medication == null)
                throw new ArgumentNullException(nameof(medication));

            if (medication.MedicationId != MedicationId)
                throw new ArgumentException(
                    "The medication does not match this reminder.", nameof(medication));

            DateTime now = DateTime.Now; // the now stores the current date and time

            if (!IsActive || !medication.IsActive(now))
                return false;

            bool timeReached =
                now.TimeOfDay >= ReminderTime.TimeOfDay;  //Checks only the time not the date as well. This is for 7:00 alamrs everyday

            bool notTriggeredToday =
                LastTriggeredDate == null ||
                LastTriggeredDate.Value.Date != now.Date;

            if (timeReached && notTriggeredToday)
            {
                LastTriggeredDate = now.Date;
                return true;
            }

            return false;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public static List<Reminders> CreateDailyReminders(
            int medicationId, List<TimeSpan> times, int firstReminderId)
        {
            if (medicationId <= 0)
                throw new ArgumentException("Medication ID must be greater than zero.");

            if (firstReminderId <= 0)
                throw new ArgumentException("Reminder ID must be greater than zero.");

            if (times == null)
                throw new ArgumentNullException(nameof(times));

            List<Reminders> reminders = new List<Reminders>();

            foreach (TimeSpan time in times)
            {
                if (time < TimeSpan.Zero || time >= TimeSpan.FromDays(1))
                    throw new ArgumentException(
                        "Reminder times must be within one day.");

                reminders.Add(new Reminders(
                    firstReminderId++,
                    medicationId,
                    DateTime.Today.Add(time),
                    true));
            }

            return reminders;
        }

    }
}
