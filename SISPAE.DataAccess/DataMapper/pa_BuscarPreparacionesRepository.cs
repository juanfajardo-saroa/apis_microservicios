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
     /// Clase Abstracta para  pa_BuscarPreparaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class pa_BuscarPreparacionesRepository : DataObject , Ipa_BuscarPreparaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public pa_BuscarPreparacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public pa_BuscarPreparacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<pa_BuscarPreparaciones> Getpa_BuscarPreparaciones( int? ID_ETC,int? ID_GrupoAlimentos,int? ID_SubGrupoAlimentos,int? ID_TipoPreparacion,int? ID_EstadoPreparacion)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_ETC",ID_ETC);
p.Add("@ID_GrupoAlimentos",ID_GrupoAlimentos);
p.Add("@ID_SubGrupoAlimentos",ID_SubGrupoAlimentos);
p.Add("@ID_TipoPreparacion",ID_TipoPreparacion);
p.Add("@ID_EstadoPreparacion",ID_EstadoPreparacion);

					List<pa_BuscarPreparaciones> l = SqlMapper.Query<pa_BuscarPreparaciones>(con, "PTN.pa_BuscarPreparaciones" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(Getpa_BuscarPreparaciones)  pa_BuscarPreparaciones  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}