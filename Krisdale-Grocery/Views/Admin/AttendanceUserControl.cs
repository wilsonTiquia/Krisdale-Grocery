using Krisdale_Grocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class AttendanceUserControl : UserControl
    {
        public AttendanceUserControl()
        {
            InitializeComponent();
        }


        public void setId(string id)
        {

            employeeIdLabel.Text = $"EMPLOYEE ID#{id}";

        }
        public void setFirstName(string firstName)
        {

            employeeFirstNameLabel.Text = firstName;

        }
        public void setLastName(string lastName)
        {

            employeeLastNameLabel.Text = lastName;

        }
        public void setTimeIn(string timeIn)
        {

            timeInLabel.Text = timeIn;

        }
        public void setTimeOut(string timeOut)
        {
            timeOutLabel.Text = timeOut;
        }
        public void setHoursWorked(string hoursWorked)
        {
            hoursWorkedLabel.Text = hoursWorked;
        }

    }
}
