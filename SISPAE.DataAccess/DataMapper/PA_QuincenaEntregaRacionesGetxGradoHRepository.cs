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
     /// Clase Abstracta para  PA_QuincenaEntregaRacionesGetxGradoH
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_QuincenaEntregaRacionesGetxGradoHRepository : DataObject , IPA_QuincenaEntregaRacionesGetxGradoH 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_QuincenaEntregaRacionesGetxGradoHRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_QuincenaEntregaRacionesGetxGradoHRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_QuincenaEntregaRacionesGetxGradoH> GetPA_QuincenaEntregaRacionesGetxGradoH( int? Id_Contrato,int? Id_Operador,int? Id_Grado,int? racionesDiarias,int? Id_SedeJornada,DateTime? Fecha_Ini,DateTime? Fecha_Fin)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@Id_Contrato",Id_Contrato);
p.Add("@Id_Operador",Id_Operador);
p.Add("@Id_Grado",Id_Grado);
p.Add("@racionesDiarias",racionesDiarias);
p.Add("@Id_SedeJornada",Id_SedeJornada);
p.Add("@Fecha_Ini",Fecha_Ini);
p.Add("@Fecha_Fin",Fecha_Fin);

					List<PA_QuincenaEntregaRacionesGetxGradoH> l = SqlMapper.Query<PA_QuincenaEntregaRacionesGetxGradoH>(con, "SeguimientoRaciones.PA_QuincenaEntregaRacionesGetxGradoH" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_QuincenaEntregaRacionesGetxGradoH)  PA_QuincenaEntregaRacionesGetxGradoH  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}