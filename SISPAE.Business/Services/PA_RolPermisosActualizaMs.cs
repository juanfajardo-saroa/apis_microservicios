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
     /// Clase del Business  para  PA_RolPermisosActualiza
     /// 
     /// </Resumen>
	 
	 
{	 

	

	#region Metodos de negocio

    
	public partial class PA_RolPermisosActualizaMs
	{
        
		#region Implementacion Metodos
        
  
                public List<PA_RolPermisosActualiza> GetPA_RolPermisosActualiza( int? id,String? id_Rol,int? id_Modulo,Boolean? Ver,Boolean? Crear,Boolean? Editar,Boolean? Eliminar,Boolean? Aprobar,Boolean? Imprimir,String? auditoria)
                {
                    var returnedEntities = new List<PA_RolPermisosActualiza>();

                    try
                    {
                        using (var repository = new PA_RolPermisosActualizaRepository())
                        {
                            foreach (var entity in repository.GetPA_RolPermisosActualiza( id,id_Rol,id_Modulo,Ver,Crear,Editar,Eliminar,Aprobar,Imprimir,auditoria))
                            {
                                returnedEntities.Add(entity);
                            }
                        }

                        return returnedEntities;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("BusinessLogic:PA_RolPermisosActualizaBusiness::GetPA_RolPermisosActualizaError occured.::Error occured. "+ ex.Message.ToString(), ex);
                    }
                }
            


        

        

		

      
		
		#endregion Implementacion Metodos


    }
	#endregion Metodos de Negocio

}