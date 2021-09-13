using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SampleDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void GetData()
    {
        SampleDataClassesDataContext dbContext = new SampleDataClassesDataContext();

        //var linQuery = from employee in dbContext.Employees select employee;

        //string sqlQuery = linQuery.ToString();
        //Response.Write(sqlQuery);
        //Response.Write(dbContext.GetCommand(linQuery).CommandText);

        GridView1.DataSource = dbContext.GetEmployees();
        GridView1.DataBind();
    }

    protected void btnGetData_Click(object sender, EventArgs e)
    {
        GetData();
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        using (SampleDataClassesDataContext dbContext = new SampleDataClassesDataContext())
        {
            Employee newEmployee = new Employee
            {
                FirstName = "Tim",
                LastName = "Tum",
                Gender = "Male",
                Salary = 55000,
                DepartmentId = 1
            };

            dbContext.Employees.InsertOnSubmit(newEmployee);
            dbContext.SubmitChanges();
        }
        GetData();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        using (SampleDataClassesDataContext dbContext = new SampleDataClassesDataContext())
        {
            Employee employee = dbContext.Employees.SingleOrDefault(x => x.ID == 12);
            employee.Salary = 6500;
            dbContext.SubmitChanges();
        }
        GetData();
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        using (SampleDataClassesDataContext dbContext = new SampleDataClassesDataContext())
        {
            Employee employee = dbContext.Employees.SingleOrDefault(x => x.ID == 12);
            dbContext.Employees.DeleteOnSubmit(employee);
            dbContext.SubmitChanges();
        }
        GetData();
    }

    protected void btnGetEmployeesByDeparment_Click(object sender, EventArgs e)
    {
        using(SampleDataClassesDataContext dbContext = new SampleDataClassesDataContext())
        {
            string deptName = string.Empty;
            GridView1.DataSource = dbContext.GetEmployeesByDepartment(1, ref deptName);
            GridView1.DataBind();

            lblDept.Text = "Depart Name = " + deptName;
        }
    }
}