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
    
    public interface IAlertasUsuario
    {
		AlertasUsuario GetById(AlertasUsuario pAlertasUsuario) ;
        List<AlertasUsuario> GetAll();
        List<AlertasUsuario> GetAllFull();
        AlertasUsuario Add(AlertasUsuario pAlertasUsuario);
        AlertasUsuario Update(AlertasUsuario pAlertasUsuario);
        bool Delete(AlertasUsuario pAlertasUsuario) ;
        List<AlertasUsuario> GetByFilter(AlertasUsuario pAlertasUsuario, int pageSize , int Page , string OrderByC );  
		List<AlertasUsuario> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<AlertasUsuario> b);

    }
}
