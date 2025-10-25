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
     /// Clase del Business  para  pa_BuscarPreparaciones
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class pa_BuscarPreparacionesMs
	{
        
		#region Implementacion Metodos
        
  
                public List<pa_BuscarPreparaciones> Getpa_BuscarPreparaciones( int? ID_ETC,int? ID_GrupoAlimentos,int? ID_SubGrupoAlimentos,int? ID_TipoPreparacion,int? ID_EstadoPreparacion)
                {
                    var returnedEntities = new List<pa_BuscarPreparaciones>();

                    try
                    {
                        using (var repository = new pa_BuscarPreparacionesRepository())
                        {
                            foreach (var entity in repository.Getpa_BuscarPreparaciones( ID_ETC,ID_GrupoAlimentos,ID_SubGrupoAlimentos,ID_TipoPreparacion,ID_EstadoPreparacion))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:pa_BuscarPreparacionesBusiness::Getpa_BuscarPreparacionesError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}