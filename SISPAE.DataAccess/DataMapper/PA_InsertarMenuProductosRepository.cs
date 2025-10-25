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
     /// Clase Abstracta para  PA_InsertarMenuProductos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_InsertarMenuProductosRepository : DataObject , IPA_InsertarMenuProductos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_InsertarMenuProductosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_InsertarMenuProductosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_InsertarMenuProductos> GetPA_InsertarMenuProductos( int? ID_CiclosMenu,int? ID_Producto,String? auditoria)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@ID_CiclosMenu",ID_CiclosMenu);
p.Add("@ID_Producto",ID_Producto);
p.Add("@auditoria",auditoria);

					List<PA_InsertarMenuProductos> l = SqlMapper.Query<PA_InsertarMenuProductos>(con, "PTN.PA_InsertarMenuProductos" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_InsertarMenuProductos)  PA_InsertarMenuProductos  ->" + ex.Message + ex);
				}
			}

		
	    #endregion Class Methods
	}

}