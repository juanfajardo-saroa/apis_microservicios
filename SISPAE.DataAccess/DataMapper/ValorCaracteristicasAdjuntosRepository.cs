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
    /// Clase Abstracta para  ValorCaracteristicasAdjuntos
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class ValorCaracteristicasAdjuntosRepository : DataObject, IValorCaracteristicasAdjuntos
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public ValorCaracteristicasAdjuntosRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public ValorCaracteristicasAdjuntosRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public ValorCaracteristicasAdjuntos GetById(ValorCaracteristicasAdjuntos pValorCaracteristicasAdjuntos)
            {

            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pValorCaracteristicasAdjuntos.id);


                ValorCaracteristicasAdjuntos o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetById)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }

        public List<ValorCaracteristicasAdjuntos> GetAll()
            {
            try
                {
                List<ValorCaracteristicasAdjuntos> l = SqlMapper.Query<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosGetAll").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }

        public List<ValorCaracteristicasAdjuntos> GetAllFull()
            {
            try
                {
                List<ValorCaracteristicasAdjuntos> l = SqlMapper.Query<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosGetAllFull").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllFull)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }

        public List<ValorCaracteristicasAdjuntos> GetAllByWithRelation()
            {
            try
                {
                List<ValorCaracteristicasAdjuntos> l = SqlMapper.Query<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosGetAllWithRelation").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllByWithRelation)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }




        public List<ValorCaracteristicasAdjuntos> GetByFilter(ValorCaracteristicasAdjuntos pValorCaracteristicasAdjuntos, int pageSize, int Page, string OrderByC)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", (pValorCaracteristicasAdjuntos.id == null || pValorCaracteristicasAdjuntos.id == 0) ? vintNUll : pValorCaracteristicasAdjuntos.id);
                p.Add("@id_ValorCaracteristicas", (pValorCaracteristicasAdjuntos.id_ValorCaracteristicas == null || pValorCaracteristicasAdjuntos.id_ValorCaracteristicas == 0) ? vintNUll : pValorCaracteristicasAdjuntos.id_ValorCaracteristicas);
                p.Add("@Adjunto", pValorCaracteristicasAdjuntos.Adjunto);
                p.Add("@Fecha", pValorCaracteristicasAdjuntos.Fecha);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<ValorCaracteristicasAdjuntos> l = SqlMapper.Query<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetByFilter)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }

        public ValorCaracteristicasAdjuntos Add(ValorCaracteristicasAdjuntos pValorCaracteristicasAdjuntos)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pValorCaracteristicasAdjuntos.id == null ? 0 : pValorCaracteristicasAdjuntos.id);
                p.Add("@id_ValorCaracteristicas", pValorCaracteristicasAdjuntos.id_ValorCaracteristicas == null ? 0 : pValorCaracteristicasAdjuntos.id_ValorCaracteristicas);
                p.Add("@Adjunto", pValorCaracteristicasAdjuntos.Adjunto);
                p.Add("@Fecha", pValorCaracteristicasAdjuntos.Fecha);
                p.Add("@auditoria", pValorCaracteristicasAdjuntos.auditoria);

                ValorCaracteristicasAdjuntos o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasAdjuntos>(con, "Infraestructura.PA_ValorCaracteristicasAdjuntosAdd", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Add)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }

        public ValorCaracteristicasAdjuntos Update(ValorCaracteristicasAdjuntos pValorCaracteristicasAdjuntos)
            {
            try
                {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pValorCaracteristicasAdjuntos.id == null ? 0 : pValorCaracteristicasAdjuntos.id);
                p.Add("@id_ValorCaracteristicas", pValorCaracteristicasAdjuntos.id_ValorCaracteristicas == null ? 0 : pValorCaracteristicasAdjuntos.id_ValorCaracteristicas);
                p.Add("@Adjunto", pValorCaracteristicasAdjuntos.Adjunto);
                p.Add("@Fecha", pValorCaracteristicasAdjuntos.Fecha);
                p.Add("@auditoria", pValorCaracteristicasAdjuntos.auditoria);




                ValorCaracteristicasAdjuntos o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosUpdate", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Update)  ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }

        public bool Delete(ValorCaracteristicasAdjuntos pValorCaracteristicasAdjuntos)
            {
            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pValorCaracteristicasAdjuntos.id);
                p.Add("@auditoria", pValorCaracteristicasAdjuntos.auditoria);





                ValorCaracteristicasAdjuntos o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicasAdjuntos>(con, "API.PA_ValorCaracteristicasAdjuntosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper: (Delete) ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }





        public List<ValorCaracteristicasAdjuntos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
            try
                {
                List<ValorCaracteristicasAdjuntos> ValorCaracteristicasAdjuntosList = new List<ValorCaracteristicasAdjuntos>();

                ValorCaracteristicasAdjuntosList = SqlMapper.Query<ValorCaracteristicasAdjuntos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return ValorCaracteristicasAdjuntosList;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(ExecProcedureQuery) ValorCaracteristicasAdjuntos  ->" + ex.Message);
                }
            }


        public void BulkInsert(List<ValorCaracteristicasAdjuntos> b)
            {
            DapperPlusManager.Entity<ValorCaracteristicasAdjuntos>().Table("ValorCaracteristicasAdjuntos");
            con.BulkInsert(b);
            }
        }
    #endregion Class Methods

    }