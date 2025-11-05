/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:DAL (Data Access Layer) - Capa de Interfaces, Se presenta la Interfaz de cada Objeto 
/// 				 que representa los metodos que deben ser implementados (Source: MVC7_DAL_Interface.Cs)   Interfaces 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using SISPAE.Model;
using System.Data.SqlClient;
using Dapper;

///		Interfaz Principal de la Capa Data Access Layer (DAL)
///
///

namespace SISPAE.DataAccess.DataInterfaces
{

    /// <Resumen>
    /// Interfaz de la capa del DAL
    /// </Resumen>
    
    public interface IModificaciones
    {
		Modificaciones GetById(Modificaciones pModificaciones) ;
        List<Modificaciones> GetAll();
        List<Modificaciones> GetAllFull();
        Modificaciones Add(Modificaciones pModificaciones);
        Modificaciones Update(Modificaciones pModificaciones);
        bool Delete(Modificaciones pModificaciones) ;
        List<Modificaciones> GetByFilter(Modificaciones pModificaciones, int pageSize , int Page , string OrderByC );  
		List<Modificaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<Modificaciones> b);

    }
}
