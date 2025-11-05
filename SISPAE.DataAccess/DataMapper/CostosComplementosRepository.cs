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
     /// Clase Abstracta para  CostosComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostosComplementosRepository : DataObject , ICostosComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostosComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostosComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CostosComplementos GetById(CostosComplementos pCostosComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostosComplementos.id);                                    


    				CostosComplementos o = SqlMapper.QueryFirstOrDefault<CostosComplementos>(con, "API.PA_CostosComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CostosComplementos  ->" + ex.Message);
				}
			}

			public List<CostosComplementos> GetAll()
			{
				try 
                {
                        List<CostosComplementos> l = SqlMapper.Query<CostosComplementos>(con, "API.PA_CostosComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CostosComplementos  ->" + ex.Message);
				}
			}

			public List<CostosComplementos> GetAllFull()
			{
				try 
				{
                    List<CostosComplementos> l = SqlMapper.Query<CostosComplementos>(con, "API.PA_CostosComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CostosComplementos  ->" + ex.Message);
				}
			}
			
			public List<CostosComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<CostosComplementos> l = SqlMapper.Query<CostosComplementos>(con, "API.PA_CostosComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CostosComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CostosComplementos> GetByFilter(CostosComplementos pCostosComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostosComplementos.id== null || pCostosComplementos.id==0) ? vintNUll :pCostosComplementos.id);
                    p.Add("@ID_ETC",(pCostosComplementos.ID_ETC== null || pCostosComplementos.ID_ETC==0) ? vintNUll :pCostosComplementos.ID_ETC);
                    p.Add("@ID_TipoModeloOperacion",(pCostosComplementos.ID_TipoModeloOperacion== null || pCostosComplementos.ID_TipoModeloOperacion==0) ? vintNUll :pCostosComplementos.ID_TipoModeloOperacion);
                    p.Add("@ID_ModalidadComplemento",(pCostosComplementos.ID_ModalidadComplemento== null || pCostosComplementos.ID_ModalidadComplemento==0) ? vintNUll :pCostosComplementos.ID_ModalidadComplemento);
                    p.Add("@ID_Vigencia",(pCostosComplementos.ID_Vigencia== null || pCostosComplementos.ID_Vigencia==0) ? vintNUll :pCostosComplementos.ID_Vigencia);
                    p.Add("@ID_Jornada",(pCostosComplementos.ID_Jornada== null || pCostosComplementos.ID_Jornada==0) ? vintNUll :pCostosComplementos.ID_Jornada);
                    p.Add("@ID_TipoComplemento",(pCostosComplementos.ID_TipoComplemento== null || pCostosComplementos.ID_TipoComplemento==0) ? vintNUll :pCostosComplementos.ID_TipoComplemento);
                    p.Add("@ValorComplemento",(pCostosComplementos.ValorComplemento== null) ? vintNUll :pCostosComplementos.ValorComplemento);
                    p.Add("@ValorComplementoCantidad",(pCostosComplementos.ValorComplementoCantidad== null) ? vintNUll :pCostosComplementos.ValorComplementoCantidad);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CostosComplementos> l = SqlMapper.Query<CostosComplementos>(con, "API.PA_CostosComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CostosComplementos  ->" + ex.Message);
				}
			}

			public CostosComplementos Add(CostosComplementos pCostosComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostosComplementos.id==null ? 0 : pCostosComplementos.id);
p.Add("@ID_ETC",pCostosComplementos.ID_ETC==null ? 0 : pCostosComplementos.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pCostosComplementos.ID_TipoModeloOperacion==null ? 0 : pCostosComplementos.ID_TipoModeloOperacion);
p.Add("@ID_ModalidadComplemento",pCostosComplementos.ID_ModalidadComplemento==null ? 0 : pCostosComplementos.ID_ModalidadComplemento);
p.Add("@ID_Vigencia",pCostosComplementos.ID_Vigencia==null ? 0 : pCostosComplementos.ID_Vigencia);
p.Add("@ID_Jornada",pCostosComplementos.ID_Jornada==null ? 0 : pCostosComplementos.ID_Jornada);
p.Add("@ID_TipoComplemento",pCostosComplementos.ID_TipoComplemento==null ? 0 : pCostosComplementos.ID_TipoComplemento);
                    p.Add("@ValorComplemento", pCostosComplementos.ValorComplemento);
                    p.Add("@ValorComplementoCantidad", pCostosComplementos.ValorComplementoCantidad);
                    p.Add("@auditoria", pCostosComplementos.auditoria);

                         


                    CostosComplementos o = SqlMapper.QueryFirstOrDefault<CostosComplementos>(con, "API.PA_CostosComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CostosComplementos  ->" + ex.Message);
				}
			}

			public CostosComplementos  Update(CostosComplementos pCostosComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostosComplementos.id==null ? 0 : pCostosComplementos.id);
p.Add("@ID_ETC",pCostosComplementos.ID_ETC==null ? 0 : pCostosComplementos.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pCostosComplementos.ID_TipoModeloOperacion==null ? 0 : pCostosComplementos.ID_TipoModeloOperacion);
p.Add("@ID_ModalidadComplemento",pCostosComplementos.ID_ModalidadComplemento==null ? 0 : pCostosComplementos.ID_ModalidadComplemento);
p.Add("@ID_Vigencia",pCostosComplementos.ID_Vigencia==null ? 0 : pCostosComplementos.ID_Vigencia);
p.Add("@ID_Jornada",pCostosComplementos.ID_Jornada==null ? 0 : pCostosComplementos.ID_Jornada);
p.Add("@ID_TipoComplemento",pCostosComplementos.ID_TipoComplemento==null ? 0 : pCostosComplementos.ID_TipoComplemento);
                    p.Add("@ValorComplemento", pCostosComplementos.ValorComplemento);
                    p.Add("@ValorComplementoCantidad", pCostosComplementos.ValorComplementoCantidad);
                    p.Add("@auditoria", pCostosComplementos.auditoria);

                         


                    CostosComplementos o = SqlMapper.QueryFirstOrDefault<CostosComplementos>(con, "API.PA_CostosComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CostosComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(CostosComplementos pCostosComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostosComplementos.id);
                    p.Add("@auditoria", pCostosComplementos.auditoria);

                

 

					CostosComplementos o = SqlMapper.QueryFirstOrDefault<CostosComplementos>(con, "API.PA_CostosComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CostosComplementos  ->" + ex.Message);
				}
			}

		



            public List<CostosComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CostosComplementos> CostosComplementosList = new List<CostosComplementos>();

                    CostosComplementosList = SqlMapper.Query<CostosComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostosComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CostosComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CostosComplementos> b)
            {
                DapperPlusManager.Entity<CostosComplementos>().Table("CostosComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}