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
     /// Clase Abstracta para  DescuentosPagos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DescuentosPagosRepository : DataObject , IDescuentosPagos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DescuentosPagosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DescuentosPagosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DescuentosPagos GetById(DescuentosPagos pDescuentosPagos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDescuentosPagos.id);                                    


    				DescuentosPagos o = SqlMapper.QueryFirstOrDefault<DescuentosPagos>(con, "API.PA_DescuentosPagosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DescuentosPagos  ->" + ex.Message);
				}
			}

			public List<DescuentosPagos> GetAll()
			{
				try 
                {
                        List<DescuentosPagos> l = SqlMapper.Query<DescuentosPagos>(con, "API.PA_DescuentosPagosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DescuentosPagos  ->" + ex.Message);
				}
			}

			public List<DescuentosPagos> GetAllFull()
			{
				try 
				{
                    List<DescuentosPagos> l = SqlMapper.Query<DescuentosPagos>(con, "API.PA_DescuentosPagosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DescuentosPagos  ->" + ex.Message);
				}
			}
			
			public List<DescuentosPagos> GetAllByWithRelation()
			{
				try 
                {
                    List<DescuentosPagos> l = SqlMapper.Query<DescuentosPagos>(con, "API.PA_DescuentosPagosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DescuentosPagos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DescuentosPagos> GetByFilter(DescuentosPagos pDescuentosPagos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDescuentosPagos.id== null || pDescuentosPagos.id==0) ? vintNUll :pDescuentosPagos.id);
                    p.Add("@ID_TipoDescuento",(pDescuentosPagos.ID_TipoDescuento== null || pDescuentosPagos.ID_TipoDescuento==0) ? vintNUll :pDescuentosPagos.ID_TipoDescuento);
                    p.Add("@Valor",(pDescuentosPagos.Valor== null) ? vintNUll :pDescuentosPagos.Valor);
                    p.Add("@ID_Pagos",(pDescuentosPagos.ID_Pagos== null || pDescuentosPagos.ID_Pagos==0) ? vintNUll :pDescuentosPagos.ID_Pagos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DescuentosPagos> l = SqlMapper.Query<DescuentosPagos>(con, "API.PA_DescuentosPagosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DescuentosPagos  ->" + ex.Message);
				}
			}

			public DescuentosPagos Add(DescuentosPagos pDescuentosPagos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDescuentosPagos.id==null ? 0 : pDescuentosPagos.id);
p.Add("@ID_TipoDescuento",pDescuentosPagos.ID_TipoDescuento==null ? 0 : pDescuentosPagos.ID_TipoDescuento);
                    p.Add("@Valor", pDescuentosPagos.Valor);
p.Add("@ID_Pagos",pDescuentosPagos.ID_Pagos==null ? 0 : pDescuentosPagos.ID_Pagos);
                    p.Add("@auditoria", pDescuentosPagos.auditoria);

                         


                    DescuentosPagos o = SqlMapper.QueryFirstOrDefault<DescuentosPagos>(con, "API.PA_DescuentosPagosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DescuentosPagos  ->" + ex.Message);
				}
			}

			public DescuentosPagos  Update(DescuentosPagos pDescuentosPagos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDescuentosPagos.id==null ? 0 : pDescuentosPagos.id);
p.Add("@ID_TipoDescuento",pDescuentosPagos.ID_TipoDescuento==null ? 0 : pDescuentosPagos.ID_TipoDescuento);
                    p.Add("@Valor", pDescuentosPagos.Valor);
p.Add("@ID_Pagos",pDescuentosPagos.ID_Pagos==null ? 0 : pDescuentosPagos.ID_Pagos);
                    p.Add("@auditoria", pDescuentosPagos.auditoria);

                         


                    DescuentosPagos o = SqlMapper.QueryFirstOrDefault<DescuentosPagos>(con, "API.PA_DescuentosPagosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DescuentosPagos  ->" + ex.Message);
				}
			}

			public bool Delete(DescuentosPagos pDescuentosPagos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDescuentosPagos.id);
                    p.Add("@auditoria", pDescuentosPagos.auditoria);

                

 

					DescuentosPagos o = SqlMapper.QueryFirstOrDefault<DescuentosPagos>(con, "API.PA_DescuentosPagosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DescuentosPagos  ->" + ex.Message);
				}
			}

		



            public List<DescuentosPagos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DescuentosPagos> DescuentosPagosList = new List<DescuentosPagos>();

                    DescuentosPagosList = SqlMapper.Query<DescuentosPagos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DescuentosPagosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DescuentosPagos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DescuentosPagos> b)
            {
                DapperPlusManager.Entity<DescuentosPagos>().Table("DescuentosPagos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}