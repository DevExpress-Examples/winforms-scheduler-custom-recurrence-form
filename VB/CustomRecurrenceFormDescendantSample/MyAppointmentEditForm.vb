Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports System.Windows.Forms

Namespace CustomRecurrenceFormDescendantSample
	Public Class MyAppointmentEditForm
		Inherits AppointmentForm

		Private recurringType As RecurrenceType

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean, ByVal type As RecurrenceType)
			MyBase.New(control, apt, openRecurrenceForm)
			recurringType = type
		End Sub

		Protected Overrides Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As FirstDayOfWeek) As Form
			Return New MyAppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Me.Controller, Me.recurringType)
		End Function
	End Class

End Namespace
