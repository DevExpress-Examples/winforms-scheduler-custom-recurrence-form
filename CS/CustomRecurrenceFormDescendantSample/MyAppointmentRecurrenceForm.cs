using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomRecurrenceFormDescendantSample
{
    public class MyAppointmentRecurrenceForm : AppointmentRecurrenceForm
    {
        public MyAppointmentRecurrenceForm(Appointment pattern,
            FirstDayOfWeek firstDayOfWeek, AppointmentFormControllerBase controller,
            RecurrenceType type) : base(pattern, firstDayOfWeek, controller)
        {
            base.dailyRecurrenceControl1.Enabled = false;
            base.weeklyRecurrenceControl1.Enabled = false;
            base.monthlyRecurrenceControl1.Enabled = false;
            base.yearlyRecurrenceControl1.Enabled = false;
            switch (type) {
                case RecurrenceType.Daily:
                    base.dailyRecurrenceControl1.Enabled = true;
                    break;
                // Code for other RecurrenceType cases if required.
            }

            base.grpRecurrencePattern.Text =
                "You can edit only daily recurring appointments";
            base.Text = "Appointment Recurrence: Modified Form";
        }
    }

}
