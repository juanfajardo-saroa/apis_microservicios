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
     /// Clase Abstracta para  Tiposltems
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class TiposltemsRepository : DataObject , ITiposltems 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public TiposltemsRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public TiposltemsRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Tiposltems GetById(Tiposltems pTiposltems)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposltems.id);                                    


    				Tiposltems o = SqlMapper.QueryFirstOrDefault<Tiposltems>(con, "API.PA_TiposltemsGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Tiposltems  ->" + ex.Message);
				}
			}

			public List<Tiposltems> GetAll()
			{
				try 
                {
                        List<Tiposltems> l = SqlMapper.Query<Tiposltems>(con, "API.PA_TiposltemsGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Tiposltems  ->" + ex.Message);
				}
			}

			public List<Tiposltems> GetAllFull()
			{
				try 
				{
                    List<Tiposltems> l = SqlMapper.Query<Tiposltems>(con, "API.PA_TiposltemsGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Tiposltems  ->" + ex.Message);
				}
			}
			
			public List<Tiposltems> GetAllByWithRelation()
			{
				try 
                {
                    List<Tiposltems> l = SqlMapper.Query<Tiposltems>(con, "API.PA_TiposltemsGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Tiposltems  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Tiposltems> GetByFilter(Tiposltems pTiposltems, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pTiposltems.id== null || pTiposltems.id==0) ? vintNUll :pTiposltems.id);
                    p.Add("@Nombre",(pTiposltems.Nombre== null) ? vintNUll :pTiposltems.Nombre);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Tiposltems> l = SqlMapper.Query<Tiposltems>(con, "API.PA_TiposltemsGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Tiposltems  ->" + ex.Message);
				}
			}

			public Tiposltems Add(Tiposltems pTiposltems)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pTiposltems.id==null ? 0 : pTiposltems.id);
                    p.Add("@Nombre", pTiposltems.Nombre);
                    p.Add("@auditoria", pTiposltems.auditoria);

                         


                    Tiposltems o = SqlMapper.QueryFirstOrDefault<Tiposltems>(con, "API.PA_TiposltemsAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Tiposltems  ->" + ex.Message);
				}
			}

			public Tiposltems  Update(Tiposltems pTiposltems)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pTiposltems.id==null ? 0 : pTiposltems.id);
                    p.Add("@Nombre", pTiposltems.Nombre);
                    p.Add("@auditoria", pTiposltems.auditoria);

                         


                    Tiposltems o = SqlMapper.QueryFirstOrDefault<Tiposltems>(con, "API.PA_TiposltemsUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Tiposltems  ->" + ex.Message);
				}
			}

			public bool Delete(Tiposltems pTiposltems)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pTiposltems.id);
                    p.Add("@auditoria", pTiposltems.auditoria);

                

 

					Tiposltems o = SqlMapper.QueryFirstOrDefault<Tiposltems>(con, "API.PA_TiposltemsDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Tiposltems  ->" + ex.Message);
				}
			}

		



            public List<Tiposltems> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Tiposltems> TiposltemsList = new List<Tiposltems>();

                    TiposltemsList = SqlMapper.Query<Tiposltems>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return TiposltemsList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Tiposltems  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Tiposltems> b)
            {
                DapperPlusManager.Entity<Tiposltems>().Table("Tiposltems");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}