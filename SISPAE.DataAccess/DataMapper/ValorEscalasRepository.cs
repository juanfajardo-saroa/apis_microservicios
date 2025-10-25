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
	/// Clase Abstracta para  ValorEscalas
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class ValorEscalasRepository : DataObject, IValorEscalas
		{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public ValorEscalasRepository()
			{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
			}

		public ValorEscalasRepository(DataAccess.DataMapper.DataMapperSource dataSource)
			{
			_dataSource = dataSource;
			}

		#endregion Class Declarations

		#region Class Methods

		public ValorEscalas GetById(ValorEscalas pValorEscalas)
			{

			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pValorEscalas.id);


				ValorEscalas o = SqlMapper.QueryFirstOrDefault<ValorEscalas>(con, "API.PA_ValorEscalasGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetById)  ValorEscalas  ->" + ex.Message);
				}
			}

		public List<ValorEscalas> GetAll()
			{
			try
				{
				List<ValorEscalas> l = SqlMapper.Query<ValorEscalas>(con, "Infraestructura.PA_ValorEscalasGetAll").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAll)  ValorEscalas  ->" + ex.Message);
				}
			}

		public List<ValorEscalas> GetAllFull()
			{
			try
				{
				List<ValorEscalas> l = SqlMapper.Query<ValorEscalas>(con, "API.PA_ValorEscalasGetAllFull").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllFull)  ValorEscalas  ->" + ex.Message);
				}
			}

		public List<ValorEscalas> GetAllByWithRelation()
			{
			try
				{
				List<ValorEscalas> l = SqlMapper.Query<ValorEscalas>(con, "API.PA_ValorEscalasGetAllWithRelation").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllByWithRelation)  ValorEscalas  ->" + ex.Message);
				}
			}




		public List<ValorEscalas> GetByFilter(ValorEscalas pValorEscalas, int pageSize, int Page, string OrderByC)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pValorEscalas.id == null || pValorEscalas.id == 0) ? vintNUll : pValorEscalas.id);
				p.Add("@ID_Escala", (pValorEscalas.ID_Escala == null || pValorEscalas.ID_Escala == 0) ? vintNUll : pValorEscalas.ID_Escala);
				p.Add("@Respuesta", pValorEscalas.Respuesta);
				p.Add("@Valor", pValorEscalas.Valor == 0 ? vintNUll : pValorEscalas.Valor);
				p.Add("@RequiereAdjunto", pValorEscalas.RequiereAdjunto);
				p.Add("@RequiereFecha", pValorEscalas.RequiereFecha);
				p.Add("@EncenderHijos", pValorEscalas.EncenderHijos);
				p.Add("@Minimo", pValorEscalas.Minimo == 0 ? vintNUll : pValorEscalas.Minimo);
				p.Add("@Maximo", pValorEscalas.Maximo == 0 ? vintNUll : pValorEscalas.Maximo);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<ValorEscalas> l = SqlMapper.Query<ValorEscalas>(con, "API.PA_ValorEscalasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetByFilter)  ValorEscalas  ->" + ex.Message);
				}
			}

		public ValorEscalas Add(ValorEscalas pValorEscalas)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pValorEscalas.id == null ? 0 : pValorEscalas.id);
				p.Add("@ID_Escala", pValorEscalas.ID_Escala == null ? 0 : pValorEscalas.ID_Escala);
				p.Add("@Respuesta", pValorEscalas.Respuesta);
				p.Add("@Valor", pValorEscalas.Valor == null ? 0 : pValorEscalas.Valor);
				p.Add("@RequiereAdjunto", pValorEscalas.RequiereAdjunto);
				p.Add("@RequiereFecha", pValorEscalas.RequiereFecha);
				p.Add("@EncenderHijos", pValorEscalas.EncenderHijos);
				p.Add("@Minimo", pValorEscalas.Minimo == null ? 0 : pValorEscalas.Minimo);
				p.Add("@Maximo", pValorEscalas.Maximo == null ? 0 : pValorEscalas.Maximo);
				p.Add("@auditoria", pValorEscalas.auditoria);




				ValorEscalas o = SqlMapper.QueryFirstOrDefault<ValorEscalas>(con, "API.PA_ValorEscalasAdd", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Add)  ValorEscalas  ->" + ex.Message);
				}
			}

		public ValorEscalas Update(ValorEscalas pValorEscalas)
			{
			try
				{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pValorEscalas.id == null ? 0 : pValorEscalas.id);
				p.Add("@ID_Escala", pValorEscalas.ID_Escala == null ? 0 : pValorEscalas.ID_Escala);
				p.Add("@Respuesta", pValorEscalas.Respuesta);
				p.Add("@Valor", pValorEscalas.Valor == null ? 0 : pValorEscalas.Valor);
				p.Add("@RequiereAdjunto", pValorEscalas.RequiereAdjunto);
				p.Add("@RequiereFecha", pValorEscalas.RequiereFecha);
				p.Add("@EncenderHijos", pValorEscalas.EncenderHijos);
				p.Add("@Minimo", pValorEscalas.Minimo == null ? 0 : pValorEscalas.Minimo);
				p.Add("@Maximo", pValorEscalas.Maximo == null ? 0 : pValorEscalas.Maximo);
				p.Add("@auditoria", pValorEscalas.auditoria);




				ValorEscalas o = SqlMapper.QueryFirstOrDefault<ValorEscalas>(con, "API.PA_ValorEscalasUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Update)  ValorEscalas  ->" + ex.Message);
				}
			}

		public bool Delete(ValorEscalas pValorEscalas)
			{
			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pValorEscalas.id);
				p.Add("@auditoria", pValorEscalas.auditoria);





				ValorEscalas o = SqlMapper.QueryFirstOrDefault<ValorEscalas>(con, "API.PA_ValorEscalasDelete", p, commandType: CommandType.StoredProcedure);

				return true;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper: (Delete) ValorEscalas  ->" + ex.Message);
				}
			}





		public List<ValorEscalas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
			{
			try
				{
				List<ValorEscalas> ValorEscalasList = new List<ValorEscalas>();

				ValorEscalasList = SqlMapper.Query<ValorEscalas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return ValorEscalasList;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(ExecProcedureQuery) ValorEscalas  ->" + ex.Message);
				}
			}


		public void BulkInsert(List<ValorEscalas> b)
			{
			DapperPlusManager.Entity<ValorEscalas>().Table("ValorEscalas");
			con.BulkInsert(b);
			}
		}
	#endregion Class Methods

	}