Imports System
Imports System.Windows.Forms

Namespace CustomRecurrenceFormDescendantSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			AddHandler Me.schedulerControl1.EditAppointmentFormShowing, AddressOf schedulerControl1_EditAppointmentFormShowing
			AddHandler Me.Shown, AddressOf Form1_Shown
		End Sub

		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs)
			' Recurrence form allows editing only daily recurring appointments. 
			Dim myForm As New MyAppointmentEditForm(schedulerControl1, e.Appointment, e.OpenRecurrenceForm, DevExpress.XtraScheduler.RecurrenceType.Daily)
			myForm.ShowDialog()
			e.Handled = True

		End Sub

		Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs)
			Me.schedulerControl1.CreateAppointment(False, True)
		End Sub
	End Class
End Namespace
