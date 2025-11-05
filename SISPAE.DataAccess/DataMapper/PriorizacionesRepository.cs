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
     /// Clase Abstracta para  Priorizaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PriorizacionesRepository : DataObject , IPriorizaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PriorizacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PriorizacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Priorizaciones GetById(Priorizaciones pPriorizaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPriorizaciones.id);                                    


    				Priorizaciones o = SqlMapper.QueryFirstOrDefault<Priorizaciones>(con, "API.PA_PriorizacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Priorizaciones  ->" + ex.Message);
				}
			}

			public List<Priorizaciones> GetAll()
			{
				try 
                {
                        List<Priorizaciones> l = SqlMapper.Query<Priorizaciones>(con, "API.PA_PriorizacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Priorizaciones  ->" + ex.Message);
				}
			}

			public List<Priorizaciones> GetAllFull()
			{
				try 
				{
                    List<Priorizaciones> l = SqlMapper.Query<Priorizaciones>(con, "API.PA_PriorizacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Priorizaciones  ->" + ex.Message);
				}
			}
			
			public List<Priorizaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<Priorizaciones> l = SqlMapper.Query<Priorizaciones>(con, "API.PA_PriorizacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Priorizaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Priorizaciones> GetByFilter(Priorizaciones pPriorizaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPriorizaciones.id== null || pPriorizaciones.id==0) ? vintNUll :pPriorizaciones.id);
                    p.Add("@ID_GradoSedeJornada",(pPriorizaciones.ID_GradoSedeJornada== null || pPriorizaciones.ID_GradoSedeJornada==0) ? vintNUll :pPriorizaciones.ID_GradoSedeJornada);
                    p.Add("@ID_TipoModalidadComplemento",(pPriorizaciones.ID_TipoModalidadComplemento== null || pPriorizaciones.ID_TipoModalidadComplemento==0) ? vintNUll :pPriorizaciones.ID_TipoModalidadComplemento);
                    p.Add("@ID_TipoModeloOperacion",(pPriorizaciones.ID_TipoModeloOperacion== null || pPriorizaciones.ID_TipoModeloOperacion==0) ? vintNUll :pPriorizaciones.ID_TipoModeloOperacion);
                    p.Add("@ID_TipoComplemento",(pPriorizaciones.ID_TipoComplemento== null || pPriorizaciones.ID_TipoComplemento==0) ? vintNUll :pPriorizaciones.ID_TipoComplemento);
                    p.Add("@ID_TipoEstadoPriorizacion",(pPriorizaciones.ID_TipoEstadoPriorizacion== null || pPriorizaciones.ID_TipoEstadoPriorizacion==0) ? vintNUll :pPriorizaciones.ID_TipoEstadoPriorizacion);
                    p.Add("@ID_Vigencia",(pPriorizaciones.ID_Vigencia== null || pPriorizaciones.ID_Vigencia==0) ? vintNUll :pPriorizaciones.ID_Vigencia);
                    p.Add("@NumeroComplementos",(pPriorizaciones.NumeroComplementos== null) ? vintNUll :pPriorizaciones.NumeroComplementos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Priorizaciones> l = SqlMapper.Query<Priorizaciones>(con, "API.PA_PriorizacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Priorizaciones  ->" + ex.Message);
				}
			}

			public Priorizaciones Add(Priorizaciones pPriorizaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPriorizaciones.id==null ? 0 : pPriorizaciones.id);
p.Add("@ID_GradoSedeJornada",pPriorizaciones.ID_GradoSedeJornada==null ? 0 : pPriorizaciones.ID_GradoSedeJornada);
p.Add("@ID_TipoModalidadComplemento",pPriorizaciones.ID_TipoModalidadComplemento==null ? 0 : pPriorizaciones.ID_TipoModalidadComplemento);
p.Add("@ID_TipoModeloOperacion",pPriorizaciones.ID_TipoModeloOperacion==null ? 0 : pPriorizaciones.ID_TipoModeloOperacion);
p.Add("@ID_TipoComplemento",pPriorizaciones.ID_TipoComplemento==null ? 0 : pPriorizaciones.ID_TipoComplemento);
p.Add("@ID_TipoEstadoPriorizacion",pPriorizaciones.ID_TipoEstadoPriorizacion==null ? 0 : pPriorizaciones.ID_TipoEstadoPriorizacion);
p.Add("@ID_Vigencia",pPriorizaciones.ID_Vigencia==null ? 0 : pPriorizaciones.ID_Vigencia);
p.Add("@NumeroComplementos",pPriorizaciones.NumeroComplementos==null ? 0 : pPriorizaciones.NumeroComplementos);
                    p.Add("@auditoria", pPriorizaciones.auditoria);

                         


                    Priorizaciones o = SqlMapper.QueryFirstOrDefault<Priorizaciones>(con, "API.PA_PriorizacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Priorizaciones  ->" + ex.Message);
				}
			}

			public Priorizaciones  Update(Priorizaciones pPriorizaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPriorizaciones.id==null ? 0 : pPriorizaciones.id);
p.Add("@ID_GradoSedeJornada",pPriorizaciones.ID_GradoSedeJornada==null ? 0 : pPriorizaciones.ID_GradoSedeJornada);
p.Add("@ID_TipoModalidadComplemento",pPriorizaciones.ID_TipoModalidadComplemento==null ? 0 : pPriorizaciones.ID_TipoModalidadComplemento);
p.Add("@ID_TipoModeloOperacion",pPriorizaciones.ID_TipoModeloOperacion==null ? 0 : pPriorizaciones.ID_TipoModeloOperacion);
p.Add("@ID_TipoComplemento",pPriorizaciones.ID_TipoComplemento==null ? 0 : pPriorizaciones.ID_TipoComplemento);
p.Add("@ID_TipoEstadoPriorizacion",pPriorizaciones.ID_TipoEstadoPriorizacion==null ? 0 : pPriorizaciones.ID_TipoEstadoPriorizacion);
p.Add("@ID_Vigencia",pPriorizaciones.ID_Vigencia==null ? 0 : pPriorizaciones.ID_Vigencia);
p.Add("@NumeroComplementos",pPriorizaciones.NumeroComplementos==null ? 0 : pPriorizaciones.NumeroComplementos);
                    p.Add("@auditoria", pPriorizaciones.auditoria);

                         


                    Priorizaciones o = SqlMapper.QueryFirstOrDefault<Priorizaciones>(con, "API.PA_PriorizacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Priorizaciones  ->" + ex.Message);
				}
			}

			public bool Delete(Priorizaciones pPriorizaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPriorizaciones.id);
                    p.Add("@auditoria", pPriorizaciones.auditoria);

                

 

					Priorizaciones o = SqlMapper.QueryFirstOrDefault<Priorizaciones>(con, "API.PA_PriorizacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Priorizaciones  ->" + ex.Message);
				}
			}

		



            public List<Priorizaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Priorizaciones> PriorizacionesList = new List<Priorizaciones>();

                    PriorizacionesList = SqlMapper.Query<Priorizaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PriorizacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Priorizaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Priorizaciones> b)
            {
                DapperPlusManager.Entity<Priorizaciones>().Table("Priorizaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}