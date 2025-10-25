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
	/// Clase Abstracta para  PesoNetoPreparacion
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class PesoNetoPreparacionRepository : DataObject, IPesoNetoPreparacion
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public PesoNetoPreparacionRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public PesoNetoPreparacionRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public PesoNetoPreparacion GetById(PesoNetoPreparacion pPesoNetoPreparacion)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPesoNetoPreparacion.id);


				PesoNetoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}

		public List<PesoNetoPreparacion> GetAll()
		{
			try
			{
				List<PesoNetoPreparacion> l = SqlMapper.Query<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}

		public List<PesoNetoPreparacion> GetAllFull()
		{
			try
			{
				List<PesoNetoPreparacion> l = SqlMapper.Query<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}

		public List<PesoNetoPreparacion> GetAllByWithRelation()
		{
			try
			{
				List<PesoNetoPreparacion> l = SqlMapper.Query<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}




		public List<PesoNetoPreparacion> GetByFilter(PesoNetoPreparacion pPesoNetoPreparacion, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pPesoNetoPreparacion.id == null || pPesoNetoPreparacion.id == 0) ? vintNUll : pPesoNetoPreparacion.id);
				p.Add("@ID_TipoComponente", (pPesoNetoPreparacion.ID_TipoComponente == null || pPesoNetoPreparacion.ID_TipoComponente == 0) ? vintNUll : pPesoNetoPreparacion.ID_TipoComponente);
				p.Add("@ID_TipoNivelEducativo", (pPesoNetoPreparacion.ID_TipoNivelEducativo == null || pPesoNetoPreparacion.ID_TipoNivelEducativo == 0) ? vintNUll : pPesoNetoPreparacion.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", (pPesoNetoPreparacion.ID_Preparacion == null || pPesoNetoPreparacion.ID_Preparacion == 0) ? vintNUll : pPesoNetoPreparacion.ID_Preparacion);
				p.Add("@PesoNeto", (pPesoNetoPreparacion.PesoNeto == null) ? vintNUll : pPesoNetoPreparacion.PesoNeto);
				p.Add("@ID_SubGrupoAlimentos", (pPesoNetoPreparacion.ID_SubGrupoAlimentos == null || pPesoNetoPreparacion.ID_SubGrupoAlimentos == 0) ? vintNUll : pPesoNetoPreparacion.ID_SubGrupoAlimentos);
				p.Add("@ID_TipoComplemento", (pPesoNetoPreparacion.ID_TipoComplemento == null || pPesoNetoPreparacion.ID_TipoComplemento == 0) ? vintNUll : pPesoNetoPreparacion.ID_TipoComplemento);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<PesoNetoPreparacion> l = SqlMapper.Query<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}

		public PesoNetoPreparacion Add(PesoNetoPreparacion pPesoNetoPreparacion)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPesoNetoPreparacion.id);
				p.Add("@ID_TipoComponente", pPesoNetoPreparacion.ID_TipoComponente);
				p.Add("@ID_TipoNivelEducativo", pPesoNetoPreparacion.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", pPesoNetoPreparacion.ID_Preparacion);
				p.Add("@PesoNeto", pPesoNetoPreparacion.PesoNeto);
				p.Add("@ID_SubGrupoAlimentos", pPesoNetoPreparacion.ID_SubGrupoAlimentos);
				p.Add("@ID_TipoComplemento", pPesoNetoPreparacion.ID_TipoComplemento);
				p.Add("@auditoria", pPesoNetoPreparacion.auditoria);




				PesoNetoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}

		public PesoNetoPreparacion Update(PesoNetoPreparacion pPesoNetoPreparacion)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPesoNetoPreparacion.id);
				p.Add("@ID_TipoComponente", pPesoNetoPreparacion.ID_TipoComponente);
				p.Add("@ID_TipoNivelEducativo", pPesoNetoPreparacion.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", pPesoNetoPreparacion.ID_Preparacion);
				p.Add("@PesoNeto", pPesoNetoPreparacion.PesoNeto);
				p.Add("@ID_SubGrupoAlimentos", pPesoNetoPreparacion.ID_SubGrupoAlimentos);
				p.Add("@ID_TipoComplemento", pPesoNetoPreparacion.ID_TipoComplemento);
				p.Add("@auditoria", pPesoNetoPreparacion.auditoria);




				PesoNetoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  PesoNetoPreparacion  ->" + ex.Message);
			}
		}

		public bool Delete(PesoNetoPreparacion pPesoNetoPreparacion)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPesoNetoPreparacion.id);
				p.Add("@auditoria", pPesoNetoPreparacion.auditoria);





				PesoNetoPreparacion o = SqlMapper.QueryFirstOrDefault<PesoNetoPreparacion>(con, "API.PA_PesoNetoPreparacionDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) PesoNetoPreparacion  ->" + ex.Message);
			}
		}





		public List<PesoNetoPreparacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<PesoNetoPreparacion> PesoNetoPreparacionList = new List<PesoNetoPreparacion>();

				PesoNetoPreparacionList = SqlMapper.Query<PesoNetoPreparacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return PesoNetoPreparacionList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) PesoNetoPreparacion  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<PesoNetoPreparacion> b)
		{
			DapperPlusManager.Entity<PesoNetoPreparacion>().Table("PesoNetoPreparacion");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}