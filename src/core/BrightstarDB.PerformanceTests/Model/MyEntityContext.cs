﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;


namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.PerformanceTests.Model.IArticle));
    		TypeMappings.AddImplMapping<BrightstarDB.PerformanceTests.Model.IArticle, BrightstarDB.PerformanceTests.Model.Article>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.PerformanceTests.Model.IDepartment));
    		TypeMappings.AddImplMapping<BrightstarDB.PerformanceTests.Model.IDepartment, BrightstarDB.PerformanceTests.Model.Department>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.PerformanceTests.Model.IJobRole));
    		TypeMappings.AddImplMapping<BrightstarDB.PerformanceTests.Model.IJobRole, BrightstarDB.PerformanceTests.Model.JobRole>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.PerformanceTests.Model.IPerson));
    		TypeMappings.AddImplMapping<BrightstarDB.PerformanceTests.Model.IPerson, BrightstarDB.PerformanceTests.Model.Person>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.PerformanceTests.Model.ISkill));
    		TypeMappings.AddImplMapping<BrightstarDB.PerformanceTests.Model.ISkill, BrightstarDB.PerformanceTests.Model.Skill>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.PerformanceTests.Model.IWebsite));
    		TypeMappings.AddImplMapping<BrightstarDB.PerformanceTests.Model.IWebsite, BrightstarDB.PerformanceTests.Model.Website>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public MyEntityContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">If set to true optmistic locking will be applied to all entity updates</param>
    	public MyEntityContext(string connectionString, bool enableOptimisticLocking=false) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public MyEntityContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Articles = 	new BrightstarEntitySet<Article>(this);
    		Departments = 	new BrightstarEntitySet<Department>(this);
    		JobRoles = 	new BrightstarEntitySet<JobRole>(this);
    		Persons = 	new BrightstarEntitySet<Person>(this);
    		Skills = 	new BrightstarEntitySet<Skill>(this);
    		Websites = 	new BrightstarEntitySet<Website>(this);
    	}
    	
    	public IEntitySet<Article> Articles 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<Department> Departments 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<JobRole> JobRoles 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<Person> Persons 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<Skill> Skills 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<Website> Websites 
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class Article : BrightstarEntityObject, IArticle 
    {
    	public Article(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Article() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IArticle
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String BodyText
    	{
            		get { return GetRelatedProperty<System.String>("BodyText"); }
            		set { SetRelatedProperty("BodyText", value); }
    	}
    
    	public System.Nullable<System.DateTime> PublishDate
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("PublishDate"); }
            		set { SetRelatedProperty("PublishDate", value); }
    	}
    
    	public BrightstarDB.PerformanceTests.Model.IPerson Publisher
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IPerson>("Publisher"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IPerson>("Publisher", value); }
    	}
    
    	public BrightstarDB.PerformanceTests.Model.IWebsite Website
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IWebsite>("Website"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IWebsite>("Website", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class Department : BrightstarEntityObject, IDepartment 
    {
    	public Department(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Department() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IDepartment
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.Int32 DeptId
    	{
            		get { return GetRelatedProperty<System.Int32>("DeptId"); }
            		set { SetRelatedProperty("DeptId", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IPerson>("Persons"); }
    		set { SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class JobRole : BrightstarEntityObject, IJobRole 
    {
    	public JobRole(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public JobRole() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IJobRole
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IPerson>("Persons"); }
    		set { SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class Person : BrightstarEntityObject, IPerson 
    {
    	public Person(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Person() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IPerson
    
    	public System.String Fullname
    	{
            		get { return GetRelatedProperty<System.String>("Fullname"); }
            		set { SetRelatedProperty("Fullname", value); }
    	}
    
    	public System.Int32 Age
    	{
            		get { return GetRelatedProperty<System.Int32>("Age"); }
            		set { SetRelatedProperty("Age", value); }
    	}
    
    	public System.Int32 Salary
    	{
            		get { return GetRelatedProperty<System.Int32>("Salary"); }
            		set { SetRelatedProperty("Salary", value); }
    	}
    
    	public System.DateTime DateOfBirth
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateOfBirth"); }
            		set { SetRelatedProperty("DateOfBirth", value); }
    	}
    
    	public System.Int32 EmployeeNumber
    	{
            		get { return GetRelatedProperty<System.Int32>("EmployeeNumber"); }
            		set { SetRelatedProperty("EmployeeNumber", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.ISkill> Skills
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.ISkill>("Skills"); }
    		set { SetRelatedObjects("Skills", value); }
    								}
    
    	public BrightstarDB.PerformanceTests.Model.IDepartment Department
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IDepartment>("Department"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IDepartment>("Department", value); }
    	}
    
    	public BrightstarDB.PerformanceTests.Model.IJobRole JobRole
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IJobRole>("JobRole"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IJobRole>("JobRole", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IArticle> Articles
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IArticle>("Articles"); }
    		set { SetRelatedObjects("Articles", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class Skill : BrightstarEntityObject, ISkill 
    {
    	public Skill(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Skill() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.ISkill
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IPerson> SkilledPeople
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IPerson>("SkilledPeople"); }
    		set { SetRelatedObjects("SkilledPeople", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class Website : BrightstarEntityObject, IWebsite 
    {
    	public Website(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Website() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IWebsite
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.String Url
    	{
            		get { return GetRelatedProperty<System.String>("Url"); }
            		set { SetRelatedProperty("Url", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IArticle> Articles
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IArticle>("Articles"); }
    		set { SetRelatedObjects("Articles", value); }
    								}
    	#endregion
    }
}
