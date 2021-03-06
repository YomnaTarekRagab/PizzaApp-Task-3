//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using PizzaAppData.HelperClasses;
using PizzaAppData.FactoryClasses;
using PizzaAppData.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PizzaAppData.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'PizzaSize'.<br/><br/></summary>
	[Serializable]
	public partial class PizzaSizeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static PizzaSizeEntityStaticMetaData _staticMetaData = new PizzaSizeEntityStaticMetaData();
		private static PizzaSizeRelations _relationsFactory = new PizzaSizeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PizzaSizeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PizzaSizeEntityStaticMetaData()
			{
				SetEntityCoreInfo("PizzaSizeEntity", InheritanceHierarchyType.None, false, (int)PizzaAppData.EntityType.PizzaSizeEntity, typeof(PizzaSizeEntity), typeof(PizzaSizeEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static PizzaSizeEntity()
		{
		}

		/// <summary> CTor</summary>
		public PizzaSizeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PizzaSizeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PizzaSizeEntity</param>
		public PizzaSizeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PizzaSize which data should be fetched into this PizzaSize object</param>
		public PizzaSizeEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for PizzaSize which data should be fetched into this PizzaSize object</param>
		/// <param name="validator">The custom validator object for this PizzaSizeEntity</param>
		public PizzaSizeEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PizzaSizeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PizzaSizeEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static PizzaSizeRelations Relations { get { return _relationsFactory; } }

		/// <summary>The Id property of the Entity PizzaSize<br/><br/></summary>
		/// <remarks>Mapped on  table field: "pizza_sizes"."id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)PizzaSizeFieldIndex.Id, true); }
			set { SetValue((int)PizzaSizeFieldIndex.Id, value); }		}

		/// <summary>The Price property of the Entity PizzaSize<br/><br/></summary>
		/// <remarks>Mapped on  table field: "pizza_sizes"."price".<br/>Table field type characteristics (type, precision, scale, length): Double, 38, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double Price
		{
			get { return (System.Double)GetValue((int)PizzaSizeFieldIndex.Price, true); }
			set	{ SetValue((int)PizzaSizeFieldIndex.Price, value); }
		}

		/// <summary>The Type property of the Entity PizzaSize<br/><br/></summary>
		/// <remarks>Mapped on  table field: "pizza_sizes"."type".<br/>Table field type characteristics (type, precision, scale, length): Text, 0, 0, 1073741824.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Type
		{
			get { return (System.String)GetValue((int)PizzaSizeFieldIndex.Type, true); }
			set	{ SetValue((int)PizzaSizeFieldIndex.Type, value); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace PizzaAppData
{
	public enum PizzaSizeFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Price. </summary>
		Price,
		///<summary>Type. </summary>
		Type,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace PizzaAppData.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: PizzaSize. </summary>
	public partial class PizzaSizeRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPizzaSizeRelations
	{

		/// <summary>CTor</summary>
		static StaticPizzaSizeRelations() { }
	}
}
