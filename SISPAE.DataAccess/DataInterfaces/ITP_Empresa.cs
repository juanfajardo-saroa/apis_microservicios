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
    
    public interface ITP_Empresa
    {
		TP_Empresa GetById(TP_Empresa pTP_Empresa) ;
        List<TP_Empresa> GetAll();
        List<TP_Empresa> GetAllFull();
        TP_Empresa Add(TP_Empresa pTP_Empresa);
        TP_Empresa Update(TP_Empresa pTP_Empresa);
        bool Delete(TP_Empresa pTP_Empresa) ;
        List<TP_Empresa> GetByFilter(TP_Empresa pTP_Empresa, int pageSize , int Page , string OrderByC );  
		List<TP_Empresa> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<TP_Empresa> b);

    }
}
