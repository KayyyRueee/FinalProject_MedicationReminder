using System;

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


        public Medication(int medicationId, string name, string dosage, string frequency, DateTime startDate, DateTime endDate)
        {
            if (medicationId <= 0)
                throw new ArgumentException("Medication ID must be greater than zero.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Medication name is required.");

            if (string.IsNullOrWhiteSpace(dosage))
                throw new ArgumentException("Dosage is required.");

            if (string.IsNullOrWhiteSpace(frequency))
                throw new ArgumentException("Frequency is required.");

            if (endDate < startDate)
                throw new ArgumentException("End date cannot be before start date.");

            this.MedicationId = medicationId;
            this.Name = name;
            this.Dosage = dosage;
            this.Frequency = frequency;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public bool IsDue(DateTime currentTime)
        {
            return currentTime.Date >= this.StartDate.Date && currentTime.Date <= this.EndDate.Date;
        }

        public bool IsActive(DateTime currentTime)
        {
            return currentTime.Date >= StartDate.Date &&
                   currentTime.Date <= EndDate.Date;
        }
    }
}
