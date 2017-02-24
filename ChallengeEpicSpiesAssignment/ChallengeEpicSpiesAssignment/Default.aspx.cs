using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Business Rule 1: Initialize Calendar controls. 
            // Previous assignment date is set to today
            // new assignment date is set 14 days from today
            // end assignment date is set 21 days from today
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

            //maintain scroll position
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            // Business Rule 3: Spies cost $500 per day against Assignment's budget.
            TimeSpan totalAssignmentDuration = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
            double totalCost = totalAssignmentDuration.TotalDays * 500.0;

            // If totalAssignmentDuration is > 21 days then add $1000
            if (totalAssignmentDuration.TotalDays > 21)
            {
                totalCost += 1000.0;
            }

            // Display budget to manager in text at bottom of page
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",
                codeNameTextBox.Text, 
                assignmentNameTextBox.Text, 
                totalCost);

            // Business rule 2: If less than 2 weeks between previous assignment date & new assignment date, display error message
            // Get time span between dates
            TimeSpan timeBetweenAssignments = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least 2 weeks between "
                + "previous assignment and new assignment.";

                DateTime earliestNewAssignmentDate = Calendar1.SelectedDate.AddDays(14);

                Calendar2.SelectedDate = earliestNewAssignmentDate;
                Calendar2.VisibleDate = earliestNewAssignmentDate;
            }
        }
    }
}