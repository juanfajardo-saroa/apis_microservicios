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
     /// Clase Abstracta para  EntregaProductos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class EntregaProductosRepository : DataObject , IEntregaProductos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public EntregaProductosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public EntregaProductosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public EntregaProductos GetById(EntregaProductos pEntregaProductos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pEntregaProductos.id);                                    


    				EntregaProductos o = SqlMapper.QueryFirstOrDefault<EntregaProductos>(con, "API.PA_EntregaProductosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  EntregaProductos  ->" + ex.Message);
				}
			}

			public List<EntregaProductos> GetAll()
			{
				try 
                {
                        List<EntregaProductos> l = SqlMapper.Query<EntregaProductos>(con, "API.PA_EntregaProductosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  EntregaProductos  ->" + ex.Message);
				}
			}

			public List<EntregaProductos> GetAllFull()
			{
				try 
				{
                    List<EntregaProductos> l = SqlMapper.Query<EntregaProductos>(con, "API.PA_EntregaProductosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  EntregaProductos  ->" + ex.Message);
				}
			}
			
			public List<EntregaProductos> GetAllByWithRelation()
			{
				try 
                {
                    List<EntregaProductos> l = SqlMapper.Query<EntregaProductos>(con, "API.PA_EntregaProductosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  EntregaProductos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<EntregaProductos> GetByFilter(EntregaProductos pEntregaProductos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pEntregaProductos.id== null || pEntregaProductos.id==0) ? vintNUll :pEntregaProductos.id);
                    p.Add("@ID_Ruta",(pEntregaProductos.ID_Ruta== null || pEntregaProductos.ID_Ruta==0) ? vintNUll :pEntregaProductos.ID_Ruta);
                    p.Add("@ID_TipoPeriocidad",(pEntregaProductos.ID_TipoPeriocidad== null || pEntregaProductos.ID_TipoPeriocidad==0) ? vintNUll :pEntregaProductos.ID_TipoPeriocidad);
                    p.Add("@ID_TipoDiaSemanaEntrega1",(pEntregaProductos.ID_TipoDiaSemanaEntrega1== null || pEntregaProductos.ID_TipoDiaSemanaEntrega1==0) ? vintNUll :pEntregaProductos.ID_TipoDiaSemanaEntrega1);
                    p.Add("@ID_TipoDiaSemanaEntrega2",(pEntregaProductos.ID_TipoDiaSemanaEntrega2== null || pEntregaProductos.ID_TipoDiaSemanaEntrega2==0) ? vintNUll :pEntregaProductos.ID_TipoDiaSemanaEntrega2);
                    p.Add("@ID_TipoProductoRuta",(pEntregaProductos.ID_TipoProductoRuta== null || pEntregaProductos.ID_TipoProductoRuta==0) ? vintNUll :pEntregaProductos.ID_TipoProductoRuta);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<EntregaProductos> l = SqlMapper.Query<EntregaProductos>(con, "API.PA_EntregaProductosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  EntregaProductos  ->" + ex.Message);
				}
			}

			public EntregaProductos Add(EntregaProductos pEntregaProductos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pEntregaProductos.id==null ? 0 : pEntregaProductos.id);
p.Add("@ID_Ruta",pEntregaProductos.ID_Ruta==null ? 0 : pEntregaProductos.ID_Ruta);
p.Add("@ID_TipoPeriocidad",pEntregaProductos.ID_TipoPeriocidad==null ? 0 : pEntregaProductos.ID_TipoPeriocidad);
p.Add("@ID_TipoDiaSemanaEntrega1",pEntregaProductos.ID_TipoDiaSemanaEntrega1==null ? 0 : pEntregaProductos.ID_TipoDiaSemanaEntrega1);
p.Add("@ID_TipoDiaSemanaEntrega2",pEntregaProductos.ID_TipoDiaSemanaEntrega2==null ? 0 : pEntregaProductos.ID_TipoDiaSemanaEntrega2);
p.Add("@ID_TipoProductoRuta",pEntregaProductos.ID_TipoProductoRuta==null ? 0 : pEntregaProductos.ID_TipoProductoRuta);
                    p.Add("@auditoria", pEntregaProductos.auditoria);

                         


                    EntregaProductos o = SqlMapper.QueryFirstOrDefault<EntregaProductos>(con, "API.PA_EntregaProductosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  EntregaProductos  ->" + ex.Message);
				}
			}

			public EntregaProductos  Update(EntregaProductos pEntregaProductos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pEntregaProductos.id==null ? 0 : pEntregaProductos.id);
p.Add("@ID_Ruta",pEntregaProductos.ID_Ruta==null ? 0 : pEntregaProductos.ID_Ruta);
p.Add("@ID_TipoPeriocidad",pEntregaProductos.ID_TipoPeriocidad==null ? 0 : pEntregaProductos.ID_TipoPeriocidad);
p.Add("@ID_TipoDiaSemanaEntrega1",pEntregaProductos.ID_TipoDiaSemanaEntrega1==null ? 0 : pEntregaProductos.ID_TipoDiaSemanaEntrega1);
p.Add("@ID_TipoDiaSemanaEntrega2",pEntregaProductos.ID_TipoDiaSemanaEntrega2==null ? 0 : pEntregaProductos.ID_TipoDiaSemanaEntrega2);
p.Add("@ID_TipoProductoRuta",pEntregaProductos.ID_TipoProductoRuta==null ? 0 : pEntregaProductos.ID_TipoProductoRuta);
                    p.Add("@auditoria", pEntregaProductos.auditoria);

                         


                    EntregaProductos o = SqlMapper.QueryFirstOrDefault<EntregaProductos>(con, "API.PA_EntregaProductosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  EntregaProductos  ->" + ex.Message);
				}
			}

			public bool Delete(EntregaProductos pEntregaProductos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pEntregaProductos.id);
                    p.Add("@auditoria", pEntregaProductos.auditoria);

                

 

					EntregaProductos o = SqlMapper.QueryFirstOrDefault<EntregaProductos>(con, "API.PA_EntregaProductosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) EntregaProductos  ->" + ex.Message);
				}
			}

		



            public List<EntregaProductos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<EntregaProductos> EntregaProductosList = new List<EntregaProductos>();

                    EntregaProductosList = SqlMapper.Query<EntregaProductos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return EntregaProductosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) EntregaProductos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<EntregaProductos> b)
            {
                DapperPlusManager.Entity<EntregaProductos>().Table("EntregaProductos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}