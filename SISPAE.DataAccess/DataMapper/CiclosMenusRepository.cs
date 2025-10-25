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


using Dapper;

using SISPAE.DataAccess.DataInterfaces;
using SISPAE.Model;

using System.Data;
using System.Data.SqlClient;

using Z.Dapper.Plus;

using static Dapper.SqlMapper;



namespace SISPAE.DataAccess.DataMapper
    {
    /// <Resumen>
    /// Clase Abstracta para  CiclosMenus
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class CiclosMenusRepository : DataObject, ICiclosMenus
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public CiclosMenusRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public CiclosMenusRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public CiclosMenus GetById(CiclosMenus pCiclosMenus)
            {

            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pCiclosMenus.id);


                CiclosMenus o = SqlMapper.QueryFirstOrDefault<CiclosMenus>(con, "API.PA_CiclosMenusGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetById)  CiclosMenus  ->" + ex.Message);
                }
            }

        public List<CiclosMenus> GetAll()
            {
            try
                {
                List<CiclosMenus> l = SqlMapper.Query<CiclosMenus>(con, "API.PA_CiclosMenusGetAll").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAll)  CiclosMenus  ->" + ex.Message);
                }
            }

        public List<CiclosMenus> GetAllFull()
            {
            try
                {
                List<CiclosMenus> l = SqlMapper.Query<CiclosMenus>(con, "API.PA_CiclosMenusGetAllFull").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllFull)  CiclosMenus  ->" + ex.Message);
                }
            }

        public List<CiclosMenus> GetAllByWithRelation()
            {
            try
                {
                List<CiclosMenus> l = SqlMapper.Query<CiclosMenus>(con, "API.PA_CiclosMenusGetAllWithRelation").AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetAllByWithRelation)  CiclosMenus  ->" + ex.Message);
                }
            }




        public List<CiclosMenus> GetByFilter(CiclosMenus pCiclosMenus, int pageSize, int Page, string OrderByC)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", (pCiclosMenus.id == null || pCiclosMenus.id == 0) ? vintNUll : pCiclosMenus.id);
                p.Add("@ID_ETC", (pCiclosMenus.ID_ETC == null || pCiclosMenus.ID_ETC == 0) ? vintNUll : pCiclosMenus.ID_ETC);
                p.Add("@ID_TipoModeloOperacion", (pCiclosMenus.ID_TipoModeloOperacion == null || pCiclosMenus.ID_TipoModeloOperacion == 0) ? vintNUll : pCiclosMenus.ID_TipoModeloOperacion);
                p.Add("@ID_TipoComplemento", (pCiclosMenus.ID_TipoComplemento == null || pCiclosMenus.ID_TipoComplemento == 0) ? vintNUll : pCiclosMenus.ID_TipoComplemento);
                p.Add("@ID_TipoModalidadComplemento", (pCiclosMenus.ID_TipoModalidadComplemento == null || pCiclosMenus.ID_TipoModalidadComplemento == 0) ? vintNUll : pCiclosMenus.ID_TipoModalidadComplemento);
                p.Add("@ID_MinutaAprobacion", (pCiclosMenus.ID_MinutaAprobacion == null || pCiclosMenus.ID_MinutaAprobacion == 0) ? vintNUll : pCiclosMenus.ID_MinutaAprobacion);
                p.Add("@ID_CiclosMenuReferencia", (pCiclosMenus.ID_CiclosMenuReferencia == null || pCiclosMenus.ID_CiclosMenuReferencia == 0) ? vintNUll : pCiclosMenus.ID_CiclosMenuReferencia);
                p.Add("@ID_TipoNivelEducativo", (pCiclosMenus.ID_TipoNivelEducativo == null || pCiclosMenus.ID_TipoNivelEducativo == 0) ? vintNUll : pCiclosMenus.ID_TipoNivelEducativo);
                p.Add("@ID_Zona", (pCiclosMenus.ID_Zona == null || pCiclosMenus.ID_Zona == 0) ? vintNUll : pCiclosMenus.ID_Zona);
                p.Add("@ID_EstadoRegistro", (pCiclosMenus.ID_EstadoRegistro == null || pCiclosMenus.ID_EstadoRegistro == 0) ? vintNUll : pCiclosMenus.ID_EstadoRegistro);
                p.Add("@Nombre", (pCiclosMenus.Nombre == null) ? vintNUll : pCiclosMenus.Nombre);
                p.Add("@MenuReferencia", (pCiclosMenus.MenuReferencia == null) ? vintNUll : pCiclosMenus.MenuReferencia);
                p.Add("@MenusParaTodosNiveles", (pCiclosMenus.MenusParaTodosNiveles == null) ? vintNUll : pCiclosMenus.MenusParaTodosNiveles);
                p.Add("@MenusParaTodasZonas", (pCiclosMenus.MenusParaTodasZonas == null) ? vintNUll : pCiclosMenus.MenusParaTodasZonas);
                p.Add("@CantidadMenus", (pCiclosMenus.CantidadMenus == null) ? vintNUll : pCiclosMenus.CantidadMenus);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<CiclosMenus> l = SqlMapper.Query<CiclosMenus>(con, "API.PA_CiclosMenusGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetByFilter)  CiclosMenus  ->" + ex.Message);
                }
            }

        public CiclosMenus Add(CiclosMenus pCiclosMenus)
            {
            try
                {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pCiclosMenus.id == null ? 0 : pCiclosMenus.id);
                p.Add("@ID_ETC", pCiclosMenus.ID_ETC == null ? vintNUll : pCiclosMenus.ID_ETC);
                p.Add("@ID_TipoModeloOperacion", pCiclosMenus.ID_TipoModeloOperacion == null ? vintNUll : pCiclosMenus.ID_TipoModeloOperacion);
                p.Add("@ID_TipoComplemento", pCiclosMenus.ID_TipoComplemento == null ? vintNUll : pCiclosMenus.ID_TipoComplemento);
                p.Add("@ID_TipoModalidadComplemento", pCiclosMenus.ID_TipoModalidadComplemento == null ? vintNUll : pCiclosMenus.ID_TipoModalidadComplemento);
                p.Add("@ID_MinutaAprobacion", pCiclosMenus.ID_MinutaAprobacion == null ? vintNUll : pCiclosMenus.ID_MinutaAprobacion);
                p.Add("@ID_CiclosMenuReferencia", pCiclosMenus.ID_CiclosMenuReferencia == null ? vintNUll : pCiclosMenus.ID_CiclosMenuReferencia);
                p.Add("@ID_TipoNivelEducativo", pCiclosMenus.ID_TipoNivelEducativo == null ? vintNUll : pCiclosMenus.ID_TipoNivelEducativo);
                p.Add("@ID_Zona", pCiclosMenus.ID_Zona == null ? vintNUll : pCiclosMenus.ID_Zona);
                p.Add("@ID_EstadoRegistro", pCiclosMenus.ID_EstadoRegistro == null ? vintNUll : pCiclosMenus.ID_EstadoRegistro);
                p.Add("@Nombre", pCiclosMenus.Nombre);
                p.Add("@MenuReferencia", pCiclosMenus.MenuReferencia);
                p.Add("@MenusParaTodosNiveles", pCiclosMenus.MenusParaTodosNiveles);
                p.Add("@MenusParaTodasZonas", pCiclosMenus.MenusParaTodasZonas);
                p.Add("@CantidadMenus", pCiclosMenus.CantidadMenus);
                p.Add("@auditoria", pCiclosMenus.auditoria);




                CiclosMenus o = SqlMapper.QueryFirstOrDefault<CiclosMenus>(con, "API.PA_CiclosMenusAdd", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Add)  CiclosMenus  ->" + ex.Message);
                }
            }

        public CiclosMenus Update(CiclosMenus pCiclosMenus)
            {
            try
                {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();

                p.Add("@id", pCiclosMenus.id == null ? 0 : pCiclosMenus.id);
                p.Add("@ID_ETC", pCiclosMenus.ID_ETC == null ? vintNUll : pCiclosMenus.ID_ETC);
                p.Add("@ID_TipoModeloOperacion", pCiclosMenus.ID_TipoModeloOperacion == null ? vintNUll : pCiclosMenus.ID_TipoModeloOperacion);
                p.Add("@ID_TipoComplemento", pCiclosMenus.ID_TipoComplemento == null ? vintNUll : pCiclosMenus.ID_TipoComplemento);
                p.Add("@ID_TipoModalidadComplemento", pCiclosMenus.ID_TipoModalidadComplemento == null ? vintNUll : pCiclosMenus.ID_TipoModalidadComplemento);
                p.Add("@ID_MinutaAprobacion", pCiclosMenus.ID_MinutaAprobacion == null ? vintNUll : pCiclosMenus.ID_MinutaAprobacion);
                p.Add("@ID_CiclosMenuReferencia", pCiclosMenus.ID_CiclosMenuReferencia == null ? vintNUll : pCiclosMenus.ID_CiclosMenuReferencia);
                p.Add("@ID_TipoNivelEducativo", pCiclosMenus.ID_TipoNivelEducativo == null ? vintNUll : pCiclosMenus.ID_TipoNivelEducativo);
                p.Add("@ID_Zona", pCiclosMenus.ID_Zona == null ? vintNUll : pCiclosMenus.ID_Zona);
                p.Add("@ID_EstadoRegistro", pCiclosMenus.ID_EstadoRegistro == null ? vintNUll : pCiclosMenus.ID_EstadoRegistro);
                p.Add("@Nombre", pCiclosMenus.Nombre);
                p.Add("@MenuReferencia", pCiclosMenus.MenuReferencia);
                p.Add("@MenusParaTodosNiveles", pCiclosMenus.MenusParaTodosNiveles);
                p.Add("@MenusParaTodasZonas", pCiclosMenus.MenusParaTodasZonas);
                p.Add("@CantidadMenus", pCiclosMenus.CantidadMenus);
                p.Add("@auditoria", pCiclosMenus.auditoria);




                CiclosMenus o = SqlMapper.QueryFirstOrDefault<CiclosMenus>(con, "API.PA_CiclosMenusUpdate", p, commandType: CommandType.StoredProcedure);

                return o;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(Update)  CiclosMenus  ->" + ex.Message);
                }
            }

        public bool Delete(CiclosMenus pCiclosMenus)
            {
            try
                {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", pCiclosMenus.id);
                p.Add("@auditoria", pCiclosMenus.auditoria);





                CiclosMenus o = SqlMapper.QueryFirstOrDefault<CiclosMenus>(con, "API.PA_CiclosMenusDelete", p, commandType: CommandType.StoredProcedure);

                return true;

                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper: (Delete) CiclosMenus  ->" + ex.Message);
                }
            }





        public List<CiclosMenus> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
            try
                {
                List<CiclosMenus> CiclosMenusList = new List<CiclosMenus>();

                CiclosMenusList = SqlMapper.Query<CiclosMenus>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return CiclosMenusList;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(ExecProcedureQuery) CiclosMenus  ->" + ex.Message);
                }
            }


        public void BulkInsert(List<CiclosMenus> b)
            {
            DapperPlusManager.Entity<CiclosMenus>().Table("CiclosMenus");
            con.BulkInsert(b);
            }
        }
    #endregion Class Methods

    }