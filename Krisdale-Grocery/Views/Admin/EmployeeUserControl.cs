using Krisdale_Grocery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krisdale_Grocery.Views.Admin
{
    public partial class EmployeeUserControl : UserControl
    {

        private EmployeeModel employeeModel;
        private EditEmployeeForm editEmployeeForm;
       
        public EmployeeUserControl()
        {
            InitializeComponent();
            employeeModel = new EmployeeModel();
        }

        public void setId(string id)
        {
            employeeModel.Id = int.Parse(id);
            employeeIDLabel.Text = $"Employee#{id}";

        }
        public void setFirstName(string name)
        {
            firstNameLabel.Text = name;
        }
        public void setLastName(string lastName)
        {
            lastNameLabel.Text = lastName;
        }
        public void setContactNumber(string contactNumber)
        {
            contactNumberLabel.Text = contactNumber;

        }
        public void setStartedWorking(string startedWorking)
        {
            startedWorkingLabel.Text = startedWorking;

        }
        public void setEmployeeImage(byte[] image)
        {
            try
            {


                using (MemoryStream ms = new MemoryStream(image))
                {

                    employeePictureBox.Image = System.Drawing.Image.FromStream(ms);
                }

            }
            catch
            {
                MessageBox.Show("An error occured");

            }
        }
        private void EmployeeUserControl_Click(object sender, EventArgs e)
        {
            editEmployeeForm = new EditEmployeeForm();
            // set the employeemodel id for form 2 to pass data
            editEmployeeForm.employeeModel = employeeModel;
            editEmployeeForm.ShowDialog();


            Control parent = this.Parent; // Get the immediate parent of the UserControl

            while (parent != null)
            {
                if (parent is FlowLayoutPanel flowLayoutPanel)
                {
                    // Access the FlowLayoutPanel here and perform actions
                    flowLayoutPanel.Controls.Clear(); // For example, clear its controls

                    Form parentForm = flowLayoutPanel.FindForm();

                    if (parentForm is ViewEmployeeForm viewEmployeeForm)
                    {
                        // Assuming initializeProducts is a public method in ViewProductsForm
                        viewEmployeeForm.InitializeEmployee(); // Call initializeProducts
                    }
                    // Optionally, break out of the loop if found
                    break;
                }

                parent = parent.Parent; // Move up in the control hierarchy
            }




        }
    }
}
