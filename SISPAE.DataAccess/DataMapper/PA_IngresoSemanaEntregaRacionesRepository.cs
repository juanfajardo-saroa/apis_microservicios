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
    /// Clase Abstracta para  PA_IngresoSemanaEntregaRaciones
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_IngresoSemanaEntregaRacionesRepository : DataObject, IPA_IngresoSemanaEntregaRaciones
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_IngresoSemanaEntregaRacionesRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public PA_IngresoSemanaEntregaRacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public List<PA_IngresoSemanaEntregaRaciones> GetPA_IngresoSemanaEntregaRaciones(int? id_contrato, DateTime? fecha, int? id_vigencia, String? auditoria)
        {
            try
            {

                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id_contrato", id_contrato);
                p.Add("@fecha", fecha);
                p.Add("@id_vigencia", id_vigencia);
                p.Add("@auditoria", auditoria);

                List<PA_IngresoSemanaEntregaRaciones> l = SqlMapper.Query<PA_IngresoSemanaEntregaRaciones>(con, "SeguimientoRaciones.PA_IngresoSemanaEntregaRaciones", p, commandType: CommandType.StoredProcedure).AsList();

                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetPA_IngresoSemanaEntregaRaciones)  PA_IngresoSemanaEntregaRaciones  ->" + ex.Message + ex);
            }
        }


        #endregion Class Methods
    }

}