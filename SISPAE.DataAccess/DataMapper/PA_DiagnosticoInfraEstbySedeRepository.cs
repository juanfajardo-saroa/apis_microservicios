    /// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:DataAccess (DataAccess Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_DAL_DataMapperBase.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SISPAE.Model;
using SISPAE.DataAccess.DataInterfaces;
using Dapper;
using static Dapper.SqlMapper;
using Z.Dapper.Plus;



namespace SISPAE.DataAccess.DataMapper
{
    /// <Resumen>
    /// Clase Abstracta para  PA_DiagnosticoInfraEst
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_DiagnosticoInfraEstbySedeRepository : DataObject, IPA_DiagnosticoInfraEstbySede
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_DiagnosticoInfraEstbySedeRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public PA_DiagnosticoInfraEstbySedeRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public List<PA_DiagnosticoInfraEstbySede> PA_DiagnosticoInfraEstbySede(int? id_Sede, int? id_Caracterizacion, String? auditoria)
        {
            try
            {

                DynamicParameters p = new DynamicParameters();

                p.Add("@id_Sede", id_Sede);
                p.Add("@id_Caracterizacion", id_Caracterizacion);
                p.Add("@auditoria", auditoria);


                List<PA_DiagnosticoInfraEstbySede> l = SqlMapper.Query<PA_DiagnosticoInfraEstbySede>(con, "Infraestructura.PA_DiagnosticoInfraEstbySede", p, commandType: CommandType.StoredProcedure).AsList();

                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(PA_DiagnosticoInfraEstbySede)  PA_DiagnosticoInfraEstbySede  ->" + ex.Message + ex);
            }
        }


        #endregion Class Methods
    }

}
