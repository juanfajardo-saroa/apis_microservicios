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
     /// Clase Abstracta para  Semanas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class SemanasRepository : DataObject , ISemanas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public SemanasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public SemanasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Semanas GetById(Semanas pSemanas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanas.id);                                    


    				Semanas o = SqlMapper.QueryFirstOrDefault<Semanas>(con, "API.PA_SemanasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Semanas  ->" + ex.Message);
				}
			}

			public List<Semanas> GetAll()
			{
				try 
                {
                        List<Semanas> l = SqlMapper.Query<Semanas>(con, "API.PA_SemanasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Semanas  ->" + ex.Message);
				}
			}

			public List<Semanas> GetAllFull()
			{
				try 
				{
                    List<Semanas> l = SqlMapper.Query<Semanas>(con, "API.PA_SemanasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Semanas  ->" + ex.Message);
				}
			}
			
			public List<Semanas> GetAllByWithRelation()
			{
				try 
                {
                    List<Semanas> l = SqlMapper.Query<Semanas>(con, "API.PA_SemanasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Semanas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Semanas> GetByFilter(Semanas pSemanas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pSemanas.id== null || pSemanas.id==0) ? vintNUll :pSemanas.id);
                    p.Add("@ID_PlanAlistamiento",(pSemanas.ID_PlanAlistamiento== null || pSemanas.ID_PlanAlistamiento==0) ? vintNUll :pSemanas.ID_PlanAlistamiento);
                    p.Add("@ID_TipoModeloOperacion",(pSemanas.ID_TipoModeloOperacion== null || pSemanas.ID_TipoModeloOperacion==0) ? vintNUll :pSemanas.ID_TipoModeloOperacion);
                    p.Add("@Numero",(pSemanas.Numero== null) ? vintNUll :pSemanas.Numero);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Semanas> l = SqlMapper.Query<Semanas>(con, "API.PA_SemanasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Semanas  ->" + ex.Message);
				}
			}

			public Semanas Add(Semanas pSemanas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pSemanas.id==null ? 0 : pSemanas.id);
p.Add("@ID_PlanAlistamiento",pSemanas.ID_PlanAlistamiento==null ? 0 : pSemanas.ID_PlanAlistamiento);
p.Add("@ID_TipoModeloOperacion",pSemanas.ID_TipoModeloOperacion==null ? 0 : pSemanas.ID_TipoModeloOperacion);
p.Add("@Numero",pSemanas.Numero==null ? 0 : pSemanas.Numero);
                    p.Add("@auditoria", pSemanas.auditoria);

                         


                    Semanas o = SqlMapper.QueryFirstOrDefault<Semanas>(con, "API.PA_SemanasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Semanas  ->" + ex.Message);
				}
			}

			public Semanas  Update(Semanas pSemanas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pSemanas.id==null ? 0 : pSemanas.id);
p.Add("@ID_PlanAlistamiento",pSemanas.ID_PlanAlistamiento==null ? 0 : pSemanas.ID_PlanAlistamiento);
p.Add("@ID_TipoModeloOperacion",pSemanas.ID_TipoModeloOperacion==null ? 0 : pSemanas.ID_TipoModeloOperacion);
p.Add("@Numero",pSemanas.Numero==null ? 0 : pSemanas.Numero);
                    p.Add("@auditoria", pSemanas.auditoria);

                         


                    Semanas o = SqlMapper.QueryFirstOrDefault<Semanas>(con, "API.PA_SemanasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Semanas  ->" + ex.Message);
				}
			}

			public bool Delete(Semanas pSemanas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pSemanas.id);
                    p.Add("@auditoria", pSemanas.auditoria);

                

 

					Semanas o = SqlMapper.QueryFirstOrDefault<Semanas>(con, "API.PA_SemanasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Semanas  ->" + ex.Message);
				}
			}

		



            public List<Semanas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Semanas> SemanasList = new List<Semanas>();

                    SemanasList = SqlMapper.Query<Semanas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return SemanasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Semanas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Semanas> b)
            {
                DapperPlusManager.Entity<Semanas>().Table("Semanas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}