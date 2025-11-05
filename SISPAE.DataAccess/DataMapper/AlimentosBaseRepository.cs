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
     /// Clase Abstracta para  AlimentosBase
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosBaseRepository : DataObject , IAlimentosBase 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosBaseRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosBaseRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosBase GetById(AlimentosBase pAlimentosBase)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosBase.id);                                    


    				AlimentosBase o = SqlMapper.QueryFirstOrDefault<AlimentosBase>(con, "API.PA_AlimentosBaseGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosBase  ->" + ex.Message);
				}
			}

			public List<AlimentosBase> GetAll()
			{
				try 
                {
                        List<AlimentosBase> l = SqlMapper.Query<AlimentosBase>(con, "API.PA_AlimentosBaseGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosBase  ->" + ex.Message);
				}
			}

			public List<AlimentosBase> GetAllFull()
			{
				try 
				{
                    List<AlimentosBase> l = SqlMapper.Query<AlimentosBase>(con, "API.PA_AlimentosBaseGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosBase  ->" + ex.Message);
				}
			}
			
			public List<AlimentosBase> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosBase> l = SqlMapper.Query<AlimentosBase>(con, "API.PA_AlimentosBaseGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosBase  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosBase> GetByFilter(AlimentosBase pAlimentosBase, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlimentosBase.id== null || pAlimentosBase.id==0) ? vintNUll :pAlimentosBase.id);
                    p.Add("@ID_TipoComponente",(pAlimentosBase.ID_TipoComponente== null || pAlimentosBase.ID_TipoComponente==0) ? vintNUll :pAlimentosBase.ID_TipoComponente);
                    p.Add("@ID_TipoComplemento",(pAlimentosBase.ID_TipoComplemento== null || pAlimentosBase.ID_TipoComplemento==0) ? vintNUll :pAlimentosBase.ID_TipoComplemento);
                    p.Add("@ID_AlimentoSIPSA",(pAlimentosBase.ID_AlimentoSIPSA== null || pAlimentosBase.ID_AlimentoSIPSA==0) ? vintNUll :pAlimentosBase.ID_AlimentoSIPSA);
                    p.Add("@ID_AlimentoNoSIPSA",(pAlimentosBase.ID_AlimentoNoSIPSA== null || pAlimentosBase.ID_AlimentoNoSIPSA==0) ? vintNUll :pAlimentosBase.ID_AlimentoNoSIPSA);
                    p.Add("@Precio",(pAlimentosBase.Precio== null) ? vintNUll :pAlimentosBase.Precio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosBase> l = SqlMapper.Query<AlimentosBase>(con, "API.PA_AlimentosBaseGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosBase  ->" + ex.Message);
				}
			}

			public AlimentosBase Add(AlimentosBase pAlimentosBase)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlimentosBase.id==null ? 0 : pAlimentosBase.id);
p.Add("@ID_TipoComponente",pAlimentosBase.ID_TipoComponente==null ? 0 : pAlimentosBase.ID_TipoComponente);
p.Add("@ID_TipoComplemento",pAlimentosBase.ID_TipoComplemento==null ? 0 : pAlimentosBase.ID_TipoComplemento);
p.Add("@ID_AlimentoSIPSA",pAlimentosBase.ID_AlimentoSIPSA==null ? 0 : pAlimentosBase.ID_AlimentoSIPSA);
p.Add("@ID_AlimentoNoSIPSA",pAlimentosBase.ID_AlimentoNoSIPSA==null ? 0 : pAlimentosBase.ID_AlimentoNoSIPSA);
                    p.Add("@Precio", pAlimentosBase.Precio);
                    p.Add("@auditoria", pAlimentosBase.auditoria);

                         


                    AlimentosBase o = SqlMapper.QueryFirstOrDefault<AlimentosBase>(con, "API.PA_AlimentosBaseAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosBase  ->" + ex.Message);
				}
			}

			public AlimentosBase  Update(AlimentosBase pAlimentosBase)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlimentosBase.id==null ? 0 : pAlimentosBase.id);
p.Add("@ID_TipoComponente",pAlimentosBase.ID_TipoComponente==null ? 0 : pAlimentosBase.ID_TipoComponente);
p.Add("@ID_TipoComplemento",pAlimentosBase.ID_TipoComplemento==null ? 0 : pAlimentosBase.ID_TipoComplemento);
p.Add("@ID_AlimentoSIPSA",pAlimentosBase.ID_AlimentoSIPSA==null ? 0 : pAlimentosBase.ID_AlimentoSIPSA);
p.Add("@ID_AlimentoNoSIPSA",pAlimentosBase.ID_AlimentoNoSIPSA==null ? 0 : pAlimentosBase.ID_AlimentoNoSIPSA);
                    p.Add("@Precio", pAlimentosBase.Precio);
                    p.Add("@auditoria", pAlimentosBase.auditoria);

                         


                    AlimentosBase o = SqlMapper.QueryFirstOrDefault<AlimentosBase>(con, "API.PA_AlimentosBaseUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosBase  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosBase pAlimentosBase)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosBase.id);
                    p.Add("@auditoria", pAlimentosBase.auditoria);

                

 

					AlimentosBase o = SqlMapper.QueryFirstOrDefault<AlimentosBase>(con, "API.PA_AlimentosBaseDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosBase  ->" + ex.Message);
				}
			}

		



            public List<AlimentosBase> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosBase> AlimentosBaseList = new List<AlimentosBase>();

                    AlimentosBaseList = SqlMapper.Query<AlimentosBase>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosBaseList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosBase  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosBase> b)
            {
                DapperPlusManager.Entity<AlimentosBase>().Table("AlimentosBase");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}