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
     /// Clase del Business  para  GetCaracterizacionNivel4
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class GetCaracterizacionNivel4Ms
	{
        
		#region Implementacion Metodos
        
  
                public List<GetCaracterizacionNivel4> GetGetCaracterizacionNivel4( int? id_ETC, int? Id_institucionEducativa)
                {
                    var returnedEntities = new List<GetCaracterizacionNivel4>();

                    try
                    {
                        using (var repository = new GetCaracterizacionNivel4Repository())
                        {
                            foreach (var entity in repository.GetGetCaracterizacionNivel4( id_ETC,Id_institucionEducativa))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:GetCaracterizacionNivel4Business::GetGetCaracterizacionNivel4Error occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}