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
     /// Clase Abstracta para  ConteoComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ConteoComplementosRepository : DataObject , IConteoComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ConteoComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ConteoComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ConteoComplementos GetById(ConteoComplementos pConteoComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pConteoComplementos.id);                                    


    				ConteoComplementos o = SqlMapper.QueryFirstOrDefault<ConteoComplementos>(con, "API.PA_ConteoComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ConteoComplementos  ->" + ex.Message);
				}
			}

			public List<ConteoComplementos> GetAll()
			{
				try 
                {
                        List<ConteoComplementos> l = SqlMapper.Query<ConteoComplementos>(con, "API.PA_ConteoComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ConteoComplementos  ->" + ex.Message);
				}
			}

			public List<ConteoComplementos> GetAllFull()
			{
				try 
				{
                    List<ConteoComplementos> l = SqlMapper.Query<ConteoComplementos>(con, "API.PA_ConteoComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ConteoComplementos  ->" + ex.Message);
				}
			}
			
			public List<ConteoComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<ConteoComplementos> l = SqlMapper.Query<ConteoComplementos>(con, "API.PA_ConteoComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ConteoComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ConteoComplementos> GetByFilter(ConteoComplementos pConteoComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pConteoComplementos.id== null || pConteoComplementos.id==0) ? vintNUll :pConteoComplementos.id);
                    p.Add("@ID_AgrupacionMensual",(pConteoComplementos.ID_AgrupacionMensual== null || pConteoComplementos.ID_AgrupacionMensual==0) ? vintNUll :pConteoComplementos.ID_AgrupacionMensual);
                    p.Add("@ID_TiposModalidadComplemento",(pConteoComplementos.ID_TiposModalidadComplemento== null || pConteoComplementos.ID_TiposModalidadComplemento==0) ? vintNUll :pConteoComplementos.ID_TiposModalidadComplemento);
                    p.Add("@Conteo",(pConteoComplementos.Conteo== null) ? vintNUll :pConteoComplementos.Conteo);
                    p.Add("@FechaEntrega",(pConteoComplementos.FechaEntrega== null) ? vintNUll :pConteoComplementos.FechaEntrega);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ConteoComplementos> l = SqlMapper.Query<ConteoComplementos>(con, "API.PA_ConteoComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ConteoComplementos  ->" + ex.Message);
				}
			}

			public ConteoComplementos Add(ConteoComplementos pConteoComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pConteoComplementos.id==null ? 0 : pConteoComplementos.id);
p.Add("@ID_AgrupacionMensual",pConteoComplementos.ID_AgrupacionMensual==null ? 0 : pConteoComplementos.ID_AgrupacionMensual);
p.Add("@ID_TiposModalidadComplemento",pConteoComplementos.ID_TiposModalidadComplemento==null ? 0 : pConteoComplementos.ID_TiposModalidadComplemento);
                    p.Add("@Conteo", pConteoComplementos.Conteo);
                    p.Add("@FechaEntrega", pConteoComplementos.FechaEntrega);
                    p.Add("@auditoria", pConteoComplementos.auditoria);

                         


                    ConteoComplementos o = SqlMapper.QueryFirstOrDefault<ConteoComplementos>(con, "API.PA_ConteoComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ConteoComplementos  ->" + ex.Message);
				}
			}

			public ConteoComplementos  Update(ConteoComplementos pConteoComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pConteoComplementos.id==null ? 0 : pConteoComplementos.id);
p.Add("@ID_AgrupacionMensual",pConteoComplementos.ID_AgrupacionMensual==null ? 0 : pConteoComplementos.ID_AgrupacionMensual);
p.Add("@ID_TiposModalidadComplemento",pConteoComplementos.ID_TiposModalidadComplemento==null ? 0 : pConteoComplementos.ID_TiposModalidadComplemento);
                    p.Add("@Conteo", pConteoComplementos.Conteo);
                    p.Add("@FechaEntrega", pConteoComplementos.FechaEntrega);
                    p.Add("@auditoria", pConteoComplementos.auditoria);

                         


                    ConteoComplementos o = SqlMapper.QueryFirstOrDefault<ConteoComplementos>(con, "API.PA_ConteoComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ConteoComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(ConteoComplementos pConteoComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pConteoComplementos.id);
                    p.Add("@auditoria", pConteoComplementos.auditoria);

                

 

					ConteoComplementos o = SqlMapper.QueryFirstOrDefault<ConteoComplementos>(con, "API.PA_ConteoComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ConteoComplementos  ->" + ex.Message);
				}
			}

		



            public List<ConteoComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ConteoComplementos> ConteoComplementosList = new List<ConteoComplementos>();

                    ConteoComplementosList = SqlMapper.Query<ConteoComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ConteoComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ConteoComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ConteoComplementos> b)
            {
                DapperPlusManager.Entity<ConteoComplementos>().Table("ConteoComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}