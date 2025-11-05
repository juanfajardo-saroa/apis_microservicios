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
     /// Clase Abstracta para  Escalas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EscalasRepository : DataObject , IEscalas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EscalasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EscalasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Escalas GetById(Escalas pEscalas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEscalas.id);                                    


    				Escalas o = SqlMapper.QueryFirstOrDefault<Escalas>(con, "API.PA_EscalasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Escalas  ->" + ex.Message);
				}
			}

			public List<Escalas> GetAll()
			{
				try 
                {
                        List<Escalas> l = SqlMapper.Query<Escalas>(con, "API.PA_EscalasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Escalas  ->" + ex.Message);
				}
			}

			public List<Escalas> GetAllFull()
			{
				try 
				{
                    List<Escalas> l = SqlMapper.Query<Escalas>(con, "API.PA_EscalasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Escalas  ->" + ex.Message);
				}
			}
			
			public List<Escalas> GetAllByWithRelation()
			{
				try 
                {
                    List<Escalas> l = SqlMapper.Query<Escalas>(con, "API.PA_EscalasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Escalas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Escalas> GetByFilter(Escalas pEscalas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEscalas.id== null || pEscalas.id==0) ? vintNUll :pEscalas.id);
                    p.Add("@Nombre",(pEscalas.Nombre== null) ? vintNUll :pEscalas.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Escalas> l = SqlMapper.Query<Escalas>(con, "API.PA_EscalasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Escalas  ->" + ex.Message);
				}
			}

			public Escalas Add(Escalas pEscalas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEscalas.id==null ? 0 : pEscalas.id);
                    p.Add("@Nombre", pEscalas.Nombre);
                    p.Add("@auditoria", pEscalas.auditoria);

                         


                    Escalas o = SqlMapper.QueryFirstOrDefault<Escalas>(con, "API.PA_EscalasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Escalas  ->" + ex.Message);
				}
			}

			public Escalas  Update(Escalas pEscalas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEscalas.id==null ? 0 : pEscalas.id);
                    p.Add("@Nombre", pEscalas.Nombre);
                    p.Add("@auditoria", pEscalas.auditoria);

                         


                    Escalas o = SqlMapper.QueryFirstOrDefault<Escalas>(con, "API.PA_EscalasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Escalas  ->" + ex.Message);
				}
			}

			public bool Delete(Escalas pEscalas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEscalas.id);
                    p.Add("@auditoria", pEscalas.auditoria);

                

 

					Escalas o = SqlMapper.QueryFirstOrDefault<Escalas>(con, "API.PA_EscalasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Escalas  ->" + ex.Message);
				}
			}

		



            public List<Escalas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Escalas> EscalasList = new List<Escalas>();

                    EscalasList = SqlMapper.Query<Escalas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EscalasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Escalas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Escalas> b)
            {
                DapperPlusManager.Entity<Escalas>().Table("Escalas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}