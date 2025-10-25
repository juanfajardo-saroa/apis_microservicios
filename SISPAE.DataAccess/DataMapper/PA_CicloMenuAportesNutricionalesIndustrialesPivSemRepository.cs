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
     /// Clase Abstracta para  PA_CicloMenuAportesNutricionalesIndustrialesPivSem
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_CicloMenuAportesNutricionalesIndustrialesPivSemRepository : DataObject , IPA_CicloMenuAportesNutricionalesIndustrialesPivSem 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_CicloMenuAportesNutricionalesIndustrialesPivSemRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_CicloMenuAportesNutricionalesIndustrialesPivSemRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_CicloMenuAportesNutricionalesIndustrialesPivSem> GetPA_CicloMenuAportesNutricionalesIndustrialesPivSem( int? ID_Etc,int? ID_TipoModeloOperacion,int? ID_TipoComplemento,int? ID_TipoModalidadComplemento,int? ID_MinutaPatronAlimento,int? ID_CiclosMenuReferencia,int? ID_TipoNivelEducativo,int? ID_Zona,int? ID_CicloMenu,int? ID_Producto,int? ID_Semana)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_Etc",ID_Etc);
p.Add("@ID_TipoModeloOperacion",ID_TipoModeloOperacion);
p.Add("@ID_TipoComplemento",ID_TipoComplemento);
p.Add("@ID_TipoModalidadComplemento",ID_TipoModalidadComplemento);
p.Add("@ID_MinutaPatronAlimento",ID_MinutaPatronAlimento);
p.Add("@ID_CiclosMenuReferencia",ID_CiclosMenuReferencia);
p.Add("@ID_TipoNivelEducativo",ID_TipoNivelEducativo);
p.Add("@ID_Zona",ID_Zona);
p.Add("@ID_CicloMenu",ID_CicloMenu);
p.Add("@ID_Producto",ID_Producto);
p.Add("@ID_Semana",ID_Semana);

					List<PA_CicloMenuAportesNutricionalesIndustrialesPivSem> l = SqlMapper.Query<PA_CicloMenuAportesNutricionalesIndustrialesPivSem>(con, "PTN.PA_CicloMenuAportesNutricionalesIndustrialesPivSem" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_CicloMenuAportesNutricionalesIndustrialesPivSem)  PA_CicloMenuAportesNutricionalesIndustrialesPivSem  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}