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
     /// Clase Abstracta para  ClasificacionesNoSIPSA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ClasificacionesNoSIPSARepository : DataObject , IClasificacionesNoSIPSA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ClasificacionesNoSIPSARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ClasificacionesNoSIPSARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ClasificacionesNoSIPSA GetById(ClasificacionesNoSIPSA pClasificacionesNoSIPSA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pClasificacionesNoSIPSA.id);                                    


    				ClasificacionesNoSIPSA o = SqlMapper.QueryFirstOrDefault<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}

			public List<ClasificacionesNoSIPSA> GetAll()
			{
				try 
                {
                        List<ClasificacionesNoSIPSA> l = SqlMapper.Query<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}

			public List<ClasificacionesNoSIPSA> GetAllFull()
			{
				try 
				{
                    List<ClasificacionesNoSIPSA> l = SqlMapper.Query<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}
			
			public List<ClasificacionesNoSIPSA> GetAllByWithRelation()
			{
				try 
                {
                    List<ClasificacionesNoSIPSA> l = SqlMapper.Query<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ClasificacionesNoSIPSA> GetByFilter(ClasificacionesNoSIPSA pClasificacionesNoSIPSA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pClasificacionesNoSIPSA.id== null || pClasificacionesNoSIPSA.id==0) ? vintNUll :pClasificacionesNoSIPSA.id);
                    p.Add("@Nombre",(pClasificacionesNoSIPSA.Nombre== null) ? vintNUll :pClasificacionesNoSIPSA.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ClasificacionesNoSIPSA> l = SqlMapper.Query<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}

			public ClasificacionesNoSIPSA Add(ClasificacionesNoSIPSA pClasificacionesNoSIPSA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pClasificacionesNoSIPSA.id==null ? 0 : pClasificacionesNoSIPSA.id);
                    p.Add("@Nombre", pClasificacionesNoSIPSA.Nombre);
                    p.Add("@auditoria", pClasificacionesNoSIPSA.auditoria);

                         


                    ClasificacionesNoSIPSA o = SqlMapper.QueryFirstOrDefault<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}

			public ClasificacionesNoSIPSA  Update(ClasificacionesNoSIPSA pClasificacionesNoSIPSA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pClasificacionesNoSIPSA.id==null ? 0 : pClasificacionesNoSIPSA.id);
                    p.Add("@Nombre", pClasificacionesNoSIPSA.Nombre);
                    p.Add("@auditoria", pClasificacionesNoSIPSA.auditoria);

                         


                    ClasificacionesNoSIPSA o = SqlMapper.QueryFirstOrDefault<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}

			public bool Delete(ClasificacionesNoSIPSA pClasificacionesNoSIPSA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pClasificacionesNoSIPSA.id);
                    p.Add("@auditoria", pClasificacionesNoSIPSA.auditoria);

                

 

					ClasificacionesNoSIPSA o = SqlMapper.QueryFirstOrDefault<ClasificacionesNoSIPSA>(con, "API.PA_ClasificacionesNoSIPSADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ClasificacionesNoSIPSA  ->" + ex.Message);
				}
			}

		



            public List<ClasificacionesNoSIPSA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ClasificacionesNoSIPSA> ClasificacionesNoSIPSAList = new List<ClasificacionesNoSIPSA>();

                    ClasificacionesNoSIPSAList = SqlMapper.Query<ClasificacionesNoSIPSA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ClasificacionesNoSIPSAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ClasificacionesNoSIPSA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ClasificacionesNoSIPSA> b)
            {
                DapperPlusManager.Entity<ClasificacionesNoSIPSA>().Table("ClasificacionesNoSIPSA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}