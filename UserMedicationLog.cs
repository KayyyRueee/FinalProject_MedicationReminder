using System;
using System.Collections.Generic;

namespace Medication_Reminder_App
{
    internal class UserMedicationLog
    {
        public int LogId { get; set; }
        public int MedicationId { get; set; }
        public string Notes { get; set; }
        public DateTime TakenTime { get; set; }

        public UserMedicationLog(int LogId, int MedicationId, string Notes, DateTime TakenTime)
        {
            if (LogId <= 0)
                throw new ArgumentException(
                    "Log ID must be greater than zero.");

            if (MedicationId <= 0)
                throw new ArgumentException(
                    "Medication ID must be greater than zero.");

            this.LogId = LogId;
            this.MedicationId = MedicationId;
            this.Notes = Notes;
            this.TakenTime = TakenTime;
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
