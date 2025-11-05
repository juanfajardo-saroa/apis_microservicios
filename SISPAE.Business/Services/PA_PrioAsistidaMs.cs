/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using SISPAE.Model;
using SISPAE.DataAccess;
using SISPAE.DataAccess.DataMapper;
using System.Data.SqlClient;
using SISPAE.Common;





namespace SISPAE.Business
     /// <Resumen>
     /// Clase del Business  para  PA_PrioAsistida
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_PrioAsistidaMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_PrioAsistida> GetPA_PrioAsistida( int? Id_ETC,int? Id_Vingencia,int? Id_TipoMunicipio,int? Id_Divipola,int? id_gradosedejornada,int? jor,int? nivel,int? zona,Decimal? Vulnerabilidad,int? modelo,int? modalidad,int? tipoRac,int? relleno,String? auditoria)
                {
                    var returnedEntities = new List<PA_PrioAsistida>();

                    try
                    {
                        using (var repository = new PA_PrioAsistidaRepository())
                        {
                            foreach (var entity in repository.GetPA_PrioAsistida( Id_ETC,Id_Vingencia,Id_TipoMunicipio,Id_Divipola,id_gradosedejornada,jor,nivel,zona,Vulnerabilidad,modelo,modalidad,tipoRac,relleno,auditoria))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_PrioAsistidaBusiness::GetPA_PrioAsistida::Error occured.", ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}