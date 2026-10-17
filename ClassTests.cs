
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Medication_Reminder_App
{
    internal class ClassTests
    {
        public static void RunAllTests()
        {
            StringBuilder results = new StringBuilder();

            TestMedication(results);
            TestReminders(results);
            TestUserMedicationLog(results);

            MessageBox.Show(
                results.ToString(),
                "Class Test Results");
        }

        private static void TestMedication(StringBuilder results)
        {
            try
            {
                Medication medication = new Medication(
                    1,
                    "Test Medication",
                    "10mg",
                    "Twice daily",
                    DateTime.Today,
                    DateTime.Today.AddDays(7));

                if (medication.IsActive(DateTime.Today))
                    results.AppendLine("PASS: Medication is active.");
                else
                    results.AppendLine("FAIL: Medication should be active.");

                results.AppendLine("PASS: Medication was created.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Medication test - " + ex.Message);
            }
        }

        private static void TestReminders(StringBuilder results)
        {
            try
            {
                List<Reminders> reminders = Reminders.CreateDailyReminders(
                    1,
                    new List<TimeSpan>
                    {
                        new TimeSpan(8, 0, 0),
                        new TimeSpan(20, 0, 0)
                    },
                    1);

                if (reminders.Count == 2)
                    results.AppendLine("PASS: Two daily reminders were created.");
                else
                    results.AppendLine("FAIL: Expected two daily reminders.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Reminder test - " + ex.Message);
            }
        }

        private static void TestUserMedicationLog(StringBuilder results)
        {
            try
            {
                UserMedicationLog log = new UserMedicationLog(
                    1,
                    1,
                    "Test note",
                    DateTime.Now);

                log.LogMedicationTaken(1);

                if (log.MedicationId == 1 &&
                    log.TakenTime.Date == DateTime.Today)
                {
                    results.AppendLine("PASS: Medication taken was logged.");
                }
                else
                {
                    results.AppendLine("FAIL: Medication log data was incorrect.");
                }
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Medication log test - " + ex.Message);
            }
        }
    }
}
