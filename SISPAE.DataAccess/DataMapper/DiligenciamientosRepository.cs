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
     /// Clase Abstracta para  Diligenciamientos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DiligenciamientosRepository : DataObject , IDiligenciamientos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DiligenciamientosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DiligenciamientosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Diligenciamientos GetById(Diligenciamientos pDiligenciamientos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDiligenciamientos.id);                                    


    				Diligenciamientos o = SqlMapper.QueryFirstOrDefault<Diligenciamientos>(con, "API.PA_DiligenciamientosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Diligenciamientos  ->" + ex.Message);
				}
			}

			public List<Diligenciamientos> GetAll()
			{
				try 
                {
                        List<Diligenciamientos> l = SqlMapper.Query<Diligenciamientos>(con, "API.PA_DiligenciamientosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Diligenciamientos  ->" + ex.Message);
				}
			}

			public List<Diligenciamientos> GetAllFull()
			{
				try 
				{
                    List<Diligenciamientos> l = SqlMapper.Query<Diligenciamientos>(con, "API.PA_DiligenciamientosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Diligenciamientos  ->" + ex.Message);
				}
			}
			
			public List<Diligenciamientos> GetAllByWithRelation()
			{
				try 
                {
                    List<Diligenciamientos> l = SqlMapper.Query<Diligenciamientos>(con, "API.PA_DiligenciamientosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Diligenciamientos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Diligenciamientos> GetByFilter(Diligenciamientos pDiligenciamientos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDiligenciamientos.id== null || pDiligenciamientos.id==0) ? vintNUll :pDiligenciamientos.id);
                    p.Add("@ID_TipoDiligenciamiento",(pDiligenciamientos.ID_TipoDiligenciamiento== null || pDiligenciamientos.ID_TipoDiligenciamiento==0) ? vintNUll :pDiligenciamientos.ID_TipoDiligenciamiento);
                    p.Add("@ID_Cuestionario",(pDiligenciamientos.ID_Cuestionario== null || pDiligenciamientos.ID_Cuestionario==0) ? vintNUll :pDiligenciamientos.ID_Cuestionario);
                    p.Add("@ID_VisitaControlSocial",(pDiligenciamientos.ID_VisitaControlSocial== null || pDiligenciamientos.ID_VisitaControlSocial==0) ? vintNUll :pDiligenciamientos.ID_VisitaControlSocial);
                    p.Add("@ID_Visita",(pDiligenciamientos.ID_Visita== null || pDiligenciamientos.ID_Visita==0) ? vintNUll :pDiligenciamientos.ID_Visita);
                    p.Add("@ID_EstadoDiligenciamiento",(pDiligenciamientos.ID_EstadoDiligenciamiento== null || pDiligenciamientos.ID_EstadoDiligenciamiento==0) ? vintNUll :pDiligenciamientos.ID_EstadoDiligenciamiento);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Diligenciamientos> l = SqlMapper.Query<Diligenciamientos>(con, "API.PA_DiligenciamientosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Diligenciamientos  ->" + ex.Message);
				}
			}

			public Diligenciamientos Add(Diligenciamientos pDiligenciamientos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDiligenciamientos.id==null ? 0 : pDiligenciamientos.id);
p.Add("@ID_TipoDiligenciamiento",pDiligenciamientos.ID_TipoDiligenciamiento==null ? 0 : pDiligenciamientos.ID_TipoDiligenciamiento);
p.Add("@ID_Cuestionario",pDiligenciamientos.ID_Cuestionario==null ? 0 : pDiligenciamientos.ID_Cuestionario);
p.Add("@ID_VisitaControlSocial",pDiligenciamientos.ID_VisitaControlSocial==null ? 0 : pDiligenciamientos.ID_VisitaControlSocial);
p.Add("@ID_Visita",pDiligenciamientos.ID_Visita==null ? 0 : pDiligenciamientos.ID_Visita);
p.Add("@ID_EstadoDiligenciamiento",pDiligenciamientos.ID_EstadoDiligenciamiento==null ? 0 : pDiligenciamientos.ID_EstadoDiligenciamiento);
                    p.Add("@auditoria", pDiligenciamientos.auditoria);

                         


                    Diligenciamientos o = SqlMapper.QueryFirstOrDefault<Diligenciamientos>(con, "API.PA_DiligenciamientosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Diligenciamientos  ->" + ex.Message);
				}
			}

			public Diligenciamientos  Update(Diligenciamientos pDiligenciamientos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDiligenciamientos.id==null ? 0 : pDiligenciamientos.id);
p.Add("@ID_TipoDiligenciamiento",pDiligenciamientos.ID_TipoDiligenciamiento==null ? 0 : pDiligenciamientos.ID_TipoDiligenciamiento);
p.Add("@ID_Cuestionario",pDiligenciamientos.ID_Cuestionario==null ? 0 : pDiligenciamientos.ID_Cuestionario);
p.Add("@ID_VisitaControlSocial",pDiligenciamientos.ID_VisitaControlSocial==null ? 0 : pDiligenciamientos.ID_VisitaControlSocial);
p.Add("@ID_Visita",pDiligenciamientos.ID_Visita==null ? 0 : pDiligenciamientos.ID_Visita);
p.Add("@ID_EstadoDiligenciamiento",pDiligenciamientos.ID_EstadoDiligenciamiento==null ? 0 : pDiligenciamientos.ID_EstadoDiligenciamiento);
                    p.Add("@auditoria", pDiligenciamientos.auditoria);

                         


                    Diligenciamientos o = SqlMapper.QueryFirstOrDefault<Diligenciamientos>(con, "API.PA_DiligenciamientosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Diligenciamientos  ->" + ex.Message);
				}
			}

			public bool Delete(Diligenciamientos pDiligenciamientos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDiligenciamientos.id);
                    p.Add("@auditoria", pDiligenciamientos.auditoria);

                

 

					Diligenciamientos o = SqlMapper.QueryFirstOrDefault<Diligenciamientos>(con, "API.PA_DiligenciamientosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Diligenciamientos  ->" + ex.Message);
				}
			}

		



            public List<Diligenciamientos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Diligenciamientos> DiligenciamientosList = new List<Diligenciamientos>();

                    DiligenciamientosList = SqlMapper.Query<Diligenciamientos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DiligenciamientosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Diligenciamientos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Diligenciamientos> b)
            {
                DapperPlusManager.Entity<Diligenciamientos>().Table("Diligenciamientos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}