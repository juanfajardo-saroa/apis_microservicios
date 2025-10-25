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
    
    public interface IStgAnexo6a
    {
		StgAnexo6a GetById(StgAnexo6a pStgAnexo6a) ;
        List<StgAnexo6a> GetAll();
        List<StgAnexo6a> GetAllFull();
        StgAnexo6a Add(StgAnexo6a pStgAnexo6a);
        StgAnexo6a Update(StgAnexo6a pStgAnexo6a);
        bool Delete(StgAnexo6a pStgAnexo6a) ;
        List<StgAnexo6a> GetByFilter(StgAnexo6a pStgAnexo6a, int pageSize , int Page , string OrderByC );  
		List<StgAnexo6a> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<StgAnexo6a> b);

    }
}
