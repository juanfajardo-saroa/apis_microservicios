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
     /// Clase Abstracta para  RubrosAdicionales
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class RubrosAdicionalesRepository : DataObject , IRubrosAdicionales 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public RubrosAdicionalesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public RubrosAdicionalesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public RubrosAdicionales GetById(RubrosAdicionales pRubrosAdicionales)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pRubrosAdicionales.id);                                    


    				RubrosAdicionales o = SqlMapper.QueryFirstOrDefault<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  RubrosAdicionales  ->" + ex.Message);
				}
			}

			public List<RubrosAdicionales> GetAll()
			{
				try 
                {
                        List<RubrosAdicionales> l = SqlMapper.Query<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  RubrosAdicionales  ->" + ex.Message);
				}
			}

			public List<RubrosAdicionales> GetAllFull()
			{
				try 
				{
                    List<RubrosAdicionales> l = SqlMapper.Query<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  RubrosAdicionales  ->" + ex.Message);
				}
			}
			
			public List<RubrosAdicionales> GetAllByWithRelation()
			{
				try 
                {
                    List<RubrosAdicionales> l = SqlMapper.Query<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  RubrosAdicionales  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<RubrosAdicionales> GetByFilter(RubrosAdicionales pRubrosAdicionales, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pRubrosAdicionales.id== null || pRubrosAdicionales.id==0) ? vintNUll :pRubrosAdicionales.id);
                    p.Add("@ID_Contrato",(pRubrosAdicionales.ID_Contrato== null || pRubrosAdicionales.ID_Contrato==0) ? vintNUll :pRubrosAdicionales.ID_Contrato);
                    p.Add("@Concepto",(pRubrosAdicionales.Concepto== null) ? vintNUll :pRubrosAdicionales.Concepto);
                    p.Add("@Valor",(pRubrosAdicionales.Valor== null) ? vintNUll :pRubrosAdicionales.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<RubrosAdicionales> l = SqlMapper.Query<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  RubrosAdicionales  ->" + ex.Message);
				}
			}

			public RubrosAdicionales Add(RubrosAdicionales pRubrosAdicionales)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pRubrosAdicionales.id==null ? 0 : pRubrosAdicionales.id);
p.Add("@ID_Contrato",pRubrosAdicionales.ID_Contrato==null ? 0 : pRubrosAdicionales.ID_Contrato);
                    p.Add("@Concepto", pRubrosAdicionales.Concepto);
                    p.Add("@Valor", pRubrosAdicionales.Valor);
                    p.Add("@auditoria", pRubrosAdicionales.auditoria);

                         


                    RubrosAdicionales o = SqlMapper.QueryFirstOrDefault<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  RubrosAdicionales  ->" + ex.Message);
				}
			}

			public RubrosAdicionales  Update(RubrosAdicionales pRubrosAdicionales)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pRubrosAdicionales.id==null ? 0 : pRubrosAdicionales.id);
p.Add("@ID_Contrato",pRubrosAdicionales.ID_Contrato==null ? 0 : pRubrosAdicionales.ID_Contrato);
                    p.Add("@Concepto", pRubrosAdicionales.Concepto);
                    p.Add("@Valor", pRubrosAdicionales.Valor);
                    p.Add("@auditoria", pRubrosAdicionales.auditoria);

                         


                    RubrosAdicionales o = SqlMapper.QueryFirstOrDefault<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  RubrosAdicionales  ->" + ex.Message);
				}
			}

			public bool Delete(RubrosAdicionales pRubrosAdicionales)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pRubrosAdicionales.id);
                    p.Add("@auditoria", pRubrosAdicionales.auditoria);

                

 

					RubrosAdicionales o = SqlMapper.QueryFirstOrDefault<RubrosAdicionales>(con, "API.PA_RubrosAdicionalesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) RubrosAdicionales  ->" + ex.Message);
				}
			}

		



            public List<RubrosAdicionales> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<RubrosAdicionales> RubrosAdicionalesList = new List<RubrosAdicionales>();

                    RubrosAdicionalesList = SqlMapper.Query<RubrosAdicionales>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return RubrosAdicionalesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) RubrosAdicionales  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<RubrosAdicionales> b)
            {
                DapperPlusManager.Entity<RubrosAdicionales>().Table("RubrosAdicionales");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}