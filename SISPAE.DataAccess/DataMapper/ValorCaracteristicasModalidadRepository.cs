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
	/// Clase Abstracta para  ValorCaracteristicasModalidad
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class ValorCaracteristicasModalidadRepository : DataObject, IValorCaracteristicasModalidad
		{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public ValorCaracteristicasModalidadRepository()
			{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
			}

		public ValorCaracteristicasModalidadRepository(DataAccess.DataMapper.DataMapperSource dataSource)
			{
			_dataSource = dataSource;
			}

		#endregion Class Declarations

		#region Class Methods

		public ValorCaracteristicasModalidad GetById(ValorCaracteristicasModalidad pValorCaracteristicasModalidad)
			{

			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pValorCaracteristicasModalidad.id);


				ValorCaracteristicasModalidad o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetById)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}

		public List<ValorCaracteristicasModalidad> GetAll()
			{
			try
				{
				List<ValorCaracteristicasModalidad> l = SqlMapper.Query<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadGetAll").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAll)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}

		public List<ValorCaracteristicasModalidad> GetAllFull()
			{
			try
				{
				List<ValorCaracteristicasModalidad> l = SqlMapper.Query<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadGetAllFull").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllFull)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}

		public List<ValorCaracteristicasModalidad> GetAllByWithRelation()
			{
			try
				{
				List<ValorCaracteristicasModalidad> l = SqlMapper.Query<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadGetAllWithRelation").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllByWithRelation)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}




		public List<ValorCaracteristicasModalidad> GetByFilter(ValorCaracteristicasModalidad pValorCaracteristicasModalidad, int pageSize, int Page, string OrderByC)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pValorCaracteristicasModalidad.id == null || pValorCaracteristicasModalidad.id == 0) ? vintNUll : pValorCaracteristicasModalidad.id);
				p.Add("@ID_ModalidadComplemento", (pValorCaracteristicasModalidad.ID_ModalidadComplemento == null || pValorCaracteristicasModalidad.ID_ModalidadComplemento == 0) ? vintNUll : pValorCaracteristicasModalidad.ID_ModalidadComplemento);
				p.Add("@ID_Caracteristica", (pValorCaracteristicasModalidad.ID_Caracteristica == null || pValorCaracteristicasModalidad.ID_Caracteristica == 0) ? vintNUll : pValorCaracteristicasModalidad.ID_Caracteristica);
				p.Add("@ID_ValorCaracteristica", (pValorCaracteristicasModalidad.ID_ValorCaracteristica == null || pValorCaracteristicasModalidad.ID_ValorCaracteristica == 0) ? vintNUll : pValorCaracteristicasModalidad.ID_ValorCaracteristica);
				p.Add("@Valor", pValorCaracteristicasModalidad.Valor == 0 ? vintNUll : pValorCaracteristicasModalidad.Valor);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<ValorCaracteristicasModalidad> l = SqlMapper.Query<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetByFilter)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}

		public ValorCaracteristicasModalidad Add(ValorCaracteristicasModalidad pValorCaracteristicasModalidad)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pValorCaracteristicasModalidad.id == null ? 0 : pValorCaracteristicasModalidad.id);
				p.Add("@ID_ModalidadComplemento", pValorCaracteristicasModalidad.ID_ModalidadComplemento == null ? 0 : pValorCaracteristicasModalidad.ID_ModalidadComplemento);
				p.Add("@ID_Caracteristica", pValorCaracteristicasModalidad.ID_Caracteristica == null ? 0 : pValorCaracteristicasModalidad.ID_Caracteristica);
				p.Add("@ID_ValorCaracteristica", pValorCaracteristicasModalidad.ID_ValorCaracteristica == null ? 0 : pValorCaracteristicasModalidad.ID_ValorCaracteristica);
				p.Add("@Valor", pValorCaracteristicasModalidad.Valor == null ? 0 : pValorCaracteristicasModalidad.Valor);
				p.Add("@auditoria", pValorCaracteristicasModalidad.auditoria);




				ValorCaracteristicasModalidad o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadAdd", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Add)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}

		public ValorCaracteristicasModalidad Update(ValorCaracteristicasModalidad pValorCaracteristicasModalidad)
			{
			try
				{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pValorCaracteristicasModalidad.id == null ? 0 : pValorCaracteristicasModalidad.id);
				p.Add("@ID_ModalidadComplemento", pValorCaracteristicasModalidad.ID_ModalidadComplemento == null ? 0 : pValorCaracteristicasModalidad.ID_ModalidadComplemento);
				p.Add("@ID_Caracteristica", pValorCaracteristicasModalidad.ID_Caracteristica == null ? 0 : pValorCaracteristicasModalidad.ID_Caracteristica);
				p.Add("@ID_ValorCaracteristica", pValorCaracteristicasModalidad.ID_ValorCaracteristica == null ? 0 : pValorCaracteristicasModalidad.ID_ValorCaracteristica);
				p.Add("@Valor", pValorCaracteristicasModalidad.Valor == null ? 0 : pValorCaracteristicasModalidad.Valor);
				p.Add("@auditoria", pValorCaracteristicasModalidad.auditoria);




				ValorCaracteristicasModalidad o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Update)  ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}

		public bool Delete(ValorCaracteristicasModalidad pValorCaracteristicasModalidad)
			{
			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pValorCaracteristicasModalidad.id);
				p.Add("@auditoria", pValorCaracteristicasModalidad.auditoria);





				ValorCaracteristicasModalidad o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasModalidad>(con, "API.PA_ValorCaracteristicasModalidadDelete", p, commandType: CommandType.StoredProcedure);

				return true;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper: (Delete) ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}





		public List<ValorCaracteristicasModalidad> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
			{
			try
				{
				List<ValorCaracteristicasModalidad> ValorCaracteristicasModalidadList = new List<ValorCaracteristicasModalidad>();

				ValorCaracteristicasModalidadList = SqlMapper.Query<ValorCaracteristicasModalidad>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return ValorCaracteristicasModalidadList;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(ExecProcedureQuery) ValorCaracteristicasModalidad  ->" + ex.Message);
				}
			}


		public void BulkInsert(List<ValorCaracteristicasModalidad> b)
			{
			DapperPlusManager.Entity<ValorCaracteristicasModalidad>().Table("ValorCaracteristicasModalidad");
			con.BulkInsert(b);
			}
		}
	#endregion Class Methods

	}