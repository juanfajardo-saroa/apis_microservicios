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
     /// Clase Abstracta para  PA_AporteNutricionalProducto
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_AporteNutricionalProductoRepository : DataObject , IPA_AporteNutricionalProducto 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_AporteNutricionalProductoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_AporteNutricionalProductoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_AporteNutricionalProducto> GetPA_AporteNutricionalProducto( int? ID_Producto,int? ID_TipoNivelEducativo,int? ID_TipoComponente)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_Producto",ID_Producto);
p.Add("@ID_TipoNivelEducativo",ID_TipoNivelEducativo);
p.Add("@ID_TipoComponente",ID_TipoComponente);

					List<PA_AporteNutricionalProducto> l = SqlMapper.Query<PA_AporteNutricionalProducto>(con, "PTN.PA_AporteNutricionalProducto" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_AporteNutricionalProducto)  PA_AporteNutricionalProducto  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}