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
     /// Clase del Business  para  PA_ZonaGetbyETC
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_ZonaGetbyETCMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_ZonaGetbyETC> GetPA_ZonaGetbyETC( int? id_ETC,int? id_tipoMunicipio,int? id_Divipola,int? id_IE,int? id_Sede)
                {
                    var returnedEntities = new List<PA_ZonaGetbyETC>();

                    try
                    {
                        using (var repository = new PA_ZonaGetbyETCRepository())
                        {
                            foreach (var entity in repository.GetPA_ZonaGetbyETC( id_ETC,id_tipoMunicipio,id_Divipola,id_IE,id_Sede))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_ZonaGetbyETCBusiness::GetPA_ZonaGetbyETCError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}