#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="buatbelajar")]
public partial class SampleDataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertDepartment(Department instance);
  partial void UpdateDepartment(Department instance);
  partial void DeleteDepartment(Department instance);
  #endregion
	
	public SampleDataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["buatbelajarConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public SampleDataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SampleDataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SampleDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SampleDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Department> Departments
	{
		get
		{
			return this.GetTable<Department>();
		}
	}
	
	public System.Data.Linq.Table<Employee> Employees
	{
		get
		{
			return this.GetTable<Employee>();
		}
	}
	
	private void InsertEmployee(Employee obj)
	{
		this.InsertEmployee(obj.FirstName, obj.LastName, obj.Gender, ((System.Nullable<int>)(obj.Salary)), ((System.Nullable<int>)(obj.DepartmentId)));
	}
	
	private void UpdateEmployee(Employee obj)
	{
		this.UpdateEmployee(((System.Nullable<int>)(obj.ID)), obj.FirstName, obj.LastName, obj.Gender, ((System.Nullable<int>)(obj.Salary)), ((System.Nullable<int>)(obj.DepartmentId)));
	}
	
	private void DeleteEmployee(Employee obj)
	{
		this.DeleteEmployee(((System.Nullable<int>)(obj.ID)));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEmployees")]
	public ISingleResult<Employee> GetEmployees()
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
		return ((ISingleResult<Employee>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteEmployee")]
	public int DeleteEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmployee")]
	public int InsertEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(50)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(50)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Int")] System.Nullable<int> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentId", DbType="Int")] System.Nullable<int> departmentId)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName, gender, salary, departmentId);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateEmployee")]
	public int UpdateEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(50)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(50)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Int")] System.Nullable<int> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentId", DbType="Int")] System.Nullable<int> departmentId)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, firstName, lastName, gender, salary, departmentId);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEmployeesByDepartment")]
	public ISingleResult<GetEmployeesByDepartmentResult> GetEmployeesByDepartment([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentId", DbType="Int")] System.Nullable<int> departmentId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentName", DbType="NVarChar(50)")] ref string departmentName)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), departmentId, departmentName);
		departmentName = ((string)(result.GetParameterValue(1)));
		return ((ISingleResult<GetEmployeesByDepartmentResult>)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departments")]
public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Location;
	
	private EntitySet<Employee> _Employees;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    #endregion
	
	public Department()
	{
		this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50)")]
	public string Location
	{
		get
		{
			return this._Location;
		}
		set
		{
			if ((this._Location != value))
			{
				this.OnLocationChanging(value);
				this.SendPropertyChanging();
				this._Location = value;
				this.SendPropertyChanged("Location");
				this.OnLocationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="ID", OtherKey="DepartmentId")]
	public EntitySet<Employee> Employees
	{
		get
		{
			return this._Employees;
		}
		set
		{
			this._Employees.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Employees(Employee entity)
	{
		this.SendPropertyChanging();
		entity.Department = this;
	}
	
	private void detach_Employees(Employee entity)
	{
		this.SendPropertyChanging();
		entity.Department = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _FirstName;
	
	private string _LastName;
	
	private string _Gender;
	
	private System.Nullable<int> _Salary;
	
	private System.Nullable<int> _DepartmentId;
	
	private EntityRef<Department> _Department;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnSalaryChanging(System.Nullable<int> value);
    partial void OnSalaryChanged();
    partial void OnDepartmentIdChanging(System.Nullable<int> value);
    partial void OnDepartmentIdChanged();
    #endregion
	
	public Employee()
	{
		this._Department = default(EntityRef<Department>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._FirstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._LastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
	public string Gender
	{
		get
		{
			return this._Gender;
		}
		set
		{
			if ((this._Gender != value))
			{
				this.OnGenderChanging(value);
				this.SendPropertyChanging();
				this._Gender = value;
				this.SendPropertyChanged("Gender");
				this.OnGenderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
	public System.Nullable<int> Salary
	{
		get
		{
			return this._Salary;
		}
		set
		{
			if ((this._Salary != value))
			{
				this.OnSalaryChanging(value);
				this.SendPropertyChanging();
				this._Salary = value;
				this.SendPropertyChanged("Salary");
				this.OnSalaryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int")]
	public System.Nullable<int> DepartmentId
	{
		get
		{
			return this._DepartmentId;
		}
		set
		{
			if ((this._DepartmentId != value))
			{
				if (this._Department.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnDepartmentIdChanging(value);
				this.SendPropertyChanging();
				this._DepartmentId = value;
				this.SendPropertyChanged("DepartmentId");
				this.OnDepartmentIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="DepartmentId", OtherKey="ID", IsForeignKey=true)]
	public Department Department
	{
		get
		{
			return this._Department.Entity;
		}
		set
		{
			Department previousValue = this._Department.Entity;
			if (((previousValue != value) 
						|| (this._Department.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Department.Entity = null;
					previousValue.Employees.Remove(this);
				}
				this._Department.Entity = value;
				if ((value != null))
				{
					value.Employees.Add(this);
					this._DepartmentId = value.ID;
				}
				else
				{
					this._DepartmentId = default(Nullable<int>);
				}
				this.SendPropertyChanged("Department");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

public partial class GetEmployeesByDepartmentResult
{
	
	private int _ID;
	
	private string _FirstName;
	
	private string _LastName;
	
	private string _Gender;
	
	private System.Nullable<int> _Salary;
	
	private System.Nullable<int> _DepartmentId;
	
	public GetEmployeesByDepartmentResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this._ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this._FirstName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this._LastName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
	public string Gender
	{
		get
		{
			return this._Gender;
		}
		set
		{
			if ((this._Gender != value))
			{
				this._Gender = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
	public System.Nullable<int> Salary
	{
		get
		{
			return this._Salary;
		}
		set
		{
			if ((this._Salary != value))
			{
				this._Salary = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int")]
	public System.Nullable<int> DepartmentId
	{
		get
		{
			return this._DepartmentId;
		}
		set
		{
			if ((this._DepartmentId != value))
			{
				this._DepartmentId = value;
			}
		}
	}
}
#pragma warning restore 1591
