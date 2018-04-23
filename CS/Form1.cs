using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;

namespace SchedulerStorageRangeControl {
    public partial class Form1 : Form {
        public static Random RandomInstance = new Random();

        public Form1() {
            InitializeComponent();
            // Create an object specifying the scheduler storage as a client of the RangeControl
            // to visualize appointment data within the RangeControl's viewport.
            Client = new SchedulerStorageRangeControlClient(schedulerStorage1);
            Client.BeginInit();
            Client.Options.RangeMinimum = DateTime.Today.AddMonths(-1);
            Client.Options.RangeMaximum = DateTime.Today.AddMonths(1);
            Client.EndInit();
            // Bind the scheduler storage to the RangeControl.
            rangeControl.Client = Client;

            // Fill the scheduler storage with appointment data.
            FillStorageData();

            // Set the time range that will be initially selected within the RangeControl.
            rangeControl.SelectedRange = 
                                    new RangeControlRange(DateTime.Today, DateTime.Today.AddDays(1));
        }
        public SchedulerStorageRangeControlClient Client { get; private set; }

        private void FillStorageData() {
            DateTime date = Client.Options.RangeMinimum;
            TimeSpan range = Client.Options.RangeMaximum - Client.Options.RangeMinimum;
            int count = range.Days;
            for (int i = 0; i < count; i++) {
                int appointmentsPerDay = RandomInstance.Next(15);
                GenerateDayAppointments(date, appointmentsPerDay);
                date = date.AddDays(1);
            }
        }
        protected void GenerateDayAppointments(DateTime date, int count) { 
            for (int i = 0; i < count; i++) {
                string subject = string.Format("Task #{0}", i + 1);
                DateTime start = date.AddHours(RandomInstance.Next(16));
                DateTime end = start.AddHours(RandomInstance.Next(3));
                int labelId = RandomInstance.Next(11);

                CreateAppointment(start, end, subject, labelId);
            }
        }
        private void CreateAppointment(DateTime start, DateTime end, string subject, int labelId) {
            Appointment apt = schedulerStorage1.CreateAppointment(AppointmentType.Normal);
            apt.Start = start;
            apt.End = end;
            apt.Subject = subject;
            apt.LabelId = labelId;
            apt.Description = string.Format("Event time from {0} to {1}", 
                                            start.ToShortTimeString(), end.ToShortTimeString());
            schedulerStorage1.Appointments.Add(apt);
        }

        // Make the GridControl display appointments contained in the time range
        // that is currently selected within the RangeControl.
        private void RangeControlRangeChanged(object sender, RangeControlRangeEventArgs e) {
            DateTime start = Convert.ToDateTime(e.Range.Minimum);
            DateTime end = Convert.ToDateTime(e.Range.Maximum);
            
            AppointmentBaseCollection appointments = schedulerStorage1.GetAppointments(start, end);

            int count = appointments.Count;
            Text = String.Format("[{0} - {1}] Count={2}", start, end, count);

            gridControl1.DataSource = appointments;
        }

    }
}