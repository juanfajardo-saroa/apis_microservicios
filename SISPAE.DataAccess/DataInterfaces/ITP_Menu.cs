/// <Derechos_Reservados>
/// Aplicacion      :Doc4Us 
/// Autor           :Oscar Mauricio Cortes Pinzon
/// Generacion      :Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano             :2018
/// Arquitectura    :Patron MVC ASP Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,  
/// Capa            :DAL (Data Access Layer) - Capa de Interfaces, Se presenta la Interfaz de cada Objeto 
///                  que representa los metodos que deben ser implementados (Source: MVC7_DAL_Interface.Cs)   Interfaces 
/// </Derechos_Reservados>


using SISPAE.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

///     Interfaz Principal de la Capa Data Access Layer (DAL)
///
///


namespace SISPAE.DataAccess.DataInterfaces
{

    /// <Resumen>
    /// Interfaz de la capa del DAL
    /// </Resumen>

    public interface ITP_Menu
    {
        TP_Menu GetById(TP_Menu pTP_Menu);
        List<TP_Menu> GetAll();
        TP_Menu Add(TP_Menu pTP_Menu);
        TP_Menu Update(TP_Menu pTP_Menu);
        bool Delete(TP_Menu pTP_Menu);
        List<TP_Menu> GetByFilter(TP_Menu pTP_Menu, int pageSize, int Page, string OrderByC);
        IList<TP_Menu> execProcedureQuery(IList<SqlParameter> sqlparametersvaluesList, string Procedimiento);
        object execProcedureNonQuery(IList<SqlParameter> sqlparametersvaluesList, string Procedimiento);

    }
}
