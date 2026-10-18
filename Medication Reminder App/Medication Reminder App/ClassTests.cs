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

            results.AppendLine("MEDICATION REMINDER CLASS TESTS");
            results.AppendLine();

            TestMedication(results);
            TestInvalidMedicationInputs(results);
            TestReminders(results);
            TestInvalidReminderInputs(results);
            TestReminderDoesNotTriggerTwice(results);
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
                    "10 mg",
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

        private static void TestInvalidMedicationInputs(StringBuilder results)
        {
            results.AppendLine();
            results.AppendLine("Testing invalid medication inputs...");

            try
            {
                new Medication(
                    1, "Test Med", "10 mg", "Once daily",
                    new DateTime(2026, 11, 10),
                    new DateTime(2026, 11, 1));

                results.AppendLine("FAIL: Invalid dates were accepted.");
            }
            catch (ArgumentException)
            {
                results.AppendLine("PASS: End date before start date rejected.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Unexpected date error - " + ex.Message);
            }

            try
            {
                new Medication(
                    0, "Test Med", "10 mg", "Once daily",
                    DateTime.Today, DateTime.Today.AddDays(7));

                results.AppendLine("FAIL: Invalid medication ID was accepted.");
            }
            catch (ArgumentException)
            {
                results.AppendLine("PASS: Medication ID of zero rejected.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Unexpected ID error - " + ex.Message);
            }

            try
            {
                new Medication(
                    2, " ", "10 mg", "Once daily",
                    DateTime.Today, DateTime.Today.AddDays(7));

                results.AppendLine("FAIL: Empty medication name was accepted.");
            }
            catch (ArgumentException)
            {
                results.AppendLine("PASS: Empty medication name rejected.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Unexpected name error - " + ex.Message);
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
                results.AppendLine("FAIL: Reminder creation test - " + ex.Message);
            }
        }

        private static void TestInvalidReminderInputs(StringBuilder results)
        {
            results.AppendLine();
            results.AppendLine("Testing invalid reminder inputs...");

            try
            {
                Reminders.CreateDailyReminders(
                    1,
                    new List<TimeSpan> { TimeSpan.FromDays(1) },
                    1);

                results.AppendLine("FAIL: Invalid reminder time was accepted.");
            }
            catch (ArgumentException)
            {
                results.AppendLine("PASS: Reminder time of 24 hours rejected.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Unexpected reminder time error - " + ex.Message);
            }

            try
            {
                new Reminders(0, 1, DateTime.Now, true);

                results.AppendLine("FAIL: Invalid reminder ID was accepted.");
            }
            catch (ArgumentException)
            {
                results.AppendLine("PASS: Reminder ID of zero rejected.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Unexpected reminder ID error - " + ex.Message);
            }
        }

        private static void TestReminderDoesNotTriggerTwice(StringBuilder results)
        {
            results.AppendLine();
            results.AppendLine("Testing repeated reminders...");

            try
            {
                Medication medication = new Medication(
                    50,
                    "Test Med",
                    "10 mg",
                    "Once daily",
                    DateTime.Today,
                    DateTime.Today.AddDays(7));

                Reminders reminder = new Reminders(
                    50,
                    50,
                    DateTime.Now.AddSeconds(-1),
                    true);

                bool firstCheck = reminder.CheckReminders(medication);
                bool secondCheck = reminder.CheckReminders(medication);

                if (firstCheck && !secondCheck)
                    results.AppendLine("PASS: Reminder triggered only once.");
                else
                    results.AppendLine("FAIL: Reminder trigger behavior was unexpected.");
            }
            catch (Exception ex)
            {
                results.AppendLine("FAIL: Reminder trigger test - " + ex.Message);
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