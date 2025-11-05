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
	/// Clase Abstracta para  Inventario
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class InventarioRepository : DataObject, IInventario
		{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public InventarioRepository()
			{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
			}

		public InventarioRepository(DataAccess.DataMapper.DataMapperSource dataSource)
			{
			_dataSource = dataSource;
			}

		#endregion Class Declarations

		#region Class Methods

		public Inventario GetById(Inventario pInventario)
			{

			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pInventario.id);


				Inventario o = SqlMapper.QueryFirstOrDefault<Inventario>(con, "API.PA_InventarioGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetById)  Inventario  ->" + ex.Message);
				}
			}

		public List<Inventario> GetAll()
			{
			try
				{
				List<Inventario> l = SqlMapper.Query<Inventario>(con, "API.PA_InventarioGetAll").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAll)  Inventario  ->" + ex.Message);
				}
			}

		public List<Inventario> GetAllFull()
			{
			try
				{
				List<Inventario> l = SqlMapper.Query<Inventario>(con, "API.PA_InventarioGetAllFull").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllFull)  Inventario  ->" + ex.Message);
				}
			}

		public List<Inventario> GetAllByWithRelation()
			{
			try
				{
				List<Inventario> l = SqlMapper.Query<Inventario>(con, "API.PA_InventarioGetAllWithRelation").AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetAllByWithRelation)  Inventario  ->" + ex.Message);
				}
			}




		public List<Inventario> GetByFilter(Inventario pInventario, int pageSize, int Page, string OrderByC)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pInventario.id == null || pInventario.id == 0) ? vintNUll : pInventario.id);
				p.Add("@ID_Caracterizacion", (pInventario.ID_Caracterizacion == null || pInventario.ID_Caracterizacion == 0) ? vintNUll : pInventario.ID_Caracterizacion);
				p.Add("@ID_Elemento", (pInventario.ID_Elemento == null || pInventario.ID_Elemento == 0) ? vintNUll : pInventario.ID_Elemento);
				p.Add("@Cantidad", pInventario.Cantidad == 0 ? vintNUll : pInventario.Cantidad);
				p.Add("@Funcionan", pInventario.Funcionan == 0 ? vintNUll : pInventario.Funcionan);
				p.Add("@SonSuficientes", pInventario.SonSuficientes);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<Inventario> l = SqlMapper.Query<Inventario>(con, "API.PA_InventarioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(GetByFilter)  Inventario  ->" + ex.Message);
				}
			}

		public Inventario Add(Inventario pInventario)
			{
			try
				{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pInventario.id == null ? 0 : pInventario.id);
				p.Add("@ID_Caracterizacion", pInventario.ID_Caracterizacion == null ? 0 : pInventario.ID_Caracterizacion);
				p.Add("@ID_Elemento", pInventario.ID_Elemento == null ? 0 : pInventario.ID_Elemento);
				p.Add("@Cantidad", pInventario.Cantidad == null ? 0 : pInventario.Cantidad);
				p.Add("@Funcionan", pInventario.Funcionan == null ? 0 : pInventario.Funcionan);
				p.Add("@SonSuficientes", pInventario.SonSuficientes);
				p.Add("@auditoria", pInventario.auditoria);




				Inventario o = SqlMapper.QueryFirstOrDefault<Inventario>(con, "API.PA_InventarioAdd", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Add)  Inventario  ->" + ex.Message);
				}
			}

		public Inventario Update(Inventario pInventario)
			{
			try
				{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pInventario.id == null ? 0 : pInventario.id);
				p.Add("@ID_Caracterizacion", pInventario.ID_Caracterizacion == null ? 0 : pInventario.ID_Caracterizacion);
				p.Add("@ID_Elemento", pInventario.ID_Elemento == null ? 0 : pInventario.ID_Elemento);
				p.Add("@Cantidad", pInventario.Cantidad == null ? 0 : pInventario.Cantidad);
				p.Add("@Funcionan", pInventario.Funcionan == null ? 0 : pInventario.Funcionan);
				p.Add("@SonSuficientes", pInventario.SonSuficientes);
				p.Add("@auditoria", pInventario.auditoria);




				Inventario o = SqlMapper.QueryFirstOrDefault<Inventario>(con, "API.PA_InventarioUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(Update)  Inventario  ->" + ex.Message);
				}
			}

		public bool Delete(Inventario pInventario)
			{
			try
				{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pInventario.id);
				p.Add("@auditoria", pInventario.auditoria);





				Inventario o = SqlMapper.QueryFirstOrDefault<Inventario>(con, "API.PA_InventarioDelete", p, commandType: CommandType.StoredProcedure);

				return true;

				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper: (Delete) Inventario  ->" + ex.Message);
				}
			}





		public List<Inventario> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
			{
			try
				{
				List<Inventario> InventarioList = new List<Inventario>();

				InventarioList = SqlMapper.Query<Inventario>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return InventarioList;
				}
			catch(Exception ex)
				{
				throw new Exception("DataMapper:(ExecProcedureQuery) Inventario  ->" + ex.Message);
				}
			}


		public void BulkInsert(List<Inventario> b)
			{
			DapperPlusManager.Entity<Inventario>().Table("Inventario");
			con.BulkInsert(b);
			}
		}
	#endregion Class Methods

	}