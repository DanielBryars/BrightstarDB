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
using NetworkedPlanet.Brightstar.Client;
using NetworkedPlanet.EntityFramework;
using NetworkedPlanet.Brightstar.EntityFramework;

namespace NetworkedPlanet.Brightstar.Tests.EntityFramework 
{
    public partial class TestContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static TestContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson));
    		TypeMappings.AddImplMapping<NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson, NetworkedPlanet.Brightstar.Tests.EntityFramework.Person>();
            provider.AddMappingsForType(TypeMappings, typeof(IAnimal));
            TypeMappings.AddImplMapping<IAnimal, Animal>();
            provider.AddMappingsForType(TypeMappings, typeof(ISkill));
            TypeMappings.AddImplMapping<ISkill, Skill>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public TestContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Persons = new BrightstarEntitySet<Person>(this);
    	    Animals = new BrightstarEntitySet<Animal>(this);
    	    Skills = new BrightstarEntitySet<Skill>(this);
    	}
    	
    	public IEntitySet<Person> Persons { get; private set; }
        public IEntitySet<Animal> Animals { get; private set; }
        public IEntitySet<Skill> Skills { get; private set; }
    }
}
namespace NetworkedPlanet.Brightstar.Tests.EntityFramework 
{
    public partial class Person : BrightstarEntityObject, IPerson 
    {
    	public Person(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public System.String Id { get {return base.GetIdentity();} }
    
    	public System.String Name
    	{
            get { return GetRelatedProperty<System.String>("Name"); }
            set { SetRelatedProperty("Name", value); }
    	}
    
    	public NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson Mother
    	{
            get { return GetRelatedObject<NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson>("Mother"); }
            set { SetRelatedObject<NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson>("Mother", value); }
    	}
    
    	public NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson Father
    	{
            get { return GetRelatedObject<NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson>("Father"); }
            set { SetRelatedObject<NetworkedPlanet.Brightstar.Tests.EntityFramework.IPerson>("Father", value); }
    	}

    	public ICollection<IPerson> Friends
    	{
    		get { return GetRelatedObjects<IPerson>("Friends"); }
    		set { SetRelatedObjects("Friends", value); }
    	}

        public IAnimal Pet
        {
            get { return GetRelatedObject<IAnimal>("Pet"); }
            set { SetRelatedObject("Pet", value); }
        }

        public ICollection<ISkill> Skills
        {
            get { return GetRelatedObjects<ISkill>("Skills"); }
            set { SetRelatedObjects("Skills", value); }
        }
    }

    public class Animal : BrightstarEntityObject, IAnimal
    {
    	public Animal(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }

        #region Implementation of IAnimal

        public string Id
        {
            get { return GetIdentity(); }
        }

        public string Name
        {
            get { return GetRelatedProperty<string>("Name"); }
            set { SetRelatedProperty("Name", value); }
        }

        public IPerson Owner
        {
            get { return GetRelatedObject<IPerson>("Owner"); }
            set { SetRelatedObject("Owner", value); }
        }

        #endregion
    }

    public class Skill : BrightstarEntityObject, ISkill
    {
        public Skill(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject)
        {
        }

        #region Implementation of ISkill

        public string Id
        {
            get { return base.GetIdentity(); }
        }

        public string Name
        {
            get { return GetRelatedProperty<string>("Name"); }
            set { SetRelatedProperty("Name", value); }
        }

        public ISkill Parent
        {
            get { return GetRelatedObject<ISkill>("Parent"); }
            set { SetRelatedObject("Parent", value); }
        }

        public ICollection<ISkill> Children
        {
            get { return GetRelatedObjects<ISkill>("Children"); }
            set { SetRelatedObject("Children", value); }
        }

        public ICollection<IPerson> SkilledPeople
        {
            get { return GetRelatedObjects<IPerson>("SkilledPeople"); }
            set { SetRelatedObjects("SkilledPeople", value); }
        }

        #endregion
    }
}
