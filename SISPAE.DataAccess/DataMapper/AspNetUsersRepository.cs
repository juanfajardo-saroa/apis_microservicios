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
    /// Clase Abstracta para  AspNetUsers
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class AspNetUsersRepository : DataObject, IAspNetUsers
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public AspNetUsersRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public AspNetUsersRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public AspNetUsers GetById(AspNetUsers pAspNetUsers)
        {

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", pAspNetUsers.Id);


                AspNetUsers o = SqlMapper.QueryFirstOrDefault<AspNetUsers>(con, "API.PA_AspNetUsersGetByKey", p, commandType: CommandType.StoredProcedure);
                return o;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetById)  AspNetUsers  ->" + ex.Message);
            }
        }

        public List<AspNetUsers> GetAll()
        {
            try
            {
                List<AspNetUsers> l = SqlMapper.Query<AspNetUsers>(con, "API.PA_AspNetUsersGetAll").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAll)  AspNetUsers  ->" + ex.Message);
            }
        }

        public List<AspNetUsers> GetAllFull()
        {
            try
            {
                List<AspNetUsers> l = SqlMapper.Query<AspNetUsers>(con, "API.PA_AspNetUsersGetAllFull").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllFull)  AspNetUsers  ->" + ex.Message);
            }
        }

        public List<AspNetUsers> GetAllByWithRelation()
        {
            try
            {
                List<AspNetUsers> l = SqlMapper.Query<AspNetUsers>(con, "API.PA_AspNetUsersGetAllWithRelation").AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetAllByWithRelation)  AspNetUsers  ->" + ex.Message);
            }
        }




        public List<AspNetUsers> GetByFilter(AspNetUsers pAspNetUsers, int pageSize, int Page, string OrderByC)
        {
            try
            {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", (pAspNetUsers.Id == null) ? vintNUll : pAspNetUsers.Id);
                p.Add("@UserName", (pAspNetUsers.UserName == null) ? vintNUll : pAspNetUsers.UserName);
                p.Add("@NormalizedUserName", (pAspNetUsers.NormalizedUserName == null) ? vintNUll : pAspNetUsers.NormalizedUserName);
                p.Add("@Email", (pAspNetUsers.Email == null) ? vintNUll : pAspNetUsers.Email);
                p.Add("@NormalizedEmail", (pAspNetUsers.NormalizedEmail == null) ? vintNUll : pAspNetUsers.NormalizedEmail);
                p.Add("@EmailConfirmed", (pAspNetUsers.EmailConfirmed == null) ? vintNUll : pAspNetUsers.EmailConfirmed);
                p.Add("@PasswordHash", (pAspNetUsers.PasswordHash == null) ? vintNUll : pAspNetUsers.PasswordHash);
                p.Add("@SecurityStamp", (pAspNetUsers.SecurityStamp == null) ? vintNUll : pAspNetUsers.SecurityStamp);
                p.Add("@ConcurrencyStamp", (pAspNetUsers.ConcurrencyStamp == null) ? vintNUll : pAspNetUsers.ConcurrencyStamp);
                p.Add("@PhoneNumber", (pAspNetUsers.PhoneNumber == null) ? vintNUll : pAspNetUsers.PhoneNumber);
                p.Add("@PhoneNumberConfirmed", (pAspNetUsers.PhoneNumberConfirmed == null) ? vintNUll : pAspNetUsers.PhoneNumberConfirmed);
                p.Add("@TwoFactorEnabled", (pAspNetUsers.TwoFactorEnabled == null) ? vintNUll : pAspNetUsers.TwoFactorEnabled);
                p.Add("@LockoutEnd", (pAspNetUsers.LockoutEnd == null) ? vintNUll : pAspNetUsers.LockoutEnd);
                p.Add("@LockoutEnabled", (pAspNetUsers.LockoutEnabled == null) ? vintNUll : pAspNetUsers.LockoutEnabled);
                p.Add("@AccessFailedCount", (pAspNetUsers.AccessFailedCount == null) ? vintNUll : pAspNetUsers.AccessFailedCount);
                p.Add("@PrimerNombre", (pAspNetUsers.PrimerNombre == null) ? vintNUll : pAspNetUsers.PrimerNombre);
                p.Add("@SegundoNombre", (pAspNetUsers.SegundoNombre == null) ? vintNUll : pAspNetUsers.SegundoNombre);
                p.Add("@PrimerApellido", (pAspNetUsers.PrimerApellido == null) ? vintNUll : pAspNetUsers.PrimerApellido);
                p.Add("@SegundoApellido", (pAspNetUsers.SegundoApellido == null) ? vintNUll : pAspNetUsers.SegundoApellido);
                p.Add("@Cargo", (pAspNetUsers.Cargo == null) ? vintNUll : pAspNetUsers.Cargo);
                p.Add("@RespuestaSeguridad", (pAspNetUsers.RespuestaSeguridad == null) ? vintNUll : pAspNetUsers.RespuestaSeguridad);
                p.Add("@UsuarioAD", (pAspNetUsers.UsuarioAD == null) ? vintNUll : pAspNetUsers.UsuarioAD);
                p.Add("@GUID", (pAspNetUsers.GUID == null) ? vintNUll : pAspNetUsers.GUID);
                p.Add("@PhotoPath", (pAspNetUsers.PhotoPath == null) ? vintNUll : pAspNetUsers.PhotoPath);
                p.Add("@FechaCreacion", (pAspNetUsers.FechaCreacion == null) ? vintNUll : pAspNetUsers.FechaCreacion);
                p.Add("@id_Ubicacion", (pAspNetUsers.id_Ubicacion == null || pAspNetUsers.id_Ubicacion == 0) ? vintNUll : pAspNetUsers.id_Ubicacion);
                p.Add("@UbicacionBase", (pAspNetUsers.UbicacionBase == null) ? vintNUll : pAspNetUsers.UbicacionBase);
                p.Add("@id_TipoActor", (pAspNetUsers.id_TipoActor == null || pAspNetUsers.id_TipoActor == 0) ? vintNUll : pAspNetUsers.id_TipoActor);
                p.Add("@DocumentoIden", (pAspNetUsers.DocumentoIden == null) ? vintNUll : pAspNetUsers.DocumentoIden);
                p.Add("@id_TipoDocumentoIden", (pAspNetUsers.id_TipoDocumentoIden == null || pAspNetUsers.id_TipoDocumentoIden == 0) ? vintNUll : pAspNetUsers.id_TipoDocumentoIden);
                p.Add("@TamPag", pageSize);
                p.Add("@pag", Page);
                p.Add("@OrdenBy", OrderByC);



                List<AspNetUsers> l = SqlMapper.Query<AspNetUsers>(con, "API.PA_AspNetUsersGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetByFilter)  AspNetUsers  ->" + ex.Message);
            }
        }

        public AspNetUsers Add(AspNetUsers pAspNetUsers)
        {
            try
            {
                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", pAspNetUsers.Id);
                p.Add("@UserName", pAspNetUsers.UserName);
                p.Add("@NormalizedUserName", pAspNetUsers.NormalizedUserName);
                p.Add("@Email", pAspNetUsers.Email);
                p.Add("@NormalizedEmail", pAspNetUsers.NormalizedEmail);
                p.Add("@EmailConfirmed", pAspNetUsers.EmailConfirmed);
                p.Add("@PasswordHash", pAspNetUsers.PasswordHash);
                p.Add("@SecurityStamp", pAspNetUsers.SecurityStamp);
                p.Add("@ConcurrencyStamp", pAspNetUsers.ConcurrencyStamp);
                p.Add("@PhoneNumber", pAspNetUsers.PhoneNumber);
                p.Add("@PhoneNumberConfirmed", pAspNetUsers.PhoneNumberConfirmed);
                p.Add("@TwoFactorEnabled", pAspNetUsers.TwoFactorEnabled);
                p.Add("@LockoutEnd", pAspNetUsers.LockoutEnd);
                p.Add("@LockoutEnabled", pAspNetUsers.LockoutEnabled);
                p.Add("@AccessFailedCount", pAspNetUsers.AccessFailedCount == null ? 0 : pAspNetUsers.AccessFailedCount);
                p.Add("@PrimerNombre", pAspNetUsers.PrimerNombre);
                p.Add("@SegundoNombre", pAspNetUsers.SegundoNombre);
                p.Add("@PrimerApellido", pAspNetUsers.PrimerApellido);
                p.Add("@SegundoApellido", pAspNetUsers.SegundoApellido);
                p.Add("@Cargo", pAspNetUsers.Cargo);
                p.Add("@RespuestaSeguridad", pAspNetUsers.RespuestaSeguridad);
                p.Add("@UsuarioAD", pAspNetUsers.UsuarioAD);
                p.Add("@GUID", pAspNetUsers.GUID);
                p.Add("@PhotoPath", pAspNetUsers.PhotoPath);
                p.Add("@FechaCreacion", pAspNetUsers.FechaCreacion);
                p.Add("@id_Ubicacion", pAspNetUsers.id_Ubicacion == null ? 0 : pAspNetUsers.id_Ubicacion);
                p.Add("@UbicacionBase", pAspNetUsers.UbicacionBase);
                p.Add("@id_TipoActor", pAspNetUsers.id_TipoActor == null ? 0 : pAspNetUsers.id_TipoActor);
                p.Add("@DocumentoIden", pAspNetUsers.DocumentoIden);
                p.Add("@id_TipoDocumentoIden", pAspNetUsers.id_TipoDocumentoIden == null ? 0 : pAspNetUsers.id_TipoDocumentoIden);
                p.Add("@auditoria", pAspNetUsers.auditoria);




                AspNetUsers o = SqlMapper.QueryFirstOrDefault<AspNetUsers>(con, "API.PA_AspNetUsersAdd", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Add)  AspNetUsers  ->" + ex.Message);
            }
        }


        public AspNetUsers updateInactiveToActive(string mail)
        {
            try
            {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();
                p.Add("@UserName", mail);
                AspNetUsers o = SqlMapper.QueryFirstOrDefault<AspNetUsers>(con, "dbo.PA_ActivarUsuario", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(updateInactive To Active)  AspNetUsers  ->" + ex.Message);
            }
        }

        public AspNetUsers Update(AspNetUsers pAspNetUsers)
        {
            try
            {
                int? vintNUll = null;

                DynamicParameters p = new DynamicParameters();

                p.Add("@Id", pAspNetUsers.Id);
                p.Add("@UserName", pAspNetUsers.UserName);
                p.Add("@NormalizedUserName", pAspNetUsers.NormalizedUserName);
                p.Add("@Email", pAspNetUsers.Email);
                p.Add("@NormalizedEmail", pAspNetUsers.NormalizedEmail);
                p.Add("@EmailConfirmed", pAspNetUsers.EmailConfirmed);
                p.Add("@PasswordHash", pAspNetUsers.PasswordHash);
                p.Add("@SecurityStamp", pAspNetUsers.SecurityStamp);
                p.Add("@ConcurrencyStamp", pAspNetUsers.ConcurrencyStamp);
                p.Add("@PhoneNumber", pAspNetUsers.PhoneNumber);
                p.Add("@PhoneNumberConfirmed", pAspNetUsers.PhoneNumberConfirmed);
                p.Add("@TwoFactorEnabled", pAspNetUsers.TwoFactorEnabled);
                p.Add("@LockoutEnd", pAspNetUsers.LockoutEnd);
                p.Add("@LockoutEnabled", pAspNetUsers.LockoutEnabled);
                p.Add("@AccessFailedCount", pAspNetUsers.AccessFailedCount == null ? 0 : pAspNetUsers.AccessFailedCount);
                p.Add("@PrimerNombre", pAspNetUsers.PrimerNombre);
                p.Add("@SegundoNombre", pAspNetUsers.SegundoNombre);
                p.Add("@PrimerApellido", pAspNetUsers.PrimerApellido);
                p.Add("@SegundoApellido", pAspNetUsers.SegundoApellido);
                p.Add("@Cargo", pAspNetUsers.Cargo);
                p.Add("@RespuestaSeguridad", pAspNetUsers.RespuestaSeguridad);
                p.Add("@UsuarioAD", pAspNetUsers.UsuarioAD);
                p.Add("@GUID", pAspNetUsers.GUID);
                p.Add("@PhotoPath", pAspNetUsers.PhotoPath);
                p.Add("@FechaCreacion", pAspNetUsers.FechaCreacion);
                p.Add("@id_Ubicacion", pAspNetUsers.id_Ubicacion == null ? 0 : pAspNetUsers.id_Ubicacion);
                p.Add("@UbicacionBase", pAspNetUsers.UbicacionBase);
                p.Add("@id_TipoActor", pAspNetUsers.id_TipoActor == null ? 0 : pAspNetUsers.id_TipoActor);
                p.Add("@DocumentoIden", pAspNetUsers.DocumentoIden);
                p.Add("@id_TipoDocumentoIden", pAspNetUsers.id_TipoDocumentoIden == null ? 0 : pAspNetUsers.id_TipoDocumentoIden);
                p.Add("@auditoria", pAspNetUsers.auditoria);




                AspNetUsers o = SqlMapper.QueryFirstOrDefault<AspNetUsers>(con, "API.PA_AspNetUsersUpdate", p, commandType: CommandType.StoredProcedure);

                return o;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(Update)  AspNetUsers  ->" + ex.Message);
            }
        }

        public bool Delete(AspNetUsers pAspNetUsers)
        {
            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", pAspNetUsers.Id);
                p.Add("@auditoria", pAspNetUsers.auditoria);





                AspNetUsers o = SqlMapper.QueryFirstOrDefault<AspNetUsers>(con, "API.PA_AspNetUsersDelete", p, commandType: CommandType.StoredProcedure);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper: (Delete) AspNetUsers  ->" + ex.Message);
            }
        }





        public List<AspNetUsers> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
        {
            try
            {
                List<AspNetUsers> AspNetUsersList = new List<AspNetUsers>();

                AspNetUsersList = SqlMapper.Query<AspNetUsers>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                return AspNetUsersList;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(ExecProcedureQuery) AspNetUsers  ->" + ex.Message);
            }
        }


        public void BulkInsert(List<AspNetUsers> b)
        {
            DapperPlusManager.Entity<AspNetUsers>().Table("AspNetUsers");
            con.BulkInsert(b);
        }
    }
    #endregion Class Methods

}