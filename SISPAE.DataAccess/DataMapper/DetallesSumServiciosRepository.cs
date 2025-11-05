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
     /// Clase Abstracta para  DetallesSumServicios
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesSumServiciosRepository : DataObject , IDetallesSumServicios 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesSumServiciosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesSumServiciosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesSumServicios GetById(DetallesSumServicios pDetallesSumServicios)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumServicios.id);                                    


    				DetallesSumServicios o = SqlMapper.QueryFirstOrDefault<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesSumServicios  ->" + ex.Message);
				}
			}

			public List<DetallesSumServicios> GetAll()
			{
				try 
                {
                        List<DetallesSumServicios> l = SqlMapper.Query<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesSumServicios  ->" + ex.Message);
				}
			}

			public List<DetallesSumServicios> GetAllFull()
			{
				try 
				{
                    List<DetallesSumServicios> l = SqlMapper.Query<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesSumServicios  ->" + ex.Message);
				}
			}
			
			public List<DetallesSumServicios> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesSumServicios> l = SqlMapper.Query<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesSumServicios  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesSumServicios> GetByFilter(DetallesSumServicios pDetallesSumServicios, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesSumServicios.id== null || pDetallesSumServicios.id==0) ? vintNUll :pDetallesSumServicios.id);
                    p.Add("@ID_Contrato",(pDetallesSumServicios.ID_Contrato== null || pDetallesSumServicios.ID_Contrato==0) ? vintNUll :pDetallesSumServicios.ID_Contrato);
                    p.Add("@NombreServicio",(pDetallesSumServicios.NombreServicio== null) ? vintNUll :pDetallesSumServicios.NombreServicio);
                    p.Add("@ValorTotal",(pDetallesSumServicios.ValorTotal== null) ? vintNUll :pDetallesSumServicios.ValorTotal);
                    p.Add("@Concepto",(pDetallesSumServicios.Concepto== null) ? vintNUll :pDetallesSumServicios.Concepto);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesSumServicios> l = SqlMapper.Query<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesSumServicios  ->" + ex.Message);
				}
			}

			public DetallesSumServicios Add(DetallesSumServicios pDetallesSumServicios)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesSumServicios.id==null ? 0 : pDetallesSumServicios.id);
p.Add("@ID_Contrato",pDetallesSumServicios.ID_Contrato==null ? 0 : pDetallesSumServicios.ID_Contrato);
                    p.Add("@NombreServicio", pDetallesSumServicios.NombreServicio);
                    p.Add("@ValorTotal", pDetallesSumServicios.ValorTotal);
                    p.Add("@Concepto", pDetallesSumServicios.Concepto);
                    p.Add("@auditoria", pDetallesSumServicios.auditoria);

                         


                    DetallesSumServicios o = SqlMapper.QueryFirstOrDefault<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesSumServicios  ->" + ex.Message);
				}
			}

			public DetallesSumServicios  Update(DetallesSumServicios pDetallesSumServicios)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesSumServicios.id==null ? 0 : pDetallesSumServicios.id);
p.Add("@ID_Contrato",pDetallesSumServicios.ID_Contrato==null ? 0 : pDetallesSumServicios.ID_Contrato);
                    p.Add("@NombreServicio", pDetallesSumServicios.NombreServicio);
                    p.Add("@ValorTotal", pDetallesSumServicios.ValorTotal);
                    p.Add("@Concepto", pDetallesSumServicios.Concepto);
                    p.Add("@auditoria", pDetallesSumServicios.auditoria);

                         


                    DetallesSumServicios o = SqlMapper.QueryFirstOrDefault<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesSumServicios  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesSumServicios pDetallesSumServicios)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumServicios.id);
                    p.Add("@auditoria", pDetallesSumServicios.auditoria);

                

 

					DetallesSumServicios o = SqlMapper.QueryFirstOrDefault<DetallesSumServicios>(con, "API.PA_DetallesSumServiciosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesSumServicios  ->" + ex.Message);
				}
			}

		



            public List<DetallesSumServicios> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesSumServicios> DetallesSumServiciosList = new List<DetallesSumServicios>();

                    DetallesSumServiciosList = SqlMapper.Query<DetallesSumServicios>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesSumServiciosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesSumServicios  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesSumServicios> b)
            {
                DapperPlusManager.Entity<DetallesSumServicios>().Table("DetallesSumServicios");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}