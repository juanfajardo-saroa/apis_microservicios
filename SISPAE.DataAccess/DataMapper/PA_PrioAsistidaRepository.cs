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
     /// Clase Abstracta para  PA_PrioAsistida
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_PrioAsistidaRepository : DataObject , IPA_PrioAsistida 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_PrioAsistidaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_PrioAsistidaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_PrioAsistida> GetPA_PrioAsistida( int? Id_ETC,int? Id_Vingencia,int? Id_TipoMunicipio,int? Id_Divipola,int? id_gradosedejornada,int? jor,int? nivel,int? zona,Decimal? Vulnerabilidad,int? modelo,int? modalidad,int? tipoRac,int? relleno,String? auditoria)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@Id_ETC",Id_ETC);
p.Add("@Id_Vingencia",Id_Vingencia);
p.Add("@Id_TipoMunicipio",Id_TipoMunicipio);
p.Add("@Id_Divipola",Id_Divipola);
p.Add("@id_gradosedejornada",id_gradosedejornada);
p.Add("@jor",jor);
p.Add("@nivel",nivel);
p.Add("@zona",zona);
p.Add("@Vulnerabilidad",Vulnerabilidad);
p.Add("@modelo",modelo);
p.Add("@modalidad",modalidad);
p.Add("@tipoRac",tipoRac);
p.Add("@relleno",relleno);
p.Add("@auditoria",auditoria);

					List<PA_PrioAsistida> l = SqlMapper.Query<PA_PrioAsistida>(con, "Priorizacion.PA_PrioAsistida" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_PrioAsistida)  PA_PrioAsistida  ->" + ex.Message + ex);
				}
			}

		
	    #endregion Class Methods
	}

}