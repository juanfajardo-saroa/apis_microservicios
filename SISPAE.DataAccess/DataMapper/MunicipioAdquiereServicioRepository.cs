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
     /// Clase Abstracta para  MunicipioAdquiereServicio
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MunicipioAdquiereServicioRepository : DataObject , IMunicipioAdquiereServicio 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MunicipioAdquiereServicioRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MunicipioAdquiereServicioRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MunicipioAdquiereServicio GetById(MunicipioAdquiereServicio pMunicipioAdquiereServicio)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMunicipioAdquiereServicio.id);                                    


    				MunicipioAdquiereServicio o = SqlMapper.QueryFirstOrDefault<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}

			public List<MunicipioAdquiereServicio> GetAll()
			{
				try 
                {
                        List<MunicipioAdquiereServicio> l = SqlMapper.Query<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}

			public List<MunicipioAdquiereServicio> GetAllFull()
			{
				try 
				{
                    List<MunicipioAdquiereServicio> l = SqlMapper.Query<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}
			
			public List<MunicipioAdquiereServicio> GetAllByWithRelation()
			{
				try 
                {
                    List<MunicipioAdquiereServicio> l = SqlMapper.Query<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MunicipioAdquiereServicio> GetByFilter(MunicipioAdquiereServicio pMunicipioAdquiereServicio, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMunicipioAdquiereServicio.id== null || pMunicipioAdquiereServicio.id==0) ? vintNUll :pMunicipioAdquiereServicio.id);
                    p.Add("@ID_Divipolas",(pMunicipioAdquiereServicio.ID_Divipolas== null || pMunicipioAdquiereServicio.ID_Divipolas==0) ? vintNUll :pMunicipioAdquiereServicio.ID_Divipolas);
                    p.Add("@Nombre",(pMunicipioAdquiereServicio.Nombre== null) ? vintNUll :pMunicipioAdquiereServicio.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MunicipioAdquiereServicio> l = SqlMapper.Query<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}

			public MunicipioAdquiereServicio Add(MunicipioAdquiereServicio pMunicipioAdquiereServicio)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMunicipioAdquiereServicio.id==null ? 0 : pMunicipioAdquiereServicio.id);
p.Add("@ID_Divipolas",pMunicipioAdquiereServicio.ID_Divipolas==null ? 0 : pMunicipioAdquiereServicio.ID_Divipolas);
                    p.Add("@Nombre", pMunicipioAdquiereServicio.Nombre);
                    p.Add("@auditoria", pMunicipioAdquiereServicio.auditoria);

                         


                    MunicipioAdquiereServicio o = SqlMapper.QueryFirstOrDefault<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}

			public MunicipioAdquiereServicio  Update(MunicipioAdquiereServicio pMunicipioAdquiereServicio)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMunicipioAdquiereServicio.id==null ? 0 : pMunicipioAdquiereServicio.id);
p.Add("@ID_Divipolas",pMunicipioAdquiereServicio.ID_Divipolas==null ? 0 : pMunicipioAdquiereServicio.ID_Divipolas);
                    p.Add("@Nombre", pMunicipioAdquiereServicio.Nombre);
                    p.Add("@auditoria", pMunicipioAdquiereServicio.auditoria);

                         


                    MunicipioAdquiereServicio o = SqlMapper.QueryFirstOrDefault<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}

			public bool Delete(MunicipioAdquiereServicio pMunicipioAdquiereServicio)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMunicipioAdquiereServicio.id);
                    p.Add("@auditoria", pMunicipioAdquiereServicio.auditoria);

                

 

					MunicipioAdquiereServicio o = SqlMapper.QueryFirstOrDefault<MunicipioAdquiereServicio>(con, "API.PA_MunicipioAdquiereServicioDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MunicipioAdquiereServicio  ->" + ex.Message);
				}
			}

		



            public List<MunicipioAdquiereServicio> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MunicipioAdquiereServicio> MunicipioAdquiereServicioList = new List<MunicipioAdquiereServicio>();

                    MunicipioAdquiereServicioList = SqlMapper.Query<MunicipioAdquiereServicio>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MunicipioAdquiereServicioList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MunicipioAdquiereServicio  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MunicipioAdquiereServicio> b)
            {
                DapperPlusManager.Entity<MunicipioAdquiereServicio>().Table("MunicipioAdquiereServicio");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}