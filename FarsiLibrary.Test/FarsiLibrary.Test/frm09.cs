using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FarsiLibrary.Test
{
    public partial class frm09 : baseForm
    {
        #region Fields

        private List<Employee> employeeCollection;

        #endregion

        #region Ctor

        public frm09()
        {
            InitializeComponent();

            employeeCollection = new List<Employee>();
        }

        #endregion

        #region Props

        public List<Employee> EmployeeCollection
        {
            get { return employeeCollection; }
        }

        #endregion

        #region Overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadEmployees();
            BindControls();
        }

        #endregion
        
        #region EventHandlers

        private void LoadEmployees()
        {
            //Fill business object with dataset
            PersonDataSet ds = new PersonDataSet();
            StringReader sr = new StringReader(Test.Properties.Resources.Employee);
            ds.ReadXml(sr, XmlReadMode.Auto);

            foreach (DataRow r in ds.Employee.Rows)
            {
                PersonDataSet.EmployeeRow row = (PersonDataSet.EmployeeRow)r;
                
                //Notice the constructor accepts PersianDate, but we're using a DateTime class! 
                //There's no conversion and casting required.
                Employee empolyee = new Employee(row.EmployeeID, row.Lastname, row.Firstname, row.Address, row.City, row.Hiredate, row.Birthdate);
                empolyee.EmployeeChanged += new EventHandler(OnInternalEmployeeChanged);
                EmployeeCollection.Add(empolyee);
            }
        }

        private void OnInternalEmployeeChanged(object sender, EventArgs e)
        {
            gridView.Refresh();
        }

        private void BindControls()
        {
            gridView.DataSource = EmployeeCollection;

            txtID.DataBindings.Add(new Binding("Text", EmployeeCollection, "EmployeeID", true));
            txtLastname.DataBindings.Add(new Binding("Text", EmployeeCollection, "Lastname", true));
            txtFirstname.DataBindings.Add(new Binding("Text", EmployeeCollection, "Firstname", true));
            faDatePickerConverter.DataBindings.Add(new Binding("SelectedDateTime", EmployeeCollection, "BirthDate", true));
            faMonthView.DataBindings.Add(new Binding("SelectedDateTime", EmployeeCollection, "HireDate", true));
            faDatePicker.DataBindings.Add(new Binding("SelectedDateTime", EmployeeCollection, "HireDate", true));
        }

        #endregion
    }
}