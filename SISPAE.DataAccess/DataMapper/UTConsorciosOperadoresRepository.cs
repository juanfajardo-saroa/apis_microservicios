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
     /// Clase Abstracta para  UTConsorciosOperadores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class UTConsorciosOperadoresRepository : DataObject , IUTConsorciosOperadores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public UTConsorciosOperadoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public UTConsorciosOperadoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public UTConsorciosOperadores GetById(UTConsorciosOperadores pUTConsorciosOperadores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pUTConsorciosOperadores.id);                                    


    				UTConsorciosOperadores o = SqlMapper.QueryFirstOrDefault<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}

			public List<UTConsorciosOperadores> GetAll()
			{
				try 
                {
                        List<UTConsorciosOperadores> l = SqlMapper.Query<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}

			public List<UTConsorciosOperadores> GetAllFull()
			{
				try 
				{
                    List<UTConsorciosOperadores> l = SqlMapper.Query<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}
			
			public List<UTConsorciosOperadores> GetAllByWithRelation()
			{
				try 
                {
                    List<UTConsorciosOperadores> l = SqlMapper.Query<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<UTConsorciosOperadores> GetByFilter(UTConsorciosOperadores pUTConsorciosOperadores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pUTConsorciosOperadores.id== null || pUTConsorciosOperadores.id==0) ? vintNUll :pUTConsorciosOperadores.id);
                    p.Add("@ID_Operador",(pUTConsorciosOperadores.ID_Operador== null || pUTConsorciosOperadores.ID_Operador==0) ? vintNUll :pUTConsorciosOperadores.ID_Operador);
                    p.Add("@ID_Consorcio",(pUTConsorciosOperadores.ID_Consorcio== null || pUTConsorciosOperadores.ID_Consorcio==0) ? vintNUll :pUTConsorciosOperadores.ID_Consorcio);
                    p.Add("@CantidadParticipacion",(pUTConsorciosOperadores.CantidadParticipacion== null) ? vintNUll :pUTConsorciosOperadores.CantidadParticipacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<UTConsorciosOperadores> l = SqlMapper.Query<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}

			public UTConsorciosOperadores Add(UTConsorciosOperadores pUTConsorciosOperadores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pUTConsorciosOperadores.id==null ? 0 : pUTConsorciosOperadores.id);
p.Add("@ID_Operador",pUTConsorciosOperadores.ID_Operador==null ? 0 : pUTConsorciosOperadores.ID_Operador);
p.Add("@ID_Consorcio",pUTConsorciosOperadores.ID_Consorcio==null ? 0 : pUTConsorciosOperadores.ID_Consorcio);
p.Add("@CantidadParticipacion",pUTConsorciosOperadores.CantidadParticipacion==null ? 0 : pUTConsorciosOperadores.CantidadParticipacion);
                    p.Add("@auditoria", pUTConsorciosOperadores.auditoria);

                         


                    UTConsorciosOperadores o = SqlMapper.QueryFirstOrDefault<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}

			public UTConsorciosOperadores  Update(UTConsorciosOperadores pUTConsorciosOperadores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pUTConsorciosOperadores.id==null ? 0 : pUTConsorciosOperadores.id);
p.Add("@ID_Operador",pUTConsorciosOperadores.ID_Operador==null ? 0 : pUTConsorciosOperadores.ID_Operador);
p.Add("@ID_Consorcio",pUTConsorciosOperadores.ID_Consorcio==null ? 0 : pUTConsorciosOperadores.ID_Consorcio);
p.Add("@CantidadParticipacion",pUTConsorciosOperadores.CantidadParticipacion==null ? 0 : pUTConsorciosOperadores.CantidadParticipacion);
                    p.Add("@auditoria", pUTConsorciosOperadores.auditoria);

                         


                    UTConsorciosOperadores o = SqlMapper.QueryFirstOrDefault<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  UTConsorciosOperadores  ->" + ex.Message);
				}
			}

			public bool Delete(UTConsorciosOperadores pUTConsorciosOperadores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pUTConsorciosOperadores.id);
                    p.Add("@auditoria", pUTConsorciosOperadores.auditoria);

                

 

					UTConsorciosOperadores o = SqlMapper.QueryFirstOrDefault<UTConsorciosOperadores>(con, "API.PA_UTConsorciosOperadoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) UTConsorciosOperadores  ->" + ex.Message);
				}
			}

		



            public List<UTConsorciosOperadores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<UTConsorciosOperadores> UTConsorciosOperadoresList = new List<UTConsorciosOperadores>();

                    UTConsorciosOperadoresList = SqlMapper.Query<UTConsorciosOperadores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return UTConsorciosOperadoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) UTConsorciosOperadores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<UTConsorciosOperadores> b)
            {
                DapperPlusManager.Entity<UTConsorciosOperadores>().Table("UTConsorciosOperadores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}