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
    
    public interface ITipoDocumentoIden
    {
		TipoDocumentoIden GetById(TipoDocumentoIden pTipoDocumentoIden) ;
        List<TipoDocumentoIden> GetAll();
        List<TipoDocumentoIden> GetAllFull();
        TipoDocumentoIden Add(TipoDocumentoIden pTipoDocumentoIden);
        TipoDocumentoIden Update(TipoDocumentoIden pTipoDocumentoIden);
        bool Delete(TipoDocumentoIden pTipoDocumentoIden) ;
        List<TipoDocumentoIden> GetByFilter(TipoDocumentoIden pTipoDocumentoIden, int pageSize , int Page , string OrderByC );  
		List<TipoDocumentoIden> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<TipoDocumentoIden> b);

    }
}
