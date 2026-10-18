using System;


namespace Medication_Reminder_App
{
    internal class UserMedicationLog
    {
        public int LogId { get; set; }
        public int MedicationId { get; set; }
        public string Notes { get; set; }
        public DateTime TakenTime { get; set; }

        public UserMedicationLog(int logId, int medicationId, string notes, DateTime takenTime)
        {
            if (logId <= 0)
                throw new ArgumentException(
                    "Log ID must be greater than zero.");

            if (medicationId <= 0)
                throw new ArgumentException(
                    "Medication ID must be greater than zero.");

            this.LogId = logId;
            this.MedicationId = medicationId;
            this.Notes = notes ?? string.Empty;
            this.TakenTime = takenTime;
        }

        public void LogMedicationTaken(int medicationId)
        {
            //if statement first to validate the medication ID
            if (medicationId <= 0)
                throw new ArgumentException(
                    "Medication ID must be greater than zero.");   //stops the app from logging a medication that doesn't exist in the database

            this.MedicationId = medicationId; //stores which meds were taken
            this.TakenTime = DateTime.Now;    //stores the time the meds were taken
        }

       
    }
}
