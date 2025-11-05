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
     /// Clase Abstracta para  Meses
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MesesRepository : DataObject , IMeses 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MesesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MesesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Meses GetById(Meses pMeses)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMeses.id);                                    


    				Meses o = SqlMapper.QueryFirstOrDefault<Meses>(con, "API.PA_MesesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Meses  ->" + ex.Message);
				}
			}

			public List<Meses> GetAll()
			{
				try 
                {
                        List<Meses> l = SqlMapper.Query<Meses>(con, "API.PA_MesesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Meses  ->" + ex.Message);
				}
			}

			public List<Meses> GetAllFull()
			{
				try 
				{
                    List<Meses> l = SqlMapper.Query<Meses>(con, "API.PA_MesesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Meses  ->" + ex.Message);
				}
			}
			
			public List<Meses> GetAllByWithRelation()
			{
				try 
                {
                    List<Meses> l = SqlMapper.Query<Meses>(con, "API.PA_MesesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Meses  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Meses> GetByFilter(Meses pMeses, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMeses.id== null || pMeses.id==0) ? vintNUll :pMeses.id);
                    p.Add("@numero",(pMeses.numero== null) ? vintNUll :pMeses.numero);
                    p.Add("@Nombre",(pMeses.Nombre== null) ? vintNUll :pMeses.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Meses> l = SqlMapper.Query<Meses>(con, "API.PA_MesesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Meses  ->" + ex.Message);
				}
			}

			public Meses Add(Meses pMeses)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMeses.id==null ? 0 : pMeses.id);
p.Add("@numero",pMeses.numero==null ? 0 : pMeses.numero);
                    p.Add("@Nombre", pMeses.Nombre);
                    p.Add("@auditoria", pMeses.auditoria);

                         


                    Meses o = SqlMapper.QueryFirstOrDefault<Meses>(con, "API.PA_MesesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Meses  ->" + ex.Message);
				}
			}

			public Meses  Update(Meses pMeses)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMeses.id==null ? 0 : pMeses.id);
p.Add("@numero",pMeses.numero==null ? 0 : pMeses.numero);
                    p.Add("@Nombre", pMeses.Nombre);
                    p.Add("@auditoria", pMeses.auditoria);

                         


                    Meses o = SqlMapper.QueryFirstOrDefault<Meses>(con, "API.PA_MesesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Meses  ->" + ex.Message);
				}
			}

			public bool Delete(Meses pMeses)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMeses.id);
                    p.Add("@auditoria", pMeses.auditoria);

                

 

					Meses o = SqlMapper.QueryFirstOrDefault<Meses>(con, "API.PA_MesesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Meses  ->" + ex.Message);
				}
			}

		



            public List<Meses> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Meses> MesesList = new List<Meses>();

                    MesesList = SqlMapper.Query<Meses>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MesesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Meses  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Meses> b)
            {
                DapperPlusManager.Entity<Meses>().Table("Meses");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}