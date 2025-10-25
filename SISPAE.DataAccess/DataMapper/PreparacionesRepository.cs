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
	/// Clase Abstracta para  Preparaciones
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class PreparacionesRepository : DataObject, IPreparaciones
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public PreparacionesRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public PreparacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public Preparaciones GetById(Preparaciones pPreparaciones)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPreparaciones.id);


				Preparaciones o = SqlMapper.QueryFirstOrDefault<Preparaciones>(con, "API.PA_PreparacionesGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  Preparaciones  ->" + ex.Message);
			}
		}

		public List<Preparaciones> GetAll()
		{
			try
			{
				List<Preparaciones> l = SqlMapper.Query<Preparaciones>(con, "API.PA_PreparacionesGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  Preparaciones  ->" + ex.Message);
			}
		}

		public List<Preparaciones> GetAllFull()
		{
			try
			{
				List<Preparaciones> l = SqlMapper.Query<Preparaciones>(con, "API.PA_PreparacionesGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  Preparaciones  ->" + ex.Message);
			}
		}

		public List<Preparaciones> GetAllByWithRelation()
		{
			try
			{
				List<Preparaciones> l = SqlMapper.Query<Preparaciones>(con, "API.PA_PreparacionesGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  Preparaciones  ->" + ex.Message);
			}
		}




		public List<Preparaciones> GetByFilter(Preparaciones pPreparaciones, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pPreparaciones.id == null || pPreparaciones.id == 0) ? vintNUll : pPreparaciones.id);
				p.Add("@ID_TipoModeloOperacion", (pPreparaciones.ID_TipoModeloOperacion == null || pPreparaciones.ID_TipoModeloOperacion == 0) ? vintNUll : pPreparaciones.ID_TipoModeloOperacion);
				p.Add("@ID_MinutaPatron", (pPreparaciones.ID_MinutaPatron == null || pPreparaciones.ID_MinutaPatron == 0) ? vintNUll : pPreparaciones.ID_MinutaPatron);
				p.Add("@ID_ETC", (pPreparaciones.ID_ETC == null || pPreparaciones.ID_ETC == 0) ? vintNUll : pPreparaciones.ID_ETC);
				p.Add("@Nombre", (pPreparaciones.Nombre == null) ? vintNUll : pPreparaciones.Nombre);
				p.Add("@PreparacionMixta", (pPreparaciones.PreparacionMixta == null) ? vintNUll : pPreparaciones.PreparacionMixta);
				p.Add("@PreparacionBebida", (pPreparaciones.PreparacionBebida == null) ? vintNUll : pPreparaciones.PreparacionBebida);
				p.Add("@GuiaPreparacion", (pPreparaciones.GuiaPreparacion == null) ? vintNUll : pPreparaciones.GuiaPreparacion);
				p.Add("@FechaPreparacion", (pPreparaciones.FechaPreparacion == null) ? vintNUll : pPreparaciones.FechaPreparacion);
				p.Add("@PathGuia", (pPreparaciones.PathGuia == null) ? vintNUll : pPreparaciones.PathGuia);
				p.Add("@ID_TipoEstado", (pPreparaciones.ID_TipoEstado == null || pPreparaciones.ID_TipoEstado == 0) ? vintNUll : pPreparaciones.ID_TipoEstado);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<Preparaciones> l = SqlMapper.Query<Preparaciones>(con, "API.PA_PreparacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  Preparaciones  ->" + ex.Message);
			}
		}

		public Preparaciones Add(Preparaciones pPreparaciones)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPreparaciones.id);
				p.Add("@ID_TipoModeloOperacion", pPreparaciones.ID_TipoModeloOperacion);
				p.Add("@ID_MinutaPatron", pPreparaciones.ID_MinutaPatron);
				p.Add("@ID_ETC", pPreparaciones.ID_ETC);
				p.Add("@Nombre", pPreparaciones.Nombre);
				p.Add("@PreparacionMixta", pPreparaciones.PreparacionMixta);
				p.Add("@PreparacionBebida", pPreparaciones.PreparacionBebida);
				p.Add("@GuiaPreparacion", pPreparaciones.GuiaPreparacion);
				p.Add("@FechaPreparacion", pPreparaciones.FechaPreparacion);
				p.Add("@PathGuia", pPreparaciones.PathGuia);
				p.Add("@ID_TipoEstado", pPreparaciones.ID_TipoEstado);
				p.Add("@auditoria", pPreparaciones.auditoria);


				Preparaciones o = SqlMapper.QueryFirstOrDefault<Preparaciones>(con, "API.PA_PreparacionesAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  Preparaciones  ->" + ex.Message);
			}
		}

		public Preparaciones Update(Preparaciones pPreparaciones)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPreparaciones.id);
				p.Add("@ID_TipoModeloOperacion", pPreparaciones.ID_TipoModeloOperacion);
				p.Add("@ID_MinutaPatron", pPreparaciones.ID_MinutaPatron);
				p.Add("@ID_ETC", pPreparaciones.ID_ETC);
				p.Add("@Nombre", pPreparaciones.Nombre);
				p.Add("@PreparacionMixta", pPreparaciones.PreparacionMixta);
				p.Add("@PreparacionBebida", pPreparaciones.PreparacionBebida);
				p.Add("@GuiaPreparacion", pPreparaciones.GuiaPreparacion);
				p.Add("@FechaPreparacion", pPreparaciones.FechaPreparacion);
				p.Add("@PathGuia", pPreparaciones.PathGuia);
				p.Add("@ID_TipoEstado", pPreparaciones.ID_TipoEstado);
				p.Add("@auditoria", pPreparaciones.auditoria);




				Preparaciones o = SqlMapper.QueryFirstOrDefault<Preparaciones>(con, "API.PA_PreparacionesUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  Preparaciones  ->" + ex.Message);
			}
		}

		public bool Delete(Preparaciones pPreparaciones)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPreparaciones.id);
				p.Add("@auditoria", pPreparaciones.auditoria);





				Preparaciones o = SqlMapper.QueryFirstOrDefault<Preparaciones>(con, "API.PA_PreparacionesDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) Preparaciones  ->" + ex.Message);
			}
		}





		public List<Preparaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<Preparaciones> PreparacionesList = new List<Preparaciones>();

				PreparacionesList = SqlMapper.Query<Preparaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return PreparacionesList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) Preparaciones  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<Preparaciones> b)
		{
			DapperPlusManager.Entity<Preparaciones>().Table("Preparaciones");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}