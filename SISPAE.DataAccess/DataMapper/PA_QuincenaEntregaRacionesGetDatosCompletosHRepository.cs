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
     /// Clase Abstracta para  PA_QuincenaEntregaRacionesGetDatosCompletosH
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_QuincenaEntregaRacionesGetDatosCompletosHRepository : DataObject , IPA_QuincenaEntregaRacionesGetDatosCompletosH 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_QuincenaEntregaRacionesGetDatosCompletosHRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_QuincenaEntregaRacionesGetDatosCompletosHRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_QuincenaEntregaRacionesGetDatosCompletosH> GetPA_QuincenaEntregaRacionesGetDatosCompletosH( int? Id_SedeJornada,int? Id_Operador,DateTime? fecha_Ini,DateTime? fecha_Fin)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@Id_SedeJornada",Id_SedeJornada);
p.Add("@Id_Operador",Id_Operador);
p.Add("@fecha_Ini",fecha_Ini);
p.Add("@fecha_Fin",fecha_Fin);

					List<PA_QuincenaEntregaRacionesGetDatosCompletosH> l = SqlMapper.Query<PA_QuincenaEntregaRacionesGetDatosCompletosH>(con, "SeguimientoRaciones.PA_QuincenaEntregaRacionesGetDatosCompletosH" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_QuincenaEntregaRacionesGetDatosCompletosH)  PA_QuincenaEntregaRacionesGetDatosCompletosH  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}