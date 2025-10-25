/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using SISPAE.Model;
using SISPAE.DataAccess;
using SISPAE.DataAccess.DataMapper;
using System.Data.SqlClient;
using SISPAE.Common;


namespace SISPAE.Business
/// <Resumen>
/// Clase del Business  para  PA_DiagnosticoInfraEst
/// 
/// </Resumen>
{



    #region Metodos de negocio


    public partial class PA_DiagnosticoInfraEstbySedeMs
    {

        #region Implementacion Metodos


        public List<PA_DiagnosticoInfraEstbySede> GetPA_DiagnosticoInfraEstbySede(int? id_Sede, int? id_Caracterizacion, String? auditoria)
        {
            var returnedEntities = new List<PA_DiagnosticoInfraEstbySede>();

            try
            {
                using (var repository = new PA_DiagnosticoInfraEstbySedeRepository())
                {
                    foreach (var entity in repository.PA_DiagnosticoInfraEstbySede(id_Sede, id_Caracterizacion,auditoria))
                    {
                        returnedEntities.Add(entity);
                    }
                }

                return returnedEntities;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:PA_DiagnosticoInfraEstBusiness::GetPA_DiagnosticoInfraEst::Error occured.", ex);
            }
        }











        #endregion Implementacion Metodos


    }
    #endregion Metodos de Negocio

}