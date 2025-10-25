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
    
    public interface ITiposEstadoMinuta
    {
		TiposEstadoMinuta GetById(TiposEstadoMinuta pTiposEstadoMinuta) ;
        List<TiposEstadoMinuta> GetAll();
        List<TiposEstadoMinuta> GetAllFull();
        TiposEstadoMinuta Add(TiposEstadoMinuta pTiposEstadoMinuta);
        TiposEstadoMinuta Update(TiposEstadoMinuta pTiposEstadoMinuta);
        bool Delete(TiposEstadoMinuta pTiposEstadoMinuta) ;
        List<TiposEstadoMinuta> GetByFilter(TiposEstadoMinuta pTiposEstadoMinuta, int pageSize , int Page , string OrderByC );  
		List<TiposEstadoMinuta> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<TiposEstadoMinuta> b);

    }
}
