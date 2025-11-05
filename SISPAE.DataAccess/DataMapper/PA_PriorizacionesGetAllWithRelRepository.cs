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
     /// Clase Abstracta para  PA_PriorizacionesGetAllWithRel
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_PriorizacionesGetAllWithRelRepository : DataObject , IPA_PriorizacionesGetAllWithRel 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_PriorizacionesGetAllWithRelRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_PriorizacionesGetAllWithRelRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_PriorizacionesGetAllWithRel> GetPA_PriorizacionesGetAllWithRel( int? id_Sede, int? id_Vigencia)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_Sede",id_Sede);
                    p.Add("@id_Vigencia", id_Vigencia);

				List<PA_PriorizacionesGetAllWithRel> l = SqlMapper.Query<PA_PriorizacionesGetAllWithRel>(con, "Priorizacion.PA_PriorizacionesGetAllWithRel" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_PriorizacionesGetAllWithRel)  PA_PriorizacionesGetAllWithRel  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}