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
     /// Clase Abstracta para  EstadosRegistro
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EstadosRegistroRepository : DataObject , IEstadosRegistro 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EstadosRegistroRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EstadosRegistroRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EstadosRegistro GetById(EstadosRegistro pEstadosRegistro)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadosRegistro.id);                                    


    				EstadosRegistro o = SqlMapper.QueryFirstOrDefault<EstadosRegistro>(con, "API.PA_EstadosRegistroGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EstadosRegistro  ->" + ex.Message);
				}
			}

			public List<EstadosRegistro> GetAll()
			{
				try 
                {
                        List<EstadosRegistro> l = SqlMapper.Query<EstadosRegistro>(con, "API.PA_EstadosRegistroGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EstadosRegistro  ->" + ex.Message);
				}
			}

			public List<EstadosRegistro> GetAllFull()
			{
				try 
				{
                    List<EstadosRegistro> l = SqlMapper.Query<EstadosRegistro>(con, "API.PA_EstadosRegistroGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EstadosRegistro  ->" + ex.Message);
				}
			}
			
			public List<EstadosRegistro> GetAllByWithRelation()
			{
				try 
                {
                    List<EstadosRegistro> l = SqlMapper.Query<EstadosRegistro>(con, "API.PA_EstadosRegistroGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EstadosRegistro  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EstadosRegistro> GetByFilter(EstadosRegistro pEstadosRegistro, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEstadosRegistro.id== null || pEstadosRegistro.id==0) ? vintNUll :pEstadosRegistro.id);
                    p.Add("@Nombre",(pEstadosRegistro.Nombre== null) ? vintNUll :pEstadosRegistro.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EstadosRegistro> l = SqlMapper.Query<EstadosRegistro>(con, "API.PA_EstadosRegistroGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EstadosRegistro  ->" + ex.Message);
				}
			}

			public EstadosRegistro Add(EstadosRegistro pEstadosRegistro)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEstadosRegistro.id==null ? 0 : pEstadosRegistro.id);
                    p.Add("@Nombre", pEstadosRegistro.Nombre);
                    p.Add("@auditoria", pEstadosRegistro.auditoria);

                         


                    EstadosRegistro o = SqlMapper.QueryFirstOrDefault<EstadosRegistro>(con, "API.PA_EstadosRegistroAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EstadosRegistro  ->" + ex.Message);
				}
			}

			public EstadosRegistro  Update(EstadosRegistro pEstadosRegistro)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEstadosRegistro.id==null ? 0 : pEstadosRegistro.id);
                    p.Add("@Nombre", pEstadosRegistro.Nombre);
                    p.Add("@auditoria", pEstadosRegistro.auditoria);

                         


                    EstadosRegistro o = SqlMapper.QueryFirstOrDefault<EstadosRegistro>(con, "API.PA_EstadosRegistroUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EstadosRegistro  ->" + ex.Message);
				}
			}

			public bool Delete(EstadosRegistro pEstadosRegistro)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEstadosRegistro.id);
                    p.Add("@auditoria", pEstadosRegistro.auditoria);

                

 

					EstadosRegistro o = SqlMapper.QueryFirstOrDefault<EstadosRegistro>(con, "API.PA_EstadosRegistroDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EstadosRegistro  ->" + ex.Message);
				}
			}

		



            public List<EstadosRegistro> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EstadosRegistro> EstadosRegistroList = new List<EstadosRegistro>();

                    EstadosRegistroList = SqlMapper.Query<EstadosRegistro>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EstadosRegistroList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EstadosRegistro  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EstadosRegistro> b)
            {
                DapperPlusManager.Entity<EstadosRegistro>().Table("EstadosRegistro");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}