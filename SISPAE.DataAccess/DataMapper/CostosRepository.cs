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
     /// Clase Abstracta para  Costos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CostosRepository : DataObject , ICostos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CostosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CostosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Costos GetById(Costos pCostos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostos.id);                                    


    				Costos o = SqlMapper.QueryFirstOrDefault<Costos>(con, "API.PA_CostosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Costos  ->" + ex.Message);
				}
			}

			public List<Costos> GetAll()
			{
				try 
                {
                        List<Costos> l = SqlMapper.Query<Costos>(con, "API.PA_CostosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Costos  ->" + ex.Message);
				}
			}

			public List<Costos> GetAllFull()
			{
				try 
				{
                    List<Costos> l = SqlMapper.Query<Costos>(con, "API.PA_CostosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Costos  ->" + ex.Message);
				}
			}
			
			public List<Costos> GetAllByWithRelation()
			{
				try 
                {
                    List<Costos> l = SqlMapper.Query<Costos>(con, "API.PA_CostosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Costos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Costos> GetByFilter(Costos pCostos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCostos.id== null || pCostos.id==0) ? vintNUll :pCostos.id);
                    p.Add("@ID_ETC",(pCostos.ID_ETC== null || pCostos.ID_ETC==0) ? vintNUll :pCostos.ID_ETC);
                    p.Add("@ID_TipoModeloOperacion",(pCostos.ID_TipoModeloOperacion== null || pCostos.ID_TipoModeloOperacion==0) ? vintNUll :pCostos.ID_TipoModeloOperacion);
                    p.Add("@ID_ModalidadComplemento",(pCostos.ID_ModalidadComplemento== null || pCostos.ID_ModalidadComplemento==0) ? vintNUll :pCostos.ID_ModalidadComplemento);
                    p.Add("@ID_Vigencia",(pCostos.ID_Vigencia== null || pCostos.ID_Vigencia==0) ? vintNUll :pCostos.ID_Vigencia);
                    p.Add("@ID_TipoComplemento",(pCostos.ID_TipoComplemento== null || pCostos.ID_TipoComplemento==0) ? vintNUll :pCostos.ID_TipoComplemento);
                    p.Add("@Valor",(pCostos.Valor== null) ? vintNUll :pCostos.Valor);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Costos> l = SqlMapper.Query<Costos>(con, "API.PA_CostosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Costos  ->" + ex.Message);
				}
			}

			public Costos Add(Costos pCostos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCostos.id==null ? 0 : pCostos.id);
p.Add("@ID_ETC",pCostos.ID_ETC==null ? 0 : pCostos.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pCostos.ID_TipoModeloOperacion==null ? 0 : pCostos.ID_TipoModeloOperacion);
p.Add("@ID_ModalidadComplemento",pCostos.ID_ModalidadComplemento==null ? 0 : pCostos.ID_ModalidadComplemento);
p.Add("@ID_Vigencia",pCostos.ID_Vigencia==null ? 0 : pCostos.ID_Vigencia);
p.Add("@ID_TipoComplemento",pCostos.ID_TipoComplemento==null ? 0 : pCostos.ID_TipoComplemento);
p.Add("@Valor",pCostos.Valor==null ? 0 : pCostos.Valor);
                    p.Add("@auditoria", pCostos.auditoria);

                         


                    Costos o = SqlMapper.QueryFirstOrDefault<Costos>(con, "API.PA_CostosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Costos  ->" + ex.Message);
				}
			}

			public Costos  Update(Costos pCostos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCostos.id==null ? 0 : pCostos.id);
p.Add("@ID_ETC",pCostos.ID_ETC==null ? 0 : pCostos.ID_ETC);
p.Add("@ID_TipoModeloOperacion",pCostos.ID_TipoModeloOperacion==null ? 0 : pCostos.ID_TipoModeloOperacion);
p.Add("@ID_ModalidadComplemento",pCostos.ID_ModalidadComplemento==null ? 0 : pCostos.ID_ModalidadComplemento);
p.Add("@ID_Vigencia",pCostos.ID_Vigencia==null ? 0 : pCostos.ID_Vigencia);
p.Add("@ID_TipoComplemento",pCostos.ID_TipoComplemento==null ? 0 : pCostos.ID_TipoComplemento);
p.Add("@Valor",pCostos.Valor==null ? 0 : pCostos.Valor);
                    p.Add("@auditoria", pCostos.auditoria);

                         


                    Costos o = SqlMapper.QueryFirstOrDefault<Costos>(con, "API.PA_CostosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Costos  ->" + ex.Message);
				}
			}

			public bool Delete(Costos pCostos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCostos.id);
                    p.Add("@auditoria", pCostos.auditoria);

                

 

					Costos o = SqlMapper.QueryFirstOrDefault<Costos>(con, "API.PA_CostosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Costos  ->" + ex.Message);
				}
			}

		



            public List<Costos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Costos> CostosList = new List<Costos>();

                    CostosList = SqlMapper.Query<Costos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CostosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Costos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Costos> b)
            {
                DapperPlusManager.Entity<Costos>().Table("Costos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}