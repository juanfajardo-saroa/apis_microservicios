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
    
    public interface IMinutaPatronAlimentos_Cuarentena
    {
		MinutaPatronAlimentos_Cuarentena GetById(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena) ;
        List<MinutaPatronAlimentos_Cuarentena> GetAll();
        List<MinutaPatronAlimentos_Cuarentena> GetAllFull();
        MinutaPatronAlimentos_Cuarentena Add(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena);
        MinutaPatronAlimentos_Cuarentena Update(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena);
        bool Delete(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena) ;
        List<MinutaPatronAlimentos_Cuarentena> GetByFilter(MinutaPatronAlimentos_Cuarentena pMinutaPatronAlimentos_Cuarentena, int pageSize , int Page , string OrderByC );  
		List<MinutaPatronAlimentos_Cuarentena> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<MinutaPatronAlimentos_Cuarentena> b);

    }
}
