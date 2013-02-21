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


namespace BrightstarDB.OData.Tests 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.IArticle));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.IArticle, BrightstarDB.OData.Tests.Article>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.ICompany));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.ICompany, BrightstarDB.OData.Tests.Company>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.IDataTypeTestEntity));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.IDataTypeTestEntity, BrightstarDB.OData.Tests.DataTypeTestEntity>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.IDepartment));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.IDepartment, BrightstarDB.OData.Tests.Department>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.IJobRole));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.IJobRole, BrightstarDB.OData.Tests.JobRole>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.IPerson));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.IPerson, BrightstarDB.OData.Tests.Person>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.IProject));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.IProject, BrightstarDB.OData.Tests.Project>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.OData.Tests.ISkill));
    		TypeMappings.AddImplMapping<BrightstarDB.OData.Tests.ISkill, BrightstarDB.OData.Tests.Skill>();
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
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public MyEntityContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
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
    		Articles = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.IArticle>(this);
    		Companies = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.ICompany>(this);
    		DataTypeTestEntities = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.IDataTypeTestEntity>(this);
    		Departments = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.IDepartment>(this);
    		JobRoles = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.IJobRole>(this);
    		Persons = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.IPerson>(this);
    		Projects = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.IProject>(this);
    		Skills = 	new BrightstarEntitySet<BrightstarDB.OData.Tests.ISkill>(this);
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.IArticle> Articles
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.ICompany> Companies
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.IDataTypeTestEntity> DataTypeTestEntities
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.IDepartment> Departments
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.IJobRole> JobRoles
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.IPerson> Persons
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.IProject> Projects
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.OData.Tests.ISkill> Skills
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class Article : BrightstarEntityObject, IArticle 
    {
    	public Article(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Article() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.IArticle
    
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
    
    	public BrightstarDB.OData.Tests.IPerson Publisher
    	{
            get { return GetRelatedObject<BrightstarDB.OData.Tests.IPerson>("Publisher"); }
            set { SetRelatedObject<BrightstarDB.OData.Tests.IPerson>("Publisher", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class Company : BrightstarEntityObject, ICompany 
    {
    	public Company(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Company() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.ICompany
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.String Address
    	{
            		get { return GetRelatedProperty<System.String>("Address"); }
            		set { SetRelatedProperty("Address", value); }
    	}
    
    	public System.DateTime DateFormed
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateFormed"); }
            		set { SetRelatedProperty("DateFormed", value); }
    	}
    
    	public System.Decimal SomeDecimal
    	{
            		get { return GetRelatedProperty<System.Decimal>("SomeDecimal"); }
            		set { SetRelatedProperty("SomeDecimal", value); }
    	}
    
    	public System.Double SomeDouble
    	{
            		get { return GetRelatedProperty<System.Double>("SomeDouble"); }
            		set { SetRelatedProperty("SomeDouble", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.IDepartment> Departments
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.IDepartment>("Departments"); }
    		set { SetRelatedObjects("Departments", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class DataTypeTestEntity : BrightstarEntityObject, IDataTypeTestEntity 
    {
    	public DataTypeTestEntity(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public DataTypeTestEntity() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.IDataTypeTestEntity
    
    	public System.String SomeString
    	{
            		get { return GetRelatedProperty<System.String>("SomeString"); }
            		set { SetRelatedProperty("SomeString", value); }
    	}
    
    	public System.DateTime SomeDateTime
    	{
            		get { return GetRelatedProperty<System.DateTime>("SomeDateTime"); }
            		set { SetRelatedProperty("SomeDateTime", value); }
    	}
    
    	public System.Nullable<System.DateTime> SomeNullableDateTime
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("SomeNullableDateTime"); }
            		set { SetRelatedProperty("SomeNullableDateTime", value); }
    	}
    
    	public System.Boolean SomeBool
    	{
            		get { return GetRelatedProperty<System.Boolean>("SomeBool"); }
            		set { SetRelatedProperty("SomeBool", value); }
    	}
    
    	public System.Nullable<System.Boolean> NullableBool
    	{
            		get { return GetRelatedProperty<System.Nullable<System.Boolean>>("NullableBool"); }
            		set { SetRelatedProperty("NullableBool", value); }
    	}
    
    	public System.Byte SomeByte
    	{
            		get { return GetRelatedProperty<System.Byte>("SomeByte"); }
            		set { SetRelatedProperty("SomeByte", value); }
    	}
    
    	public System.Byte AnotherByte
    	{
            		get { return GetRelatedProperty<System.Byte>("AnotherByte"); }
            		set { SetRelatedProperty("AnotherByte", value); }
    	}
    
    	public System.Nullable<System.Byte> NullableByte
    	{
            		get { return GetRelatedProperty<System.Nullable<System.Byte>>("NullableByte"); }
            		set { SetRelatedProperty("NullableByte", value); }
    	}
    
    	public System.Nullable<System.Byte> AnotherNullableByte
    	{
            		get { return GetRelatedProperty<System.Nullable<System.Byte>>("AnotherNullableByte"); }
            		set { SetRelatedProperty("AnotherNullableByte", value); }
    	}
    
    	public System.Decimal SomeDecimal
    	{
            		get { return GetRelatedProperty<System.Decimal>("SomeDecimal"); }
            		set { SetRelatedProperty("SomeDecimal", value); }
    	}
    
    	public System.Double SomeDouble
    	{
            		get { return GetRelatedProperty<System.Double>("SomeDouble"); }
            		set { SetRelatedProperty("SomeDouble", value); }
    	}
    
    	public System.Single SomeFloat
    	{
            		get { return GetRelatedProperty<System.Single>("SomeFloat"); }
            		set { SetRelatedProperty("SomeFloat", value); }
    	}
    
    	public System.Int32 SomeInt
    	{
            		get { return GetRelatedProperty<System.Int32>("SomeInt"); }
            		set { SetRelatedProperty("SomeInt", value); }
    	}
    
    	public System.Nullable<System.Int32> SomeNullableInt
    	{
            		get { return GetRelatedProperty<System.Nullable<System.Int32>>("SomeNullableInt"); }
            		set { SetRelatedProperty("SomeNullableInt", value); }
    	}
    
    	public System.Int64 SomeLong
    	{
            		get { return GetRelatedProperty<System.Int64>("SomeLong"); }
            		set { SetRelatedProperty("SomeLong", value); }
    	}
    
    	public System.SByte SomeSByte
    	{
            		get { return GetRelatedProperty<System.SByte>("SomeSByte"); }
            		set { SetRelatedProperty("SomeSByte", value); }
    	}
    
    	public System.SByte AnotherSByte
    	{
            		get { return GetRelatedProperty<System.SByte>("AnotherSByte"); }
            		set { SetRelatedProperty("AnotherSByte", value); }
    	}
    
    	public System.Int16 SomeShort
    	{
            		get { return GetRelatedProperty<System.Int16>("SomeShort"); }
            		set { SetRelatedProperty("SomeShort", value); }
    	}
    
    	public System.Int16 AnotherShort
    	{
            		get { return GetRelatedProperty<System.Int16>("AnotherShort"); }
            		set { SetRelatedProperty("AnotherShort", value); }
    	}
    
    	public System.UInt32 SomeUInt
    	{
            		get { return GetRelatedProperty<System.UInt32>("SomeUInt"); }
            		set { SetRelatedProperty("SomeUInt", value); }
    	}
    
    	public System.UInt32 AnotherUInt
    	{
            		get { return GetRelatedProperty<System.UInt32>("AnotherUInt"); }
            		set { SetRelatedProperty("AnotherUInt", value); }
    	}
    
    	public System.UInt64 SomeULong
    	{
            		get { return GetRelatedProperty<System.UInt64>("SomeULong"); }
            		set { SetRelatedProperty("SomeULong", value); }
    	}
    
    	public System.UInt64 AnotherULong
    	{
            		get { return GetRelatedProperty<System.UInt64>("AnotherULong"); }
            		set { SetRelatedProperty("AnotherULong", value); }
    	}
    
    	public System.UInt16 SomeUShort
    	{
            		get { return GetRelatedProperty<System.UInt16>("SomeUShort"); }
            		set { SetRelatedProperty("SomeUShort", value); }
    	}
    
    	public System.UInt16 AnotherUShort
    	{
            		get { return GetRelatedProperty<System.UInt16>("AnotherUShort"); }
            		set { SetRelatedProperty("AnotherUShort", value); }
    	}
    
    	public System.Byte[] SomeByteArray
    	{
            		get { return GetRelatedProperty<System.Byte[]>("SomeByteArray"); }
            		set { SetRelatedProperty("SomeByteArray", value); }
    	}
    
    	public BrightstarDB.OData.Tests.TestEnumeration SomeEnumeration
    	{
            		get { return GetRelatedProperty<BrightstarDB.OData.Tests.TestEnumeration>("SomeEnumeration"); }
            		set { SetRelatedProperty("SomeEnumeration", value); }
    	}
    	public System.Collections.Generic.ICollection<System.String> CollectionOfStrings
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.String>("CollectionOfStrings"); }
    		set { SetRelatedLiteralPropertiesCollection<System.String>("CollectionOfStrings", value); }
    	}
    	public System.Collections.Generic.ICollection<System.DateTime> CollectionOfDateTimes
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.DateTime>("CollectionOfDateTimes"); }
    		set { SetRelatedLiteralPropertiesCollection<System.DateTime>("CollectionOfDateTimes", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Boolean> CollectionOfBools
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Boolean>("CollectionOfBools"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Boolean>("CollectionOfBools", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Decimal> CollectionOfDecimals
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Decimal>("CollectionOfDecimals"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Decimal>("CollectionOfDecimals", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Double> CollectionOfDoubles
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Double>("CollectionOfDoubles"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Double>("CollectionOfDoubles", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Single> CollectionOfFloats
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Single>("CollectionOfFloats"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Single>("CollectionOfFloats", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Int32> CollectionOfInts
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Int32>("CollectionOfInts"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Int32>("CollectionOfInts", value); }
    	}
    	public System.Collections.Generic.ICollection<System.Int64> CollectionOfLong
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.Int64>("CollectionOfLong"); }
    		set { SetRelatedLiteralPropertiesCollection<System.Int64>("CollectionOfLong", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class Department : BrightstarEntityObject, IDepartment 
    {
    	public Department(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Department() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.IDepartment
    
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
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.IPerson>("Persons"); }
    		set { SetRelatedObjects("Persons", value); }
    								}
    
    	public BrightstarDB.OData.Tests.ICompany Company
    	{
            get { return GetRelatedObject<BrightstarDB.OData.Tests.ICompany>("Company"); }
            set { SetRelatedObject<BrightstarDB.OData.Tests.ICompany>("Company", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class JobRole : BrightstarEntityObject, IJobRole 
    {
    	public JobRole(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public JobRole() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.IJobRole
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.IPerson>("Persons"); }
    		set { SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class Person : BrightstarEntityObject, IPerson 
    {
    	public Person(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Person() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.IPerson
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.Nullable<System.DateTime> DateOfBirth
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("DateOfBirth"); }
            		set { SetRelatedProperty("DateOfBirth", value); }
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
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.ISkill> Skills
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.ISkill>("Skills"); }
    		set { SetRelatedObjects("Skills", value); }
    								}
    
    	public BrightstarDB.OData.Tests.IDepartment Department
    	{
            get { return GetRelatedObject<BrightstarDB.OData.Tests.IDepartment>("Department"); }
            set { SetRelatedObject<BrightstarDB.OData.Tests.IDepartment>("Department", value); }
    	}
    
    	public System.Int32 EmployeeId
    	{
            		get { return GetRelatedProperty<System.Int32>("EmployeeId"); }
            		set { SetRelatedProperty("EmployeeId", value); }
    	}
    
    	public BrightstarDB.OData.Tests.IJobRole JobRole
    	{
            get { return GetRelatedObject<BrightstarDB.OData.Tests.IJobRole>("JobRole"); }
            set { SetRelatedObject<BrightstarDB.OData.Tests.IJobRole>("JobRole", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.IArticle> Articles
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.IArticle>("Articles"); }
    		set { SetRelatedObjects("Articles", value); }
    								}
    	public System.Collections.Generic.ICollection<System.String> CollectionOfStrings
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.String>("CollectionOfStrings"); }
    		set { SetRelatedLiteralPropertiesCollection<System.String>("CollectionOfStrings", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class Project : BrightstarEntityObject, IProject 
    {
    	public Project(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Project() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.IProject
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String Summary
    	{
            		get { return GetRelatedProperty<System.String>("Summary"); }
            		set { SetRelatedProperty("Summary", value); }
    	}
    
    	public System.Uri Website
    	{
            		get { return GetRelatedProperty<System.Uri>("Website"); }
            		set { SetRelatedProperty("Website", value); }
    	}
    
    	public System.Int32 ProjectCode
    	{
            		get { return GetRelatedProperty<System.Int32>("ProjectCode"); }
            		set { SetRelatedProperty("ProjectCode", value); }
    	}
    
    	public System.Nullable<System.DateTime> StartDate
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("StartDate"); }
            		set { SetRelatedProperty("StartDate", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.OData.Tests 
{
    public partial class Skill : BrightstarEntityObject, ISkill 
    {
    	public Skill(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Skill() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.OData.Tests.ISkill
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public BrightstarDB.OData.Tests.ISkill Parent
    	{
            get { return GetRelatedObject<BrightstarDB.OData.Tests.ISkill>("Parent"); }
            set { SetRelatedObject<BrightstarDB.OData.Tests.ISkill>("Parent", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.ISkill> Children
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.ISkill>("Children"); }
    		set { SetRelatedObjects("Children", value); }
    								}
    	public System.Collections.Generic.ICollection<BrightstarDB.OData.Tests.IPerson> SkilledPeople
    	{
    		get { return GetRelatedObjects<BrightstarDB.OData.Tests.IPerson>("SkilledPeople"); }
    		set { SetRelatedObjects("SkilledPeople", value); }
    								}
    	#endregion
    }
}
