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
     /// Clase Abstracta para  PA_SedeGetbyETC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_SedeGetbyETCRepository : DataObject , IPA_SedeGetbyETC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_SedeGetbyETCRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_SedeGetbyETCRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_SedeGetbyETC> GetPA_SedeGetbyETC( int? id_ETC,int? id_tipoMunicipio,int? id_Divipola,int? id_IE)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_ETC",id_ETC);
p.Add("@id_tipoMunicipio",id_tipoMunicipio);
p.Add("@id_Divipola",id_Divipola);
p.Add("@id_IE",id_IE);

					List<PA_SedeGetbyETC> l = SqlMapper.Query<PA_SedeGetbyETC>(con, "Priorizacion.PA_SedeGetbyETC" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_SedeGetbyETC)  PA_SedeGetbyETC  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}