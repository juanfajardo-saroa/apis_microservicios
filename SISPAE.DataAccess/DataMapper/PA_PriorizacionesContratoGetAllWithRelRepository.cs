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
     /// Clase Abstracta para  PA_PriorizacionesContratoGetAllWithRel
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_PriorizacionesContratoGetAllWithRelRepository : DataObject , IPA_PriorizacionesContratoGetAllWithRel 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_PriorizacionesContratoGetAllWithRelRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_PriorizacionesContratoGetAllWithRelRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_PriorizacionesContratoGetAllWithRel> GetPA_PriorizacionesContratoGetAllWithRel( int? id_Sede)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_Sede",id_Sede);

					List<PA_PriorizacionesContratoGetAllWithRel> l = SqlMapper.Query<PA_PriorizacionesContratoGetAllWithRel>(con, "Priorizacion.PA_PriorizacionesContratoGetAllWithRel" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_PriorizacionesContratoGetAllWithRel)  PA_PriorizacionesContratoGetAllWithRel  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}