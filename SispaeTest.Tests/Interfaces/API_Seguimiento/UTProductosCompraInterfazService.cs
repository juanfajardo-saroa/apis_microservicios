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
    public interface IProductosCompraService
    {

        IEnumerable<ProductosCompra> GetAll();
        IEnumerable<ProductosCompra> GetAllFull();

        ProductosCompra GetById(int id);
        ProductosCompra Post(ProductosCompra obj);
        ProductosCompra Put(ProductosCompra obj);
        void Delete(int id);

        ObjectResult LoadTable(DtParameters dtParameters);
        IEnumerable<ProductosCompra> GetAllRelation();
        bool ValidateForeignKey(string table);

        

    }
}
