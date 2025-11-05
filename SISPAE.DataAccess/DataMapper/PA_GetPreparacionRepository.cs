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
     /// Clase Abstracta para  PA_GetPreparacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_GetPreparacionRepository : DataObject , IPA_GetPreparacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_GetPreparacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_GetPreparacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_GetPreparacion> GetPA_GetPreparacion( int? Id_ETC,int? id_TipoComponente,int? Id_GrupoAlimento,int? Id_SubgrupoAlimento,int? Id_TipoPreparacion,String? Preparacion)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@Id_ETC",Id_ETC);
p.Add("@id_TipoComponente",id_TipoComponente);
p.Add("@Id_GrupoAlimento",Id_GrupoAlimento);
p.Add("@Id_SubgrupoAlimento",Id_SubgrupoAlimento);
p.Add("@Id_TipoPreparacion",Id_TipoPreparacion);
p.Add("@Preparacion",Preparacion);

					List<PA_GetPreparacion> l = SqlMapper.Query<PA_GetPreparacion>(con, "PTN.PA_GetPreparacion" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_GetPreparacion)  PA_GetPreparacion  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}