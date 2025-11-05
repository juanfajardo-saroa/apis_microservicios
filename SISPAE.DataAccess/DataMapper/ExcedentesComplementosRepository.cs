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
	/// Clase Abstracta para  ExcedentesComplementos
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class ExcedentesComplementosRepository : DataObject, IExcedentesComplementos
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public ExcedentesComplementosRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public ExcedentesComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public ExcedentesComplementos GetById(ExcedentesComplementos pExcedentesComplementos)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pExcedentesComplementos.id);


				ExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  ExcedentesComplementos  ->" + ex.Message);
			}
		}

		public List<ExcedentesComplementos> GetAll()
		{
			try
			{
				List<ExcedentesComplementos> l = SqlMapper.Query<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  ExcedentesComplementos  ->" + ex.Message);
			}
		}

		public List<ExcedentesComplementos> GetAllFull()
		{
			try
			{
				List<ExcedentesComplementos> l = SqlMapper.Query<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  ExcedentesComplementos  ->" + ex.Message);
			}
		}

		public List<ExcedentesComplementos> GetAllByWithRelation()
		{
			try
			{
				List<ExcedentesComplementos> l = SqlMapper.Query<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  ExcedentesComplementos  ->" + ex.Message);
			}
		}




		public List<ExcedentesComplementos> GetByFilter(ExcedentesComplementos pExcedentesComplementos, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pExcedentesComplementos.id == null || pExcedentesComplementos.id == 0) ? vintNUll : pExcedentesComplementos.id);
				p.Add("@ID_Comite", (pExcedentesComplementos.ID_Comite == null || pExcedentesComplementos.ID_Comite == 0) ? vintNUll : pExcedentesComplementos.ID_Comite);
				p.Add("@ID_GradoSedeJornada", (pExcedentesComplementos.ID_GradoSedeJornada == null || pExcedentesComplementos.ID_GradoSedeJornada == 0) ? vintNUll : pExcedentesComplementos.ID_GradoSedeJornada);
				p.Add("@ID_TipoDestinoComplemento", (pExcedentesComplementos.ID_TipoDestinoComplemento == null || pExcedentesComplementos.ID_TipoDestinoComplemento == 0) ? vintNUll : pExcedentesComplementos.ID_TipoDestinoComplemento);
				p.Add("@FechaReporte", (pExcedentesComplementos.FechaReporte == null) ? vintNUll : pExcedentesComplementos.FechaReporte);
				p.Add("@CantExcedentes", (pExcedentesComplementos.CantExcedentes == null) ? vintNUll : pExcedentesComplementos.CantExcedentes);
				p.Add("@Justificacion", (pExcedentesComplementos.Justificacion == null) ? vintNUll : pExcedentesComplementos.Justificacion);
				p.Add("@Id_TipoEstadoExcedentesComplementos", (pExcedentesComplementos.Id_TipoEstadoExcedentesComplementos == null || pExcedentesComplementos.Id_TipoEstadoExcedentesComplementos == 0) ? vintNUll : pExcedentesComplementos.Id_TipoEstadoExcedentesComplementos);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<ExcedentesComplementos> l = SqlMapper.Query<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  ExcedentesComplementos  ->" + ex.Message);
			}
		}

		public ExcedentesComplementos Add(ExcedentesComplementos pExcedentesComplementos)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pExcedentesComplementos.id);
				p.Add("@ID_Comite", pExcedentesComplementos.ID_Comite);
				p.Add("@ID_GradoSedeJornada", pExcedentesComplementos.ID_GradoSedeJornada);
				p.Add("@ID_TipoDestinoComplemento", pExcedentesComplementos.ID_TipoDestinoComplemento);
				p.Add("@FechaReporte", pExcedentesComplementos.FechaReporte);
				p.Add("@CantExcedentes", pExcedentesComplementos.CantExcedentes);
				p.Add("@Justificacion", pExcedentesComplementos.Justificacion);
				p.Add("@Id_TipoEstadoExcedentesComplementos", pExcedentesComplementos.Id_TipoEstadoExcedentesComplementos );
				p.Add("@auditoria", pExcedentesComplementos.auditoria);




				ExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  ExcedentesComplementos  ->" + ex.Message);
			}
		}

		public ExcedentesComplementos Update(ExcedentesComplementos pExcedentesComplementos)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pExcedentesComplementos.id);
				p.Add("@ID_Comite", pExcedentesComplementos.ID_Comite);
				p.Add("@ID_GradoSedeJornada", pExcedentesComplementos.ID_GradoSedeJornada);
				p.Add("@ID_TipoDestinoComplemento", pExcedentesComplementos.ID_TipoDestinoComplemento);
				p.Add("@FechaReporte", pExcedentesComplementos.FechaReporte);
				p.Add("@CantExcedentes", pExcedentesComplementos.CantExcedentes);
				p.Add("@Justificacion", pExcedentesComplementos.Justificacion);
				p.Add("@Id_TipoEstadoExcedentesComplementos", pExcedentesComplementos.Id_TipoEstadoExcedentesComplementos);
				p.Add("@auditoria", pExcedentesComplementos.auditoria);




				ExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  ExcedentesComplementos  ->" + ex.Message);
			}
		}

		public bool Delete(ExcedentesComplementos pExcedentesComplementos)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pExcedentesComplementos.id);
				p.Add("@auditoria", pExcedentesComplementos.auditoria);





				ExcedentesComplementos o = SqlMapper.QueryFirstOrDefault<ExcedentesComplementos>(con, "API.PA_ExcedentesComplementosDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) ExcedentesComplementos  ->" + ex.Message);
			}
		}





		public List<ExcedentesComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<ExcedentesComplementos> ExcedentesComplementosList = new List<ExcedentesComplementos>();

				ExcedentesComplementosList = SqlMapper.Query<ExcedentesComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return ExcedentesComplementosList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) ExcedentesComplementos  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<ExcedentesComplementos> b)
		{
			DapperPlusManager.Entity<ExcedentesComplementos>().Table("ExcedentesComplementos");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}