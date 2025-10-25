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
     /// Clase Abstracta para  TP_Enum
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TP_EnumRepository : DataObject , ITP_Enum 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TP_EnumRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TP_EnumRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public TP_Enum GetById(TP_Enum pTP_Enum)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Enum.id);                                    


    				TP_Enum o = SqlMapper.QueryFirstOrDefault<TP_Enum>(con, "API.PA_TP_EnumGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  TP_Enum  ->" + ex.Message);
				}
			}

			public List<TP_Enum> GetAll()
			{
				try 
                {
                        List<TP_Enum> l = SqlMapper.Query<TP_Enum>(con, "API.PA_TP_EnumGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  TP_Enum  ->" + ex.Message);
				}
			}

			public List<TP_Enum> GetAllFull()
			{
				try 
				{
                    List<TP_Enum> l = SqlMapper.Query<TP_Enum>(con, "API.PA_TP_EnumGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  TP_Enum  ->" + ex.Message);
				}
			}
			
			public List<TP_Enum> GetAllByWithRelation()
			{
				try 
                {
                    List<TP_Enum> l = SqlMapper.Query<TP_Enum>(con, "API.PA_TP_EnumGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  TP_Enum  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<TP_Enum> GetByFilter(TP_Enum pTP_Enum, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTP_Enum.id== null || pTP_Enum.id==0) ? vintNUll :pTP_Enum.id);
                    p.Add("@id_TP_Empresa",(pTP_Enum.id_TP_Empresa== null || pTP_Enum.id_TP_Empresa==0) ? vintNUll :pTP_Enum.id_TP_Empresa);
                    p.Add("@Enum", pTP_Enum.Enum);
                    p.Add("@Condicion", pTP_Enum.Condicion);
                    p.Add("@Listado", pTP_Enum.Listado);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<TP_Enum> l = SqlMapper.Query<TP_Enum>(con, "API.PA_TP_EnumGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  TP_Enum  ->" + ex.Message);
				}
			}

			public TP_Enum Add(TP_Enum pTP_Enum)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTP_Enum.id== null ? 0: pTP_Enum.id);
p.Add("@id_TP_Empresa",pTP_Enum.id_TP_Empresa== null ? 0: pTP_Enum.id_TP_Empresa);
                    p.Add("@Enum", pTP_Enum.Enum);
                    p.Add("@Condicion", pTP_Enum.Condicion);
                    p.Add("@Listado", pTP_Enum.Listado);
                    p.Add("@auditoria", pTP_Enum.auditoria);

                         


                    TP_Enum o = SqlMapper.QueryFirstOrDefault<TP_Enum>(con, "API.PA_TP_EnumAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  TP_Enum  ->" + ex.Message);
				}
			}

			public TP_Enum  Update(TP_Enum pTP_Enum)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTP_Enum.id== null ? 0: pTP_Enum.id);
p.Add("@id_TP_Empresa",pTP_Enum.id_TP_Empresa== null ? 0: pTP_Enum.id_TP_Empresa);
                    p.Add("@Enum", pTP_Enum.Enum);
                    p.Add("@Condicion", pTP_Enum.Condicion);
                    p.Add("@Listado", pTP_Enum.Listado);
                    p.Add("@auditoria", pTP_Enum.auditoria);

                         


                    TP_Enum o = SqlMapper.QueryFirstOrDefault<TP_Enum>(con, "API.PA_TP_EnumUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  TP_Enum  ->" + ex.Message);
				}
			}

			public bool Delete(TP_Enum pTP_Enum)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTP_Enum.id);
                    p.Add("@auditoria", pTP_Enum.auditoria);

                

 

					TP_Enum o = SqlMapper.QueryFirstOrDefault<TP_Enum>(con, "API.PA_TP_EnumDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) TP_Enum  ->" + ex.Message);
				}
			}

		



            public List<TP_Enum> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<TP_Enum> TP_EnumList = new List<TP_Enum>();

                    TP_EnumList = SqlMapper.Query<TP_Enum>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TP_EnumList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) TP_Enum  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<TP_Enum> b)
            {
                DapperPlusManager.Entity<TP_Enum>().Table("TP_Enum");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}