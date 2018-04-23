Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace CustomRecurrenceFormDescendantSample
    Public Class MyAppointmentRecurrenceForm
        Inherits AppointmentRecurrenceForm

        Public Sub New(ByVal pattern As Appointment, ByVal firstDayOfWeek As FirstDayOfWeek, ByVal controller As AppointmentFormControllerBase, ByVal type As RecurrenceType)
            MyBase.New(pattern, firstDayOfWeek, controller)
            MyBase.dailyRecurrenceControl1.Enabled = False
            MyBase.weeklyRecurrenceControl1.Enabled = False
            MyBase.monthlyRecurrenceControl1.Enabled = False
            MyBase.yearlyRecurrenceControl1.Enabled = False
            Select Case type
                Case RecurrenceType.Daily
                    MyBase.dailyRecurrenceControl1.Enabled = True
                ' Code for other RecurrenceType cases if required.
            End Select

            MyBase.grpRecurrencePattern.Text = "You can edit only daily recurring appointments"
            MyBase.Text = "Appointment Recurrence: Modified Form"
        End Sub
    End Class

End Namespace
