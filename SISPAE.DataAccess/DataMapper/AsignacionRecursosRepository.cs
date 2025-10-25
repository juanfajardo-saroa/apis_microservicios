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
    /// Clase Abstracta para  AsignacionRecursos
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class AsignacionRecursosRepository : DataObject, IAsignacionRecursos
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public AsignacionRecursosRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public AsignacionRecursosRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public AsignacionRecursos GetById(AsignacionRecursos pAsignacionRecursos)
        {

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", pAsignacionRecursos.Id);


                AsignacionRecursos o = SqlMapper.QueryFirstOrDefault<AsignacionRecursos>(con, "API.PA_AsignacionRecursosGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetById)  AsignacionRecursos  ->" + ex.Message);
            }
        }

        public List<AsignacionRecursos> GetAll()
        {
            try
            {
                List<AsignacionRecursos> l = SqlMapper.Query<AsignacionRecursos>(con, "API.PA_AsignacionRecursosGetAll").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAll)  AsignacionRecursos  ->" + ex.Message);
            }
        }

        public List<AsignacionRecursos> GetAllFull()
        {
            try
            {
                List<AsignacionRecursos> l = SqlMapper.Query<AsignacionRecursos>(con, "API.PA_AsignacionRecursosGetAllFull").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllFull)  AsignacionRecursos  ->" + ex.Message);
            }
        }

        public List<AsignacionRecursos> GetAllByWithRelation()
        {
            try
            {
                List<AsignacionRecursos> l = SqlMapper.Query<AsignacionRecursos>(con, "API.PA_AsignacionRecursosGetAllWithRelation").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllByWithRelation)  AsignacionRecursos  ->" + ex.Message);
            }
        }




        public List<AsignacionRecursos> GetByFilter(AsignacionRecursos pAsignacionRecursos, int pageSize, int Page, string OrderByC)
        {
            try
            {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", (pAsignacionRecursos.Id == null || pAsignacionRecursos.Id == 0) ? vintNUll : pAsignacionRecursos.Id);
                p.Add("@ID_FuenteFinanciacion", (pAsignacionRecursos.ID_FuenteFinanciacion == null || pAsignacionRecursos.ID_FuenteFinanciacion == 0) ? vintNUll : pAsignacionRecursos.ID_FuenteFinanciacion);
                p.Add("@ID_FuenteIngreso", (pAsignacionRecursos.ID_FuenteIngreso == null || pAsignacionRecursos.ID_FuenteIngreso == 0) ? vintNUll : pAsignacionRecursos.ID_FuenteIngreso);
                p.Add("@NombreResolucion", (pAsignacionRecursos.NombreResolucion == null) ? vintNUll : pAsignacionRecursos.NombreResolucion);
                p.Add("@ValorPresupuestal", (pAsignacionRecursos.ValorPresupuestal == null) ? vintNUll : pAsignacionRecursos.ValorPresupuestal);
                p.Add("@ArchivoResolucion", (pAsignacionRecursos.ArchivoResolucion == null) ? vintNUll : pAsignacionRecursos.ArchivoResolucion);
                p.Add("@ID_EstadoResolucion", (pAsignacionRecursos.ID_EstadoResolucion == null || pAsignacionRecursos.ID_EstadoResolucion == 0) ? vintNUll : pAsignacionRecursos.ID_EstadoResolucion);
                p.Add("@Vigencia", (pAsignacionRecursos.Vigencia == null) ? vintNUll : pAsignacionRecursos.Vigencia);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<AsignacionRecursos> l = SqlMapper.Query<AsignacionRecursos>(con, "API.PA_AsignacionRecursosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetByFilter)  AsignacionRecursos  ->" + ex.Message);
            }
        }

        public AsignacionRecursos Add(AsignacionRecursos pAsignacionRecursos)
        {
            try
            {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", pAsignacionRecursos.Id == null ? 0 : pAsignacionRecursos.Id);
                p.Add("@ID_FuenteFinanciacion", pAsignacionRecursos.ID_FuenteFinanciacion == null ? 0 : pAsignacionRecursos.ID_FuenteFinanciacion);
                p.Add("@ID_FuenteIngreso", pAsignacionRecursos.ID_FuenteIngreso == null ? 0 : pAsignacionRecursos.ID_FuenteIngreso);
                p.Add("@NombreResolucion", pAsignacionRecursos.NombreResolucion);
                p.Add("@ValorPresupuestal", pAsignacionRecursos.ValorPresupuestal);
                p.Add("@ArchivoResolucion", pAsignacionRecursos.ArchivoResolucion);
                p.Add("@ID_EstadoResolucion", pAsignacionRecursos.ID_EstadoResolucion == null ? 0 : pAsignacionRecursos.ID_EstadoResolucion);
                p.Add("@Vigencia", pAsignacionRecursos.Vigencia == null ? 0 : pAsignacionRecursos.Vigencia);




                AsignacionRecursos o = SqlMapper.QueryFirstOrDefault<AsignacionRecursos>(con, "API.PA_AsignacionRecursosAdd", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Add)  AsignacionRecursos  ->" + ex.Message);
            }
        }

        public AsignacionRecursos Update(AsignacionRecursos pAsignacionRecursos)
        {
            try
            {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", pAsignacionRecursos.Id == null ? 0 : pAsignacionRecursos.Id);
                p.Add("@ID_FuenteFinanciacion", pAsignacionRecursos.ID_FuenteFinanciacion == null ? 0 : pAsignacionRecursos.ID_FuenteFinanciacion);
                p.Add("@ID_FuenteIngreso", pAsignacionRecursos.ID_FuenteIngreso == null ? 0 : pAsignacionRecursos.ID_FuenteIngreso);
                p.Add("@NombreResolucion", pAsignacionRecursos.NombreResolucion);
                p.Add("@ValorPresupuestal", pAsignacionRecursos.ValorPresupuestal);
                p.Add("@ArchivoResolucion", pAsignacionRecursos.ArchivoResolucion);
                p.Add("@ID_EstadoResolucion", pAsignacionRecursos.ID_EstadoResolucion == null ? 0 : pAsignacionRecursos.ID_EstadoResolucion);
                p.Add("@Vigencia", pAsignacionRecursos.Vigencia == null ? 0 : pAsignacionRecursos.Vigencia);



                AsignacionRecursos o = SqlMapper.QueryFirstOrDefault<AsignacionRecursos>(con, "API.PA_AsignacionRecursosUpdate", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Update)  AsignacionRecursos  ->" + ex.Message);
            }
        }

        public bool Delete(AsignacionRecursos pAsignacionRecursos)
        {
            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", pAsignacionRecursos.Id);




                AsignacionRecursos o = SqlMapper.QueryFirstOrDefault<AsignacionRecursos>(con, "API.PA_AsignacionRecursosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper: (Delete) AsignacionRecursos  ->" + ex.Message);
            }
        }





        public List<AsignacionRecursos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
        {
            try
            {
                List<AsignacionRecursos> AsignacionRecursosList = new List<AsignacionRecursos>();

                AsignacionRecursosList = SqlMapper.Query<AsignacionRecursos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return AsignacionRecursosList;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(ExecProcedureQuery) AsignacionRecursos  ->" + ex.Message);
            }
        }


        public void BulkInsert(List<AsignacionRecursos> b)
        {
            DapperPlusManager.Entity<AsignacionRecursos>().Table("AsignacionRecursos");
            con.BulkInsert(b);
        }
    }
    #endregion Class Methods

}