using System;

namespace Medication_Reminder_App
{
    public class UserMedicationLog
    {
        public int LogId { get; private set; }
        public int MedicationId { get; private set; }
        public string Notes { get; private set; }
        public DateTime TakenTime { get; private set; }

        public UserMedicationLog(
            int logId,
            int medicationId,
            string notes,
            DateTime takenTime)
        {
            if (logId <= 0)
                throw new ArgumentException(
                    "Log ID must be greater than zero.");

            if (medicationId <= 0)
                throw new ArgumentException(
                    "Medication ID must be greater than zero.");

            LogId = logId;
            MedicationId = medicationId;
            Notes = notes ?? string.Empty;
            TakenTime = takenTime;
        }

        public void LogMedicationTaken(int medicationId)
        {
            if (medicationId <= 0)
                throw new ArgumentException(
                    "Medication ID must be greater than zero.");

            MedicationId = medicationId;
            TakenTime = DateTime.Now;
        }
    }
}