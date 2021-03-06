﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceZipZop.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProjetoCardapio")]
	public partial class ZipZopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertGrupoUsuario(GrupoUsuario instance);
    partial void UpdateGrupoUsuario(GrupoUsuario instance);
    partial void DeleteGrupoUsuario(GrupoUsuario instance);
    partial void InsertRelGrupoUsuario(RelGrupoUsuario instance);
    partial void UpdateRelGrupoUsuario(RelGrupoUsuario instance);
    partial void DeleteRelGrupoUsuario(RelGrupoUsuario instance);
    #endregion
		
		public ZipZopDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoCardapioConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ZipZopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ZipZopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ZipZopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ZipZopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<GrupoUsuario> GrupoUsuarios
		{
			get
			{
				return this.GetTable<GrupoUsuario>();
			}
		}
		
		public System.Data.Linq.Table<RelGrupoUsuario> RelGrupoUsuarios
		{
			get
			{
				return this.GetTable<RelGrupoUsuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nome;
		
		private string _Foto;
		
		private string _Uri;
		
		private EntitySet<GrupoUsuario> _GrupoUsuarios;
		
		private EntitySet<RelGrupoUsuario> _RelGrupoUsuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnFotoChanging(string value);
    partial void OnFotoChanged();
    partial void OnUriChanging(string value);
    partial void OnUriChanged();
    #endregion
		
		public Usuario()
		{
			this._GrupoUsuarios = new EntitySet<GrupoUsuario>(new Action<GrupoUsuario>(this.attach_GrupoUsuarios), new Action<GrupoUsuario>(this.detach_GrupoUsuarios));
			this._RelGrupoUsuarios = new EntitySet<RelGrupoUsuario>(new Action<RelGrupoUsuario>(this.attach_RelGrupoUsuarios), new Action<RelGrupoUsuario>(this.detach_RelGrupoUsuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Foto", DbType="VarChar(50)")]
		public string Foto
		{
			get
			{
				return this._Foto;
			}
			set
			{
				if ((this._Foto != value))
				{
					this.OnFotoChanging(value);
					this.SendPropertyChanging();
					this._Foto = value;
					this.SendPropertyChanged("Foto");
					this.OnFotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uri", DbType="VarChar(MAX)")]
		public string Uri
		{
			get
			{
				return this._Uri;
			}
			set
			{
				if ((this._Uri != value))
				{
					this.OnUriChanging(value);
					this.SendPropertyChanging();
					this._Uri = value;
					this.SendPropertyChanged("Uri");
					this.OnUriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_GrupoUsuario", Storage="_GrupoUsuarios", ThisKey="Id", OtherKey="idAdm")]
		internal EntitySet<GrupoUsuario> GrupoUsuarios
		{
			get
			{
				return this._GrupoUsuarios;
			}
			set
			{
				this._GrupoUsuarios.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_RelGrupoUsuario", Storage="_RelGrupoUsuarios", ThisKey="Id", OtherKey="Usuario_Id")]
		internal EntitySet<RelGrupoUsuario> RelGrupoUsuarios
		{
			get
			{
				return this._RelGrupoUsuarios;
			}
			set
			{
				this._RelGrupoUsuarios.Assign(value);
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
		
		private void attach_GrupoUsuarios(GrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_GrupoUsuarios(GrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
		
		private void attach_RelGrupoUsuarios(RelGrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_RelGrupoUsuarios(RelGrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GrupoUsuario")]
	public partial class GrupoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Descricao;
		
		private System.Nullable<int> _idAdm;
		
		private EntitySet<RelGrupoUsuario> _RelGrupoUsuarios;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnidAdmChanging(System.Nullable<int> value);
    partial void OnidAdmChanged();
    #endregion
		
		public GrupoUsuario()
		{
			this._RelGrupoUsuarios = new EntitySet<RelGrupoUsuario>(new Action<RelGrupoUsuario>(this.attach_RelGrupoUsuarios), new Action<RelGrupoUsuario>(this.detach_RelGrupoUsuarios));
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descricao", DbType="VarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAdm", DbType="Int")]
		public System.Nullable<int> idAdm
		{
			get
			{
				return this._idAdm;
			}
			set
			{
				if ((this._idAdm != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAdmChanging(value);
					this.SendPropertyChanging();
					this._idAdm = value;
					this.SendPropertyChanged("idAdm");
					this.OnidAdmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GrupoUsuario_RelGrupoUsuario", Storage="_RelGrupoUsuarios", ThisKey="Id", OtherKey="GrupoUsuario_Id")]
		internal EntitySet<RelGrupoUsuario> RelGrupoUsuarios
		{
			get
			{
				return this._RelGrupoUsuarios;
			}
			set
			{
				this._RelGrupoUsuarios.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_GrupoUsuario", Storage="_Usuario", ThisKey="idAdm", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		internal Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.GrupoUsuarios.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.GrupoUsuarios.Add(this);
						this._idAdm = value.Id;
					}
					else
					{
						this._idAdm = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
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
		
		private void attach_RelGrupoUsuarios(RelGrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.GrupoUsuario = this;
		}
		
		private void detach_RelGrupoUsuarios(RelGrupoUsuario entity)
		{
			this.SendPropertyChanging();
			entity.GrupoUsuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RelGrupoUsuario")]
	public partial class RelGrupoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Usuario_Id;
		
		private int _GrupoUsuario_Id;
		
		private EntityRef<GrupoUsuario> _GrupoUsuario;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsuario_IdChanging(int value);
    partial void OnUsuario_IdChanged();
    partial void OnGrupoUsuario_IdChanging(int value);
    partial void OnGrupoUsuario_IdChanged();
    #endregion
		
		public RelGrupoUsuario()
		{
			this._GrupoUsuario = default(EntityRef<GrupoUsuario>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Usuario_Id
		{
			get
			{
				return this._Usuario_Id;
			}
			set
			{
				if ((this._Usuario_Id != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsuario_IdChanging(value);
					this.SendPropertyChanging();
					this._Usuario_Id = value;
					this.SendPropertyChanged("Usuario_Id");
					this.OnUsuario_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GrupoUsuario_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int GrupoUsuario_Id
		{
			get
			{
				return this._GrupoUsuario_Id;
			}
			set
			{
				if ((this._GrupoUsuario_Id != value))
				{
					if (this._GrupoUsuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGrupoUsuario_IdChanging(value);
					this.SendPropertyChanging();
					this._GrupoUsuario_Id = value;
					this.SendPropertyChanged("GrupoUsuario_Id");
					this.OnGrupoUsuario_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GrupoUsuario_RelGrupoUsuario", Storage="_GrupoUsuario", ThisKey="GrupoUsuario_Id", OtherKey="Id", IsForeignKey=true)]
		internal GrupoUsuario GrupoUsuario
		{
			get
			{
				return this._GrupoUsuario.Entity;
			}
			set
			{
				GrupoUsuario previousValue = this._GrupoUsuario.Entity;
				if (((previousValue != value) 
							|| (this._GrupoUsuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GrupoUsuario.Entity = null;
						previousValue.RelGrupoUsuarios.Remove(this);
					}
					this._GrupoUsuario.Entity = value;
					if ((value != null))
					{
						value.RelGrupoUsuarios.Add(this);
						this._GrupoUsuario_Id = value.Id;
					}
					else
					{
						this._GrupoUsuario_Id = default(int);
					}
					this.SendPropertyChanged("GrupoUsuario");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_RelGrupoUsuario", Storage="_Usuario", ThisKey="Usuario_Id", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		internal Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.RelGrupoUsuarios.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.RelGrupoUsuarios.Add(this);
						this._Usuario_Id = value.Id;
					}
					else
					{
						this._Usuario_Id = default(int);
					}
					this.SendPropertyChanged("Usuario");
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
