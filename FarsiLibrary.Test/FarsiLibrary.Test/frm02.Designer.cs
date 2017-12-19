using System;

namespace FarsiLibrary.Test
{
    partial class frm02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faDatePickerConverter = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.label1 = new System.Windows.Forms.Label();
            this.listEvents = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnDatePicker = new System.Windows.Forms.Button();
            this.btnDatePickerConverter = new System.Windows.Forms.Button();
            this.btnMonthView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // faMonthView
            // 
            this.faMonthView.Location = new System.Drawing.Point(30, 34);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 5, 24, 15, 55, 27, 49);
            this.faMonthView.TabIndex = 0;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faMonthView.DayChanged += new System.EventHandler(this.faMonthView_DayChanged);
            this.faMonthView.ThemeChanged += new System.EventHandler(this.faMonthView_ThemeChanged);
            this.faMonthView.SelectedDateTimeChanged += new EventHandler(this.faMonthView_SelectedDateTimeChanged);
            this.faMonthView.SelectedDateRangeChanged += new EventHandler(this.faMonthView_SelectedDateRangeChanged);
            this.faMonthView.MonthChanged += new System.EventHandler(this.faMonthView_MonthChanged);
            this.faMonthView.YearChanged += new System.EventHandler(this.faMonthView_YearChanged);
            // 
            // faDatePicker
            // 
            this.faDatePicker.Location = new System.Drawing.Point(14, 206);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.Size = new System.Drawing.Size(194, 22);
            this.faDatePicker.TabIndex = 1;
            this.faDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDatePicker.SelectedDateTimeChanging += new FarsiLibrary.Win.Events.SelectedDateTimeChangingEventHandler(this.faDatePicker_SelectedDateTimeChanging);
            this.faDatePicker.ValueValidating += new FarsiLibrary.Win.Events.ValueValidatingEventHandler(this.faDatePicker_ValueValidating);
            this.faDatePicker.RightToLeftChanged += new System.EventHandler(this.faDatePicker_RightToLeftChanged);
            this.faDatePicker.SelectedDateTimeChanged += new EventHandler(this.faDatePicker_SelectedDateTimeChanged);
            this.faDatePicker.ValueChanged += new System.EventHandler(this.faDatePicker_ValueChanged);
            // 
            // faDatePickerConverter
            // 
            this.faDatePickerConverter.Location = new System.Drawing.Point(14, 234);
            this.faDatePickerConverter.Name = "faDatePickerConverter";
            this.faDatePickerConverter.Size = new System.Drawing.Size(194, 22);
            this.faDatePickerConverter.TabIndex = 2;
            this.faDatePickerConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDatePickerConverter.SelectedDateTimeChanging += new FarsiLibrary.Win.Events.SelectedDateTimeChangingEventHandler(this.faDatePickerConverter_SelectedDateTimeChanging);
            this.faDatePickerConverter.ValueValidating += new FarsiLibrary.Win.Events.ValueValidatingEventHandler(this.faDatePickerConverter_ValueValidating);
            this.faDatePickerConverter.RightToLeftChanged += new System.EventHandler(this.faDatePickerConverter_RightToLeftChanged);
            this.faDatePickerConverter.SelectedDateTimeChanged += new EventHandler(this.faDatePickerConverter_SelectedDateTimeChanged);
            this.faDatePickerConverter.ValueChanged += new System.EventHandler(this.faDatePickerConverter_ValueChanged);
            this.faDatePickerConverter.ConvertButtonClicked += new System.EventHandler(this.faDatePickerConverter_ConvertButtonClicked);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(215, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Events : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listEvents
            // 
            this.listEvents.FormattingEnabled = true;
            this.listEvents.ItemHeight = 14;
            this.listEvents.Location = new System.Drawing.Point(218, 41);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(405, 312);
            this.listEvents.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(537, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(631, 13);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.faMonthView;
            this.propertyGrid.Size = new System.Drawing.Size(267, 340);
            this.propertyGrid.TabIndex = 6;
            // 
            // btnDatePicker
            // 
            this.btnDatePicker.Location = new System.Drawing.Point(14, 296);
            this.btnDatePicker.Name = "btnDatePicker";
            this.btnDatePicker.Size = new System.Drawing.Size(194, 25);
            this.btnDatePicker.TabIndex = 7;
            this.btnDatePicker.Text = "Monitor FADatePicker";
            this.btnDatePicker.UseVisualStyleBackColor = true;
            this.btnDatePicker.Click += new System.EventHandler(this.btnDatePicker_Click);
            // 
            // btnDatePickerConverter
            // 
            this.btnDatePickerConverter.Location = new System.Drawing.Point(14, 327);
            this.btnDatePickerConverter.Name = "btnDatePickerConverter";
            this.btnDatePickerConverter.Size = new System.Drawing.Size(194, 25);
            this.btnDatePickerConverter.TabIndex = 8;
            this.btnDatePickerConverter.Text = "Monitor FADatePickerConverter";
            this.btnDatePickerConverter.UseVisualStyleBackColor = true;
            this.btnDatePickerConverter.Click += new System.EventHandler(this.btnDatePickerConverter_Click);
            // 
            // btnMonthView
            // 
            this.btnMonthView.Location = new System.Drawing.Point(14, 265);
            this.btnMonthView.Name = "btnMonthView";
            this.btnMonthView.Size = new System.Drawing.Size(194, 25);
            this.btnMonthView.TabIndex = 9;
            this.btnMonthView.Text = "Monitor FAMonthView";
            this.btnMonthView.UseVisualStyleBackColor = true;
            this.btnMonthView.Click += new System.EventHandler(this.btnMonthView_Click);
            // 
            // frm02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 360);
            this.Controls.Add(this.btnMonthView);
            this.Controls.Add(this.btnDatePickerConverter);
            this.Controls.Add(this.btnDatePicker);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faDatePickerConverter);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.faMonthView);
            this.Name = "frm02";
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEvents;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button btnDatePicker;
        private System.Windows.Forms.Button btnDatePickerConverter;
        private System.Windows.Forms.Button btnMonthView;
    }
}