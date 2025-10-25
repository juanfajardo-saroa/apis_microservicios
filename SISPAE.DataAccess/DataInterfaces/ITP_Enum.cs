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
    
    public interface ITP_Enum
    {
		TP_Enum GetById(TP_Enum pTP_Enum) ;
        List<TP_Enum> GetAll();
        List<TP_Enum> GetAllFull();
        TP_Enum Add(TP_Enum pTP_Enum);
        TP_Enum Update(TP_Enum pTP_Enum);
        bool Delete(TP_Enum pTP_Enum) ;
        List<TP_Enum> GetByFilter(TP_Enum pTP_Enum, int pageSize , int Page , string OrderByC );  
		List<TP_Enum> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<TP_Enum> b);

    }
}
