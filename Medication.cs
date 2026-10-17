using System;
using System.Collections.Generic;
using System.Text;

namespace Medication_Reminder_App
{
    internal class Medication
    {
        public string Name { get; set; }
        public int MedicationId { get; set; }
        public string Dosage { get; set; } 
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Medication(int MedicationId, string Name, string Dosage, string Frequency, DateTime StartDate, DateTime EndDate)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Medication name is required.");

            if (string.IsNullOrWhiteSpace(Dosage))
                throw new ArgumentException("Dosage is required.");

            if (string.IsNullOrWhiteSpace(Frequency))
                throw new ArgumentException("Frequency is required.");

            if (EndDate < StartDate)
                throw new ArgumentException("End date cannot be before start date.");

            this.MedicationId = MedicationId;
            this.Name = Name;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        public bool IsDue(DateTime currentTime)
        {
            return currentTime.Date >= this.StartDate && currentTime.Date <= this.EndDate;
        }

        public bool IsActive(DateTime currentTime)
        {
            return currentTime.Date >= StartDate.Date &&
                   currentTime.Date <= EndDate.Date;
        }
    }
}
