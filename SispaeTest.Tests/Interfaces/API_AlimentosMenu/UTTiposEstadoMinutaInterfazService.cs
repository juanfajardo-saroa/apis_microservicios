/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, UnitTest
/// Capa			:Capa Interfaz de Servicios para  Pruebas Unitarias para SISPAE    
/// </Derechos_Reservados>
/// 
/// 
/// 
using Microsoft.AspNetCore.Mvc;
using SISPAE.Model;
using System.Collections.Generic;
 
namespace SISPAE.Tests.Interfaces
{
    public interface ITiposEstadoMinutaService
    {

        IEnumerable<TiposEstadoMinuta> GetAll();
        IEnumerable<TiposEstadoMinuta> GetAllFull();

        TiposEstadoMinuta GetById(int id);
        TiposEstadoMinuta Post(TiposEstadoMinuta obj);
        TiposEstadoMinuta Put(TiposEstadoMinuta obj);
        void Delete(int id);

        ObjectResult LoadTable(DtParameters dtParameters);
        IEnumerable<TiposEstadoMinuta> GetAllRelation();
        bool ValidateForeignKey(string table);

        

    }
}
