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
	/// Clase Abstracta para  MenusPlanAlistamiento
	/// No haga cambios sobre esta clase,
	/// 
	/// </Resumen>
	public partial class MenusPlanAlistamientoRepository : DataObject, IMenusPlanAlistamiento
	{
		#region Class Declarations

		private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
		private readonly SqlConnection con;


		public MenusPlanAlistamientoRepository()
		{
			_dataSource = new DataMapperSource();
			con = new SqlConnection(_dataSource.cadena);
		}

		public MenusPlanAlistamientoRepository(DataAccess.DataMapper.DataMapperSource dataSource)
		{
			_dataSource = dataSource;
		}

		#endregion Class Declarations

		#region Class Methods

		public MenusPlanAlistamiento GetById(MenusPlanAlistamiento pMenusPlanAlistamiento)
		{

			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@ID", pMenusPlanAlistamiento.ID);


				MenusPlanAlistamiento o = SqlMapper.QueryFirstOrDefault<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoGetByKey", p, commandType: CommandType.StoredProcedure);
				return o;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetById)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}

		public List<MenusPlanAlistamiento> GetAll()
		{
			try
			{
				List<MenusPlanAlistamiento> l = SqlMapper.Query<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoGetAll").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAll)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}

		public List<MenusPlanAlistamiento> GetAllFull()
		{
			try
			{
				List<MenusPlanAlistamiento> l = SqlMapper.Query<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoGetAllFull").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllFull)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}

		public List<MenusPlanAlistamiento> GetAllByWithRelation()
		{
			try
			{
				List<MenusPlanAlistamiento> l = SqlMapper.Query<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoGetAllWithRelation").AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetAllByWithRelation)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}




		public List<MenusPlanAlistamiento> GetByFilter(MenusPlanAlistamiento pMenusPlanAlistamiento, int pageSize, int Page, string OrderByC)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@ID", (pMenusPlanAlistamiento.ID == null || pMenusPlanAlistamiento.ID == 0) ? vintNUll : pMenusPlanAlistamiento.ID);
				p.Add("@ID_EstadoValidacion", (pMenusPlanAlistamiento.ID_EstadoValidacion == null || pMenusPlanAlistamiento.ID_EstadoValidacion == 0) ? vintNUll : pMenusPlanAlistamiento.ID_EstadoValidacion);
				p.Add("@ID_UsuarioEntidad", (pMenusPlanAlistamiento.ID_UsuarioEntidad == null || pMenusPlanAlistamiento.ID_UsuarioEntidad == 0) ? vintNUll : pMenusPlanAlistamiento.ID_UsuarioEntidad);
				p.Add("@ID_CiclosMenu", (pMenusPlanAlistamiento.ID_CiclosMenu == null || pMenusPlanAlistamiento.ID_CiclosMenu == 0) ? vintNUll : pMenusPlanAlistamiento.ID_CiclosMenu);
				p.Add("@ID_PlanesAlistamiento", (pMenusPlanAlistamiento.ID_PlanesAlistamiento == null || pMenusPlanAlistamiento.ID_PlanesAlistamiento == 0) ? vintNUll : pMenusPlanAlistamiento.ID_PlanesAlistamiento);
				p.Add("@ID_TipoModalidadComplemento", (pMenusPlanAlistamiento.ID_TipoModalidadComplemento == null || pMenusPlanAlistamiento.ID_TipoModalidadComplemento == 0) ? vintNUll : pMenusPlanAlistamiento.ID_TipoModalidadComplemento);
				p.Add("@ID_NivelEducativo", (pMenusPlanAlistamiento.ID_NivelEducativo == null || pMenusPlanAlistamiento.ID_NivelEducativo == 0) ? vintNUll : pMenusPlanAlistamiento.ID_NivelEducativo);
				p.Add("@ID_TipoComplemento", (pMenusPlanAlistamiento.ID_TipoComplemento == null || pMenusPlanAlistamiento.ID_TipoComplemento == 0) ? vintNUll : pMenusPlanAlistamiento.ID_TipoComplemento);
				p.Add("@ID_Jornada", (pMenusPlanAlistamiento.ID_Jornada == null || pMenusPlanAlistamiento.ID_Jornada == 0) ? vintNUll : pMenusPlanAlistamiento.ID_Jornada);
				p.Add("@ID_ModeloOperacion", (pMenusPlanAlistamiento.ID_ModeloOperacion == null || pMenusPlanAlistamiento.ID_ModeloOperacion == 0) ? vintNUll : pMenusPlanAlistamiento.ID_ModeloOperacion);
				p.Add("@NumeroMenu", (pMenusPlanAlistamiento.NumeroMenu == null) ? vintNUll : pMenusPlanAlistamiento.NumeroMenu);
				p.Add("@TamPag", pageSize);
				p.Add("@pag", Page);
				p.Add("@OrdenBy", OrderByC);



				List<MenusPlanAlistamiento> l = SqlMapper.Query<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
				return l;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(GetByFilter)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}

		public MenusPlanAlistamiento Add(MenusPlanAlistamiento pMenusPlanAlistamiento)
		{
			try
			{
				int? vintNUll = null;
				DynamicParameters p = new DynamicParameters();

				p.Add("@ID", pMenusPlanAlistamiento.ID == null ? 0 : pMenusPlanAlistamiento.ID);
				p.Add("@ID_EstadoValidacion", pMenusPlanAlistamiento.ID_EstadoValidacion);
				p.Add("@ID_UsuarioEntidad", pMenusPlanAlistamiento.ID_UsuarioEntidad);
				p.Add("@ID_CiclosMenu", pMenusPlanAlistamiento.ID_CiclosMenu);
				p.Add("@ID_PlanesAlistamiento", pMenusPlanAlistamiento.ID_PlanesAlistamiento);
				p.Add("@ID_TipoModalidadComplemento", pMenusPlanAlistamiento.ID_TipoModalidadComplemento);
				p.Add("@ID_NivelEducativo", pMenusPlanAlistamiento.ID_NivelEducativo);
				p.Add("@ID_TipoComplemento", pMenusPlanAlistamiento.ID_TipoComplemento);
				p.Add("@ID_Jornada", pMenusPlanAlistamiento.ID_Jornada);
				p.Add("@ID_ModeloOperacion", pMenusPlanAlistamiento.ID_ModeloOperacion);
				p.Add("@NumeroMenu", pMenusPlanAlistamiento.NumeroMenu);
				p.Add("@auditoria", pMenusPlanAlistamiento.auditoria);




				MenusPlanAlistamiento o = SqlMapper.QueryFirstOrDefault<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoAdd", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Add)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}

		public MenusPlanAlistamiento Update(MenusPlanAlistamiento pMenusPlanAlistamiento)
		{
			try
			{
				int? vintNUll = null;

				DynamicParameters p = new DynamicParameters();

				p.Add("@ID", pMenusPlanAlistamiento.ID);
				p.Add("@ID_EstadoValidacion", pMenusPlanAlistamiento.ID_EstadoValidacion);
				p.Add("@ID_UsuarioEntidad", pMenusPlanAlistamiento.ID_UsuarioEntidad);
				p.Add("@ID_CiclosMenu", pMenusPlanAlistamiento.ID_CiclosMenu );
				p.Add("@ID_PlanesAlistamiento", pMenusPlanAlistamiento.ID_PlanesAlistamiento );
				p.Add("@ID_TipoModalidadComplemento", pMenusPlanAlistamiento.ID_TipoModalidadComplemento );
				p.Add("@ID_NivelEducativo", pMenusPlanAlistamiento.ID_NivelEducativo);
				p.Add("@ID_TipoComplemento", pMenusPlanAlistamiento.ID_TipoComplemento);
				p.Add("@ID_Jornada", pMenusPlanAlistamiento.ID_Jornada);
				p.Add("@ID_ModeloOperacion", pMenusPlanAlistamiento.ID_ModeloOperacion);
				p.Add("@NumeroMenu", pMenusPlanAlistamiento.NumeroMenu);
				p.Add("@auditoria", pMenusPlanAlistamiento.auditoria);




				MenusPlanAlistamiento o = SqlMapper.QueryFirstOrDefault<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoUpdate", p, commandType: CommandType.StoredProcedure);

				return o;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(Update)  MenusPlanAlistamiento  ->" + ex.Message);
			}
		}

		public bool Delete(MenusPlanAlistamiento pMenusPlanAlistamiento)
		{
			try
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@ID", pMenusPlanAlistamiento.ID);
				p.Add("@auditoria", pMenusPlanAlistamiento.auditoria);





				MenusPlanAlistamiento o = SqlMapper.QueryFirstOrDefault<MenusPlanAlistamiento>(con, "API.PA_MenusPlanAlistamientoDelete", p, commandType: CommandType.StoredProcedure);

				return true;

			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper: (Delete) MenusPlanAlistamiento  ->" + ex.Message);
			}
		}





		public List<MenusPlanAlistamiento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
		{
			try
			{
				List<MenusPlanAlistamiento> MenusPlanAlistamientoList = new List<MenusPlanAlistamiento>();

				MenusPlanAlistamientoList = SqlMapper.Query<MenusPlanAlistamiento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

				return MenusPlanAlistamientoList;
			}
			catch (Exception ex)
			{
				throw new Exception("DataMapper:(ExecProcedureQuery) MenusPlanAlistamiento  ->" + ex.Message);
			}
		}


		public void BulkInsert(List<MenusPlanAlistamiento> b)
		{
			DapperPlusManager.Entity<MenusPlanAlistamiento>().Table("MenusPlanAlistamiento");
			con.BulkInsert(b);
		}
	}
	#endregion Class Methods

}