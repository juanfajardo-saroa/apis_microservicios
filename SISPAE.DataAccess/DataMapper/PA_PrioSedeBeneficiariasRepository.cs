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
     /// Clase Abstracta para  PA_PrioSedeBeneficiarias
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_PrioSedeBeneficiariasRepository : DataObject , IPA_PrioSedeBeneficiarias 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_PrioSedeBeneficiariasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_PrioSedeBeneficiariasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_PrioSedeBeneficiarias> GetPA_PrioSedeBeneficiarias( int? id_ETC,int? Id_TipoMunicipio,int? Id_Municipio,int? Id_InstEducativa,int? Id_sede,int? Id_Jornada,int? Id_NivelEducativo,int? Id_Zona,int? Id_CriterioVul,int? Id_EstadoPrio,int? priorizadaPAE)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id_ETC",id_ETC);
p.Add("@Id_TipoMunicipio",Id_TipoMunicipio);
p.Add("@Id_Municipio",Id_Municipio);
p.Add("@Id_InstEducativa",Id_InstEducativa);
p.Add("@Id_sede",Id_sede);
p.Add("@Id_Jornada",Id_Jornada);
p.Add("@Id_NivelEducativo",Id_NivelEducativo);
p.Add("@Id_Zona",Id_Zona);
p.Add("@Id_CriterioVul",Id_CriterioVul);
p.Add("@Id_EstadoPrio",Id_EstadoPrio);
p.Add("@priorizadaPAE",priorizadaPAE);

					List<PA_PrioSedeBeneficiarias> l = SqlMapper.Query<PA_PrioSedeBeneficiarias>(con, "Priorizacion.PA_PrioSedeBeneficiarias" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_PrioSedeBeneficiarias)  PA_PrioSedeBeneficiarias  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}