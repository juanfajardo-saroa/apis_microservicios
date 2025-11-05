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
     /// Clase Abstracta para  PA_JornadaGetbyETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_JornadaGetbyETCRepository : DataObject , IPA_JornadaGetbyETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_JornadaGetbyETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_JornadaGetbyETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_JornadaGetbyETC> GetPA_JornadaGetbyETC( int? id_ETC,int? id_tipoMunicipio,int? id_Divipola,int? id_IE,int? id_sede)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_ETC",id_ETC);
p.Add("@id_tipoMunicipio",id_tipoMunicipio);
p.Add("@id_Divipola",id_Divipola);
p.Add("@id_IE",id_IE);
p.Add("@id_sede",id_sede);

					List<PA_JornadaGetbyETC> l = SqlMapper.Query<PA_JornadaGetbyETC>(con, "Priorizacion.PA_JornadaGetbyETC" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_JornadaGetbyETC)  PA_JornadaGetbyETC  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}