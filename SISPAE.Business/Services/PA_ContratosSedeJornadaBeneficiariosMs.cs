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
     /// Clase del Business  para  PA_ContratosSedeJornadaBeneficiarios
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_ContratosSedeJornadaBeneficiariosMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_ContratosSedeJornadaBeneficiarios> GetPA_ContratosSedeJornadaBeneficiarios( int? id_Contrato,int? id_divipola,int? id_IE,int? id_sede)
                {
                    var returnedEntities = new List<PA_ContratosSedeJornadaBeneficiarios>();

                    try
                    {
                        using (var repository = new PA_ContratosSedeJornadaBeneficiariosRepository())
                        {
                            foreach (var entity in repository.GetPA_ContratosSedeJornadaBeneficiarios( id_Contrato,id_divipola,id_IE,id_sede))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_ContratosSedeJornadaBeneficiariosBusiness::GetPA_ContratosSedeJornadaBeneficiariosError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}