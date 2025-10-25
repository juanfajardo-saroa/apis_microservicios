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
     /// Clase Abstracta para  SubTiposAlimento
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SubTiposAlimentoRepository : DataObject , ISubTiposAlimento 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SubTiposAlimentoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SubTiposAlimentoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public SubTiposAlimento GetById(SubTiposAlimento pSubTiposAlimento)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubTiposAlimento.id);                                    


    				SubTiposAlimento o = SqlMapper.QueryFirstOrDefault<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  SubTiposAlimento  ->" + ex.Message);
				}
			}

			public List<SubTiposAlimento> GetAll()
			{
				try 
                {
                        List<SubTiposAlimento> l = SqlMapper.Query<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  SubTiposAlimento  ->" + ex.Message);
				}
			}

			public List<SubTiposAlimento> GetAllFull()
			{
				try 
				{
                    List<SubTiposAlimento> l = SqlMapper.Query<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  SubTiposAlimento  ->" + ex.Message);
				}
			}
			
			public List<SubTiposAlimento> GetAllByWithRelation()
			{
				try 
                {
                    List<SubTiposAlimento> l = SqlMapper.Query<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  SubTiposAlimento  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<SubTiposAlimento> GetByFilter(SubTiposAlimento pSubTiposAlimento, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSubTiposAlimento.id== null || pSubTiposAlimento.id==0) ? vintNUll :pSubTiposAlimento.id);
                    p.Add("@Nombre",(pSubTiposAlimento.Nombre== null) ? vintNUll :pSubTiposAlimento.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<SubTiposAlimento> l = SqlMapper.Query<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  SubTiposAlimento  ->" + ex.Message);
				}
			}

			public SubTiposAlimento Add(SubTiposAlimento pSubTiposAlimento)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSubTiposAlimento.id==null ? 0 : pSubTiposAlimento.id);
p.Add("@Nombre",pSubTiposAlimento.Nombre==null ? 0 : pSubTiposAlimento.Nombre);
                    p.Add("@auditoria", pSubTiposAlimento.auditoria);

                         


                    SubTiposAlimento o = SqlMapper.QueryFirstOrDefault<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  SubTiposAlimento  ->" + ex.Message);
				}
			}

			public SubTiposAlimento  Update(SubTiposAlimento pSubTiposAlimento)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSubTiposAlimento.id==null ? 0 : pSubTiposAlimento.id);
p.Add("@Nombre",pSubTiposAlimento.Nombre==null ? 0 : pSubTiposAlimento.Nombre);
                    p.Add("@auditoria", pSubTiposAlimento.auditoria);

                         


                    SubTiposAlimento o = SqlMapper.QueryFirstOrDefault<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  SubTiposAlimento  ->" + ex.Message);
				}
			}

			public bool Delete(SubTiposAlimento pSubTiposAlimento)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSubTiposAlimento.id);
                    p.Add("@auditoria", pSubTiposAlimento.auditoria);

                

 

					SubTiposAlimento o = SqlMapper.QueryFirstOrDefault<SubTiposAlimento>(con, "API.PA_SubTiposAlimentoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) SubTiposAlimento  ->" + ex.Message);
				}
			}

		



            public List<SubTiposAlimento> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<SubTiposAlimento> SubTiposAlimentoList = new List<SubTiposAlimento>();

                    SubTiposAlimentoList = SqlMapper.Query<SubTiposAlimento>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SubTiposAlimentoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) SubTiposAlimento  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<SubTiposAlimento> b)
            {
                DapperPlusManager.Entity<SubTiposAlimento>().Table("SubTiposAlimento");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}