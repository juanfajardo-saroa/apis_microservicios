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
     /// Clase Abstracta para  PA_InstutucionesEduGetbyETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_InstutucionesEduGetbyETCRepository : DataObject , IPA_InstutucionesEduGetbyETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_InstutucionesEduGetbyETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_InstutucionesEduGetbyETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_InstutucionesEduGetbyETC> GetPA_InstutucionesEduGetbyETC( int? id_ETC,int? id_tipoMunicipio,int? id_Divipola)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_ETC",id_ETC);
p.Add("@id_tipoMunicipio",id_tipoMunicipio);
p.Add("@id_Divipola",id_Divipola);

					List<PA_InstutucionesEduGetbyETC> l = SqlMapper.Query<PA_InstutucionesEduGetbyETC>(con, "Priorizacion.PA_InstutucionesEduGetbyETC" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_InstutucionesEduGetbyETC)  PA_InstutucionesEduGetbyETC  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}