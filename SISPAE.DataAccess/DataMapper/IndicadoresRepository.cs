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
     /// Clase Abstracta para  Indicadores
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class IndicadoresRepository : DataObject , IIndicadores 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public IndicadoresRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public IndicadoresRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Indicadores GetById(Indicadores pIndicadores)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pIndicadores.id);                                    


    				Indicadores o = SqlMapper.QueryFirstOrDefault<Indicadores>(con, "API.PA_IndicadoresGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Indicadores  ->" + ex.Message);
				}
			}

			public List<Indicadores> GetAll()
			{
				try 
                {
                        List<Indicadores> l = SqlMapper.Query<Indicadores>(con, "API.PA_IndicadoresGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Indicadores  ->" + ex.Message);
				}
			}

			public List<Indicadores> GetAllFull()
			{
				try 
				{
                    List<Indicadores> l = SqlMapper.Query<Indicadores>(con, "API.PA_IndicadoresGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Indicadores  ->" + ex.Message);
				}
			}
			
			public List<Indicadores> GetAllByWithRelation()
			{
				try 
                {
                    List<Indicadores> l = SqlMapper.Query<Indicadores>(con, "API.PA_IndicadoresGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Indicadores  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Indicadores> GetByFilter(Indicadores pIndicadores, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pIndicadores.id== null || pIndicadores.id==0) ? vintNUll :pIndicadores.id);
                    p.Add("@ID_Area",(pIndicadores.ID_Area== null || pIndicadores.ID_Area==0) ? vintNUll :pIndicadores.ID_Area);
                    p.Add("@Enunciado",(pIndicadores.Enunciado== null) ? vintNUll :pIndicadores.Enunciado);
                    p.Add("@icono",(pIndicadores.icono== null) ? vintNUll :pIndicadores.icono);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Indicadores> l = SqlMapper.Query<Indicadores>(con, "API.PA_IndicadoresGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Indicadores  ->" + ex.Message);
				}
			}

			public Indicadores Add(Indicadores pIndicadores)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pIndicadores.id==null ? 0 : pIndicadores.id);
p.Add("@ID_Area",pIndicadores.ID_Area==null ? 0 : pIndicadores.ID_Area);
                    p.Add("@Enunciado", pIndicadores.Enunciado);
                    p.Add("@icono", pIndicadores.icono);
                    p.Add("@auditoria", pIndicadores.auditoria);

                         


                    Indicadores o = SqlMapper.QueryFirstOrDefault<Indicadores>(con, "API.PA_IndicadoresAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Indicadores  ->" + ex.Message);
				}
			}

			public Indicadores  Update(Indicadores pIndicadores)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pIndicadores.id==null ? 0 : pIndicadores.id);
p.Add("@ID_Area",pIndicadores.ID_Area==null ? 0 : pIndicadores.ID_Area);
                    p.Add("@Enunciado", pIndicadores.Enunciado);
                    p.Add("@icono", pIndicadores.icono);
                    p.Add("@auditoria", pIndicadores.auditoria);

                         


                    Indicadores o = SqlMapper.QueryFirstOrDefault<Indicadores>(con, "API.PA_IndicadoresUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Indicadores  ->" + ex.Message);
				}
			}

			public bool Delete(Indicadores pIndicadores)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pIndicadores.id);
                    p.Add("@auditoria", pIndicadores.auditoria);

                

 

					Indicadores o = SqlMapper.QueryFirstOrDefault<Indicadores>(con, "API.PA_IndicadoresDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Indicadores  ->" + ex.Message);
				}
			}

		



            public List<Indicadores> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Indicadores> IndicadoresList = new List<Indicadores>();

                    IndicadoresList = SqlMapper.Query<Indicadores>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return IndicadoresList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Indicadores  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Indicadores> b)
            {
                DapperPlusManager.Entity<Indicadores>().Table("Indicadores");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}