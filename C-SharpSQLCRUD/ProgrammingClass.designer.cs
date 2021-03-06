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

namespace C_SharpSQLCRUD
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CRUDTestDB")]
	public partial class ProgrammingClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProductInfo(ProductInfo instance);
    partial void UpdateProductInfo(ProductInfo instance);
    partial void DeleteProductInfo(ProductInfo instance);
    #endregion
		
		public ProgrammingClassDataContext() : 
				base(global::C_SharpSQLCRUD.Properties.Settings.Default.CRUDTestDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProgrammingClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ProductInfo> ProductInfos
		{
			get
			{
				return this.GetTable<ProductInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductInfo")]
	public partial class ProductInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ItemName;
		
		private string _Design;
		
		private string _Color;
		
		private System.Nullable<System.DateTime> _InsertDate;
		
		private System.Nullable<System.DateTime> _UpdateDate;
		
		private System.Nullable<System.DateTime> _ModifyDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnDesignChanging(string value);
    partial void OnDesignChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnInsertDateChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertDateChanged();
    partial void OnUpdateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateDateChanged();
    partial void OnModifyDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifyDateChanged();
    #endregion
		
		public ProductInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="NVarChar(50)")]
		public string ItemName
		{
			get
			{
				return this._ItemName;
			}
			set
			{
				if ((this._ItemName != value))
				{
					this.OnItemNameChanging(value);
					this.SendPropertyChanging();
					this._ItemName = value;
					this.SendPropertyChanged("ItemName");
					this.OnItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Design", DbType="NVarChar(150)")]
		public string Design
		{
			get
			{
				return this._Design;
			}
			set
			{
				if ((this._Design != value))
				{
					this.OnDesignChanging(value);
					this.SendPropertyChanging();
					this._Design = value;
					this.SendPropertyChanged("Design");
					this.OnDesignChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(50)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertDate
		{
			get
			{
				return this._InsertDate;
			}
			set
			{
				if ((this._InsertDate != value))
				{
					this.OnInsertDateChanging(value);
					this.SendPropertyChanging();
					this._InsertDate = value;
					this.SendPropertyChanged("InsertDate");
					this.OnInsertDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdateDate
		{
			get
			{
				return this._UpdateDate;
			}
			set
			{
				if ((this._UpdateDate != value))
				{
					this.OnUpdateDateChanging(value);
					this.SendPropertyChanging();
					this._UpdateDate = value;
					this.SendPropertyChanged("UpdateDate");
					this.OnUpdateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifyDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifyDate
		{
			get
			{
				return this._ModifyDate;
			}
			set
			{
				if ((this._ModifyDate != value))
				{
					this.OnModifyDateChanging(value);
					this.SendPropertyChanging();
					this._ModifyDate = value;
					this.SendPropertyChanged("ModifyDate");
					this.OnModifyDateChanged();
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
}
#pragma warning restore 1591
