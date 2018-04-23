using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomRecurrenceFormDescendantSample
{
    public class MyAppointmentEditForm : AppointmentForm
    {
        RecurrenceType recurringType;

        public MyAppointmentEditForm(SchedulerControl control, Appointment apt,
            bool openRecurrenceForm, RecurrenceType type)
            : base(control, apt, openRecurrenceForm)
        {
            recurringType = type;
        }

        protected override Form CreateAppointmentRecurrenceForm(Appointment patternCopy,
            FirstDayOfWeek firstDayOfWeek)
        {
            return new MyAppointmentRecurrenceForm(patternCopy, firstDayOfWeek,
                this.Controller, this.recurringType);
        }
    }

}
