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
     /// Clase Abstracta para  PA_GradosSedesJornadasGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_GradosSedesJornadasGetAllWithRelationRepository : DataObject , IPA_GradosSedesJornadasGetAllWithRelation 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_GradosSedesJornadasGetAllWithRelationRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_GradosSedesJornadasGetAllWithRelationRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_GradosSedesJornadasGetAllWithRelation> GetPA_GradosSedesJornadasGetAllWithRelation( int? ID_SedeJornada)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_SedeJornada",ID_SedeJornada);

					List<PA_GradosSedesJornadasGetAllWithRelation> l = SqlMapper.Query<PA_GradosSedesJornadasGetAllWithRelation>(con, "SistemaEducativo.PA_GradosSedesJornadasGetAllWithRelation" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_GradosSedesJornadasGetAllWithRelation)  PA_GradosSedesJornadasGetAllWithRelation  ->" + ex.Message );
				}
			}

		
	    #endregion Class Methods
	}

}