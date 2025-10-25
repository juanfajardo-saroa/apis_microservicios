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
     /// Clase del Business  para  PA_AportesComponentePreparacion
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_AportesComponentePreparacionMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_AportesComponentePreparacion> GetPA_AportesComponentePreparacion( int? ID_etc,int? id_TipoModeloOperacion,int? ID_Preparacion,int? ID_Complemento,int? ID_TipoNivelEducativo)
                {
                    var returnedEntities = new List<PA_AportesComponentePreparacion>();

                    try
                    {
                        using (var repository = new PA_AportesComponentePreparacionRepository())
                        {
                            foreach (var entity in repository.GetPA_AportesComponentePreparacion( ID_etc,id_TipoModeloOperacion,ID_Preparacion,ID_Complemento,ID_TipoNivelEducativo))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_AportesComponentePreparacionBusiness::GetPA_AportesComponentePreparacionError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}