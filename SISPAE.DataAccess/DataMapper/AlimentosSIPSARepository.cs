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
     /// Clase Abstracta para  AlimentosSIPSA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosSIPSARepository : DataObject , IAlimentosSIPSA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosSIPSARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosSIPSARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosSIPSA GetById(AlimentosSIPSA pAlimentosSIPSA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosSIPSA.id);                                    


    				AlimentosSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosSIPSA  ->" + ex.Message);
				}
			}

			public List<AlimentosSIPSA> GetAll()
			{
				try 
                {
                        List<AlimentosSIPSA> l = SqlMapper.Query<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosSIPSA  ->" + ex.Message);
				}
			}

			public List<AlimentosSIPSA> GetAllFull()
			{
				try 
				{
                    List<AlimentosSIPSA> l = SqlMapper.Query<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosSIPSA  ->" + ex.Message);
				}
			}
			
			public List<AlimentosSIPSA> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosSIPSA> l = SqlMapper.Query<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosSIPSA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosSIPSA> GetByFilter(AlimentosSIPSA pAlimentosSIPSA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlimentosSIPSA.id== null || pAlimentosSIPSA.id==0) ? vintNUll :pAlimentosSIPSA.id);
                    p.Add("@ID_AlimentolCBF",(pAlimentosSIPSA.ID_AlimentolCBF== null || pAlimentosSIPSA.ID_AlimentolCBF==0) ? vintNUll :pAlimentosSIPSA.ID_AlimentolCBF);
                    p.Add("@CodigoSIPSA",(pAlimentosSIPSA.CodigoSIPSA== null) ? vintNUll :pAlimentosSIPSA.CodigoSIPSA);
                    p.Add("@ID_ETC",(pAlimentosSIPSA.ID_ETC== null || pAlimentosSIPSA.ID_ETC==0) ? vintNUll :pAlimentosSIPSA.ID_ETC);
                    p.Add("@CodigoETC",(pAlimentosSIPSA.CodigoETC== null) ? vintNUll :pAlimentosSIPSA.CodigoETC);
                    p.Add("@ano",(pAlimentosSIPSA.ano== null) ? vintNUll :pAlimentosSIPSA.ano);
                    p.Add("@NombreArticulo",(pAlimentosSIPSA.NombreArticulo== null) ? vintNUll :pAlimentosSIPSA.NombreArticulo);
                    p.Add("@Precio",(pAlimentosSIPSA.Precio== null) ? vintNUll :pAlimentosSIPSA.Precio);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosSIPSA> l = SqlMapper.Query<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosSIPSA  ->" + ex.Message);
				}
			}

			public AlimentosSIPSA Add(AlimentosSIPSA pAlimentosSIPSA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlimentosSIPSA.id==null ? 0 : pAlimentosSIPSA.id);
p.Add("@ID_AlimentolCBF",pAlimentosSIPSA.ID_AlimentolCBF==null ? 0 : pAlimentosSIPSA.ID_AlimentolCBF);
p.Add("@CodigoSIPSA",pAlimentosSIPSA.CodigoSIPSA==null ? 0 : pAlimentosSIPSA.CodigoSIPSA);
p.Add("@ID_ETC",pAlimentosSIPSA.ID_ETC==null ? 0 : pAlimentosSIPSA.ID_ETC);
p.Add("@CodigoETC",pAlimentosSIPSA.CodigoETC==null ? 0 : pAlimentosSIPSA.CodigoETC);
p.Add("@ano",pAlimentosSIPSA.ano==null ? 0 : pAlimentosSIPSA.ano);
                    p.Add("@NombreArticulo", pAlimentosSIPSA.NombreArticulo);
                    p.Add("@Precio", pAlimentosSIPSA.Precio);
                    p.Add("@auditoria", pAlimentosSIPSA.auditoria);

                         


                    AlimentosSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosSIPSA  ->" + ex.Message);
				}
			}

			public AlimentosSIPSA  Update(AlimentosSIPSA pAlimentosSIPSA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlimentosSIPSA.id==null ? 0 : pAlimentosSIPSA.id);
p.Add("@ID_AlimentolCBF",pAlimentosSIPSA.ID_AlimentolCBF==null ? 0 : pAlimentosSIPSA.ID_AlimentolCBF);
p.Add("@CodigoSIPSA",pAlimentosSIPSA.CodigoSIPSA==null ? 0 : pAlimentosSIPSA.CodigoSIPSA);
p.Add("@ID_ETC",pAlimentosSIPSA.ID_ETC==null ? 0 : pAlimentosSIPSA.ID_ETC);
p.Add("@CodigoETC",pAlimentosSIPSA.CodigoETC==null ? 0 : pAlimentosSIPSA.CodigoETC);
p.Add("@ano",pAlimentosSIPSA.ano==null ? 0 : pAlimentosSIPSA.ano);
                    p.Add("@NombreArticulo", pAlimentosSIPSA.NombreArticulo);
                    p.Add("@Precio", pAlimentosSIPSA.Precio);
                    p.Add("@auditoria", pAlimentosSIPSA.auditoria);

                         


                    AlimentosSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosSIPSA  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosSIPSA pAlimentosSIPSA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosSIPSA.id);
                    p.Add("@auditoria", pAlimentosSIPSA.auditoria);

                

 

					AlimentosSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosSIPSA>(con, "API.PA_AlimentosSIPSADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosSIPSA  ->" + ex.Message);
				}
			}

		



            public List<AlimentosSIPSA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosSIPSA> AlimentosSIPSAList = new List<AlimentosSIPSA>();

                    AlimentosSIPSAList = SqlMapper.Query<AlimentosSIPSA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosSIPSAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosSIPSA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosSIPSA> b)
            {
                DapperPlusManager.Entity<AlimentosSIPSA>().Table("AlimentosSIPSA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}