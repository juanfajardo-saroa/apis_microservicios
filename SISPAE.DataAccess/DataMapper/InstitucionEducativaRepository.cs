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
     /// Clase Abstracta para  InstitucionEducativa
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class InstitucionEducativaRepository : DataObject , IInstitucionEducativa 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public InstitucionEducativaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public InstitucionEducativaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public InstitucionEducativa GetById(InstitucionEducativa pInstitucionEducativa)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pInstitucionEducativa.id);                                    


    				InstitucionEducativa o = SqlMapper.QueryFirstOrDefault<InstitucionEducativa>(con, "API.PA_InstitucionEducativaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  InstitucionEducativa  ->" + ex.Message);
				}
			}

			public List<InstitucionEducativa> GetAll()
			{
				try 
                {
                        List<InstitucionEducativa> l = SqlMapper.Query<InstitucionEducativa>(con, "API.PA_InstitucionEducativaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  InstitucionEducativa  ->" + ex.Message);
				}
			}

			public List<InstitucionEducativa> GetAllFull()
			{
				try 
				{
                    List<InstitucionEducativa> l = SqlMapper.Query<InstitucionEducativa>(con, "API.PA_InstitucionEducativaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  InstitucionEducativa  ->" + ex.Message);
				}
			}
			
			public List<InstitucionEducativa> GetAllByWithRelation()
			{
				try 
                {
                    List<InstitucionEducativa> l = SqlMapper.Query<InstitucionEducativa>(con, "API.PA_InstitucionEducativaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  InstitucionEducativa  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<InstitucionEducativa> GetByFilter(InstitucionEducativa pInstitucionEducativa, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pInstitucionEducativa.id== null || pInstitucionEducativa.id==0) ? vintNUll :pInstitucionEducativa.id);
                    p.Add("@ID_Rector",(pInstitucionEducativa.ID_Rector== null || pInstitucionEducativa.ID_Rector==0) ? vintNUll :pInstitucionEducativa.ID_Rector);
                    p.Add("@ID_ETC",(pInstitucionEducativa.ID_ETC== null || pInstitucionEducativa.ID_ETC==0) ? vintNUll :pInstitucionEducativa.ID_ETC);
                    p.Add("@ID_ET",(pInstitucionEducativa.ID_ET== null || pInstitucionEducativa.ID_ET==0) ? vintNUll :pInstitucionEducativa.ID_ET);
                    p.Add("@ID_DiviPola",(pInstitucionEducativa.ID_DiviPola== null || pInstitucionEducativa.ID_DiviPola==0) ? vintNUll :pInstitucionEducativa.ID_DiviPola);
                    p.Add("@CodigoDane",(pInstitucionEducativa.CodigoDane== null) ? vintNUll :pInstitucionEducativa.CodigoDane);
                    p.Add("@Nombre",(pInstitucionEducativa.Nombre== null) ? vintNUll :pInstitucionEducativa.Nombre);
                    p.Add("@Correo",(pInstitucionEducativa.Correo== null) ? vintNUll :pInstitucionEducativa.Correo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<InstitucionEducativa> l = SqlMapper.Query<InstitucionEducativa>(con, "API.PA_InstitucionEducativaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  InstitucionEducativa  ->" + ex.Message);
				}
			}

			public InstitucionEducativa Add(InstitucionEducativa pInstitucionEducativa)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pInstitucionEducativa.id==null ? 0 : pInstitucionEducativa.id);
p.Add("@ID_Rector",pInstitucionEducativa.ID_Rector==null ? 0 : pInstitucionEducativa.ID_Rector);
p.Add("@ID_ETC",pInstitucionEducativa.ID_ETC==null ? 0 : pInstitucionEducativa.ID_ETC);
p.Add("@ID_ET",pInstitucionEducativa.ID_ET==null ? 0 : pInstitucionEducativa.ID_ET);
p.Add("@ID_DiviPola",pInstitucionEducativa.ID_DiviPola==null ? 0 : pInstitucionEducativa.ID_DiviPola);
                    p.Add("@CodigoDane", pInstitucionEducativa.CodigoDane);
                    p.Add("@Nombre", pInstitucionEducativa.Nombre);
                    p.Add("@Correo", pInstitucionEducativa.Correo);
                    p.Add("@auditoria", pInstitucionEducativa.auditoria);

                         


                    InstitucionEducativa o = SqlMapper.QueryFirstOrDefault<InstitucionEducativa>(con, "API.PA_InstitucionEducativaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  InstitucionEducativa  ->" + ex.Message);
				}
			}

			public InstitucionEducativa  Update(InstitucionEducativa pInstitucionEducativa)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pInstitucionEducativa.id==null ? 0 : pInstitucionEducativa.id);
p.Add("@ID_Rector",pInstitucionEducativa.ID_Rector==null ? 0 : pInstitucionEducativa.ID_Rector);
p.Add("@ID_ETC",pInstitucionEducativa.ID_ETC==null ? 0 : pInstitucionEducativa.ID_ETC);
p.Add("@ID_ET",pInstitucionEducativa.ID_ET==null ? 0 : pInstitucionEducativa.ID_ET);
p.Add("@ID_DiviPola",pInstitucionEducativa.ID_DiviPola==null ? 0 : pInstitucionEducativa.ID_DiviPola);
                    p.Add("@CodigoDane", pInstitucionEducativa.CodigoDane);
                    p.Add("@Nombre", pInstitucionEducativa.Nombre);
                    p.Add("@Correo", pInstitucionEducativa.Correo);
                    p.Add("@auditoria", pInstitucionEducativa.auditoria);

                         


                    InstitucionEducativa o = SqlMapper.QueryFirstOrDefault<InstitucionEducativa>(con, "API.PA_InstitucionEducativaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  InstitucionEducativa  ->" + ex.Message);
				}
			}

			public bool Delete(InstitucionEducativa pInstitucionEducativa)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pInstitucionEducativa.id);
                    p.Add("@auditoria", pInstitucionEducativa.auditoria);

                

 

					InstitucionEducativa o = SqlMapper.QueryFirstOrDefault<InstitucionEducativa>(con, "API.PA_InstitucionEducativaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) InstitucionEducativa  ->" + ex.Message);
				}
			}

		



            public List<InstitucionEducativa> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<InstitucionEducativa> InstitucionEducativaList = new List<InstitucionEducativa>();

                    InstitucionEducativaList = SqlMapper.Query<InstitucionEducativa>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return InstitucionEducativaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) InstitucionEducativa  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<InstitucionEducativa> b)
            {
                DapperPlusManager.Entity<InstitucionEducativa>().Table("InstitucionEducativa");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}