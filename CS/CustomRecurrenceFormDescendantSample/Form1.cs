using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomRecurrenceFormDescendantSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.schedulerControl1.EditAppointmentFormShowing += schedulerControl1_EditAppointmentFormShowing;
            this.Shown += Form1_Shown;
        }

        void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            // Recurrence form allows editing only daily recurring appointments. 
            MyAppointmentEditForm myForm = new MyAppointmentEditForm(schedulerControl1,
                e.Appointment, e.OpenRecurrenceForm, DevExpress.XtraScheduler.RecurrenceType.Daily);
            myForm.ShowDialog();
            e.Handled = true;

        }

        void Form1_Shown(object sender, EventArgs e)
        {
            this.schedulerControl1.CreateAppointment(false, true);
        }
    }
}
