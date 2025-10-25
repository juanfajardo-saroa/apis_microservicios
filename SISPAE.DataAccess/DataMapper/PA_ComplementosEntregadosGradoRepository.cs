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
     /// Clase Abstracta para  PA_ComplementosEntregadosGrado
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_ComplementosEntregadosGradoRepository : DataObject , IPA_ComplementosEntregadosGrado 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_ComplementosEntregadosGradoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_ComplementosEntregadosGradoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_ComplementosEntregadosGrado> GetPA_ComplementosEntregadosGrado( int? id_contrato,int? id_sede,int? id_jornada,int? Id_grado,DateTime? fechaInicial,DateTime? fechaFinal)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_contrato",id_contrato);
p.Add("@id_sede",id_sede);
p.Add("@id_jornada",id_jornada);
p.Add("@Id_grado",Id_grado);
p.Add("@fechaInicial",fechaInicial);
p.Add("@fechaFinal",fechaFinal);

					List<PA_ComplementosEntregadosGrado> l = SqlMapper.Query<PA_ComplementosEntregadosGrado>(con, "SeguimientoRaciones.PA_ComplementosEntregadosGrado" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_ComplementosEntregadosGrado)  PA_ComplementosEntregadosGrado  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}