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


namespace BrightstarDB.Mobile.Tests.EntityFramework 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static MyEntityContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Mobile.Tests.EntityFramework.INote));
    		TypeMappings.AddImplMapping<BrightstarDB.Mobile.Tests.EntityFramework.INote, BrightstarDB.Mobile.Tests.EntityFramework.Note>();
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
    		Notes = 	new BrightstarEntitySet<Note>(this);
    	}
    	
    	public IEntitySet<Note> Notes 
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Mobile.Tests.EntityFramework 
{
    public partial class Note : BrightstarEntityObject, INote 
    {
    	public Note(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Note() : base() { }
    	#region Implementation of BrightstarDB.Mobile.Tests.EntityFramework.INote
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String Body
    	{
            		get { return GetRelatedProperty<System.String>("Body"); }
            		set { SetRelatedProperty("Body", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Mobile.Tests.EntityFramework.INote> LinkedNotes
    	{
    		get { return GetRelatedObjects<BrightstarDB.Mobile.Tests.EntityFramework.INote>("LinkedNotes"); }
    		set { SetRelatedObjects("LinkedNotes", value); }
    								}
    	#endregion
    }
}
