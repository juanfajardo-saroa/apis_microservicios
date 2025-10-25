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
     /// Clase Abstracta para  PA_AporteNutricionalIngredientesDet
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_AporteNutricionalIngredientesDetRepository : DataObject , IPA_AporteNutricionalIngredientesDet 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_AporteNutricionalIngredientesDetRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_AporteNutricionalIngredientesDetRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_AporteNutricionalIngredientesDet> GetPA_AporteNutricionalIngredientesDet( int? ID_ETC,int? ID_Ingrediente,int? ID_TipoComplemento,int? ID_TipoNivelEducativo,int? ID_ModeloOperacion)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_ETC",ID_ETC);
p.Add("@ID_Ingrediente",ID_Ingrediente);
p.Add("@ID_TipoComplemento",ID_TipoComplemento);
p.Add("@ID_TipoNivelEducativo",ID_TipoNivelEducativo);
p.Add("@ID_ModeloOperacion",ID_ModeloOperacion);

					List<PA_AporteNutricionalIngredientesDet> l = SqlMapper.Query<PA_AporteNutricionalIngredientesDet>(con, "PTN.PA_AporteNutricionalIngredientesDet" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_AporteNutricionalIngredientesDet)  PA_AporteNutricionalIngredientesDet  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}