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
     /// Clase Abstracta para  Polizas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PolizasRepository : DataObject , IPolizas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PolizasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PolizasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Polizas GetById(Polizas pPolizas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPolizas.id);                                    


    				Polizas o = SqlMapper.QueryFirstOrDefault<Polizas>(con, "API.PA_PolizasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Polizas  ->" + ex.Message);
				}
			}

			public List<Polizas> GetAll()
			{
				try 
                {
                        List<Polizas> l = SqlMapper.Query<Polizas>(con, "API.PA_PolizasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Polizas  ->" + ex.Message);
				}
			}

			public List<Polizas> GetAllFull()
			{
				try 
				{
                    List<Polizas> l = SqlMapper.Query<Polizas>(con, "API.PA_PolizasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Polizas  ->" + ex.Message);
				}
			}
			
			public List<Polizas> GetAllByWithRelation()
			{
				try 
                {
                    List<Polizas> l = SqlMapper.Query<Polizas>(con, "API.PA_PolizasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Polizas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Polizas> GetByFilter(Polizas pPolizas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPolizas.id== null || pPolizas.id==0) ? vintNUll :pPolizas.id);
                    p.Add("@ID_Contrato",(pPolizas.ID_Contrato== null || pPolizas.ID_Contrato==0) ? vintNUll :pPolizas.ID_Contrato);
                    p.Add("@ID_TipoPoliza",(pPolizas.ID_TipoPoliza== null || pPolizas.ID_TipoPoliza==0) ? vintNUll :pPolizas.ID_TipoPoliza);
                    p.Add("@FechaAprobacion",(pPolizas.FechaAprobacion== null) ? vintNUll :pPolizas.FechaAprobacion);
                    p.Add("@Numero",(pPolizas.Numero== null) ? vintNUll :pPolizas.Numero);
                    p.Add("@ValorTotal",(pPolizas.ValorTotal== null) ? vintNUll :pPolizas.ValorTotal);
                    p.Add("@FechaPoliza",(pPolizas.FechaPoliza== null) ? vintNUll :pPolizas.FechaPoliza);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Polizas> l = SqlMapper.Query<Polizas>(con, "API.PA_PolizasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Polizas  ->" + ex.Message);
				}
			}

			public Polizas Add(Polizas pPolizas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPolizas.id==null ? 0 : pPolizas.id);
p.Add("@ID_Contrato",pPolizas.ID_Contrato==null ? 0 : pPolizas.ID_Contrato);
p.Add("@ID_TipoPoliza",pPolizas.ID_TipoPoliza==null ? 0 : pPolizas.ID_TipoPoliza);
                    p.Add("@FechaAprobacion", pPolizas.FechaAprobacion);
                    p.Add("@Numero", pPolizas.Numero);
                    p.Add("@ValorTotal", pPolizas.ValorTotal);
                    p.Add("@FechaPoliza", pPolizas.FechaPoliza);
                    p.Add("@auditoria", pPolizas.auditoria);

                         


                    Polizas o = SqlMapper.QueryFirstOrDefault<Polizas>(con, "API.PA_PolizasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Polizas  ->" + ex.Message);
				}
			}

			public Polizas  Update(Polizas pPolizas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPolizas.id==null ? 0 : pPolizas.id);
p.Add("@ID_Contrato",pPolizas.ID_Contrato==null ? 0 : pPolizas.ID_Contrato);
p.Add("@ID_TipoPoliza",pPolizas.ID_TipoPoliza==null ? 0 : pPolizas.ID_TipoPoliza);
                    p.Add("@FechaAprobacion", pPolizas.FechaAprobacion);
                    p.Add("@Numero", pPolizas.Numero);
                    p.Add("@ValorTotal", pPolizas.ValorTotal);
                    p.Add("@FechaPoliza", pPolizas.FechaPoliza);
                    p.Add("@auditoria", pPolizas.auditoria);

                         


                    Polizas o = SqlMapper.QueryFirstOrDefault<Polizas>(con, "API.PA_PolizasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Polizas  ->" + ex.Message);
				}
			}

			public bool Delete(Polizas pPolizas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPolizas.id);
                    p.Add("@auditoria", pPolizas.auditoria);

                

 

					Polizas o = SqlMapper.QueryFirstOrDefault<Polizas>(con, "API.PA_PolizasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Polizas  ->" + ex.Message);
				}
			}

		



            public List<Polizas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Polizas> PolizasList = new List<Polizas>();

                    PolizasList = SqlMapper.Query<Polizas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PolizasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Polizas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Polizas> b)
            {
                DapperPlusManager.Entity<Polizas>().Table("Polizas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}