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
    
    public interface INutrientesProducto
    {
		NutrientesProducto GetById(NutrientesProducto pNutrientesProducto) ;
        List<NutrientesProducto> GetAll();
        List<NutrientesProducto> GetAllFull();
        NutrientesProducto Add(NutrientesProducto pNutrientesProducto);
        NutrientesProducto Update(NutrientesProducto pNutrientesProducto);
        bool Delete(NutrientesProducto pNutrientesProducto) ;
        List<NutrientesProducto> GetByFilter(NutrientesProducto pNutrientesProducto, int pageSize , int Page , string OrderByC );  
		List<NutrientesProducto> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<NutrientesProducto> b);

    }
}
