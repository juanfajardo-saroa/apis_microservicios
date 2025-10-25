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
     /// Clase Abstracta para  PA_ContratosPlanAlistamientoGetAll
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_ContratosPlanAlistamientoGetAllRepository : DataObject , IPA_ContratosPlanAlistamientoGetAll 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_ContratosPlanAlistamientoGetAllRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_ContratosPlanAlistamientoGetAllRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_ContratosPlanAlistamientoGetAll> GetPA_ContratosPlanAlistamientoGetAll( int? ID_TipoModeloOperacion,String? NumContrato,int? ID_Operador,int? ID_ETC,int? ID_ET)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_TipoModeloOperacion",ID_TipoModeloOperacion);
p.Add("@NumContrato",NumContrato);
p.Add("@ID_Operador",ID_Operador);
p.Add("@ID_ETC",ID_ETC);
p.Add("@ID_ET",ID_ET);

					List<PA_ContratosPlanAlistamientoGetAll> l = SqlMapper.Query<PA_ContratosPlanAlistamientoGetAll>(con, "PlanAlistamiento.PA_ContratosPlanAlistamientoGetAll" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_ContratosPlanAlistamientoGetAll)  PA_ContratosPlanAlistamientoGetAll  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}