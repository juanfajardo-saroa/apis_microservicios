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
     /// Clase Abstracta para  PA_InstitucionEducativaGetbyOperadorContratoMunicipio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_InstitucionEducativaGetbyOperadorContratoMunicipioRepository : DataObject , IPA_InstitucionEducativaGetbyOperadorContratoMunicipio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_InstitucionEducativaGetbyOperadorContratoMunicipioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_InstitucionEducativaGetbyOperadorContratoMunicipioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_InstitucionEducativaGetbyOperadorContratoMunicipio> GetPA_InstitucionEducativaGetbyOperadorContratoMunicipio( int? Id_Operador,int? Id_Contrato,int? Id_Divipola)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@Id_Operador",Id_Operador);
p.Add("@Id_Contrato",Id_Contrato);
p.Add("@Id_Divipola",Id_Divipola);

					List<PA_InstitucionEducativaGetbyOperadorContratoMunicipio> l = SqlMapper.Query<PA_InstitucionEducativaGetbyOperadorContratoMunicipio>(con, "SistemaEducativo.PA_InstitucionEducativaGetbyOperadorContratoMunicipio" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_InstitucionEducativaGetbyOperadorContratoMunicipio)  PA_InstitucionEducativaGetbyOperadorContratoMunicipio  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}