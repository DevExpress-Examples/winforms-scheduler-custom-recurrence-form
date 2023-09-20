Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI

Namespace CustomRecurrenceFormDescendantSample

    Public Class MyAppointmentRecurrenceForm
        Inherits AppointmentRecurrenceForm

        Public Sub New(ByVal pattern As Appointment, ByVal firstDayOfWeek As FirstDayOfWeek, ByVal controller As AppointmentFormControllerBase, ByVal type As RecurrenceType)
            MyBase.New(pattern, firstDayOfWeek, controller)
            dailyRecurrenceControl1.Enabled = False
            weeklyRecurrenceControl1.Enabled = False
            monthlyRecurrenceControl1.Enabled = False
            yearlyRecurrenceControl1.Enabled = False
            Select Case type
                Case RecurrenceType.Daily
                    dailyRecurrenceControl1.Enabled = True
            ' Code for other RecurrenceType cases if required.
            End Select

            grpRecurrencePattern.Text = "You can edit only daily recurring appointments"
            Text = "Appointment Recurrence: Modified Form"
        End Sub
    End Class
End Namespace
