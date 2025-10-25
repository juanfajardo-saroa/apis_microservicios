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
     /// Clase Abstracta para  ETCDivipola
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ETCDivipolaRepository : DataObject , IETCDivipola 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ETCDivipolaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ETCDivipolaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ETCDivipola GetById(ETCDivipola pETCDivipola)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pETCDivipola.id);                                    


    				ETCDivipola o = SqlMapper.QueryFirstOrDefault<ETCDivipola>(con, "API.PA_ETCDivipolaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ETCDivipola  ->" + ex.Message);
				}
			}

			public List<ETCDivipola> GetAll()
			{
				try 
                {
                        List<ETCDivipola> l = SqlMapper.Query<ETCDivipola>(con, "API.PA_ETCDivipolaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ETCDivipola  ->" + ex.Message);
				}
			}

			public List<ETCDivipola> GetAllFull()
			{
				try 
				{
                    List<ETCDivipola> l = SqlMapper.Query<ETCDivipola>(con, "API.PA_ETCDivipolaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ETCDivipola  ->" + ex.Message);
				}
			}
			
			public List<ETCDivipola> GetAllByWithRelation()
			{
				try 
                {
                    List<ETCDivipola> l = SqlMapper.Query<ETCDivipola>(con, "API.PA_ETCDivipolaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ETCDivipola  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ETCDivipola> GetByFilter(ETCDivipola pETCDivipola, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pETCDivipola.id== null || pETCDivipola.id==0) ? vintNUll :pETCDivipola.id);
                    p.Add("@ID_ETC",(pETCDivipola.ID_ETC== null || pETCDivipola.ID_ETC==0) ? vintNUll :pETCDivipola.ID_ETC);
                    p.Add("@ID_DiviPola",(pETCDivipola.ID_DiviPola== null || pETCDivipola.ID_DiviPola==0) ? vintNUll :pETCDivipola.ID_DiviPola);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ETCDivipola> l = SqlMapper.Query<ETCDivipola>(con, "API.PA_ETCDivipolaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ETCDivipola  ->" + ex.Message);
				}
			}

			public ETCDivipola Add(ETCDivipola pETCDivipola)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pETCDivipola.id==null ? 0 : pETCDivipola.id);
p.Add("@ID_ETC",pETCDivipola.ID_ETC==null ? 0 : pETCDivipola.ID_ETC);
p.Add("@ID_DiviPola",pETCDivipola.ID_DiviPola==null ? 0 : pETCDivipola.ID_DiviPola);
                    p.Add("@auditoria", pETCDivipola.auditoria);

                         


                    ETCDivipola o = SqlMapper.QueryFirstOrDefault<ETCDivipola>(con, "API.PA_ETCDivipolaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ETCDivipola  ->" + ex.Message);
				}
			}

			public ETCDivipola  Update(ETCDivipola pETCDivipola)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pETCDivipola.id==null ? 0 : pETCDivipola.id);
p.Add("@ID_ETC",pETCDivipola.ID_ETC==null ? 0 : pETCDivipola.ID_ETC);
p.Add("@ID_DiviPola",pETCDivipola.ID_DiviPola==null ? 0 : pETCDivipola.ID_DiviPola);
                    p.Add("@auditoria", pETCDivipola.auditoria);

                         


                    ETCDivipola o = SqlMapper.QueryFirstOrDefault<ETCDivipola>(con, "API.PA_ETCDivipolaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ETCDivipola  ->" + ex.Message);
				}
			}

			public bool Delete(ETCDivipola pETCDivipola)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pETCDivipola.id);
                    p.Add("@auditoria", pETCDivipola.auditoria);

                

 

					ETCDivipola o = SqlMapper.QueryFirstOrDefault<ETCDivipola>(con, "API.PA_ETCDivipolaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ETCDivipola  ->" + ex.Message);
				}
			}

		



            public List<ETCDivipola> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ETCDivipola> ETCDivipolaList = new List<ETCDivipola>();

                    ETCDivipolaList = SqlMapper.Query<ETCDivipola>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ETCDivipolaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ETCDivipola  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ETCDivipola> b)
            {
                DapperPlusManager.Entity<ETCDivipola>().Table("ETCDivipola");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}