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
     /// Clase del Business  para  PA_ActualizaSedesPrioModeloOper
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_ActualizaSedesPrioModeloOperMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_ActualizaSedesPrioModeloOper> GetPA_ActualizaSedesPrioModeloOper( int? Id_ETC,int? Id_TipoMunicipio,int? Id_Divipola,int? ID_IE,int? id_sede,int? jor,int? nivel,int? zona,Decimal? Vulnerabilidad,int? id_EstadoPriorizacion,int? PrioPAE,int? ModeloOper,String? auditoria)
                {
                    var returnedEntities = new List<PA_ActualizaSedesPrioModeloOper>();

                    try
                    {
                        using (var repository = new PA_ActualizaSedesPrioModeloOperRepository())
                        {
                            foreach (var entity in repository.GetPA_ActualizaSedesPrioModeloOper( Id_ETC,Id_TipoMunicipio,Id_Divipola,ID_IE,id_sede,jor,nivel,zona,Vulnerabilidad,id_EstadoPriorizacion,PrioPAE,ModeloOper,auditoria))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_ActualizaSedesPrioModeloOperBusiness::GetPA_ActualizaSedesPrioModeloOper::Error occured.", ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}