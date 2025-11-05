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
    /// Clase Abstracta para  ValorCaracteristicas
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class ValorCaracteristicasRepository : DataObject, IValorCaracteristicas
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public ValorCaracteristicasRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public ValorCaracteristicasRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public ValorCaracteristicas GetById(ValorCaracteristicas pValorCaracteristicas)
            {

            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pValorCaracteristicas.id);


                ValorCaracteristicas o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetById)  ValorCaracteristicas  ->" + ex.Message);
                }
            }

        public List<ValorCaracteristicas> GetAll()
            {
            try
                {
                List<ValorCaracteristicas> l = SqlMapper.Query<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasGetAll").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  ValorCaracteristicas  ->" + ex.Message);
                }
            }

        public List<ValorCaracteristicas> GetAllFull()
            {
            try
                {
                List<ValorCaracteristicas> l = SqlMapper.Query<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasGetAllFull").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllFull)  ValorCaracteristicas  ->" + ex.Message);
                }
            }

        public List<ValorCaracteristicas> GetAllByWithRelation()
            {
            try
                {
                List<ValorCaracteristicas> l = SqlMapper.Query<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasGetAllWithRelation").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllByWithRelation)  ValorCaracteristicas  ->" + ex.Message);
                }
            }




        public List<ValorCaracteristicas> GetByFilter(ValorCaracteristicas pValorCaracteristicas, int pageSize, int Page, string OrderByC)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", (pValorCaracteristicas.id == null || pValorCaracteristicas.id == 0) ? vintNUll : pValorCaracteristicas.id);
                p.Add("@ID_Caracterizacion", (pValorCaracteristicas.ID_Caracterizacion == null || pValorCaracteristicas.ID_Caracterizacion == 0) ? vintNUll : pValorCaracteristicas.ID_Caracterizacion);
                p.Add("@ID_ValorEscala", (pValorCaracteristicas.ID_ValorEscala == null || pValorCaracteristicas.ID_ValorEscala == 0) ? vintNUll : pValorCaracteristicas.ID_ValorEscala);
                p.Add("@ID_Caracteristica", (pValorCaracteristicas.ID_Caracteristica == null || pValorCaracteristicas.ID_Caracteristica == 0) ? vintNUll : pValorCaracteristicas.ID_Caracteristica);
                p.Add("@Valor", pValorCaracteristicas.Valor == 0 ? vintNUll : pValorCaracteristicas.Valor);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<ValorCaracteristicas> l = SqlMapper.Query<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetByFilter)  ValorCaracteristicas  ->" + ex.Message);
                }
            }

        public ValorCaracteristicas Add(ValorCaracteristicas pValorCaracteristicas)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pValorCaracteristicas.id == null ? 0 : pValorCaracteristicas.id);
                p.Add("@ID_Caracterizacion", pValorCaracteristicas.ID_Caracterizacion == null ? 0 : pValorCaracteristicas.ID_Caracterizacion);
                p.Add("@ID_ValorEscala", pValorCaracteristicas.ID_ValorEscala == null ? 0 : pValorCaracteristicas.ID_ValorEscala);
                p.Add("@ID_Caracteristica", pValorCaracteristicas.ID_Caracteristica == null ? 0 : pValorCaracteristicas.ID_Caracteristica);
                p.Add("@Valor", pValorCaracteristicas.Valor == null ? 0 : pValorCaracteristicas.Valor);
                p.Add("@auditoria", pValorCaracteristicas.auditoria);

                ValorCaracteristicas o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicas>(con, "Infraestructura.PA_ValorCaracteristicasAdd", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Add)  ValorCaracteristicas  ->" + ex.Message);
                }
            }

        public ValorCaracteristicas Update(ValorCaracteristicas pValorCaracteristicas)
            {
            try
                {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pValorCaracteristicas.id == null ? 0 : pValorCaracteristicas.id);
                p.Add("@ID_Caracterizacion", pValorCaracteristicas.ID_Caracterizacion == null ? 0 : pValorCaracteristicas.ID_Caracterizacion);
                p.Add("@ID_ValorEscala", pValorCaracteristicas.ID_ValorEscala == null ? 0 : pValorCaracteristicas.ID_ValorEscala);
                p.Add("@ID_Caracteristica", pValorCaracteristicas.ID_Caracteristica == null ? 0 : pValorCaracteristicas.ID_Caracteristica);
                p.Add("@Valor", pValorCaracteristicas.Valor == null ? 0 : pValorCaracteristicas.Valor);
                p.Add("@auditoria", pValorCaracteristicas.auditoria);




                ValorCaracteristicas o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasUpdate", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Update)  ValorCaracteristicas  ->" + ex.Message);
                }
            }

        public bool Delete(ValorCaracteristicas pValorCaracteristicas)
            {
            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pValorCaracteristicas.id);
                p.Add("@auditoria", pValorCaracteristicas.auditoria);





                ValorCaracteristicas o = SqlMapper.QueryFirstOrDefault<ValorCaracteristicas>(con, "API.PA_ValorCaracteristicasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper: (Delete) ValorCaracteristicas  ->" + ex.Message);
                }
            }





        public List<ValorCaracteristicas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
            try
                {
                List<ValorCaracteristicas> ValorCaracteristicasList = new List<ValorCaracteristicas>();

                ValorCaracteristicasList = SqlMapper.Query<ValorCaracteristicas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return ValorCaracteristicasList;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(ExecProcedureQuery) ValorCaracteristicas  ->" + ex.Message);
                }
            }


        public void BulkInsert(List<ValorCaracteristicas> b)
            {
            DapperPlusManager.Entity<ValorCaracteristicas>().Table("ValorCaracteristicas");
            con.BulkInsert(b);
            }
        }
    #endregion Class Methods

    }