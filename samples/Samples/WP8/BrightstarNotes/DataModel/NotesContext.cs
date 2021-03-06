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


namespace BrightstarNotes.DataModel 
{
    public partial class NotesContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static NotesContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarNotes.DataModel.INote));
    		TypeMappings.AddImplMapping<BrightstarNotes.DataModel.INote, BrightstarNotes.DataModel.Note>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarNotes.DataModel.INoteCategory));
    		TypeMappings.AddImplMapping<BrightstarNotes.DataModel.INoteCategory, BrightstarNotes.DataModel.NoteCategory>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public NotesContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public NotesContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public NotesContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Notes = 	new BrightstarEntitySet<BrightstarNotes.DataModel.INote>(this);
    		NoteCategories = 	new BrightstarEntitySet<BrightstarNotes.DataModel.INoteCategory>(this);
    	}
    	
    	public IEntitySet<BrightstarNotes.DataModel.INote> Notes
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarNotes.DataModel.INoteCategory> NoteCategories
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarNotes.DataModel 
{
    
    public partial class Note : BrightstarEntityObject, INote 
    {
    	public Note(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Note() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarNotes.DataModel.INote
    
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
    
    	public System.DateTime Modified
    	{
            		get { return GetRelatedProperty<System.DateTime>("Modified"); }
            		set { SetRelatedProperty("Modified", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarNotes.DataModel.INote> LinkedNotes
    	{
    		get { return GetRelatedObjects<BrightstarNotes.DataModel.INote>("LinkedNotes"); }
    		set { SetRelatedObjects("LinkedNotes", value); }
    								}
    
    	public BrightstarNotes.DataModel.INoteCategory Category
    	{
            get { return GetRelatedObject<BrightstarNotes.DataModel.INoteCategory>("Category"); }
            set { SetRelatedObject<BrightstarNotes.DataModel.INoteCategory>("Category", value); }
    	}
    	#endregion
    }
}
namespace BrightstarNotes.DataModel 
{
    
    public partial class NoteCategory : BrightstarEntityObject, INoteCategory 
    {
    	public NoteCategory(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public NoteCategory() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarNotes.DataModel.INoteCategory
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarNotes.DataModel.INote> Notes
    	{
    		get { return GetRelatedObjects<BrightstarNotes.DataModel.INote>("Notes"); }
    		set { SetRelatedObjects("Notes", value); }
    								}
    	#endregion
    }
}
