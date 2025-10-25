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
    public interface IPlanesAlistamientosService
    {

        IEnumerable<PlanesAlistamientos> GetAll();
        IEnumerable<PlanesAlistamientos> GetAllFull();

        PlanesAlistamientos GetById(int id);
        PlanesAlistamientos Post(PlanesAlistamientos obj);
        PlanesAlistamientos Put(PlanesAlistamientos obj);
        void Delete(int id);

        ObjectResult LoadTable(DtParameters dtParameters);
        IEnumerable<PlanesAlistamientos> GetAllRelation();
        bool ValidateForeignKey(string table);

        

    }
}
