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
     /// Clase Abstracta para  PA_ObtenerNotificaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_ObtenerNotificacionesRepository : DataObject , IPA_ObtenerNotificaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_ObtenerNotificacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_ObtenerNotificacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_ObtenerNotificaciones> GetPA_ObtenerNotificaciones( String? usuario,int? Estado,int? Modulo,int? MaxReg,int? ETC)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@usuario",usuario);
p.Add("@Estado",Estado);
p.Add("@Modulo",Modulo);
p.Add("@MaxReg",MaxReg);
p.Add("@ETC",ETC);

					List<PA_ObtenerNotificaciones> l = SqlMapper.Query<PA_ObtenerNotificaciones>(con, "Alertas.PA_ObtenerNotificaciones" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_ObtenerNotificaciones)  PA_ObtenerNotificaciones  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}