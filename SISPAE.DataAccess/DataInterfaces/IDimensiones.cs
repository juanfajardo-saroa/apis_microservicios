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
    
    public interface IDimensiones
    {
		Dimensiones GetById(Dimensiones pDimensiones) ;
        List<Dimensiones> GetAll();
        List<Dimensiones> GetAllFull();
        Dimensiones Add(Dimensiones pDimensiones);
        Dimensiones Update(Dimensiones pDimensiones);
        bool Delete(Dimensiones pDimensiones) ;
        List<Dimensiones> GetByFilter(Dimensiones pDimensiones, int pageSize , int Page , string OrderByC );  
		List<Dimensiones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<Dimensiones> b);

    }
}
