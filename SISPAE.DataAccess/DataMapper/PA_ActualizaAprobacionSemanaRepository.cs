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
    /// Clase Abstracta para  PA_ActualizaAprobacionSemana
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_ActualizaAprobacionSemanaRepository : DataObject, IPA_ActualizaAprobacionSemana
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_ActualizaAprobacionSemanaRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public PA_ActualizaAprobacionSemanaRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public List<PA_ActualizaAprobacionSemana> GetPA_ActualizaAprobacionSemana(int? ano, int? mes, int? semana, int? id_sede, int? idJornada, int? id_estado, String? auditoria)
        {
            try
            {

                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@ano", ano);
                p.Add("@mes", mes);
                p.Add("@semana", semana);
                p.Add("@id_sede", id_sede);
                p.Add("@idJornada", idJornada);
                p.Add("@id_estado", id_estado);
                p.Add("@auditoria", auditoria);

                List<PA_ActualizaAprobacionSemana> l = SqlMapper.Query<PA_ActualizaAprobacionSemana>(con, "SeguimientoRaciones.PA_ActualizaAprobacionSemana", p, commandType: CommandType.StoredProcedure).AsList();

                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetPA_ActualizaAprobacionSemana)  PA_ActualizaAprobacionSemana  ->" + ex.Message + ex);
            }
        }


        #endregion Class Methods
    }

}