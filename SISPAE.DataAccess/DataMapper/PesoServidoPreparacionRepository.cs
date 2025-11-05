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
	/// Clase Abstracta para  PesoServidoPreparacion
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class PesoServidoPreparacionRepository : DataObject, IPesoServidoPreparacion
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public PesoServidoPreparacionRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public PesoServidoPreparacionRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public PesoServidoPreparacion GetById(PesoServidoPreparacion pPesoServidoPreparacion)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPesoServidoPreparacion.id);


				PesoServidoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}

		public List<PesoServidoPreparacion> GetAll()
		{
			try
			{
				List<PesoServidoPreparacion> l = SqlMapper.Query<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}

		public List<PesoServidoPreparacion> GetAllFull()
		{
			try
			{
				List<PesoServidoPreparacion> l = SqlMapper.Query<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}

		public List<PesoServidoPreparacion> GetAllByWithRelation()
		{
			try
			{
				List<PesoServidoPreparacion> l = SqlMapper.Query<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}




		public List<PesoServidoPreparacion> GetByFilter(PesoServidoPreparacion pPesoServidoPreparacion, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pPesoServidoPreparacion.id == null || pPesoServidoPreparacion.id == 0) ? vintNUll : pPesoServidoPreparacion.id);
				p.Add("@ID_TipoComplemento", (pPesoServidoPreparacion.ID_TipoComplemento == null || pPesoServidoPreparacion.ID_TipoComplemento == 0) ? vintNUll : pPesoServidoPreparacion.ID_TipoComplemento);
				p.Add("@ID_TipoNivelEducativo", (pPesoServidoPreparacion.ID_TipoNivelEducativo == null || pPesoServidoPreparacion.ID_TipoNivelEducativo == 0) ? vintNUll : pPesoServidoPreparacion.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", (pPesoServidoPreparacion.ID_Preparacion == null || pPesoServidoPreparacion.ID_Preparacion == 0) ? vintNUll : pPesoServidoPreparacion.ID_Preparacion);
				p.Add("@PesoServido", (pPesoServidoPreparacion.PesoServido == null) ? vintNUll : pPesoServidoPreparacion.PesoServido);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<PesoServidoPreparacion> l = SqlMapper.Query<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}

		public PesoServidoPreparacion Add(PesoServidoPreparacion pPesoServidoPreparacion)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPesoServidoPreparacion.id);
				p.Add("@ID_TipoComplemento", pPesoServidoPreparacion.ID_TipoComplemento);
				p.Add("@ID_TipoNivelEducativo", pPesoServidoPreparacion.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", pPesoServidoPreparacion.ID_Preparacion);
				p.Add("@PesoServido", pPesoServidoPreparacion.PesoServido);
				p.Add("@auditoria", pPesoServidoPreparacion.auditoria);


				PesoServidoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}

		public PesoServidoPreparacion Update(PesoServidoPreparacion pPesoServidoPreparacion)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPesoServidoPreparacion.id);
				p.Add("@ID_TipoComplemento", pPesoServidoPreparacion.ID_TipoComplemento);
				p.Add("@ID_TipoNivelEducativo", pPesoServidoPreparacion.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", pPesoServidoPreparacion.ID_Preparacion);
				p.Add("@PesoServido", pPesoServidoPreparacion.PesoServido);
				p.Add("@auditoria", pPesoServidoPreparacion.auditoria);




				PesoServidoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  PesoServidoPreparacion  ->" + ex.Message);
			}
		}

		public bool Delete(PesoServidoPreparacion pPesoServidoPreparacion)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPesoServidoPreparacion.id);
				p.Add("@auditoria", pPesoServidoPreparacion.auditoria);





				PesoServidoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoServidoPreparacion>(con, "API.PA_PesoServidoPreparacionDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) PesoServidoPreparacion  ->" + ex.Message);
			}
		}





		public List<PesoServidoPreparacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<PesoServidoPreparacion> PesoServidoPreparacionList = new List<PesoServidoPreparacion>();

				PesoServidoPreparacionList = SqlMapper.Query<PesoServidoPreparacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return PesoServidoPreparacionList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) PesoServidoPreparacion  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<PesoServidoPreparacion> b)
		{
			DapperPlusManager.Entity<PesoServidoPreparacion>().Table("PesoServidoPreparacion");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}