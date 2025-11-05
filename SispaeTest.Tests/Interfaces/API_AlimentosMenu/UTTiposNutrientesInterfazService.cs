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
    public interface ITiposNutrientesService
    {

        IEnumerable<TiposNutrientes> GetAll();
        IEnumerable<TiposNutrientes> GetAllFull();

        TiposNutrientes GetById(int id);
        TiposNutrientes Post(TiposNutrientes obj);
        TiposNutrientes Put(TiposNutrientes obj);
        void Delete(int id);

        ObjectResult LoadTable(DtParameters dtParameters);
        IEnumerable<TiposNutrientes> GetAllRelation();
        bool ValidateForeignKey(string table);

        

    }
}
