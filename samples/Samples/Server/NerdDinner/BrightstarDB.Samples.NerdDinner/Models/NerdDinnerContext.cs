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

using System.ComponentModel.DataAnnotations;

namespace BrightstarDB.Samples.NerdDinner.Models 
{
    public partial class NerdDinnerContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static NerdDinnerContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.NerdDinner.Models.IDinner));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.NerdDinner.Models.IDinner, BrightstarDB.Samples.NerdDinner.Models.Dinner>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.NerdDinner.Models.INerdDinnerLogin));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.NerdDinner.Models.INerdDinnerLogin, BrightstarDB.Samples.NerdDinner.Models.NerdDinnerLogin>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.NerdDinner.Models.IRSVP));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.NerdDinner.Models.IRSVP, BrightstarDB.Samples.NerdDinner.Models.RSVP>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public NerdDinnerContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public NerdDinnerContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public NerdDinnerContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Dinners = 	new BrightstarEntitySet<BrightstarDB.Samples.NerdDinner.Models.IDinner>(this);
    		NerdDinnerLogins = 	new BrightstarEntitySet<BrightstarDB.Samples.NerdDinner.Models.INerdDinnerLogin>(this);
    		RSVPs = 	new BrightstarEntitySet<BrightstarDB.Samples.NerdDinner.Models.IRSVP>(this);
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.NerdDinner.Models.IDinner> Dinners
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.NerdDinner.Models.INerdDinnerLogin> NerdDinnerLogins
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.NerdDinner.Models.IRSVP> RSVPs
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Samples.NerdDinner.Models 
{
    
    public partial class Dinner : BrightstarEntityObject, IDinner 
    {
    	public Dinner(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Dinner() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.NerdDinner.Models.IDinner
    	
    	[System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage="Please provide a title for the dinner")]
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    	
    	[System.ComponentModel.DataAnnotations.DisplayAttribute(Name="Event Date")]	
    	[System.ComponentModel.DataAnnotations.DataTypeAttribute(DataType.DateTime)]
    	public System.DateTime EventDate
    	{
            		get { return GetRelatedProperty<System.DateTime>("EventDate"); }
            		set { SetRelatedProperty("EventDate", value); }
    	}
    	
    	[System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage="The event must have an address.")]
    	public System.String Address
    	{
            		get { return GetRelatedProperty<System.String>("Address"); }
            		set { SetRelatedProperty("Address", value); }
    	}
    	
    	[System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage="Please enter the city where the event takes place")]
    	public System.String City
    	{
            		get { return GetRelatedProperty<System.String>("City"); }
            		set { SetRelatedProperty("City", value); }
    	}
    	
    	[System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage="Please enter the name of the host of this event")]	
    	[System.ComponentModel.DataAnnotations.DisplayAttribute(Name="Host")]
    	public System.String HostedBy
    	{
            		get { return GetRelatedProperty<System.String>("HostedBy"); }
            		set { SetRelatedProperty("HostedBy", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.NerdDinner.Models.IRSVP> RSVPs
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.NerdDinner.Models.IRSVP>("RSVPs"); }
    		set { SetRelatedObjects("RSVPs", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Samples.NerdDinner.Models 
{
    
    public partial class NerdDinnerLogin : BrightstarEntityObject, INerdDinnerLogin 
    {
    	public NerdDinnerLogin(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public NerdDinnerLogin() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.NerdDinner.Models.INerdDinnerLogin
    
    	public System.String Username
    	{
            		get { return GetRelatedProperty<System.String>("Username"); }
            		set { SetRelatedProperty("Username", value); }
    	}
    
    	public System.String Password
    	{
            		get { return GetRelatedProperty<System.String>("Password"); }
            		set { SetRelatedProperty("Password", value); }
    	}
    
    	public System.String PasswordSalt
    	{
            		get { return GetRelatedProperty<System.String>("PasswordSalt"); }
            		set { SetRelatedProperty("PasswordSalt", value); }
    	}
    
    	public System.String Email
    	{
            		get { return GetRelatedProperty<System.String>("Email"); }
            		set { SetRelatedProperty("Email", value); }
    	}
    
    	public System.String Comments
    	{
            		get { return GetRelatedProperty<System.String>("Comments"); }
            		set { SetRelatedProperty("Comments", value); }
    	}
    
    	public System.DateTime CreatedDate
    	{
            		get { return GetRelatedProperty<System.DateTime>("CreatedDate"); }
            		set { SetRelatedProperty("CreatedDate", value); }
    	}
    
    	public System.DateTime LastActive
    	{
            		get { return GetRelatedProperty<System.DateTime>("LastActive"); }
            		set { SetRelatedProperty("LastActive", value); }
    	}
    
    	public System.DateTime LastLoginDate
    	{
            		get { return GetRelatedProperty<System.DateTime>("LastLoginDate"); }
            		set { SetRelatedProperty("LastLoginDate", value); }
    	}
    
    	public System.Boolean IsActivated
    	{
            		get { return GetRelatedProperty<System.Boolean>("IsActivated"); }
            		set { SetRelatedProperty("IsActivated", value); }
    	}
    
    	public System.Boolean IsLockedOut
    	{
            		get { return GetRelatedProperty<System.Boolean>("IsLockedOut"); }
            		set { SetRelatedProperty("IsLockedOut", value); }
    	}
    
    	public System.DateTime LastLockedOutDate
    	{
            		get { return GetRelatedProperty<System.DateTime>("LastLockedOutDate"); }
            		set { SetRelatedProperty("LastLockedOutDate", value); }
    	}
    
    	public System.String LastLockedOutReason
    	{
            		get { return GetRelatedProperty<System.String>("LastLockedOutReason"); }
            		set { SetRelatedProperty("LastLockedOutReason", value); }
    	}
    
    	public System.Nullable<System.Int32> LoginAttempts
    	{
            		get { return GetRelatedProperty<System.Nullable<System.Int32>>("LoginAttempts"); }
            		set { SetRelatedProperty("LoginAttempts", value); }
    	}
    	public System.Collections.Generic.ICollection<System.String> Roles
    	{
    		get { return GetRelatedLiteralPropertiesCollection<System.String>("Roles"); }
    		set { SetRelatedLiteralPropertiesCollection<System.String>("Roles", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Samples.NerdDinner.Models 
{
    
    public partial class RSVP : BrightstarEntityObject, IRSVP 
    {
    	public RSVP(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public RSVP() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.NerdDinner.Models.IRSVP
    	
    	[System.ComponentModel.DataAnnotations.DisplayAttribute(Name="Email Address")]	
    	[System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage="Email address is required")]
    	public System.String AttendeeEmail
    	{
            		get { return GetRelatedProperty<System.String>("AttendeeEmail"); }
            		set { SetRelatedProperty("AttendeeEmail", value); }
    	}
    
    	public BrightstarDB.Samples.NerdDinner.Models.IDinner Dinner
    	{
            get { return GetRelatedObject<BrightstarDB.Samples.NerdDinner.Models.IDinner>("Dinner"); }
            set { SetRelatedObject<BrightstarDB.Samples.NerdDinner.Models.IDinner>("Dinner", value); }
    	}
    	#endregion
    }
}
