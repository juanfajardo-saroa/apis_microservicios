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
     /// Clase del Business  para  PA_PrioSedeAsignaRacion
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_PrioSedeAsignaRacionMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_PrioSedeAsignaRacion> GetPA_PrioSedeAsignaRacion( int? id_ETC,int? Id_Vigencia,int? Id_TipoMunicipio,int? Id_Municipio,int? Id_InstEducativa,int? Id_sede,int? Id_Jornada,int? Id_NivelEducativo,int? Id_Zona,int? Id_CriterioVul,int? Id_EstadoPrio,int? id_Grado)
                {
                    var returnedEntities = new List<PA_PrioSedeAsignaRacion>();

                    try
                    {
                        using (var repository = new PA_PrioSedeAsignaRacionRepository())
                        {
                            foreach (var entity in repository.GetPA_PrioSedeAsignaRacion( id_ETC,Id_Vigencia,Id_TipoMunicipio,Id_Municipio,Id_InstEducativa,Id_sede,Id_Jornada,Id_NivelEducativo,Id_Zona,Id_CriterioVul,Id_EstadoPrio,id_Grado))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_PrioSedeAsignaRacionBusiness::GetPA_PrioSedeAsignaRacionError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}