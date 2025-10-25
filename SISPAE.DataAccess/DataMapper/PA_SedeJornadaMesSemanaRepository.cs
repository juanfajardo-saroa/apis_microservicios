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
     /// Clase Abstracta para  PA_SedeJornadaMesSemana
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_SedeJornadaMesSemanaRepository : DataObject , IPA_SedeJornadaMesSemana 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_SedeJornadaMesSemanaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_SedeJornadaMesSemanaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_SedeJornadaMesSemana> GetPA_SedeJornadaMesSemana( int? id_contrato,int? agno,int? mes,int? Id_Estado)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_contrato",id_contrato);
p.Add("@agno",agno);
p.Add("@mes",mes);
p.Add("@Id_Estado",Id_Estado);

					List<PA_SedeJornadaMesSemana> l = SqlMapper.Query<PA_SedeJornadaMesSemana>(con, "SeguimientoRaciones.PA_SedeJornadaMesSemana" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_SedeJornadaMesSemana)  PA_SedeJornadaMesSemana  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}