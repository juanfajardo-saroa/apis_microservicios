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
     /// Clase del Business  para  PA_QuincenaEntregaRacionesGetxGrado
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_QuincenaEntregaRacionesGetxGradoMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_QuincenaEntregaRacionesGetxGrado> GetPA_QuincenaEntregaRacionesGetxGrado( int? Id_Contrato,int? Id_Operador,int? Id_Grado,int? racionesDiarias,int? Id_SedeJornada)
                {
                    var returnedEntities = new List<PA_QuincenaEntregaRacionesGetxGrado>();

                    try
                    {
                        using (var repository = new PA_QuincenaEntregaRacionesGetxGradoRepository())
                        {
                            foreach (var entity in repository.GetPA_QuincenaEntregaRacionesGetxGrado( Id_Contrato,Id_Operador,Id_Grado,racionesDiarias,Id_SedeJornada))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_QuincenaEntregaRacionesGetxGradoBusiness::GetPA_QuincenaEntregaRacionesGetxGradoError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}