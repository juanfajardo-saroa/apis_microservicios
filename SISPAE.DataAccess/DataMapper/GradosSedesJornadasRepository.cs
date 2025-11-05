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
     /// Clase Abstracta para  GradosSedesJornadas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class GradosSedesJornadasRepository : DataObject , IGradosSedesJornadas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public GradosSedesJornadasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public GradosSedesJornadasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public GradosSedesJornadas GetById(GradosSedesJornadas pGradosSedesJornadas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pGradosSedesJornadas.id);                                    


    				GradosSedesJornadas o = SqlMapper.QueryFirstOrDefault<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  GradosSedesJornadas  ->" + ex.Message);
				}
			}

			public List<GradosSedesJornadas> GetAll()
			{
				try 
                {
                        List<GradosSedesJornadas> l = SqlMapper.Query<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  GradosSedesJornadas  ->" + ex.Message);
				}
			}

			public List<GradosSedesJornadas> GetAllFull()
			{
				try 
				{
                    List<GradosSedesJornadas> l = SqlMapper.Query<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  GradosSedesJornadas  ->" + ex.Message);
				}
			}
			
			public List<GradosSedesJornadas> GetAllByWithRelation()
			{
				try 
                {
                    List<GradosSedesJornadas> l = SqlMapper.Query<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  GradosSedesJornadas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<GradosSedesJornadas> GetByFilter(GradosSedesJornadas pGradosSedesJornadas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pGradosSedesJornadas.id== null || pGradosSedesJornadas.id==0) ? vintNUll :pGradosSedesJornadas.id);
                    p.Add("@ID_SedeJornada",(pGradosSedesJornadas.ID_SedeJornada== null || pGradosSedesJornadas.ID_SedeJornada==0) ? vintNUll :pGradosSedesJornadas.ID_SedeJornada);
                    p.Add("@ID_Grado",(pGradosSedesJornadas.ID_Grado== null || pGradosSedesJornadas.ID_Grado==0) ? vintNUll :pGradosSedesJornadas.ID_Grado);
                    p.Add("@Matricula",(pGradosSedesJornadas.Matricula== null) ? vintNUll :pGradosSedesJornadas.Matricula);
                    p.Add("@CantlndigVicDis",(pGradosSedesJornadas.CantlndigVicDis== null) ? vintNUll :pGradosSedesJornadas.CantlndigVicDis);
                    p.Add("@CantSisbenAB",(pGradosSedesJornadas.CantSisbenAB== null) ? vintNUll :pGradosSedesJornadas.CantSisbenAB);
                    p.Add("@CantDiscapacitados",(pGradosSedesJornadas.CantDiscapacitados== null) ? vintNUll :pGradosSedesJornadas.CantDiscapacitados);
                    p.Add("@CantIndigenasDiscapacidad",(pGradosSedesJornadas.CantIndigenasDiscapacidad== null) ? vintNUll :pGradosSedesJornadas.CantIndigenasDiscapacidad);
                    p.Add("@CambioMatricula",(pGradosSedesJornadas.CambioMatricula== null) ? vintNUll :pGradosSedesJornadas.CambioMatricula);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<GradosSedesJornadas> l = SqlMapper.Query<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  GradosSedesJornadas  ->" + ex.Message);
				}
			}

			public GradosSedesJornadas Add(GradosSedesJornadas pGradosSedesJornadas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pGradosSedesJornadas.id==null ? 0 : pGradosSedesJornadas.id);
p.Add("@ID_SedeJornada",pGradosSedesJornadas.ID_SedeJornada==null ? 0 : pGradosSedesJornadas.ID_SedeJornada);
p.Add("@ID_Grado",pGradosSedesJornadas.ID_Grado==null ? 0 : pGradosSedesJornadas.ID_Grado);
p.Add("@Matricula",pGradosSedesJornadas.Matricula==null ? 0 : pGradosSedesJornadas.Matricula);
p.Add("@CantlndigVicDis",pGradosSedesJornadas.CantlndigVicDis==null ? 0 : pGradosSedesJornadas.CantlndigVicDis);
p.Add("@CantSisbenAB",pGradosSedesJornadas.CantSisbenAB==null ? 0 : pGradosSedesJornadas.CantSisbenAB);
p.Add("@CantDiscapacitados",pGradosSedesJornadas.CantDiscapacitados==null ? 0 : pGradosSedesJornadas.CantDiscapacitados);
p.Add("@CantIndigenasDiscapacidad",pGradosSedesJornadas.CantIndigenasDiscapacidad==null ? 0 : pGradosSedesJornadas.CantIndigenasDiscapacidad);
                    p.Add("@CambioMatricula", pGradosSedesJornadas.CambioMatricula);
                    p.Add("@auditoria", pGradosSedesJornadas.auditoria);

                         


                    GradosSedesJornadas o = SqlMapper.QueryFirstOrDefault<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  GradosSedesJornadas  ->" + ex.Message);
				}
			}

			public GradosSedesJornadas  Update(GradosSedesJornadas pGradosSedesJornadas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pGradosSedesJornadas.id==null ? 0 : pGradosSedesJornadas.id);
p.Add("@ID_SedeJornada",pGradosSedesJornadas.ID_SedeJornada==null ? 0 : pGradosSedesJornadas.ID_SedeJornada);
p.Add("@ID_Grado",pGradosSedesJornadas.ID_Grado==null ? 0 : pGradosSedesJornadas.ID_Grado);
p.Add("@Matricula",pGradosSedesJornadas.Matricula==null ? 0 : pGradosSedesJornadas.Matricula);
p.Add("@CantlndigVicDis",pGradosSedesJornadas.CantlndigVicDis==null ? 0 : pGradosSedesJornadas.CantlndigVicDis);
p.Add("@CantSisbenAB",pGradosSedesJornadas.CantSisbenAB==null ? 0 : pGradosSedesJornadas.CantSisbenAB);
p.Add("@CantDiscapacitados",pGradosSedesJornadas.CantDiscapacitados==null ? 0 : pGradosSedesJornadas.CantDiscapacitados);
p.Add("@CantIndigenasDiscapacidad",pGradosSedesJornadas.CantIndigenasDiscapacidad==null ? 0 : pGradosSedesJornadas.CantIndigenasDiscapacidad);
                    p.Add("@CambioMatricula", pGradosSedesJornadas.CambioMatricula);
                    p.Add("@auditoria", pGradosSedesJornadas.auditoria);

                         


                    GradosSedesJornadas o = SqlMapper.QueryFirstOrDefault<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  GradosSedesJornadas  ->" + ex.Message);
				}
			}

			public bool Delete(GradosSedesJornadas pGradosSedesJornadas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pGradosSedesJornadas.id);
                    p.Add("@auditoria", pGradosSedesJornadas.auditoria);

                

 

					GradosSedesJornadas o = SqlMapper.QueryFirstOrDefault<GradosSedesJornadas>(con, "API.PA_GradosSedesJornadasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) GradosSedesJornadas  ->" + ex.Message);
				}
			}

		



            public List<GradosSedesJornadas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<GradosSedesJornadas> GradosSedesJornadasList = new List<GradosSedesJornadas>();

                    GradosSedesJornadasList = SqlMapper.Query<GradosSedesJornadas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return GradosSedesJornadasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) GradosSedesJornadas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<GradosSedesJornadas> b)
            {
                DapperPlusManager.Entity<GradosSedesJornadas>().Table("GradosSedesJornadas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}