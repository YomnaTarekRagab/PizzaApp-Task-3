﻿//////////////////////////////////////////////////////////////
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

	/// <summary>Entity class which represents the entity 'OrdersList'.<br/><br/></summary>
	[Serializable]
	public partial class OrdersListEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<PizzasListEntity> _pizzasLists;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static OrdersListEntityStaticMetaData _staticMetaData = new OrdersListEntityStaticMetaData();
		private static OrdersListRelations _relationsFactory = new OrdersListRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name PizzasLists</summary>
			public static readonly string PizzasLists = "PizzasLists";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class OrdersListEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public OrdersListEntityStaticMetaData()
			{
				SetEntityCoreInfo("OrdersListEntity", InheritanceHierarchyType.None, false, (int)PizzaAppData.EntityType.OrdersListEntity, typeof(OrdersListEntity), typeof(OrdersListEntityFactory), false);
				AddNavigatorMetaData<OrdersListEntity, EntityCollection<PizzasListEntity>>("PizzasLists", a => a._pizzasLists, (a, b) => a._pizzasLists = b, a => a.PizzasLists, () => new OrdersListRelations().PizzasListEntityUsingOrderId, typeof(PizzasListEntity), (int)PizzaAppData.EntityType.PizzasListEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static OrdersListEntity()
		{
		}

		/// <summary> CTor</summary>
		public OrdersListEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public OrdersListEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this OrdersListEntity</param>
		public OrdersListEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for OrdersList which data should be fetched into this OrdersList object</param>
		public OrdersListEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for OrdersList which data should be fetched into this OrdersList object</param>
		/// <param name="validator">The custom validator object for this OrdersListEntity</param>
		public OrdersListEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OrdersListEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PizzasList' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPizzasLists() { return CreateRelationInfoForNavigator("PizzasLists"); }
		
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
		/// <param name="validator">The validator object for this OrdersListEntity</param>
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
		public static OrdersListRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PizzasList' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPizzasLists { get { return _staticMetaData.GetPrefetchPathElement("PizzasLists", CommonEntityBase.CreateEntityCollection<PizzasListEntity>()); } }

		/// <summary>The Id property of the Entity OrdersList<br/><br/></summary>
		/// <remarks>Mapped on  table field: "orders_list"."id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)OrdersListFieldIndex.Id, true); }
			set { SetValue((int)OrdersListFieldIndex.Id, value); }		}

		/// <summary>The NumberOfPizzas property of the Entity OrdersList<br/><br/></summary>
		/// <remarks>Mapped on  table field: "orders_list"."number_of_pizzas".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 NumberOfPizzas
		{
			get { return (System.Int32)GetValue((int)OrdersListFieldIndex.NumberOfPizzas, true); }
			set	{ SetValue((int)OrdersListFieldIndex.NumberOfPizzas, value); }
		}

		/// <summary>The TotalPrice property of the Entity OrdersList<br/><br/></summary>
		/// <remarks>Mapped on  table field: "orders_list"."total_price".<br/>Table field type characteristics (type, precision, scale, length): Double, 38, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double TotalPrice
		{
			get { return (System.Double)GetValue((int)OrdersListFieldIndex.TotalPrice, true); }
			set	{ SetValue((int)OrdersListFieldIndex.TotalPrice, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'PizzasListEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PizzasListEntity))]
		public virtual EntityCollection<PizzasListEntity> PizzasLists { get { return GetOrCreateEntityCollection<PizzasListEntity, PizzasListEntityFactory>("OrdersList", true, false, ref _pizzasLists); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace PizzaAppData
{
	public enum OrdersListFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>NumberOfPizzas. </summary>
		NumberOfPizzas,
		///<summary>TotalPrice. </summary>
		TotalPrice,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace PizzaAppData.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: OrdersList. </summary>
	public partial class OrdersListRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between OrdersListEntity and PizzasListEntity over the 1:n relation they have, using the relation between the fields: OrdersList.Id - PizzasList.OrderId</summary>
		public virtual IEntityRelation PizzasListEntityUsingOrderId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PizzasLists", true, new[] { OrdersListFields.Id, PizzasListFields.OrderId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrdersListRelations
	{
		internal static readonly IEntityRelation PizzasListEntityUsingOrderIdStatic = new OrdersListRelations().PizzasListEntityUsingOrderId;

		/// <summary>CTor</summary>
		static StaticOrdersListRelations() { }
	}
}
