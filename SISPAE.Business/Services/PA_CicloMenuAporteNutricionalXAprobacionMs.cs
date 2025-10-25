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
     /// Clase del Business  para  PA_CicloMenuAporteNutricionalXAprobacion
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_CicloMenuAporteNutricionalXAprobacionMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_CicloMenuAporteNutricionalXAprobacion> GetPA_CicloMenuAporteNutricionalXAprobacion( int? ID_Etc,int? ID_MinutaAprobacion,int? ID_TipoModeloOperacion,int? ID_TipoModalidadComplemento,int? ID_TipoComplemento,int? ID_TipoNivelEducativo,int? ID_Zona,int? ID_CicloMenu,int? ID_Preparacion,int? ID_Semana,int? Dia,int? ID_CiclosMenuReferencia,int? ID_Producto)
                {
                    var returnedEntities = new List<PA_CicloMenuAporteNutricionalXAprobacion>();

                    try
                    {
                        using (var repository = new PA_CicloMenuAporteNutricionalXAprobacionRepository())
                        {
                            foreach (var entity in repository.GetPA_CicloMenuAporteNutricionalXAprobacion( ID_Etc,ID_MinutaAprobacion,ID_TipoModeloOperacion,ID_TipoModalidadComplemento,ID_TipoComplemento,ID_TipoNivelEducativo,ID_Zona,ID_CicloMenu,ID_Preparacion,ID_Semana,Dia,ID_CiclosMenuReferencia,ID_Producto))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_CicloMenuAporteNutricionalXAprobacionBusiness::GetPA_CicloMenuAporteNutricionalXAprobacionError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}