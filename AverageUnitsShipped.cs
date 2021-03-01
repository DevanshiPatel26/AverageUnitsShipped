//Name: Devanshi Patel
//Student ID: 100805084
//COurse: Net Development
//Date: 22 January, 2021
//Description: This application will calculate the average unit shipped of the 7 days. 
// It will validate the user input and only allows input which are numeric and is in the 
// range between 0 to 5000.




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShipped
{
    public partial class formAverageUnitsShipped : Form
    {
        // Declarations
        // Current Day 
        int dayOfUnitShipped = 1;
        // Current Total
        int currentTotalUnits = 0;
        

        public formAverageUnitsShipped()
        {
            InitializeComponent();
        }

        private void formAverageUnitsShipped_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// on pressing enter button, it will calculate the average
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declarations
            // Declare constant for the minimum units
            const int MinimumUnits = 0;
            // Declare constant for the maximum units
            const int MaximumUnits = 5000;
            // Declare constant for the maximum days
            const int MaximumDays = 7;
            // Variable for the unit entry
            int unitEntry;

            // it will take the valid entry to the entry box
            if (int.TryParse(textBoxUnitsInput.Text, out unitEntry))
            {
                // It checks whether the value is in range or not
                if (unitEntry >= MinimumUnits && unitEntry <= MaximumUnits)
                {
                    // it will add entry to the entry box
                    textBoxUnitsShippedEntries.Text += unitEntry + "\r\n";
                    // the current total gets updated
                    currentTotalUnits += unitEntry;
                    // the days of the unit gets updates with valid entry
                    dayOfUnitShipped++;
                    // after the valid entry, the text box gets clear
                    textBoxUnitsInput.Clear();

                    // it executes until the current days are more than maximum days
                    if (dayOfUnitShipped > MaximumDays)
                    {
                        // it will calculate the average 
                        double averageUnits;
                        averageUnits = (double) currentTotalUnits / MaximumDays;
                        // it will display the text in the label
                        labelOutput.Text = "Average per day: " + Math.Round(averageUnits, 2);
                        // it disabled the entry box after the minimum entries
                        textBoxUnitsShippedEntries.Enabled = false;
                        // the enter button also gets disabled
                        buttonEnter.Enabled = false;
                        // it will set the focus on the reset button
                        buttonReset.Focus();


                    }

                    // if the current days are less than 7
                    else
                    {
                        // it will set focus to the entry box to enter another set of values
                        labelDays.Text = "Day " + dayOfUnitShipped;
                        textBoxUnitsInput.Focus();

                    }

                }

                // it will show the error message
                else
                {
                    // if the entered value is out of range, it will display the error message
                    MessageBox.Show("Please enter the unit shipped value between "
                        + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Output!");
                    // the entry box gets cleared and set focus to enter another one
                    textBoxUnitsInput.Clear();
                    textBoxUnitsInput.SelectAll();
                    textBoxUnitsInput.Focus();

                }
            }

            // display the error message if the value is non numeric
            else
            {
                // if the value is non numeric, it will display error message
                MessageBox.Show("The entered unit value must be whole number. Please enter again.",
                    "Invalid Input!");
                textBoxUnitsInput.Clear();
                textBoxUnitsInput.SelectAll();
                textBoxUnitsInput.Focus();
            }


        }

        /// <summary>
        /// It will close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            // It is used to close the form.
            Close();
        }

        /// <summary>
        /// it will reset the form on pressing reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // the entry box gets cleared
            textBoxUnitsInput.Clear();
            // the added entries gets cleared
            textBoxUnitsShippedEntries.Clear();
            // the label text gets empty
            labelOutput.Text = "";
            // the current days set to 1
            dayOfUnitShipped = 1;
            // current total set to 0
            currentTotalUnits = 0;
            // the label of the day displayed day1
            labelDays.Text = "Day " + dayOfUnitShipped;
            // it enabled the entry box and enter button
            textBoxUnitsInput.Enabled = true;
            buttonEnter.Enabled = true;
            // set the focus on the entry box for user to calculate another set of values
            textBoxUnitsInput.Focus();

        }

        
    }
}
