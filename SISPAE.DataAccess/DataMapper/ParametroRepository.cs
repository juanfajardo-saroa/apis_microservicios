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
     /// Clase Abstracta para  Parametro
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ParametroRepository : DataObject , IParametro 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ParametroRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ParametroRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Parametro GetById(Parametro pParametro)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pParametro.id);                                    


    				Parametro o = SqlMapper.QueryFirstOrDefault<Parametro>(con, "API.PA_ParametroGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Parametro  ->" + ex.Message);
				}
			}

			public List<Parametro> GetAll()
			{
				try 
                {
                        List<Parametro> l = SqlMapper.Query<Parametro>(con, "API.PA_ParametroGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Parametro  ->" + ex.Message);
				}
			}

			public List<Parametro> GetAllFull()
			{
				try 
				{
                    List<Parametro> l = SqlMapper.Query<Parametro>(con, "API.PA_ParametroGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Parametro  ->" + ex.Message);
				}
			}
			
			public List<Parametro> GetAllByWithRelation()
			{
				try 
                {
                    List<Parametro> l = SqlMapper.Query<Parametro>(con, "API.PA_ParametroGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Parametro  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Parametro> GetByFilter(Parametro pParametro, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pParametro.id== null || pParametro.id==0) ? vintNUll :pParametro.id);
                    p.Add("@Nombre",(pParametro.Nombre== null) ? vintNUll :pParametro.Nombre);
                    p.Add("@valor",(pParametro.valor== null) ? vintNUll :pParametro.valor);
                    p.Add("@unidad",(pParametro.unidad== null) ? vintNUll :pParametro.unidad);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Parametro> l = SqlMapper.Query<Parametro>(con, "API.PA_ParametroGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Parametro  ->" + ex.Message);
				}
			}

			public Parametro Add(Parametro pParametro)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pParametro.id==null ? 0 : pParametro.id);
                    p.Add("@Nombre", pParametro.Nombre);
                    p.Add("@valor", pParametro.valor);
                    p.Add("@unidad", pParametro.unidad);
                    p.Add("@auditoria", pParametro.auditoria);

                         


                    Parametro o = SqlMapper.QueryFirstOrDefault<Parametro>(con, "API.PA_ParametroAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Parametro  ->" + ex.Message);
				}
			}

			public Parametro  Update(Parametro pParametro)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pParametro.id==null ? 0 : pParametro.id);
                    p.Add("@Nombre", pParametro.Nombre);
                    p.Add("@valor", pParametro.valor);
                    p.Add("@unidad", pParametro.unidad);
                    p.Add("@auditoria", pParametro.auditoria);

                         


                    Parametro o = SqlMapper.QueryFirstOrDefault<Parametro>(con, "API.PA_ParametroUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Parametro  ->" + ex.Message);
				}
			}

			public bool Delete(Parametro pParametro)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pParametro.id);
                    p.Add("@auditoria", pParametro.auditoria);

                

 

					Parametro o = SqlMapper.QueryFirstOrDefault<Parametro>(con, "API.PA_ParametroDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Parametro  ->" + ex.Message);
				}
			}

		



            public List<Parametro> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Parametro> ParametroList = new List<Parametro>();

                    ParametroList = SqlMapper.Query<Parametro>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ParametroList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Parametro  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Parametro> b)
            {
                DapperPlusManager.Entity<Parametro>().Table("Parametro");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}