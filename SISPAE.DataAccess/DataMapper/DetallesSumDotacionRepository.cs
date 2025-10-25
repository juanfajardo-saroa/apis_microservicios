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
     /// Clase Abstracta para  DetallesSumDotacion
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesSumDotacionRepository : DataObject , IDetallesSumDotacion 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesSumDotacionRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesSumDotacionRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesSumDotacion GetById(DetallesSumDotacion pDetallesSumDotacion)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumDotacion.id);                                    


    				DetallesSumDotacion o = SqlMapper.QueryFirstOrDefault<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesSumDotacion  ->" + ex.Message);
				}
			}

			public List<DetallesSumDotacion> GetAll()
			{
				try 
                {
                        List<DetallesSumDotacion> l = SqlMapper.Query<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesSumDotacion  ->" + ex.Message);
				}
			}

			public List<DetallesSumDotacion> GetAllFull()
			{
				try 
				{
                    List<DetallesSumDotacion> l = SqlMapper.Query<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesSumDotacion  ->" + ex.Message);
				}
			}
			
			public List<DetallesSumDotacion> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesSumDotacion> l = SqlMapper.Query<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesSumDotacion  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesSumDotacion> GetByFilter(DetallesSumDotacion pDetallesSumDotacion, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesSumDotacion.id== null || pDetallesSumDotacion.id==0) ? vintNUll :pDetallesSumDotacion.id);
                    p.Add("@ID_Contrato",(pDetallesSumDotacion.ID_Contrato== null || pDetallesSumDotacion.ID_Contrato==0) ? vintNUll :pDetallesSumDotacion.ID_Contrato);
                    p.Add("@NombreProducto",(pDetallesSumDotacion.NombreProducto== null) ? vintNUll :pDetallesSumDotacion.NombreProducto);
                    p.Add("@UnidadesContratadas",(pDetallesSumDotacion.UnidadesContratadas== null) ? vintNUll :pDetallesSumDotacion.UnidadesContratadas);
                    p.Add("@ValorUnitario",(pDetallesSumDotacion.ValorUnitario== null) ? vintNUll :pDetallesSumDotacion.ValorUnitario);
                    p.Add("@ValorTotal",(pDetallesSumDotacion.ValorTotal== null) ? vintNUll :pDetallesSumDotacion.ValorTotal);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesSumDotacion> l = SqlMapper.Query<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesSumDotacion  ->" + ex.Message);
				}
			}

			public DetallesSumDotacion Add(DetallesSumDotacion pDetallesSumDotacion)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesSumDotacion.id==null ? 0 : pDetallesSumDotacion.id);
p.Add("@ID_Contrato",pDetallesSumDotacion.ID_Contrato==null ? 0 : pDetallesSumDotacion.ID_Contrato);
                    p.Add("@NombreProducto", pDetallesSumDotacion.NombreProducto);
p.Add("@UnidadesContratadas",pDetallesSumDotacion.UnidadesContratadas==null ? 0 : pDetallesSumDotacion.UnidadesContratadas);
                    p.Add("@ValorUnitario", pDetallesSumDotacion.ValorUnitario);
                    p.Add("@ValorTotal", pDetallesSumDotacion.ValorTotal);
                    p.Add("@auditoria", pDetallesSumDotacion.auditoria);

                         


                    DetallesSumDotacion o = SqlMapper.QueryFirstOrDefault<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesSumDotacion  ->" + ex.Message);
				}
			}

			public DetallesSumDotacion  Update(DetallesSumDotacion pDetallesSumDotacion)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesSumDotacion.id==null ? 0 : pDetallesSumDotacion.id);
p.Add("@ID_Contrato",pDetallesSumDotacion.ID_Contrato==null ? 0 : pDetallesSumDotacion.ID_Contrato);
                    p.Add("@NombreProducto", pDetallesSumDotacion.NombreProducto);
p.Add("@UnidadesContratadas",pDetallesSumDotacion.UnidadesContratadas==null ? 0 : pDetallesSumDotacion.UnidadesContratadas);
                    p.Add("@ValorUnitario", pDetallesSumDotacion.ValorUnitario);
                    p.Add("@ValorTotal", pDetallesSumDotacion.ValorTotal);
                    p.Add("@auditoria", pDetallesSumDotacion.auditoria);

                         


                    DetallesSumDotacion o = SqlMapper.QueryFirstOrDefault<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesSumDotacion  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesSumDotacion pDetallesSumDotacion)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumDotacion.id);
                    p.Add("@auditoria", pDetallesSumDotacion.auditoria);

                

 

					DetallesSumDotacion o = SqlMapper.QueryFirstOrDefault<DetallesSumDotacion>(con, "API.PA_DetallesSumDotacionDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesSumDotacion  ->" + ex.Message);
				}
			}

		



            public List<DetallesSumDotacion> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesSumDotacion> DetallesSumDotacionList = new List<DetallesSumDotacion>();

                    DetallesSumDotacionList = SqlMapper.Query<DetallesSumDotacion>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesSumDotacionList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesSumDotacion  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesSumDotacion> b)
            {
                DapperPlusManager.Entity<DetallesSumDotacion>().Table("DetallesSumDotacion");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}