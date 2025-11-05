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
	/// Clase Abstracta para  RiesgosDimension
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class RiesgosDimensionRepository : DataObject, IRiesgosDimension
		{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public RiesgosDimensionRepository()
			{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
			}

		public RiesgosDimensionRepository(DataAccess.DataMapper.DataMapperSource dataSource)
			{
			_dataSource = dataSource;
			}

		#endregion Class Declarations

		#region Class Methods

		public RiesgosDimension GetById(RiesgosDimension pRiesgosDimension)
			{

			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pRiesgosDimension.id);


				RiesgosDimension o = SqlMapper.QueryFirstOrDefault<RiesgosDimension>(con, "API.PA_RiesgosDimensionGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetById)  RiesgosDimension  ->" + ex.Message);
				}
			}

		public List<RiesgosDimension> GetAll()
			{
			try
				{
				List<RiesgosDimension> l = SqlMapper.Query<RiesgosDimension>(con, "API.PA_RiesgosDimensionGetAll").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAll)  RiesgosDimension  ->" + ex.Message);
				}
			}

		public List<RiesgosDimension> GetAllFull()
			{
			try
				{
				List<RiesgosDimension> l = SqlMapper.Query<RiesgosDimension>(con, "API.PA_RiesgosDimensionGetAllFull").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllFull)  RiesgosDimension  ->" + ex.Message);
				}
			}

		public List<RiesgosDimension> GetAllByWithRelation()
			{
			try
				{
				List<RiesgosDimension> l = SqlMapper.Query<RiesgosDimension>(con, "API.PA_RiesgosDimensionGetAllWithRelation").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllByWithRelation)  RiesgosDimension  ->" + ex.Message);
				}
			}




		public List<RiesgosDimension> GetByFilter(RiesgosDimension pRiesgosDimension, int pageSize, int Page, string OrderByC)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pRiesgosDimension.id == null || pRiesgosDimension.id == 0) ? vintNUll : pRiesgosDimension.id);
				p.Add("@ID_CaInfraestructura", (pRiesgosDimension.ID_CaInfraestructura == null || pRiesgosDimension.ID_CaInfraestructura == 0) ? vintNUll : pRiesgosDimension.ID_CaInfraestructura);
				p.Add("@ID_Dimension", (pRiesgosDimension.ID_Dimension == null || pRiesgosDimension.ID_Dimension == 0) ? vintNUll : pRiesgosDimension.ID_Dimension);
				p.Add("@Riesgo", pRiesgosDimension.Riesgo == 0 ? vintNUll : pRiesgosDimension.Riesgo);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<RiesgosDimension> l = SqlMapper.Query<RiesgosDimension>(con, "API.PA_RiesgosDimensionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetByFilter)  RiesgosDimension  ->" + ex.Message);
				}
			}

		public RiesgosDimension Add(RiesgosDimension pRiesgosDimension)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pRiesgosDimension.id == null ? 0 : pRiesgosDimension.id);
				p.Add("@ID_CaInfraestructura", pRiesgosDimension.ID_CaInfraestructura == null ? 0 : pRiesgosDimension.ID_CaInfraestructura);
				p.Add("@ID_Dimension", pRiesgosDimension.ID_Dimension == null ? 0 : pRiesgosDimension.ID_Dimension);
				p.Add("@Riesgo", pRiesgosDimension.Riesgo == null ? 0 : pRiesgosDimension.Riesgo);
				p.Add("@auditoria", pRiesgosDimension.auditoria);




				RiesgosDimension o = SqlMapper.QueryFirstOrDefault<RiesgosDimension>(con, "API.PA_RiesgosDimensionAdd", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Add)  RiesgosDimension  ->" + ex.Message);
				}
			}

		public RiesgosDimension Update(RiesgosDimension pRiesgosDimension)
			{
			try
				{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pRiesgosDimension.id == null ? 0 : pRiesgosDimension.id);
				p.Add("@ID_CaInfraestructura", pRiesgosDimension.ID_CaInfraestructura == null ? 0 : pRiesgosDimension.ID_CaInfraestructura);
				p.Add("@ID_Dimension", pRiesgosDimension.ID_Dimension == null ? 0 : pRiesgosDimension.ID_Dimension);
				p.Add("@Riesgo", pRiesgosDimension.Riesgo == null ? 0 : pRiesgosDimension.Riesgo);
				p.Add("@auditoria", pRiesgosDimension.auditoria);




				RiesgosDimension o = SqlMapper.QueryFirstOrDefault<RiesgosDimension>(con, "API.PA_RiesgosDimensionUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Update)  RiesgosDimension  ->" + ex.Message);
				}
			}

		public bool Delete(RiesgosDimension pRiesgosDimension)
			{
			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pRiesgosDimension.id);
				p.Add("@auditoria", pRiesgosDimension.auditoria);





				RiesgosDimension o = SqlMapper.QueryFirstOrDefault<RiesgosDimension>(con, "API.PA_RiesgosDimensionDelete", p, commandType: CommandType.StoredProcedure);

				return true;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper: (Delete) RiesgosDimension  ->" + ex.Message);
				}
			}





		public List<RiesgosDimension> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
			{
			try
				{
				List<RiesgosDimension> RiesgosDimensionList = new List<RiesgosDimension>();

				RiesgosDimensionList = SqlMapper.Query<RiesgosDimension>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return RiesgosDimensionList;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(ExecProcedureQuery) RiesgosDimension  ->" + ex.Message);
				}
			}


		public void BulkInsert(List<RiesgosDimension> b)
			{
			DapperPlusManager.Entity<RiesgosDimension>().Table("RiesgosDimension");
			con.BulkInsert(b);
			}
		}
	#endregion Class Methods

	}