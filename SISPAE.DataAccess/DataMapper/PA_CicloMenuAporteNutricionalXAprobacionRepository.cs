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
     /// Clase Abstracta para  PA_CicloMenuAporteNutricionalXAprobacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_CicloMenuAporteNutricionalXAprobacionRepository : DataObject , IPA_CicloMenuAporteNutricionalXAprobacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_CicloMenuAporteNutricionalXAprobacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_CicloMenuAporteNutricionalXAprobacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_CicloMenuAporteNutricionalXAprobacion> GetPA_CicloMenuAporteNutricionalXAprobacion( int? ID_Etc,int? ID_MinutaAprobacion,int? ID_TipoModeloOperacion,int? ID_TipoModalidadComplemento,int? ID_TipoComplemento,int? ID_TipoNivelEducativo,int? ID_Zona,int? ID_CicloMenu,int? ID_Preparacion,int? ID_Semana,int? Dia,int? ID_CiclosMenuReferencia,int? ID_Producto)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_Etc",ID_Etc);
p.Add("@ID_MinutaAprobacion",ID_MinutaAprobacion);
p.Add("@ID_TipoModeloOperacion",ID_TipoModeloOperacion);
p.Add("@ID_TipoModalidadComplemento",ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",ID_TipoComplemento);
p.Add("@ID_TipoNivelEducativo",ID_TipoNivelEducativo);
p.Add("@ID_Zona",ID_Zona);
p.Add("@ID_CicloMenu",ID_CicloMenu);
p.Add("@ID_Preparacion",ID_Preparacion);
p.Add("@ID_Semana",ID_Semana);
p.Add("@Dia",Dia);
p.Add("@ID_CiclosMenuReferencia",ID_CiclosMenuReferencia);
p.Add("@ID_Producto",ID_Producto);

					List<PA_CicloMenuAporteNutricionalXAprobacion> l = SqlMapper.Query<PA_CicloMenuAporteNutricionalXAprobacion>(con, "PTN.PA_CicloMenuAporteNutricionalXAprobacion" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_CicloMenuAporteNutricionalXAprobacion)  PA_CicloMenuAporteNutricionalXAprobacion  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}