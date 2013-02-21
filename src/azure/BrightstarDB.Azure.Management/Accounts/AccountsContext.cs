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


namespace BrightstarDB.Azure.Management.Accounts 
{
    public partial class AccountsContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static AccountsContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Azure.Management.Accounts.IAccount));
    		TypeMappings.AddImplMapping<BrightstarDB.Azure.Management.Accounts.IAccount, BrightstarDB.Azure.Management.Accounts.Account>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Azure.Management.Accounts.IStore));
    		TypeMappings.AddImplMapping<BrightstarDB.Azure.Management.Accounts.IStore, BrightstarDB.Azure.Management.Accounts.Store>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Azure.Management.Accounts.IStoreAccess));
    		TypeMappings.AddImplMapping<BrightstarDB.Azure.Management.Accounts.IStoreAccess, BrightstarDB.Azure.Management.Accounts.StoreAccess>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Azure.Management.Accounts.ISubscription));
    		TypeMappings.AddImplMapping<BrightstarDB.Azure.Management.Accounts.ISubscription, BrightstarDB.Azure.Management.Accounts.Subscription>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Azure.Management.Accounts.IUserToken));
    		TypeMappings.AddImplMapping<BrightstarDB.Azure.Management.Accounts.IUserToken, BrightstarDB.Azure.Management.Accounts.UserToken>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public AccountsContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public AccountsContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public AccountsContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Accounts = 	new BrightstarEntitySet<Account>(this);
    		Stores = 	new BrightstarEntitySet<Store>(this);
    		StoreAccesss = 	new BrightstarEntitySet<StoreAccess>(this);
    		Subscriptions = 	new BrightstarEntitySet<Subscription>(this);
    		UserTokens = 	new BrightstarEntitySet<UserToken>(this);
    	}
    	
    	public IEntitySet<Account> Accounts 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<Store> Stores 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<StoreAccess> StoreAccesss 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<Subscription> Subscriptions 
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<UserToken> UserTokens 
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Azure.Management.Accounts 
{
    public partial class Account : BrightstarEntityObject, IAccount 
    {
    	public Account(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Account() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Azure.Management.Accounts.IAccount
    	public System.Collections.Generic.ICollection<BrightstarDB.Azure.Management.Accounts.IUserToken> UserTokens
    	{
    		get { return GetRelatedObjects<BrightstarDB.Azure.Management.Accounts.IUserToken>("UserTokens"); }
    		set { SetRelatedObjects("UserTokens", value); }
    								}
    	public System.Collections.Generic.ICollection<BrightstarDB.Azure.Management.Accounts.ISubscription> Subscriptions
    	{
    		get { return GetRelatedObjects<BrightstarDB.Azure.Management.Accounts.ISubscription>("Subscriptions"); }
    		set { SetRelatedObjects("Subscriptions", value); }
    								}
    
    	public System.String PrimaryKey
    	{
            		get { return GetRelatedProperty<System.String>("PrimaryKey"); }
            		set { SetRelatedProperty("PrimaryKey", value); }
    	}
    
    	public System.String SecondaryKey
    	{
            		get { return GetRelatedProperty<System.String>("SecondaryKey"); }
            		set { SetRelatedProperty("SecondaryKey", value); }
    	}
    
    	public System.Boolean IsAdmin
    	{
            		get { return GetRelatedProperty<System.Boolean>("IsAdmin"); }
            		set { SetRelatedProperty("IsAdmin", value); }
    	}
    
    	public System.String EmailAddress
    	{
            		get { return GetRelatedProperty<System.String>("EmailAddress"); }
            		set { SetRelatedProperty("EmailAddress", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Azure.Management.Accounts 
{
    public partial class Store : BrightstarEntityObject, IStore 
    {
    	public Store(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Store() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Azure.Management.Accounts.IStore
    
    	public System.Boolean IsLimited
    	{
            		get { return GetRelatedProperty<System.Boolean>("IsLimited"); }
            		set { SetRelatedProperty("IsLimited", value); }
    	}
    
    	public System.String StoreContainer
    	{
            		get { return GetRelatedProperty<System.String>("StoreContainer"); }
            		set { SetRelatedProperty("StoreContainer", value); }
    	}
    
    	public BrightstarDB.Azure.Management.Accounts.ISubscription Subscription
    	{
            get { return GetRelatedObject<BrightstarDB.Azure.Management.Accounts.ISubscription>("Subscription"); }
            set { SetRelatedObject<BrightstarDB.Azure.Management.Accounts.ISubscription>("Subscription", value); }
    	}
    
    	public System.Int32 CurrentSize
    	{
            		get { return GetRelatedProperty<System.Int32>("CurrentSize"); }
            		set { SetRelatedProperty("CurrentSize", value); }
    	}
    
    	public System.Int32 SizeLimit
    	{
            		get { return GetRelatedProperty<System.Int32>("SizeLimit"); }
            		set { SetRelatedProperty("SizeLimit", value); }
    	}
    
    	public System.String Label
    	{
            		get { return GetRelatedProperty<System.String>("Label"); }
            		set { SetRelatedProperty("Label", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Azure.Management.Accounts 
{
    public partial class StoreAccess : BrightstarEntityObject, IStoreAccess 
    {
    	public StoreAccess(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public StoreAccess() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Azure.Management.Accounts.IStoreAccess
    
    	public BrightstarDB.Azure.Management.Accounts.IAccount Grantee
    	{
            get { return GetRelatedObject<BrightstarDB.Azure.Management.Accounts.IAccount>("Grantee"); }
            set { SetRelatedObject<BrightstarDB.Azure.Management.Accounts.IAccount>("Grantee", value); }
    	}
    
    	public System.Int32 GrantLevel
    	{
            		get { return GetRelatedProperty<System.Int32>("GrantLevel"); }
            		set { SetRelatedProperty("GrantLevel", value); }
    	}
    
    	public BrightstarDB.Azure.Management.Accounts.IStore AccessStore
    	{
            get { return GetRelatedObject<BrightstarDB.Azure.Management.Accounts.IStore>("AccessStore"); }
            set { SetRelatedObject<BrightstarDB.Azure.Management.Accounts.IStore>("AccessStore", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Azure.Management.Accounts 
{
    public partial class Subscription : BrightstarEntityObject, ISubscription 
    {
    	public Subscription(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Subscription() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Azure.Management.Accounts.ISubscription
    
    	public BrightstarDB.Azure.Management.Accounts.IAccount Account
    	{
            get { return GetRelatedObject<BrightstarDB.Azure.Management.Accounts.IAccount>("Account"); }
            set { SetRelatedObject<BrightstarDB.Azure.Management.Accounts.IAccount>("Account", value); }
    	}
    
    	public System.String Label
    	{
            		get { return GetRelatedProperty<System.String>("Label"); }
            		set { SetRelatedProperty("Label", value); }
    	}
    
    	public System.DateTime Created
    	{
            		get { return GetRelatedProperty<System.DateTime>("Created"); }
            		set { SetRelatedProperty("Created", value); }
    	}
    
    	public System.Boolean IsTrial
    	{
            		get { return GetRelatedProperty<System.Boolean>("IsTrial"); }
            		set { SetRelatedProperty("IsTrial", value); }
    	}
    
    	public System.Int32 StoreCount
    	{
            		get { return GetRelatedProperty<System.Int32>("StoreCount"); }
            		set { SetRelatedProperty("StoreCount", value); }
    	}
    
    	public System.Int32 StoreSizeLimit
    	{
            		get { return GetRelatedProperty<System.Int32>("StoreSizeLimit"); }
            		set { SetRelatedProperty("StoreSizeLimit", value); }
    	}
    
    	public System.Int32 StoreCountLimit
    	{
            		get { return GetRelatedProperty<System.Int32>("StoreCountLimit"); }
            		set { SetRelatedProperty("StoreCountLimit", value); }
    	}
    
    	public System.Int32 TotalSizeLimit
    	{
            		get { return GetRelatedProperty<System.Int32>("TotalSizeLimit"); }
            		set { SetRelatedProperty("TotalSizeLimit", value); }
    	}
    
    	public System.Boolean IsActive
    	{
            		get { return GetRelatedProperty<System.Boolean>("IsActive"); }
            		set { SetRelatedProperty("IsActive", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Azure.Management.Accounts.IStore> Stores
    	{
    		get { return GetRelatedObjects<BrightstarDB.Azure.Management.Accounts.IStore>("Stores"); }
    		set { SetRelatedObjects("Stores", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Azure.Management.Accounts 
{
    public partial class UserToken : BrightstarEntityObject, IUserToken 
    {
    	public UserToken(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public UserToken() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Azure.Management.Accounts.IUserToken
    	#endregion
    }
}
