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
    
    public interface ICaracteristicasFinancierasF3
    {
		CaracteristicasFinancierasF3 GetById(CaracteristicasFinancierasF3 pCaracteristicasFinancierasF3) ;
        List<CaracteristicasFinancierasF3> GetAll();
        List<CaracteristicasFinancierasF3> GetAllFull();
        CaracteristicasFinancierasF3 Add(CaracteristicasFinancierasF3 pCaracteristicasFinancierasF3);
        CaracteristicasFinancierasF3 Update(CaracteristicasFinancierasF3 pCaracteristicasFinancierasF3);
        bool Delete(CaracteristicasFinancierasF3 pCaracteristicasFinancierasF3) ;
        List<CaracteristicasFinancierasF3> GetByFilter(CaracteristicasFinancierasF3 pCaracteristicasFinancierasF3, int pageSize , int Page , string OrderByC );  
		List<CaracteristicasFinancierasF3> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento);  
		void BulkInsert(List<CaracteristicasFinancierasF3> b);

    }
}
