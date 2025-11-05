/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:DataAccess (DataAccess Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_DAL_DataMapperBase.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SISPAE.Model;
using SISPAE.DataAccess.DataInterfaces;
using Dapper;
using static Dapper.SqlMapper;
using Z.Dapper.Plus;



namespace SISPAE.DataAccess.DataMapper
	{
	/// <Resumen>
	/// Clase Abstracta para  ListaOpciones
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class ListaOpcionesRepository : DataObject, IListaOpciones
		{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public ListaOpcionesRepository()
			{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
			}

		public ListaOpcionesRepository(DataAccess.DataMapper.DataMapperSource dataSource)
			{
			_dataSource = dataSource;
			}

		#endregion Class Declarations

		#region Class Methods

		public ListaOpciones GetById(ListaOpciones pListaOpciones)
			{

			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pListaOpciones.id);


				ListaOpciones o = SqlMapper.QueryFirstOrDefault<ListaOpciones>(con, "API.PA_ListaOpcionesGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetById)  ListaOpciones  ->" + ex.Message);
				}
			}

		public List<ListaOpciones> GetAll()
			{
			try
				{
				List<ListaOpciones> l = SqlMapper.Query<ListaOpciones>(con, "API.PA_ListaOpcionesGetAll").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAll)  ListaOpciones  ->" + ex.Message);
				}
			}

		public List<ListaOpciones> GetAllFull()
			{
			try
				{
				List<ListaOpciones> l = SqlMapper.Query<ListaOpciones>(con, "API.PA_ListaOpcionesGetAllFull").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllFull)  ListaOpciones  ->" + ex.Message);
				}
			}

		public List<ListaOpciones> GetAllByWithRelation()
			{
			try
				{
				List<ListaOpciones> l = SqlMapper.Query<ListaOpciones>(con, "API.PA_ListaOpcionesGetAllWithRelation").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllByWithRelation)  ListaOpciones  ->" + ex.Message);
				}
			}




		public List<ListaOpciones> GetByFilter(ListaOpciones pListaOpciones, int pageSize, int Page, string OrderByC)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pListaOpciones.id == null || pListaOpciones.id == 0) ? vintNUll : pListaOpciones.id);
				p.Add("@Lista", pListaOpciones.Lista);
				p.Add("@Codigo", pListaOpciones.Codigo == 0 ? vintNUll : pListaOpciones.Codigo);
				p.Add("@Valor", pListaOpciones.Valor);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<ListaOpciones> l = SqlMapper.Query<ListaOpciones>(con, "API.PA_ListaOpcionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetByFilter)  ListaOpciones  ->" + ex.Message);
				}
			}

		public ListaOpciones Add(ListaOpciones pListaOpciones)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pListaOpciones.id == null ? 0 : pListaOpciones.id);
				p.Add("@Lista", pListaOpciones.Lista);
				p.Add("@Codigo", pListaOpciones.Codigo == null ? 0 : pListaOpciones.Codigo);
				p.Add("@Valor", pListaOpciones.Valor);
				p.Add("@auditoria", pListaOpciones.auditoria);




				ListaOpciones o = SqlMapper.QueryFirstOrDefault<ListaOpciones>(con, "API.PA_ListaOpcionesAdd", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Add)  ListaOpciones  ->" + ex.Message);
				}
			}

		public ListaOpciones Update(ListaOpciones pListaOpciones)
			{
			try
				{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pListaOpciones.id == null ? 0 : pListaOpciones.id);
				p.Add("@Lista", pListaOpciones.Lista);
				p.Add("@Codigo", pListaOpciones.Codigo == null ? 0 : pListaOpciones.Codigo);
				p.Add("@Valor", pListaOpciones.Valor);
				p.Add("@auditoria", pListaOpciones.auditoria);




				ListaOpciones o = SqlMapper.QueryFirstOrDefault<ListaOpciones>(con, "API.PA_ListaOpcionesUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Update)  ListaOpciones  ->" + ex.Message);
				}
			}

		public bool Delete(ListaOpciones pListaOpciones)
			{
			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pListaOpciones.id);
				p.Add("@auditoria", pListaOpciones.auditoria);





				ListaOpciones o = SqlMapper.QueryFirstOrDefault<ListaOpciones>(con, "API.PA_ListaOpcionesDelete", p, commandType: CommandType.StoredProcedure);

				return true;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper: (Delete) ListaOpciones  ->" + ex.Message);
				}
			}





		public List<ListaOpciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
			{
			try
				{
				List<ListaOpciones> ListaOpcionesList = new List<ListaOpciones>();

				ListaOpcionesList = SqlMapper.Query<ListaOpciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return ListaOpcionesList;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(ExecProcedureQuery) ListaOpciones  ->" + ex.Message);
				}
			}


		public void BulkInsert(List<ListaOpciones> b)
			{
			DapperPlusManager.Entity<ListaOpciones>().Table("ListaOpciones");
			con.BulkInsert(b);
			}
		}
	#endregion Class Methods

	}