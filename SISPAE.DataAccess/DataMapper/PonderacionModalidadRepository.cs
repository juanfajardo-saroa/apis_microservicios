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
	/// Clase Abstracta para  PonderacionModalidad
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class PonderacionModalidadRepository : DataObject, IPonderacionModalidad
		{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public PonderacionModalidadRepository()
			{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
			}

		public PonderacionModalidadRepository(DataAccess.DataMapper.DataMapperSource dataSource)
			{
			_dataSource = dataSource;
			}

		#endregion Class Declarations

		#region Class Methods

		public PonderacionModalidad GetById(PonderacionModalidad pPonderacionModalidad)
			{

			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPonderacionModalidad.id);


				PonderacionModalidad o = SqlMapper.QueryFirstOrDefault<PonderacionModalidad>(con, "API.PA_PonderacionModalidadGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetById)  PonderacionModalidad  ->" + ex.Message);
				}
			}

		public List<PonderacionModalidad> GetAll()
			{
			try
				{
				List<PonderacionModalidad> l = SqlMapper.Query<PonderacionModalidad>(con, "API.PA_PonderacionModalidadGetAll").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAll)  PonderacionModalidad  ->" + ex.Message);
				}
			}

		public List<PonderacionModalidad> GetAllFull()
			{
			try
				{
				List<PonderacionModalidad> l = SqlMapper.Query<PonderacionModalidad>(con, "API.PA_PonderacionModalidadGetAllFull").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllFull)  PonderacionModalidad  ->" + ex.Message);
				}
			}

		public List<PonderacionModalidad> GetAllByWithRelation()
			{
			try
				{
				List<PonderacionModalidad> l = SqlMapper.Query<PonderacionModalidad>(con, "API.PA_PonderacionModalidadGetAllWithRelation").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllByWithRelation)  PonderacionModalidad  ->" + ex.Message);
				}
			}




		public List<PonderacionModalidad> GetByFilter(PonderacionModalidad pPonderacionModalidad, int pageSize, int Page, string OrderByC)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pPonderacionModalidad.id == null || pPonderacionModalidad.id == 0) ? vintNUll : pPonderacionModalidad.id);
				p.Add("@ID_Caracteristica", (pPonderacionModalidad.ID_Caracteristica == null || pPonderacionModalidad.ID_Caracteristica == 0) ? vintNUll : pPonderacionModalidad.ID_Caracteristica);
				p.Add("@ID_TipoAcceso", (pPonderacionModalidad.ID_TipoAcceso == null || pPonderacionModalidad.ID_TipoAcceso == 0) ? vintNUll : pPonderacionModalidad.ID_TipoAcceso);
				p.Add("@ID_ModalidadComplemento", (pPonderacionModalidad.ID_ModalidadComplemento == null || pPonderacionModalidad.ID_ModalidadComplemento == 0) ? vintNUll : pPonderacionModalidad.ID_ModalidadComplemento);
				p.Add("@Valor", pPonderacionModalidad.Valor == 0 ? vintNUll : pPonderacionModalidad.Valor);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<PonderacionModalidad> l = SqlMapper.Query<PonderacionModalidad>(con, "API.PA_PonderacionModalidadGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetByFilter)  PonderacionModalidad  ->" + ex.Message);
				}
			}

		public PonderacionModalidad Add(PonderacionModalidad pPonderacionModalidad)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPonderacionModalidad.id == null ? 0 : pPonderacionModalidad.id);
				p.Add("@ID_Caracteristica", pPonderacionModalidad.ID_Caracteristica == null ? 0 : pPonderacionModalidad.ID_Caracteristica);
				p.Add("@ID_TipoAcceso", pPonderacionModalidad.ID_TipoAcceso == null ? 0 : pPonderacionModalidad.ID_TipoAcceso);
				p.Add("@ID_ModalidadComplemento", pPonderacionModalidad.ID_ModalidadComplemento == null ? 0 : pPonderacionModalidad.ID_ModalidadComplemento);
				p.Add("@Valor", pPonderacionModalidad.Valor == null ? 0 : pPonderacionModalidad.Valor);
				p.Add("@auditoria", pPonderacionModalidad.auditoria);




				PonderacionModalidad o = SqlMapper.QueryFirstOrDefault<PonderacionModalidad>(con, "API.PA_PonderacionModalidadAdd", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Add)  PonderacionModalidad  ->" + ex.Message);
				}
			}

		public PonderacionModalidad Update(PonderacionModalidad pPonderacionModalidad)
			{
			try
				{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pPonderacionModalidad.id == null ? 0 : pPonderacionModalidad.id);
				p.Add("@ID_Caracteristica", pPonderacionModalidad.ID_Caracteristica == null ? 0 : pPonderacionModalidad.ID_Caracteristica);
				p.Add("@ID_TipoAcceso", pPonderacionModalidad.ID_TipoAcceso == null ? 0 : pPonderacionModalidad.ID_TipoAcceso);
				p.Add("@ID_ModalidadComplemento", pPonderacionModalidad.ID_ModalidadComplemento == null ? 0 : pPonderacionModalidad.ID_ModalidadComplemento);
				p.Add("@Valor", pPonderacionModalidad.Valor == null ? 0 : pPonderacionModalidad.Valor);
				p.Add("@auditoria", pPonderacionModalidad.auditoria);




				PonderacionModalidad o = SqlMapper.QueryFirstOrDefault<PonderacionModalidad>(con, "API.PA_PonderacionModalidadUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Update)  PonderacionModalidad  ->" + ex.Message);
				}
			}

		public bool Delete(PonderacionModalidad pPonderacionModalidad)
			{
			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pPonderacionModalidad.id);
				p.Add("@auditoria", pPonderacionModalidad.auditoria);





				PonderacionModalidad o = SqlMapper.QueryFirstOrDefault<PonderacionModalidad>(con, "API.PA_PonderacionModalidadDelete", p, commandType: CommandType.StoredProcedure);

				return true;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper: (Delete) PonderacionModalidad  ->" + ex.Message);
				}
			}





		public List<PonderacionModalidad> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
			{
			try
				{
				List<PonderacionModalidad> PonderacionModalidadList = new List<PonderacionModalidad>();

				PonderacionModalidadList = SqlMapper.Query<PonderacionModalidad>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return PonderacionModalidadList;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(ExecProcedureQuery) PonderacionModalidad  ->" + ex.Message);
				}
			}


		public void BulkInsert(List<PonderacionModalidad> b)
			{
			DapperPlusManager.Entity<PonderacionModalidad>().Table("PonderacionModalidad");
			con.BulkInsert(b);
			}
		}
	#endregion Class Methods

	}