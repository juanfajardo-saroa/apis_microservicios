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
    
    public interface IAplicacion
    {
		Aplicacion GetById(Aplicacion pAplicacion) ;
        List<Aplicacion> GetAll();
        List<Aplicacion> GetAllFull();
        Aplicacion Add(Aplicacion pAplicacion);
        Aplicacion Update(Aplicacion pAplicacion);
        bool Delete(Aplicacion pAplicacion) ;
        List<Aplicacion> GetByFilter(Aplicacion pAplicacion, int pageSize , int Page , string OrderByC );  
		List<Aplicacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<Aplicacion> b);

    }
}
