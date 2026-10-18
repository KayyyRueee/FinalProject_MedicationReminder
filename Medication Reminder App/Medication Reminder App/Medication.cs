using System;

namespace Medication_Reminder_App
{
    public class Medication
    {
        public int MedicationId { get; private set; }
        public string Name { get; private set; }
        public string Dosage { get; private set; }
        public string Frequency { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Medication(
            int medicationId,
            string name,
            string dosage,
            string frequency,
            DateTime startDate,
            DateTime endDate)
        {
            if (medicationId <= 0)
                throw new ArgumentException(
                    "Medication ID must be greater than zero.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Medication name is required.");

            if (string.IsNullOrWhiteSpace(dosage))
                throw new ArgumentException(
                    "Dosage is required.");

            if (string.IsNullOrWhiteSpace(frequency))
                throw new ArgumentException(
                    "Frequency is required.");

            if (endDate.Date < startDate.Date)
                throw new ArgumentException(
                    "End date cannot be before start date.");

            MedicationId = medicationId;
            Name = name.Trim();
            Dosage = dosage.Trim();
            Frequency = frequency.Trim();
            StartDate = startDate.Date;
            EndDate = endDate.Date;
        }

        public bool IsActive(DateTime currentTime)
        {
            return currentTime.Date >= StartDate.Date &&
                   currentTime.Date <= EndDate.Date;
        }

        public bool IsDue(DateTime currentTime)
        {
            return IsActive(currentTime);
        }
    }
}