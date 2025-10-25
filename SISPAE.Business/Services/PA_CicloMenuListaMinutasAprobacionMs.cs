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
     /// Clase del Business  para  PA_CicloMenuListaMinutasAprobacion
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_CicloMenuListaMinutasAprobacionMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_CicloMenuListaMinutasAprobacion> GetPA_CicloMenuListaMinutasAprobacion( int? ID_TipoModeloOperacion,int? ID_TipoModalidadComplemento,int? ID_TipoComplemento,int? ID_TipoNivelEducativo,int? ID_ETC)
                {
                    var returnedEntities = new List<PA_CicloMenuListaMinutasAprobacion>();

                    try
                    {
                        using (var repository = new PA_CicloMenuListaMinutasAprobacionRepository())
                        {
                            foreach (var entity in repository.GetPA_CicloMenuListaMinutasAprobacion( ID_TipoModeloOperacion,ID_TipoModalidadComplemento,ID_TipoComplemento,ID_TipoNivelEducativo,ID_ETC))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_CicloMenuListaMinutasAprobacionBusiness::GetPA_CicloMenuListaMinutasAprobacionError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}