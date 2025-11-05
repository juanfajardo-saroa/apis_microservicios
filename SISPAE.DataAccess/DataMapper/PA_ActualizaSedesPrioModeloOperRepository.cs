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
     /// Clase Abstracta para  PA_ActualizaSedesPrioModeloOper
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_ActualizaSedesPrioModeloOperRepository : DataObject , IPA_ActualizaSedesPrioModeloOper 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_ActualizaSedesPrioModeloOperRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_ActualizaSedesPrioModeloOperRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_ActualizaSedesPrioModeloOper> GetPA_ActualizaSedesPrioModeloOper( int? Id_ETC,int? Id_TipoMunicipio,int? Id_Divipola,int? ID_IE,int? id_sede,int? jor,int? nivel,int? zona,Decimal? Vulnerabilidad,int? id_EstadoPriorizacion,int? PrioPAE,int? ModeloOper,String? auditoria)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@Id_ETC",Id_ETC);
p.Add("@Id_TipoMunicipio",Id_TipoMunicipio);
p.Add("@Id_Divipola",Id_Divipola);
p.Add("@ID_IE",ID_IE);
p.Add("@id_sede",id_sede);
p.Add("@jor",jor);
p.Add("@nivel",nivel);
p.Add("@zona",zona);
p.Add("@Vulnerabilidad",Vulnerabilidad);
p.Add("@id_EstadoPriorizacion",id_EstadoPriorizacion);
p.Add("@PrioPAE",PrioPAE);
p.Add("@ModeloOper",ModeloOper);
p.Add("@auditoria",auditoria);

					List<PA_ActualizaSedesPrioModeloOper> l = SqlMapper.Query<PA_ActualizaSedesPrioModeloOper>(con, "SistemaEducativo.PA_ActualizaSedesPrioModeloOper" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_ActualizaSedesPrioModeloOper)  PA_ActualizaSedesPrioModeloOper  ->" + ex.Message + ex);
				}
			}

		
	    #endregion Class Methods
	}

}