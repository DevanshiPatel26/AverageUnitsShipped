
namespace AverageUnitsShipped
{
    partial class formAverageUnitsShipped
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxUnitsInput = new System.Windows.Forms.TextBox();
            this.textBoxUnitsShippedEntries = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnits
            // 
            this.labelUnits.Location = new System.Drawing.Point(56, 43);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(73, 31);
            this.labelUnits.TabIndex = 0;
            this.labelUnits.Text = "&Units:";
            // 
            // textBoxUnitsInput
            // 
            this.textBoxUnitsInput.Location = new System.Drawing.Point(152, 43);
            this.textBoxUnitsInput.Name = "textBoxUnitsInput";
            this.textBoxUnitsInput.Size = new System.Drawing.Size(150, 31);
            this.textBoxUnitsInput.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxUnitsInput, "Please enter the units that are shipped.");
            // 
            // textBoxUnitsShippedEntries
            // 
            this.textBoxUnitsShippedEntries.Location = new System.Drawing.Point(114, 103);
            this.textBoxUnitsShippedEntries.Multiline = true;
            this.textBoxUnitsShippedEntries.Name = "textBoxUnitsShippedEntries";
            this.textBoxUnitsShippedEntries.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUnitsShippedEntries.Size = new System.Drawing.Size(261, 187);
            this.textBoxUnitsShippedEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxUnitsShippedEntries, "It shows the list of valid inputs.");
            // 
            // labelDays
            // 
            this.labelDays.Location = new System.Drawing.Point(359, 43);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(95, 31);
            this.labelDays.TabIndex = 4;
            this.labelDays.Text = "Day 1";
            this.toolTip.SetToolTip(this.labelDays, "It shows the different days.");
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(77, 314);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(330, 44);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelOutput, "It shows that overall average of the units shipped.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(31, 391);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonEnter.Size = new System.Drawing.Size(112, 34);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter\r\n\r\n";
            this.toolTip.SetToolTip(this.buttonEnter, "Please Click Enter to input the value.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(190, 391);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 34);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Please Click Reset to enter the input again.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(359, 391);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Please Click Exit to come out of the form.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 446);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxUnitsShippedEntries);
            this.Controls.Add(this.textBoxUnitsInput);
            this.Controls.Add(this.labelUnits);
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.Load += new System.EventHandler(this.formAverageUnitsShipped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxUnitsInput;
        private System.Windows.Forms.TextBox textBoxUnitsShippedEntries;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

