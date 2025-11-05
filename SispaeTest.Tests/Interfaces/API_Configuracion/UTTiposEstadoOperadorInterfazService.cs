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
    public interface ITiposEstadoOperadorService
    {

        IEnumerable<TiposEstadoOperador> GetAll();
        IEnumerable<TiposEstadoOperador> GetAllFull();

        TiposEstadoOperador GetById(int id);
        TiposEstadoOperador Post(TiposEstadoOperador obj);
        TiposEstadoOperador Put(TiposEstadoOperador obj);
        void Delete(int id);

        ObjectResult LoadTable(DtParameters dtParameters);
        IEnumerable<TiposEstadoOperador> GetAllRelation();
        bool ValidateForeignKey(string table);

        

    }
}
