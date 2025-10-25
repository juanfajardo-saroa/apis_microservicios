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
    public interface IAlimentosPlanService
    {

        IEnumerable<AlimentosPlan> GetAll();
        IEnumerable<AlimentosPlan> GetAllFull();

        AlimentosPlan GetById(int id);
        AlimentosPlan Post(AlimentosPlan obj);
        AlimentosPlan Put(AlimentosPlan obj);
        void Delete(int id);

        ObjectResult LoadTable(DtParameters dtParameters);
        IEnumerable<AlimentosPlan> GetAllRelation();
        bool ValidateForeignKey(string table);

        

    }
}
