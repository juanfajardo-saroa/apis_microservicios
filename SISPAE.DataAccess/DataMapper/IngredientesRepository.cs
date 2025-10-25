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
	/// Clase Abstracta para  Ingredientes
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class IngredientesRepository : DataObject, IIngredientes
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public IngredientesRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public IngredientesRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public Ingredientes GetById(Ingredientes pIngredientes)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pIngredientes.id);


				Ingredientes o = SqlMapper.QueryFirstOrDefault<Ingredientes>(con, "API.PA_IngredientesGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  Ingredientes  ->" + ex.Message);
			}
		}

		public List<Ingredientes> GetAll()
		{
			try
			{
				List<Ingredientes> l = SqlMapper.Query<Ingredientes>(con, "API.PA_IngredientesGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  Ingredientes  ->" + ex.Message);
			}
		}

		public List<Ingredientes> GetAllFull()
		{
			try
			{
				List<Ingredientes> l = SqlMapper.Query<Ingredientes>(con, "API.PA_IngredientesGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  Ingredientes  ->" + ex.Message);
			}
		}

		public List<Ingredientes> GetAllByWithRelation()
		{
			try
			{
				List<Ingredientes> l = SqlMapper.Query<Ingredientes>(con, "API.PA_IngredientesGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  Ingredientes  ->" + ex.Message);
			}
		}




		public List<Ingredientes> GetByFilter(Ingredientes pIngredientes, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", (pIngredientes.id == null || pIngredientes.id == 0) ? vintNUll : pIngredientes.id);
				p.Add("@ID_AlimentosICBF", (pIngredientes.ID_AlimentosICBF == null || pIngredientes.ID_AlimentosICBF == 0) ? vintNUll : pIngredientes.ID_AlimentosICBF);
				p.Add("@ID_TipoNivelEducativo", (pIngredientes.ID_TipoNivelEducativo == null || pIngredientes.ID_TipoNivelEducativo == 0) ? vintNUll : pIngredientes.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", (pIngredientes.ID_Preparacion == null || pIngredientes.ID_Preparacion == 0) ? vintNUll : pIngredientes.ID_Preparacion);
				p.Add("@ID_TipoComplemento", (pIngredientes.ID_TipoComplemento == null || pIngredientes.ID_TipoComplemento == 0) ? vintNUll : pIngredientes.ID_TipoComplemento);
				p.Add("@PesoBruto", (pIngredientes.PesoBruto == null) ? vintNUll : pIngredientes.PesoBruto);
				p.Add("@PesoNeto", (pIngredientes.PesoNeto == null) ? vintNUll : pIngredientes.PesoNeto);
				p.Add("@PorcentajeComestible", (pIngredientes.PorcentajeComestible == null) ? vintNUll : pIngredientes.PorcentajeComestible);
				p.Add("@IntercambioEstandarizado", (pIngredientes.IntercambioEstandarizado == null) ? vintNUll : pIngredientes.IntercambioEstandarizado);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<Ingredientes> l = SqlMapper.Query<Ingredientes>(con, "API.PA_IngredientesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  Ingredientes  ->" + ex.Message);
			}
		}

		public Ingredientes Add(Ingredientes pIngredientes)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pIngredientes.id);
				p.Add("@ID_AlimentosICBF", pIngredientes.ID_AlimentosICBF);
				p.Add("@ID_TipoNivelEducativo", pIngredientes.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", pIngredientes.ID_Preparacion);
				p.Add("@ID_TipoComplemento", pIngredientes.ID_TipoComplemento);
				p.Add("@PesoBruto", pIngredientes.PesoBruto);
				p.Add("@PesoNeto", pIngredientes.PesoNeto);
				p.Add("@PorcentajeComestible", pIngredientes.PorcentajeComestible);
				p.Add("@IntercambioEstandarizado", pIngredientes.IntercambioEstandarizado);
				p.Add("@auditoria", pIngredientes.auditoria);




				Ingredientes o = SqlMapper.QueryFirstOrDefault<Ingredientes>(con, "API.PA_IngredientesAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  Ingredientes  ->" + ex.Message);
			}
		}

		public Ingredientes Update(Ingredientes pIngredientes)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@id", pIngredientes.id);
				p.Add("@ID_AlimentosICBF", pIngredientes.ID_AlimentosICBF);
				p.Add("@ID_TipoNivelEducativo", pIngredientes.ID_TipoNivelEducativo);
				p.Add("@ID_Preparacion", pIngredientes.ID_Preparacion);
				p.Add("@ID_TipoComplemento", pIngredientes.ID_TipoComplemento);
				p.Add("@PesoBruto", pIngredientes.PesoBruto);
				p.Add("@PesoNeto", pIngredientes.PesoNeto);
				p.Add("@PorcentajeComestible", pIngredientes.PorcentajeComestible);
				p.Add("@IntercambioEstandarizado", pIngredientes.IntercambioEstandarizado);
				p.Add("@auditoria", pIngredientes.auditoria);


				Ingredientes o = SqlMapper.QueryFirstOrDefault<Ingredientes>(con, "API.PA_IngredientesUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  Ingredientes  ->" + ex.Message);
			}
		}

		public bool Delete(Ingredientes pIngredientes)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@id", pIngredientes.id);
				p.Add("@auditoria", pIngredientes.auditoria);





				Ingredientes o = SqlMapper.QueryFirstOrDefault<Ingredientes>(con, "API.PA_IngredientesDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) Ingredientes  ->" + ex.Message);
			}
		}





		public List<Ingredientes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<Ingredientes> IngredientesList = new List<Ingredientes>();

				IngredientesList = SqlMapper.Query<Ingredientes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return IngredientesList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) Ingredientes  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<Ingredientes> b)
		{
			DapperPlusManager.Entity<Ingredientes>().Table("Ingredientes");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}