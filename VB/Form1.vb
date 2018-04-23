Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors

Namespace SchedulerStorageRangeControl
	Partial Public Class Form1
		Inherits Form
		Public Shared RandomInstance As New Random()

		Public Sub New()
			InitializeComponent()
			' Create an object specifying the scheduler storage as a client of the RangeControl
			' to visualize appointment data within the RangeControl's viewport.
			Client = New SchedulerStorageRangeControlClient(schedulerStorage1)
			Client.BeginInit()
			Client.Options.RangeMinimum = DateTime.Today.AddMonths(-1)
			Client.Options.RangeMaximum = DateTime.Today.AddMonths(1)
			Client.EndInit()
			' Bind the scheduler storage to the RangeControl.
			rangeControl.Client = Client

			' Fill the scheduler storage with appointment data.
			FillStorageData()

			' Set the time range that will be initially selected within the RangeControl.
			rangeControl.SelectedRange = New RangeControlRange(DateTime.Today, DateTime.Today.AddDays(1))
		End Sub
		Private privateClient As SchedulerStorageRangeControlClient
		Public Property Client() As SchedulerStorageRangeControlClient
			Get
				Return privateClient
			End Get
			Private Set(ByVal value As SchedulerStorageRangeControlClient)
				privateClient = value
			End Set
		End Property

		Private Sub FillStorageData()
			Dim [date] As DateTime = Client.Options.RangeMinimum
			Dim range As TimeSpan = Client.Options.RangeMaximum - Client.Options.RangeMinimum
			Dim count As Integer = range.Days
			For i As Integer = 0 To count - 1
				Dim appointmentsPerDay As Integer = RandomInstance.Next(15)
				GenerateDayAppointments([date], appointmentsPerDay)
				[date] = [date].AddDays(1)
			Next i
		End Sub
		Protected Sub GenerateDayAppointments(ByVal [date] As DateTime, ByVal count As Integer)
			For i As Integer = 0 To count - 1
				Dim subject As String = String.Format("Task #{0}", i + 1)
				Dim start As DateTime = [date].AddHours(RandomInstance.Next(16))
				Dim [end] As DateTime = start.AddHours(RandomInstance.Next(3))
				Dim labelId As Integer = RandomInstance.Next(11)

				CreateAppointment(start, [end], subject, labelId)
			Next i
		End Sub
		Private Sub CreateAppointment(ByVal start As DateTime, ByVal [end] As DateTime, ByVal subject As String, ByVal labelId As Integer)
			Dim apt As Appointment = schedulerStorage1.CreateAppointment(AppointmentType.Normal)
			apt.Start = start
			apt.End = [end]
			apt.Subject = subject
			apt.LabelId = labelId
			apt.Description = String.Format("Event time from {0} to {1}", start.ToShortTimeString(), [end].ToShortTimeString())
			schedulerStorage1.Appointments.Add(apt)
		End Sub

		' Make the GridControl display appointments contained in the time range
		' that is currently selected within the RangeControl.
		Private Sub RangeControlRangeChanged(ByVal sender As Object, ByVal e As RangeControlRangeEventArgs) Handles rangeControl.RangeChanged
			Dim start As DateTime = Convert.ToDateTime(e.Range.Minimum)
			Dim [end] As DateTime = Convert.ToDateTime(e.Range.Maximum)

			Dim appointments As AppointmentBaseCollection = schedulerStorage1.GetAppointments(start, [end])

			Dim count As Integer = appointments.Count
			Text = String.Format("[{0} - {1}] Count={2}", start, [end], count)

			gridControl1.DataSource = appointments
		End Sub

	End Class
End Namespace