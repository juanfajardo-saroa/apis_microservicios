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
     /// Clase Abstracta para  ModalidadModelo
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ModalidadModeloRepository : DataObject , IModalidadModelo 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ModalidadModeloRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ModalidadModeloRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ModalidadModelo GetById(ModalidadModelo pModalidadModelo)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@ID",pModalidadModelo.ID);                                    


    				ModalidadModelo o = SqlMapper.QueryFirstOrDefault<ModalidadModelo>(con, "API.PA_ModalidadModeloGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ModalidadModelo  ->" + ex.Message);
				}
			}

			public List<ModalidadModelo> GetAll()
			{
				try 
                {
                        List<ModalidadModelo> l = SqlMapper.Query<ModalidadModelo>(con, "API.PA_ModalidadModeloGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ModalidadModelo  ->" + ex.Message);
				}
			}

			public List<ModalidadModelo> GetAllFull()
			{
				try 
				{
                    List<ModalidadModelo> l = SqlMapper.Query<ModalidadModelo>(con, "API.PA_ModalidadModeloGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ModalidadModelo  ->" + ex.Message);
				}
			}
			
			public List<ModalidadModelo> GetAllByWithRelation()
			{
				try 
                {
                    List<ModalidadModelo> l = SqlMapper.Query<ModalidadModelo>(con, "API.PA_ModalidadModeloGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ModalidadModelo  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ModalidadModelo> GetByFilter(ModalidadModelo pModalidadModelo, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@ID",(pModalidadModelo.ID== null || pModalidadModelo.ID==0) ? vintNUll :pModalidadModelo.ID);
                    p.Add("@ID_TipoModeloOperacion",(pModalidadModelo.ID_TipoModeloOperacion== null || pModalidadModelo.ID_TipoModeloOperacion==0) ? vintNUll :pModalidadModelo.ID_TipoModeloOperacion);
                    p.Add("@ID_TipoModalidadComplemento",(pModalidadModelo.ID_TipoModalidadComplemento== null || pModalidadModelo.ID_TipoModalidadComplemento==0) ? vintNUll :pModalidadModelo.ID_TipoModalidadComplemento);
                    p.Add("@ID_TipoComplemento",(pModalidadModelo.ID_TipoComplemento== null || pModalidadModelo.ID_TipoComplemento==0) ? vintNUll :pModalidadModelo.ID_TipoComplemento);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ModalidadModelo> l = SqlMapper.Query<ModalidadModelo>(con, "API.PA_ModalidadModeloGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ModalidadModelo  ->" + ex.Message);
				}
			}

			public ModalidadModelo Add(ModalidadModelo pModalidadModelo)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@ID",pModalidadModelo.ID==null ? 0 : pModalidadModelo.ID);
p.Add("@ID_TipoModeloOperacion",pModalidadModelo.ID_TipoModeloOperacion==null ? 0 : pModalidadModelo.ID_TipoModeloOperacion);
p.Add("@ID_TipoModalidadComplemento",pModalidadModelo.ID_TipoModalidadComplemento==null ? 0 : pModalidadModelo.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pModalidadModelo.ID_TipoComplemento==null ? 0 : pModalidadModelo.ID_TipoComplemento);
                    p.Add("@auditoria", pModalidadModelo.auditoria);

                         


                    ModalidadModelo o = SqlMapper.QueryFirstOrDefault<ModalidadModelo>(con, "API.PA_ModalidadModeloAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ModalidadModelo  ->" + ex.Message);
				}
			}

			public ModalidadModelo  Update(ModalidadModelo pModalidadModelo)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@ID",pModalidadModelo.ID==null ? 0 : pModalidadModelo.ID);
p.Add("@ID_TipoModeloOperacion",pModalidadModelo.ID_TipoModeloOperacion==null ? 0 : pModalidadModelo.ID_TipoModeloOperacion);
p.Add("@ID_TipoModalidadComplemento",pModalidadModelo.ID_TipoModalidadComplemento==null ? 0 : pModalidadModelo.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pModalidadModelo.ID_TipoComplemento==null ? 0 : pModalidadModelo.ID_TipoComplemento);
                    p.Add("@auditoria", pModalidadModelo.auditoria);

                         


                    ModalidadModelo o = SqlMapper.QueryFirstOrDefault<ModalidadModelo>(con, "API.PA_ModalidadModeloUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ModalidadModelo  ->" + ex.Message);
				}
			}

			public bool Delete(ModalidadModelo pModalidadModelo)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@ID",pModalidadModelo.ID);
                    p.Add("@auditoria", pModalidadModelo.auditoria);

                

 

					ModalidadModelo o = SqlMapper.QueryFirstOrDefault<ModalidadModelo>(con, "API.PA_ModalidadModeloDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ModalidadModelo  ->" + ex.Message);
				}
			}

		



            public List<ModalidadModelo> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ModalidadModelo> ModalidadModeloList = new List<ModalidadModelo>();

                    ModalidadModeloList = SqlMapper.Query<ModalidadModelo>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ModalidadModeloList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ModalidadModelo  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ModalidadModelo> b)
            {
                DapperPlusManager.Entity<ModalidadModelo>().Table("ModalidadModelo");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}