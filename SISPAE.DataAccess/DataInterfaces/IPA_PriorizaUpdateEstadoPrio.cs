/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:DAL (Data Access Layer) - Capa de Interfaces, Se presenta la Interfaz de cada Objeto 
/// 				 que representa los metodos que deben ser implementados (Source: MVC7_DAL_Interface.Cs)   Interfaces 
/// </Derechos_Reservados>


using SISPAE.Model;

///		Interfaz Principal de la Capa Data Access Layer (DAL)
///
///
namespace SISPAE.DataAccess.DataInterfaces
    {

    /// <Resumen>
    /// Interfaz de la capa del DAL
    /// </Resumen>

    public interface IPA_PriorizaUpdateEstadoPrio
        {
        List<PA_PriorizaUpdateEstadoPrio> GetPA_PriorizaUpdateEstadoPrio(int? id_Sede, int? id_Vigencia, int? ID_TipoEstadoPriorizacion, string? auditoria);

        }
    }
