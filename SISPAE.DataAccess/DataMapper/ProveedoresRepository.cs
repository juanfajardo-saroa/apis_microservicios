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
     /// Clase Abstracta para  Proveedores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ProveedoresRepository : DataObject , IProveedores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ProveedoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ProveedoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Proveedores GetById(Proveedores pProveedores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pProveedores.id);                                    


    				Proveedores o = SqlMapper.QueryFirstOrDefault<Proveedores>(con, "API.PA_ProveedoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Proveedores  ->" + ex.Message);
				}
			}

			public List<Proveedores> GetAll()
			{
				try 
                {
                        List<Proveedores> l = SqlMapper.Query<Proveedores>(con, "API.PA_ProveedoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Proveedores  ->" + ex.Message);
				}
			}

			public List<Proveedores> GetAllFull()
			{
				try 
				{
                    List<Proveedores> l = SqlMapper.Query<Proveedores>(con, "API.PA_ProveedoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Proveedores  ->" + ex.Message);
				}
			}
			
			public List<Proveedores> GetAllByWithRelation()
			{
				try 
                {
                    List<Proveedores> l = SqlMapper.Query<Proveedores>(con, "API.PA_ProveedoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Proveedores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Proveedores> GetByFilter(Proveedores pProveedores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pProveedores.id== null || pProveedores.id==0) ? vintNUll :pProveedores.id);
                    p.Add("@ID_DivipolasProveedor",(pProveedores.ID_DivipolasProveedor== null || pProveedores.ID_DivipolasProveedor==0) ? vintNUll :pProveedores.ID_DivipolasProveedor);
                    p.Add("@NombreRazonSocial",(pProveedores.NombreRazonSocial== null) ? vintNUll :pProveedores.NombreRazonSocial);
                    p.Add("@Nit",(pProveedores.Nit== null) ? vintNUll :pProveedores.Nit);
                    p.Add("@NumeroCedula",(pProveedores.NumeroCedula== null) ? vintNUll :pProveedores.NumeroCedula);
                    p.Add("@ImagenCedulaPATH",(pProveedores.ImagenCedulaPATH== null) ? vintNUll :pProveedores.ImagenCedulaPATH);
                    p.Add("@Correo",(pProveedores.Correo== null) ? vintNUll :pProveedores.Correo);
                    p.Add("@Telefono",(pProveedores.Telefono== null) ? vintNUll :pProveedores.Telefono);
                    p.Add("@Direccion",(pProveedores.Direccion== null) ? vintNUll :pProveedores.Direccion);
                    p.Add("@ImagenRUTPath",(pProveedores.ImagenRUTPath== null) ? vintNUll :pProveedores.ImagenRUTPath);
                    p.Add("@NombreRepresentantelegalId",(pProveedores.NombreRepresentantelegalId== null) ? vintNUll :pProveedores.NombreRepresentantelegalId);
                    p.Add("@ApellidoRepresentantelegalId",(pProveedores.ApellidoRepresentantelegalId== null) ? vintNUll :pProveedores.ApellidoRepresentantelegalId);
                    p.Add("@NumeroIdentificacion",(pProveedores.NumeroIdentificacion== null) ? vintNUll :pProveedores.NumeroIdentificacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Proveedores> l = SqlMapper.Query<Proveedores>(con, "API.PA_ProveedoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Proveedores  ->" + ex.Message);
				}
			}

			public Proveedores Add(Proveedores pProveedores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pProveedores.id==null ? 0 : pProveedores.id);
p.Add("@ID_DivipolasProveedor",pProveedores.ID_DivipolasProveedor==null ? 0 : pProveedores.ID_DivipolasProveedor);
                    p.Add("@NombreRazonSocial", pProveedores.NombreRazonSocial);
                    p.Add("@Nit", pProveedores.Nit);
                    p.Add("@NumeroCedula", pProveedores.NumeroCedula);
                    p.Add("@ImagenCedulaPATH", pProveedores.ImagenCedulaPATH);
                    p.Add("@Correo", pProveedores.Correo);
                    p.Add("@Telefono", pProveedores.Telefono);
                    p.Add("@Direccion", pProveedores.Direccion);
                    p.Add("@ImagenRUTPath", pProveedores.ImagenRUTPath);
p.Add("@NombreRepresentantelegalId",pProveedores.NombreRepresentantelegalId==null ? 0 : pProveedores.NombreRepresentantelegalId);
p.Add("@ApellidoRepresentantelegalId",pProveedores.ApellidoRepresentantelegalId==null ? 0 : pProveedores.ApellidoRepresentantelegalId);
                    p.Add("@NumeroIdentificacion", pProveedores.NumeroIdentificacion);
                    p.Add("@auditoria", pProveedores.auditoria);

                         


                    Proveedores o = SqlMapper.QueryFirstOrDefault<Proveedores>(con, "API.PA_ProveedoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Proveedores  ->" + ex.Message);
				}
			}

			public Proveedores  Update(Proveedores pProveedores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pProveedores.id==null ? 0 : pProveedores.id);
p.Add("@ID_DivipolasProveedor",pProveedores.ID_DivipolasProveedor==null ? 0 : pProveedores.ID_DivipolasProveedor);
                    p.Add("@NombreRazonSocial", pProveedores.NombreRazonSocial);
                    p.Add("@Nit", pProveedores.Nit);
                    p.Add("@NumeroCedula", pProveedores.NumeroCedula);
                    p.Add("@ImagenCedulaPATH", pProveedores.ImagenCedulaPATH);
                    p.Add("@Correo", pProveedores.Correo);
                    p.Add("@Telefono", pProveedores.Telefono);
                    p.Add("@Direccion", pProveedores.Direccion);
                    p.Add("@ImagenRUTPath", pProveedores.ImagenRUTPath);
p.Add("@NombreRepresentantelegalId",pProveedores.NombreRepresentantelegalId==null ? 0 : pProveedores.NombreRepresentantelegalId);
p.Add("@ApellidoRepresentantelegalId",pProveedores.ApellidoRepresentantelegalId==null ? 0 : pProveedores.ApellidoRepresentantelegalId);
                    p.Add("@NumeroIdentificacion", pProveedores.NumeroIdentificacion);
                    p.Add("@auditoria", pProveedores.auditoria);

                         


                    Proveedores o = SqlMapper.QueryFirstOrDefault<Proveedores>(con, "API.PA_ProveedoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Proveedores  ->" + ex.Message);
				}
			}

			public bool Delete(Proveedores pProveedores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pProveedores.id);
                    p.Add("@auditoria", pProveedores.auditoria);

                

 

					Proveedores o = SqlMapper.QueryFirstOrDefault<Proveedores>(con, "API.PA_ProveedoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Proveedores  ->" + ex.Message);
				}
			}

		



            public List<Proveedores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Proveedores> ProveedoresList = new List<Proveedores>();

                    ProveedoresList = SqlMapper.Query<Proveedores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ProveedoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Proveedores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Proveedores> b)
            {
                DapperPlusManager.Entity<Proveedores>().Table("Proveedores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}