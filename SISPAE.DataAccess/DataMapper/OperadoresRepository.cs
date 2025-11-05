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
     /// Clase Abstracta para  Operadores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class OperadoresRepository : DataObject , IOperadores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public OperadoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public OperadoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Operadores GetById(Operadores pOperadores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pOperadores.id);                                    


    				Operadores o = SqlMapper.QueryFirstOrDefault<Operadores>(con, "API.PA_OperadoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Operadores  ->" + ex.Message);
				}
			}

			public List<Operadores> GetAll()
			{
				try 
                {
                        List<Operadores> l = SqlMapper.Query<Operadores>(con, "API.PA_OperadoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Operadores  ->" + ex.Message);
				}
			}

			public List<Operadores> GetAllFull()
			{
				try 
				{
                    List<Operadores> l = SqlMapper.Query<Operadores>(con, "API.PA_OperadoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Operadores  ->" + ex.Message);
				}
			}
			
			public List<Operadores> GetAllByWithRelation()
			{
				try 
                {
                    List<Operadores> l = SqlMapper.Query<Operadores>(con, "API.PA_OperadoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Operadores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Operadores> GetByFilter(Operadores pOperadores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pOperadores.id== null || pOperadores.id==0) ? vintNUll :pOperadores.id);
                    p.Add("@ID_TipoEstadoOperador",(pOperadores.ID_TipoEstadoOperador== null || pOperadores.ID_TipoEstadoOperador==0) ? vintNUll :pOperadores.ID_TipoEstadoOperador);
                    p.Add("@ID_SubTipoRegistroMercantil",(pOperadores.ID_SubTipoRegistroMercantil== null || pOperadores.ID_SubTipoRegistroMercantil==0) ? vintNUll :pOperadores.ID_SubTipoRegistroMercantil);
                    p.Add("@ID_Divipola",(pOperadores.ID_Divipola== null || pOperadores.ID_Divipola==0) ? vintNUll :pOperadores.ID_Divipola);
                    p.Add("@ID_UsuarioEntidad",(pOperadores.ID_UsuarioEntidad== null || pOperadores.ID_UsuarioEntidad==0) ? vintNUll :pOperadores.ID_UsuarioEntidad);
                    p.Add("@ID_Tipoldentificacion",(pOperadores.ID_Tipoldentificacion== null || pOperadores.ID_Tipoldentificacion==0) ? vintNUll :pOperadores.ID_Tipoldentificacion);
                    p.Add("@NombreRazonSocial",(pOperadores.NombreRazonSocial== null) ? vintNUll :pOperadores.NombreRazonSocial);
                    p.Add("@Nit",(pOperadores.Nit== null) ? vintNUll :pOperadores.Nit);
                    p.Add("@DV",(pOperadores.DV== null) ? vintNUll :pOperadores.DV);
                    p.Add("@RUTPath",(pOperadores.RUTPath== null) ? vintNUll :pOperadores.RUTPath);
                    p.Add("@NombreRepresentanteLegal",(pOperadores.NombreRepresentanteLegal== null) ? vintNUll :pOperadores.NombreRepresentanteLegal);
                    p.Add("@ApellidoRepresentanteLegal",(pOperadores.ApellidoRepresentanteLegal== null) ? vintNUll :pOperadores.ApellidoRepresentanteLegal);
                    p.Add("@Numeroldentificacion",(pOperadores.Numeroldentificacion== null) ? vintNUll :pOperadores.Numeroldentificacion);
                    p.Add("@Correo",(pOperadores.Correo== null) ? vintNUll :pOperadores.Correo);
                    p.Add("@Telefono",(pOperadores.Telefono== null) ? vintNUll :pOperadores.Telefono);
                    p.Add("@Direccion",(pOperadores.Direccion== null) ? vintNUll :pOperadores.Direccion);
                    p.Add("@ProveedorPAE",(pOperadores.ProveedorPAE== null) ? vintNUll :pOperadores.ProveedorPAE);
                    p.Add("@OperadorMAER",(pOperadores.OperadorMAER== null) ? vintNUll :pOperadores.OperadorMAER);
                    p.Add("@CertificadoMAERPath",(pOperadores.CertificadoMAERPath== null) ? vintNUll :pOperadores.CertificadoMAERPath);
                    p.Add("@OperadorMAIP",(pOperadores.OperadorMAIP== null) ? vintNUll :pOperadores.OperadorMAIP);
                    p.Add("@OperadorMAEM",(pOperadores.OperadorMAEM== null) ? vintNUll :pOperadores.OperadorMAEM);
                    p.Add("@OperadorPAEC",(pOperadores.OperadorPAEC== null) ? vintNUll :pOperadores.OperadorPAEC);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Operadores> l = SqlMapper.Query<Operadores>(con, "API.PA_OperadoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Operadores  ->" + ex.Message);
				}
			}

			public Operadores Add(Operadores pOperadores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pOperadores.id==null ? 0 : pOperadores.id);
p.Add("@ID_TipoEstadoOperador",pOperadores.ID_TipoEstadoOperador==null ? 0 : pOperadores.ID_TipoEstadoOperador);
p.Add("@ID_SubTipoRegistroMercantil",pOperadores.ID_SubTipoRegistroMercantil==null ? 0 : pOperadores.ID_SubTipoRegistroMercantil);
p.Add("@ID_Divipola",pOperadores.ID_Divipola==null ? 0 : pOperadores.ID_Divipola);
p.Add("@ID_UsuarioEntidad",pOperadores.ID_UsuarioEntidad==null ? 0 : pOperadores.ID_UsuarioEntidad);
p.Add("@ID_Tipoldentificacion",pOperadores.ID_Tipoldentificacion==null ? 0 : pOperadores.ID_Tipoldentificacion);
                    p.Add("@NombreRazonSocial", pOperadores.NombreRazonSocial);
                    p.Add("@Nit", pOperadores.Nit);
p.Add("@DV",pOperadores.DV==null ? 0 : pOperadores.DV);
                    p.Add("@RUTPath", pOperadores.RUTPath);
                    p.Add("@NombreRepresentanteLegal", pOperadores.NombreRepresentanteLegal);
                    p.Add("@ApellidoRepresentanteLegal", pOperadores.ApellidoRepresentanteLegal);
                    p.Add("@Numeroldentificacion", pOperadores.Numeroldentificacion);
                    p.Add("@Correo", pOperadores.Correo);
                    p.Add("@Telefono", pOperadores.Telefono);
                    p.Add("@Direccion", pOperadores.Direccion);
                    p.Add("@ProveedorPAE", pOperadores.ProveedorPAE);
                    p.Add("@OperadorMAER", pOperadores.OperadorMAER);
                    p.Add("@CertificadoMAERPath", pOperadores.CertificadoMAERPath);
                    p.Add("@OperadorMAIP", pOperadores.OperadorMAIP);
                    p.Add("@OperadorMAEM", pOperadores.OperadorMAEM);
                    p.Add("@OperadorPAEC", pOperadores.OperadorPAEC);
                    p.Add("@auditoria", pOperadores.auditoria);

                         


                    Operadores o = SqlMapper.QueryFirstOrDefault<Operadores>(con, "API.PA_OperadoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Operadores  ->" + ex.Message);
				}
			}

			public Operadores  Update(Operadores pOperadores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pOperadores.id==null ? 0 : pOperadores.id);
p.Add("@ID_TipoEstadoOperador",pOperadores.ID_TipoEstadoOperador==null ? 0 : pOperadores.ID_TipoEstadoOperador);
p.Add("@ID_SubTipoRegistroMercantil",pOperadores.ID_SubTipoRegistroMercantil==null ? 0 : pOperadores.ID_SubTipoRegistroMercantil);
p.Add("@ID_Divipola",pOperadores.ID_Divipola==null ? 0 : pOperadores.ID_Divipola);
p.Add("@ID_UsuarioEntidad",pOperadores.ID_UsuarioEntidad==null ? 0 : pOperadores.ID_UsuarioEntidad);
p.Add("@ID_Tipoldentificacion",pOperadores.ID_Tipoldentificacion==null ? 0 : pOperadores.ID_Tipoldentificacion);
                    p.Add("@NombreRazonSocial", pOperadores.NombreRazonSocial);
                    p.Add("@Nit", pOperadores.Nit);
p.Add("@DV",pOperadores.DV==null ? 0 : pOperadores.DV);
                    p.Add("@RUTPath", pOperadores.RUTPath);
                    p.Add("@NombreRepresentanteLegal", pOperadores.NombreRepresentanteLegal);
                    p.Add("@ApellidoRepresentanteLegal", pOperadores.ApellidoRepresentanteLegal);
                    p.Add("@Numeroldentificacion", pOperadores.Numeroldentificacion);
                    p.Add("@Correo", pOperadores.Correo);
                    p.Add("@Telefono", pOperadores.Telefono);
                    p.Add("@Direccion", pOperadores.Direccion);
                    p.Add("@ProveedorPAE", pOperadores.ProveedorPAE);
                    p.Add("@OperadorMAER", pOperadores.OperadorMAER);
                    p.Add("@CertificadoMAERPath", pOperadores.CertificadoMAERPath);
                    p.Add("@OperadorMAIP", pOperadores.OperadorMAIP);
                    p.Add("@OperadorMAEM", pOperadores.OperadorMAEM);
                    p.Add("@OperadorPAEC", pOperadores.OperadorPAEC);
                    p.Add("@auditoria", pOperadores.auditoria);

                         


                    Operadores o = SqlMapper.QueryFirstOrDefault<Operadores>(con, "API.PA_OperadoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Operadores  ->" + ex.Message);
				}
			}

			public bool Delete(Operadores pOperadores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pOperadores.id);
                    p.Add("@auditoria", pOperadores.auditoria);

                

 

					Operadores o = SqlMapper.QueryFirstOrDefault<Operadores>(con, "API.PA_OperadoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Operadores  ->" + ex.Message);
				}
			}

		



            public List<Operadores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Operadores> OperadoresList = new List<Operadores>();

                    OperadoresList = SqlMapper.Query<Operadores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return OperadoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Operadores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Operadores> b)
            {
                DapperPlusManager.Entity<Operadores>().Table("Operadores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}