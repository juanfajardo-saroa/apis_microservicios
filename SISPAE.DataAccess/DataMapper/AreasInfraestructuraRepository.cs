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
     /// Clase Abstracta para  AreasInfraestructura
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AreasInfraestructuraRepository : DataObject , IAreasInfraestructura 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AreasInfraestructuraRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AreasInfraestructuraRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AreasInfraestructura GetById(AreasInfraestructura pAreasInfraestructura)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAreasInfraestructura.id);                                    


    				AreasInfraestructura o = SqlMapper.QueryFirstOrDefault<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AreasInfraestructura  ->" + ex.Message);
				}
			}

			public List<AreasInfraestructura> GetAll()
			{
				try 
                {
                        List<AreasInfraestructura> l = SqlMapper.Query<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AreasInfraestructura  ->" + ex.Message);
				}
			}

			public List<AreasInfraestructura> GetAllFull()
			{
				try 
				{
                    List<AreasInfraestructura> l = SqlMapper.Query<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AreasInfraestructura  ->" + ex.Message);
				}
			}
			
			public List<AreasInfraestructura> GetAllByWithRelation()
			{
				try 
                {
                    List<AreasInfraestructura> l = SqlMapper.Query<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AreasInfraestructura  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AreasInfraestructura> GetByFilter(AreasInfraestructura pAreasInfraestructura, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAreasInfraestructura.id== null || pAreasInfraestructura.id==0) ? vintNUll :pAreasInfraestructura.id);
                    p.Add("@ID_Dimension",(pAreasInfraestructura.ID_Dimension== null || pAreasInfraestructura.ID_Dimension==0) ? vintNUll :pAreasInfraestructura.ID_Dimension);
                    p.Add("@Nombre",(pAreasInfraestructura.Nombre== null) ? vintNUll :pAreasInfraestructura.Nombre);
                    p.Add("@icono",(pAreasInfraestructura.icono== null) ? vintNUll :pAreasInfraestructura.icono);
                    p.Add("@PonderacionRps",(pAreasInfraestructura.PonderacionRps== null) ? vintNUll :pAreasInfraestructura.PonderacionRps);
                    p.Add("@PonderacionRi",(pAreasInfraestructura.PonderacionRi== null) ? vintNUll :pAreasInfraestructura.PonderacionRi);
                    p.Add("@PonderacionCatering",(pAreasInfraestructura.PonderacionCatering== null) ? vintNUll :pAreasInfraestructura.PonderacionCatering);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AreasInfraestructura> l = SqlMapper.Query<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AreasInfraestructura  ->" + ex.Message);
				}
			}

			public AreasInfraestructura Add(AreasInfraestructura pAreasInfraestructura)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAreasInfraestructura.id==null ? 0 : pAreasInfraestructura.id);
p.Add("@ID_Dimension",pAreasInfraestructura.ID_Dimension==null ? 0 : pAreasInfraestructura.ID_Dimension);
                    p.Add("@Nombre", pAreasInfraestructura.Nombre);
                    p.Add("@icono", pAreasInfraestructura.icono);
                    p.Add("@PonderacionRps", pAreasInfraestructura.PonderacionRps);
                    p.Add("@PonderacionRi", pAreasInfraestructura.PonderacionRi);
                    p.Add("@PonderacionCatering", pAreasInfraestructura.PonderacionCatering);
                    p.Add("@auditoria", pAreasInfraestructura.auditoria);

                         


                    AreasInfraestructura o = SqlMapper.QueryFirstOrDefault<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AreasInfraestructura  ->" + ex.Message);
				}
			}

			public AreasInfraestructura  Update(AreasInfraestructura pAreasInfraestructura)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAreasInfraestructura.id==null ? 0 : pAreasInfraestructura.id);
p.Add("@ID_Dimension",pAreasInfraestructura.ID_Dimension==null ? 0 : pAreasInfraestructura.ID_Dimension);
                    p.Add("@Nombre", pAreasInfraestructura.Nombre);
                    p.Add("@icono", pAreasInfraestructura.icono);
                    p.Add("@PonderacionRps", pAreasInfraestructura.PonderacionRps);
                    p.Add("@PonderacionRi", pAreasInfraestructura.PonderacionRi);
                    p.Add("@PonderacionCatering", pAreasInfraestructura.PonderacionCatering);
                    p.Add("@auditoria", pAreasInfraestructura.auditoria);

                         


                    AreasInfraestructura o = SqlMapper.QueryFirstOrDefault<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AreasInfraestructura  ->" + ex.Message);
				}
			}

			public bool Delete(AreasInfraestructura pAreasInfraestructura)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAreasInfraestructura.id);
                    p.Add("@auditoria", pAreasInfraestructura.auditoria);

                

 

					AreasInfraestructura o = SqlMapper.QueryFirstOrDefault<AreasInfraestructura>(con, "API.PA_AreasInfraestructuraDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AreasInfraestructura  ->" + ex.Message);
				}
			}

		



            public List<AreasInfraestructura> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AreasInfraestructura> AreasInfraestructuraList = new List<AreasInfraestructura>();

                    AreasInfraestructuraList = SqlMapper.Query<AreasInfraestructura>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AreasInfraestructuraList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AreasInfraestructura  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AreasInfraestructura> b)
            {
                DapperPlusManager.Entity<AreasInfraestructura>().Table("AreasInfraestructura");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}