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
    /// Clase Abstracta para  AspNetRoleClaims
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class AspNetRoleClaimsRepository : DataObject, IAspNetRoleClaims
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public AspNetRoleClaimsRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public AspNetRoleClaimsRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public AspNetRoleClaims GetById(AspNetRoleClaims pAspNetRoleClaims)
        {

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", pAspNetRoleClaims.Id);


                AspNetRoleClaims o = SqlMapper.QueryFirstOrDefault<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetById)  AspNetRoleClaims  ->" + ex.Message);
            }
        }

        public List<AspNetRoleClaims> GetAll()
        {
            try
            {
                List<AspNetRoleClaims> l = SqlMapper.Query<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsGetAll").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAll)  AspNetRoleClaims  ->" + ex.Message);
            }
        }

        public List<AspNetRoleClaims> GetAllFull()
        {
            try
            {
                List<AspNetRoleClaims> l = SqlMapper.Query<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsGetAllFull").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllFull)  AspNetRoleClaims  ->" + ex.Message);
            }
        }

        public List<AspNetRoleClaims> GetAllByWithRelation()
        {
            try
            {
                List<AspNetRoleClaims> l = SqlMapper.Query<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsGetAllWithRelation").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetRoleClaims  ->" + ex.Message);
            }
        }




        public List<AspNetRoleClaims> GetByFilter(AspNetRoleClaims pAspNetRoleClaims, int pageSize, int Page, string OrderByC)
        {
            try
            {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", (pAspNetRoleClaims.Id == null || pAspNetRoleClaims.Id == 0) ? vintNUll : pAspNetRoleClaims.Id);
                p.Add("@RoleId", (pAspNetRoleClaims.RoleId == null) ? vintNUll : pAspNetRoleClaims.RoleId);
                p.Add("@ClaimType", (pAspNetRoleClaims.ClaimType == null) ? vintNUll : pAspNetRoleClaims.ClaimType);
                p.Add("@ClaimValue", (pAspNetRoleClaims.ClaimValue == null) ? vintNUll : pAspNetRoleClaims.ClaimValue);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<AspNetRoleClaims> l = SqlMapper.Query<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetByFilter)  AspNetRoleClaims  ->" + ex.Message);
            }
        }

        public AspNetRoleClaims Add(AspNetRoleClaims pAspNetRoleClaims)
        {
            try
            {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", pAspNetRoleClaims.Id == null ? 0 : pAspNetRoleClaims.Id);
                p.Add("@RoleId", pAspNetRoleClaims.RoleId);
                p.Add("@ClaimType", pAspNetRoleClaims.ClaimType);
                p.Add("@ClaimValue", pAspNetRoleClaims.ClaimValue);





                AspNetRoleClaims o = SqlMapper.QueryFirstOrDefault<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsAdd", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Add)  AspNetRoleClaims  ->" + ex.Message);
            }
        }

        public AspNetRoleClaims Update(AspNetRoleClaims pAspNetRoleClaims)
        {
            try
            {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", pAspNetRoleClaims.Id == null ? 0 : pAspNetRoleClaims.Id);
                p.Add("@RoleId", pAspNetRoleClaims.RoleId);
                p.Add("@ClaimType", pAspNetRoleClaims.ClaimType);
                p.Add("@ClaimValue", pAspNetRoleClaims.ClaimValue);





                AspNetRoleClaims o = SqlMapper.QueryFirstOrDefault<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsUpdate", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Update)  AspNetRoleClaims  ->" + ex.Message);
            }
        }

        public bool Delete(AspNetRoleClaims pAspNetRoleClaims)
        {
            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", pAspNetRoleClaims.Id);





                AspNetRoleClaims o = SqlMapper.QueryFirstOrDefault<AspNetRoleClaims>(con, "API.PA_AspNetRoleClaimsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper: (Delete) AspNetRoleClaims  ->" + ex.Message);
            }
        }





        public List<AspNetRoleClaims> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
        {
            try
            {
                List<AspNetRoleClaims> AspNetRoleClaimsList = new List<AspNetRoleClaims>();

                AspNetRoleClaimsList = SqlMapper.Query<AspNetRoleClaims>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return AspNetRoleClaimsList;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(ExecProcedureQuery) AspNetRoleClaims  ->" + ex.Message);
            }
        }


        public void BulkInsert(List<AspNetRoleClaims> b)
        {
            DapperPlusManager.Entity<AspNetRoleClaims>().Table("AspNetRoleClaims");
            con.BulkInsert(b);
        }
    }
    #endregion Class Methods

}