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
     /// Clase Abstracta para  PA_ComponentesCiclos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_ComponentesCiclosRepository : DataObject , IPA_ComponentesCiclos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_ComponentesCiclosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_ComponentesCiclosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_ComponentesCiclos> GetPA_ComponentesCiclos( int? ID_CiclosMenu,int? ID_NivelEducativo,int? id_Semana,int? NumeroDia)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_CiclosMenu",ID_CiclosMenu);
p.Add("@ID_NivelEducativo",ID_NivelEducativo);
p.Add("@id_Semana",id_Semana);
p.Add("@NumeroDia",NumeroDia);

					List<PA_ComponentesCiclos> l = SqlMapper.Query<PA_ComponentesCiclos>(con, "PTN.PA_ComponentesCiclos" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_ComponentesCiclos)  PA_ComponentesCiclos  ->" + ex.Message + ex);
				}
			}

		
	    #endregion Class Methods
	}

}