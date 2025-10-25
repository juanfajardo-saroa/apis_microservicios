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
    
    public interface ITiposDestinosRaciones
    {
		TiposDestinosRaciones GetById(TiposDestinosRaciones pTiposDestinosRaciones) ;
        List<TiposDestinosRaciones> GetAll();
        List<TiposDestinosRaciones> GetAllFull();
        TiposDestinosRaciones Add(TiposDestinosRaciones pTiposDestinosRaciones);
        TiposDestinosRaciones Update(TiposDestinosRaciones pTiposDestinosRaciones);
        bool Delete(TiposDestinosRaciones pTiposDestinosRaciones) ;
        List<TiposDestinosRaciones> GetByFilter(TiposDestinosRaciones pTiposDestinosRaciones, int pageSize , int Page , string OrderByC );  
		List<TiposDestinosRaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<TiposDestinosRaciones> b);

    }
}
