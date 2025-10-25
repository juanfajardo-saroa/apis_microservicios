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
	/// Clase Abstracta para  EntregasComplementos
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class EntregasComplementosRepository : DataObject, IEntregasComplementos
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public EntregasComplementosRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public EntregasComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public EntregasComplementos GetById(EntregasComplementos pEntregasComplementos)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pEntregasComplementos.id);


				EntregasComplementos o = SqlMapper.QueryFirstOrDefault<EntregasComplementos>(con, "API.PA_EntregasComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  EntregasComplementos  ->" + ex.Message);
			}
		}

		public List<EntregasComplementos> GetAll()
		{
			try
			{
				List<EntregasComplementos> l = SqlMapper.Query<EntregasComplementos>(con, "API.PA_EntregasComplementosGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  EntregasComplementos  ->" + ex.Message);
			}
		}

		public List<EntregasComplementos> GetAllFull()
		{
			try
			{
				List<EntregasComplementos> l = SqlMapper.Query<EntregasComplementos>(con, "API.PA_EntregasComplementosGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  EntregasComplementos  ->" + ex.Message);
			}
		}

		public List<EntregasComplementos> GetAllByWithRelation()
		{
			try
			{
				List<EntregasComplementos> l = SqlMapper.Query<EntregasComplementos>(con, "API.PA_EntregasComplementosGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  EntregasComplementos  ->" + ex.Message);
			}
		}




		public List<EntregasComplementos> GetByFilter(EntregasComplementos pEntregasComplementos, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pEntregasComplementos.id == null || pEntregasComplementos.id == 0) ? vintNUll : pEntregasComplementos.id);
				p.Add("@ID_SemanaEntregaComplemento", (pEntregasComplementos.ID_SemanaEntregaComplemento == null || pEntregasComplementos.ID_SemanaEntregaComplemento == 0) ? vintNUll : pEntregasComplementos.ID_SemanaEntregaComplemento);
				p.Add("@ID_TipoReporteEntrega", (pEntregasComplementos.ID_TipoReporteEntrega == null || pEntregasComplementos.ID_TipoReporteEntrega == 0) ? vintNUll : pEntregasComplementos.ID_TipoReporteEntrega);
				p.Add("@FechaEntrega", (pEntregasComplementos.FechaEntrega == null) ? vintNUll : pEntregasComplementos.FechaEntrega);
				p.Add("@ComplementosPreparadas", (pEntregasComplementos.ComplementosPreparadas == null) ? vintNUll : pEntregasComplementos.ComplementosPreparadas);
				p.Add("@Justificacion", (pEntregasComplementos.Justificacion == null) ? vintNUll : pEntregasComplementos.Justificacion);
				p.Add("@pathDocumentoContrato", (pEntregasComplementos.pathDocumentoContrato == null) ? vintNUll : pEntregasComplementos.pathDocumentoContrato);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<EntregasComplementos> l = SqlMapper.Query<EntregasComplementos>(con, "API.PA_EntregasComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  EntregasComplementos  ->" + ex.Message);
			}
		}

		public EntregasComplementos Add(EntregasComplementos pEntregasComplementos)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pEntregasComplementos.id == null ? 0 : pEntregasComplementos.id);
				p.Add("@ID_SemanaEntregaComplemento", pEntregasComplementos.ID_SemanaEntregaComplemento == null ? 0 : pEntregasComplementos.ID_SemanaEntregaComplemento);
				p.Add("@ID_TipoReporteEntrega", pEntregasComplementos.ID_TipoReporteEntrega == null ? 0 : pEntregasComplementos.ID_TipoReporteEntrega);
				p.Add("@FechaEntrega", pEntregasComplementos.FechaEntrega);
				p.Add("@ComplementosPreparadas", pEntregasComplementos.ComplementosPreparadas == null ? 0 : pEntregasComplementos.ComplementosPreparadas);
				p.Add("@Justificacion", pEntregasComplementos.Justificacion);
				p.Add("@pathDocumentoContrato", pEntregasComplementos.pathDocumentoContrato);
				p.Add("@auditoria", pEntregasComplementos.auditoria);




				EntregasComplementos o = SqlMapper.QueryFirstOrDefault<EntregasComplementos>(con, "API.PA_EntregasComplementosAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  EntregasComplementos  ->" + ex.Message);
			}
		}

		public EntregasComplementos Update(EntregasComplementos pEntregasComplementos)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pEntregasComplementos.id == null ? 0 : pEntregasComplementos.id);
				p.Add("@ID_SemanaEntregaComplemento", pEntregasComplementos.ID_SemanaEntregaComplemento == null ? 0 : pEntregasComplementos.ID_SemanaEntregaComplemento);
				p.Add("@ID_TipoReporteEntrega", pEntregasComplementos.ID_TipoReporteEntrega == null ? 0 : pEntregasComplementos.ID_TipoReporteEntrega);
				p.Add("@FechaEntrega", pEntregasComplementos.FechaEntrega);
				p.Add("@ComplementosPreparadas", pEntregasComplementos.ComplementosPreparadas == null ? 0 : pEntregasComplementos.ComplementosPreparadas);
				p.Add("@Justificacion", pEntregasComplementos.Justificacion);
				p.Add("@pathDocumentoContrato", pEntregasComplementos.pathDocumentoContrato);
				p.Add("@auditoria", pEntregasComplementos.auditoria);




				EntregasComplementos o = SqlMapper.QueryFirstOrDefault<EntregasComplementos>(con, "API.PA_EntregasComplementosUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  EntregasComplementos  ->" + ex.Message);
			}
		}

		public bool Delete(EntregasComplementos pEntregasComplementos)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pEntregasComplementos.id);
				p.Add("@auditoria", pEntregasComplementos.auditoria);





				EntregasComplementos o = SqlMapper.QueryFirstOrDefault<EntregasComplementos>(con, "API.PA_EntregasComplementosDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) EntregasComplementos  ->" + ex.Message);
			}
		}





		public List<EntregasComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<EntregasComplementos> EntregasComplementosList = new List<EntregasComplementos>();

				EntregasComplementosList = SqlMapper.Query<EntregasComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return EntregasComplementosList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) EntregasComplementos  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<EntregasComplementos> b)
		{
			DapperPlusManager.Entity<EntregasComplementos>().Table("EntregasComplementos");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}