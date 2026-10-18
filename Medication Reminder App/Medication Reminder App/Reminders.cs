using System;
using System.Collections.Generic;

namespace Medication_Reminder_App
{
    public class Reminders
    {
        private int ReminderId { get; set; }
        public int MedicationId { get; set; }
        public DateTime ReminderTime { get; set; }
        private bool IsActive { get; set; }
        private DateTime? LastTriggeredDate { get; set; }

        public Reminders(int reminderId, int medicationId,
            DateTime reminderTime, bool isActive)
        {
            if (reminderId <= 0)
                throw new ArgumentException("Reminder ID must be greater than zero.");
            if (medicationId <= 0)
                throw new ArgumentException("Medication ID must be greater than zero.");

            ReminderId = reminderId;
            MedicationId = medicationId;
            ReminderTime = reminderTime;
            IsActive = isActive;
            LastTriggeredDate = null;
        }

        public bool CheckReminders(Medication medication)
        {
            if (medication == null)
                throw new ArgumentNullException(nameof(medication));

            if (medication.MedicationId != MedicationId)
                throw new ArgumentException("Medication does not match this reminder.");

            if (!IsActive || !medication.IsActive(DateTime.Now))
                return false;

            if (LastTriggeredDate.HasValue)
                return false;

            if (DateTime.Now >= ReminderTime)
            {
                LastTriggeredDate = DateTime.Now;
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
                    throw new ArgumentException("Reminder time must be within one day.");

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
