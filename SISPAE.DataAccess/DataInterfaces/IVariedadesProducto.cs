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
    
    public interface IVariedadesProducto
    {
		VariedadesProducto GetById(VariedadesProducto pVariedadesProducto) ;
        List<VariedadesProducto> GetAll();
        List<VariedadesProducto> GetAllFull();
        VariedadesProducto Add(VariedadesProducto pVariedadesProducto);
        VariedadesProducto Update(VariedadesProducto pVariedadesProducto);
        bool Delete(VariedadesProducto pVariedadesProducto) ;
        List<VariedadesProducto> GetByFilter(VariedadesProducto pVariedadesProducto, int pageSize , int Page , string OrderByC );  
		List<VariedadesProducto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<VariedadesProducto> b);

    }
}
