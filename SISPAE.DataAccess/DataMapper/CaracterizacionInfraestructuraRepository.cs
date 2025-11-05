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
    /// Clase Abstracta para  CaracterizacionInfraestructura
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class CaracterizacionInfraestructuraRepository : DataObject, ICaracterizacionInfraestructura
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public CaracterizacionInfraestructuraRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public CaracterizacionInfraestructuraRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public CaracterizacionInfraestructura GetById(CaracterizacionInfraestructura pCaracterizacionInfraestructura)
            {

            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pCaracterizacionInfraestructura.id);


                CaracterizacionInfraestructura o = SqlMapper.QueryFirstOrDefault<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetById)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }

        public List<CaracterizacionInfraestructura> GetAll()
            {
            try
                {
                List<CaracterizacionInfraestructura> l = SqlMapper.Query<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraGetAll").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }

        public List<CaracterizacionInfraestructura> GetAllFull()
            {
            try
                {
                List<CaracterizacionInfraestructura> l = SqlMapper.Query<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraGetAllFull").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllFull)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }

        public List<CaracterizacionInfraestructura> GetAllByWithRelation()
            {
            try
                {
                List<CaracterizacionInfraestructura> l = SqlMapper.Query<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraGetAllWithRelation").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllByWithRelation)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }




        public List<CaracterizacionInfraestructura> GetByFilter(CaracterizacionInfraestructura pCaracterizacionInfraestructura, int pageSize, int Page, string OrderByC)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", (pCaracterizacionInfraestructura.id == null || pCaracterizacionInfraestructura.id == 0) ? vintNUll : pCaracterizacionInfraestructura.id);
                p.Add("@ID_Sede", (pCaracterizacionInfraestructura.ID_Sede == null || pCaracterizacionInfraestructura.ID_Sede == 0) ? vintNUll : pCaracterizacionInfraestructura.ID_Sede);
                p.Add("@ID_Inventario", (pCaracterizacionInfraestructura.ID_Inventario == null || pCaracterizacionInfraestructura.ID_Inventario == 0) ? vintNUll : pCaracterizacionInfraestructura.ID_Inventario);
                p.Add("@FechaCaracterizacion", pCaracterizacionInfraestructura.FechaCaracterizacion);
                p.Add("@FechaModificacion", pCaracterizacionInfraestructura.FechaModificacion);
                p.Add("@Descripcion", pCaracterizacionInfraestructura.Descripcion);
                p.Add("@CHS_Fecha", pCaracterizacionInfraestructura.CHS_Fecha);
                p.Add("@CHS_Documento", pCaracterizacionInfraestructura.CHS_Documento);
                p.Add("@RutaArchivo", pCaracterizacionInfraestructura.RutaArchivo);
                p.Add("@SuficienciaDotacion", pCaracterizacionInfraestructura.SuficienciaDotacion);
                p.Add("@Id_TipoEstadoCaracterizacion", (pCaracterizacionInfraestructura.Id_TipoEstadoCaracterizacion == null || pCaracterizacionInfraestructura.Id_TipoEstadoCaracterizacion == 0) ? vintNUll : pCaracterizacionInfraestructura.Id_TipoEstadoCaracterizacion);
                p.Add("@id_TipoModalidadComplementoSugerida", pCaracterizacionInfraestructura.id_TipoModalidadComplementoSugerida);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<CaracterizacionInfraestructura> l = SqlMapper.Query<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetByFilter)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }

        public CaracterizacionInfraestructura Add(CaracterizacionInfraestructura pCaracterizacionInfraestructura)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pCaracterizacionInfraestructura.id == null ? 0 : pCaracterizacionInfraestructura.id);
                p.Add("@ID_Sede", pCaracterizacionInfraestructura.ID_Sede == null ? 0 : pCaracterizacionInfraestructura.ID_Sede);
                p.Add("@ID_Inventario", pCaracterizacionInfraestructura.ID_Inventario);
                p.Add("@FechaCaracterizacion", pCaracterizacionInfraestructura.FechaCaracterizacion);
                p.Add("@FechaModificacion", pCaracterizacionInfraestructura.FechaModificacion);
                p.Add("@Descripcion", pCaracterizacionInfraestructura.Descripcion);
                p.Add("@CHS_Fecha", pCaracterizacionInfraestructura.CHS_Fecha);
                p.Add("@CHS_Documento", pCaracterizacionInfraestructura.CHS_Documento);
                p.Add("@RutaArchivo", pCaracterizacionInfraestructura.RutaArchivo);
                p.Add("@SuficienciaDotacion", pCaracterizacionInfraestructura.SuficienciaDotacion);
                p.Add("@Id_TipoEstadoCaracterizacion", pCaracterizacionInfraestructura.Id_TipoEstadoCaracterizacion);
                p.Add("@id_TipoModalidadComplementoSugerida", pCaracterizacionInfraestructura.id_TipoModalidadComplementoSugerida);

                p.Add("@auditoria", pCaracterizacionInfraestructura.auditoria);


                CaracterizacionInfraestructura o = SqlMapper.QueryFirstOrDefault<CaracterizacionInfraestructura>(con, "Infraestructura.PA_CaracterizacionInfraestructuraAdd", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Add)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }

        public CaracterizacionInfraestructura Update(CaracterizacionInfraestructura pCaracterizacionInfraestructura)
            {
            try
                {
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pCaracterizacionInfraestructura.id == null ? 0 : pCaracterizacionInfraestructura.id);
                p.Add("@ID_Sede", pCaracterizacionInfraestructura.ID_Sede == null ? 0 : pCaracterizacionInfraestructura.ID_Sede);
                p.Add("@ID_Inventario", pCaracterizacionInfraestructura.ID_Inventario);
                p.Add("@FechaCaracterizacion", pCaracterizacionInfraestructura.FechaCaracterizacion);
                p.Add("@FechaModificacion", pCaracterizacionInfraestructura.FechaModificacion);
                p.Add("@Descripcion", pCaracterizacionInfraestructura.Descripcion);
                p.Add("@CHS_Fecha", pCaracterizacionInfraestructura.CHS_Fecha);
                p.Add("@CHS_Documento", pCaracterizacionInfraestructura.CHS_Documento, DbType.Binary, ParameterDirection.Input, -1);
                p.Add("@RutaArchivo", pCaracterizacionInfraestructura.RutaArchivo);
                p.Add("@SuficienciaDotacion", pCaracterizacionInfraestructura.SuficienciaDotacion);
                p.Add("@Id_TipoEstadoCaracterizacion", pCaracterizacionInfraestructura.Id_TipoEstadoCaracterizacion == null ? 0 : pCaracterizacionInfraestructura.Id_TipoEstadoCaracterizacion);
                p.Add("@id_TipoModalidadComplementoSugerida", pCaracterizacionInfraestructura.id_TipoModalidadComplementoSugerida);
                p.Add("@auditoria", pCaracterizacionInfraestructura.auditoria);

                var x = SqlMapper.Query(con, "API.PA_CaracterizacionInfraestructuraUpdate", p, commandType: CommandType.StoredProcedure).SingleOrDefault();


                DynamicParameters p1 = new DynamicParameters();
                p1.Add("@id", pCaracterizacionInfraestructura.id);


                CaracterizacionInfraestructura o = SqlMapper.QueryFirstOrDefault<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraGetByKey", p1, commandType: CommandType.StoredProcedure);
                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Update)  CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }

        public bool Delete(CaracterizacionInfraestructura pCaracterizacionInfraestructura)
            {
            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pCaracterizacionInfraestructura.id);
                p.Add("@auditoria", pCaracterizacionInfraestructura.auditoria);


                CaracterizacionInfraestructura o = SqlMapper.QueryFirstOrDefault<CaracterizacionInfraestructura>(con, "API.PA_CaracterizacionInfraestructuraDelete", p, commandType: CommandType.StoredProcedure);

                return true;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper: (Delete) CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }





        public List<CaracterizacionInfraestructura> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
            try
                {
                List<CaracterizacionInfraestructura> CaracterizacionInfraestructuraList = new List<CaracterizacionInfraestructura>();

                CaracterizacionInfraestructuraList = SqlMapper.Query<CaracterizacionInfraestructura>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return CaracterizacionInfraestructuraList;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(ExecProcedureQuery) CaracterizacionInfraestructura  ->" + ex.Message);
                }
            }


        public void BulkInsert(List<CaracterizacionInfraestructura> b)
            {
            DapperPlusManager.Entity<CaracterizacionInfraestructura>().Table("CaracterizacionInfraestructura");
            con.BulkInsert(b);
            }
        }
    #endregion Class Methods

    }