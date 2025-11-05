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
     /// Clase Abstracta para  GetCaracterizacionNivel4
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class GetCaracterizacionNivel4Repository : DataObject , IGetCaracterizacionNivel4 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public GetCaracterizacionNivel4Repository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public GetCaracterizacionNivel4Repository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<GetCaracterizacionNivel4> GetGetCaracterizacionNivel4( int? id_ETC, int? Id_institucionEducativa)
			{

				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_ETC",id_ETC);
                    p.Add("@Id_institucionEducativa", Id_institucionEducativa);

                List<GetCaracterizacionNivel4> l = SqlMapper.Query<GetCaracterizacionNivel4>(con, "Infraestructura.GetCaracterizacionNivel4" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetGetCaracterizacionNivel4)  GetCaracterizacionNivel4  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}