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
     /// Clase Abstracta para  Preguntas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PreguntasRepository : DataObject , IPreguntas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PreguntasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PreguntasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Preguntas GetById(Preguntas pPreguntas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPreguntas.id);                                    


    				Preguntas o = SqlMapper.QueryFirstOrDefault<Preguntas>(con, "API.PA_PreguntasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Preguntas  ->" + ex.Message);
				}
			}

			public List<Preguntas> GetAll()
			{
				try 
                {
                        List<Preguntas> l = SqlMapper.Query<Preguntas>(con, "API.PA_PreguntasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Preguntas  ->" + ex.Message);
				}
			}

			public List<Preguntas> GetAllFull()
			{
				try 
				{
                    List<Preguntas> l = SqlMapper.Query<Preguntas>(con, "API.PA_PreguntasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Preguntas  ->" + ex.Message);
				}
			}
			
			public List<Preguntas> GetAllByWithRelation()
			{
				try 
                {
                    List<Preguntas> l = SqlMapper.Query<Preguntas>(con, "API.PA_PreguntasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Preguntas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Preguntas> GetByFilter(Preguntas pPreguntas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPreguntas.id== null || pPreguntas.id==0) ? vintNUll :pPreguntas.id);
                    p.Add("@ID_Cuestionario",(pPreguntas.ID_Cuestionario== null || pPreguntas.ID_Cuestionario==0) ? vintNUll :pPreguntas.ID_Cuestionario);
                    p.Add("@ID_ETC",(pPreguntas.ID_ETC== null || pPreguntas.ID_ETC==0) ? vintNUll :pPreguntas.ID_ETC);
                    p.Add("@Enunciado",(pPreguntas.Enunciado== null) ? vintNUll :pPreguntas.Enunciado);
                    p.Add("@Orden",(pPreguntas.Orden== null) ? vintNUll :pPreguntas.Orden);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Preguntas> l = SqlMapper.Query<Preguntas>(con, "API.PA_PreguntasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Preguntas  ->" + ex.Message);
				}
			}

			public Preguntas Add(Preguntas pPreguntas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPreguntas.id==null ? 0 : pPreguntas.id);
p.Add("@ID_Cuestionario",pPreguntas.ID_Cuestionario==null ? 0 : pPreguntas.ID_Cuestionario);
p.Add("@ID_ETC",pPreguntas.ID_ETC==null ? 0 : pPreguntas.ID_ETC);
                    p.Add("@Enunciado", pPreguntas.Enunciado);
p.Add("@Orden",pPreguntas.Orden==null ? 0 : pPreguntas.Orden);
                    p.Add("@auditoria", pPreguntas.auditoria);

                         


                    Preguntas o = SqlMapper.QueryFirstOrDefault<Preguntas>(con, "API.PA_PreguntasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Preguntas  ->" + ex.Message);
				}
			}

			public Preguntas  Update(Preguntas pPreguntas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPreguntas.id==null ? 0 : pPreguntas.id);
p.Add("@ID_Cuestionario",pPreguntas.ID_Cuestionario==null ? 0 : pPreguntas.ID_Cuestionario);
p.Add("@ID_ETC",pPreguntas.ID_ETC==null ? 0 : pPreguntas.ID_ETC);
                    p.Add("@Enunciado", pPreguntas.Enunciado);
p.Add("@Orden",pPreguntas.Orden==null ? 0 : pPreguntas.Orden);
                    p.Add("@auditoria", pPreguntas.auditoria);

                         


                    Preguntas o = SqlMapper.QueryFirstOrDefault<Preguntas>(con, "API.PA_PreguntasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Preguntas  ->" + ex.Message);
				}
			}

			public bool Delete(Preguntas pPreguntas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPreguntas.id);
                    p.Add("@auditoria", pPreguntas.auditoria);

                

 

					Preguntas o = SqlMapper.QueryFirstOrDefault<Preguntas>(con, "API.PA_PreguntasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Preguntas  ->" + ex.Message);
				}
			}

		



            public List<Preguntas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Preguntas> PreguntasList = new List<Preguntas>();

                    PreguntasList = SqlMapper.Query<Preguntas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PreguntasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Preguntas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Preguntas> b)
            {
                DapperPlusManager.Entity<Preguntas>().Table("Preguntas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}