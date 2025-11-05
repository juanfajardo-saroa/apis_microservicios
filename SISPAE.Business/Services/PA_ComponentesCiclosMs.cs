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
     /// Clase del Business  para  PA_ComponentesCiclos
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_ComponentesCiclosMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_ComponentesCiclos> GetPA_ComponentesCiclos( int? ID_CiclosMenu,int? ID_NivelEducativo,int? id_Semana,int? NumeroDia)
                {
                    var returnedEntities = new List<PA_ComponentesCiclos>();

                    try
                    {
                        using (var repository = new PA_ComponentesCiclosRepository())
                        {
                            foreach (var entity in repository.GetPA_ComponentesCiclos( ID_CiclosMenu,ID_NivelEducativo,id_Semana,NumeroDia))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_ComponentesCiclosBusiness::GetPA_ComponentesCiclos::Error occured.", ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}