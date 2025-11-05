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
     /// Clase Abstracta para  Impuestos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ImpuestosRepository : DataObject , IImpuestos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ImpuestosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ImpuestosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Impuestos GetById(Impuestos pImpuestos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pImpuestos.id);                                    


    				Impuestos o = SqlMapper.QueryFirstOrDefault<Impuestos>(con, "API.PA_ImpuestosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Impuestos  ->" + ex.Message);
				}
			}

			public List<Impuestos> GetAll()
			{
				try 
                {
                        List<Impuestos> l = SqlMapper.Query<Impuestos>(con, "API.PA_ImpuestosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Impuestos  ->" + ex.Message);
				}
			}

			public List<Impuestos> GetAllFull()
			{
				try 
				{
                    List<Impuestos> l = SqlMapper.Query<Impuestos>(con, "API.PA_ImpuestosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Impuestos  ->" + ex.Message);
				}
			}
			
			public List<Impuestos> GetAllByWithRelation()
			{
				try 
                {
                    List<Impuestos> l = SqlMapper.Query<Impuestos>(con, "API.PA_ImpuestosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Impuestos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Impuestos> GetByFilter(Impuestos pImpuestos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pImpuestos.id== null || pImpuestos.id==0) ? vintNUll :pImpuestos.id);
                    p.Add("@ID_ETC",(pImpuestos.ID_ETC== null || pImpuestos.ID_ETC==0) ? vintNUll :pImpuestos.ID_ETC);
                    p.Add("@Nombre",(pImpuestos.Nombre== null) ? vintNUll :pImpuestos.Nombre);
                    p.Add("@Tarifa",(pImpuestos.Tarifa== null) ? vintNUll :pImpuestos.Tarifa);
                    p.Add("@BaseGravable",(pImpuestos.BaseGravable== null) ? vintNUll :pImpuestos.BaseGravable);
                    p.Add("@CostoTotal",(pImpuestos.CostoTotal== null) ? vintNUll :pImpuestos.CostoTotal);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Impuestos> l = SqlMapper.Query<Impuestos>(con, "API.PA_ImpuestosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Impuestos  ->" + ex.Message);
				}
			}

			public Impuestos Add(Impuestos pImpuestos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pImpuestos.id==null ? 0 : pImpuestos.id);
p.Add("@ID_ETC",pImpuestos.ID_ETC==null ? 0 : pImpuestos.ID_ETC);
                    p.Add("@Nombre", pImpuestos.Nombre);
                    p.Add("@Tarifa", pImpuestos.Tarifa);
                    p.Add("@BaseGravable", pImpuestos.BaseGravable);
                    p.Add("@CostoTotal", pImpuestos.CostoTotal);
                    p.Add("@auditoria", pImpuestos.auditoria);

                         


                    Impuestos o = SqlMapper.QueryFirstOrDefault<Impuestos>(con, "API.PA_ImpuestosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Impuestos  ->" + ex.Message);
				}
			}

			public Impuestos  Update(Impuestos pImpuestos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pImpuestos.id==null ? 0 : pImpuestos.id);
p.Add("@ID_ETC",pImpuestos.ID_ETC==null ? 0 : pImpuestos.ID_ETC);
                    p.Add("@Nombre", pImpuestos.Nombre);
                    p.Add("@Tarifa", pImpuestos.Tarifa);
                    p.Add("@BaseGravable", pImpuestos.BaseGravable);
                    p.Add("@CostoTotal", pImpuestos.CostoTotal);
                    p.Add("@auditoria", pImpuestos.auditoria);

                         


                    Impuestos o = SqlMapper.QueryFirstOrDefault<Impuestos>(con, "API.PA_ImpuestosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Impuestos  ->" + ex.Message);
				}
			}

			public bool Delete(Impuestos pImpuestos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pImpuestos.id);
                    p.Add("@auditoria", pImpuestos.auditoria);

                

 

					Impuestos o = SqlMapper.QueryFirstOrDefault<Impuestos>(con, "API.PA_ImpuestosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Impuestos  ->" + ex.Message);
				}
			}

		



            public List<Impuestos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Impuestos> ImpuestosList = new List<Impuestos>();

                    ImpuestosList = SqlMapper.Query<Impuestos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ImpuestosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Impuestos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Impuestos> b)
            {
                DapperPlusManager.Entity<Impuestos>().Table("Impuestos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}