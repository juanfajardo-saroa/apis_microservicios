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
     /// Clase Abstracta para  AlimentosNoSIPSA
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosNoSIPSARepository : DataObject , IAlimentosNoSIPSA 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosNoSIPSARepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosNoSIPSARepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosNoSIPSA GetById(AlimentosNoSIPSA pAlimentosNoSIPSA)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosNoSIPSA.id);                                    


    				AlimentosNoSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}

			public List<AlimentosNoSIPSA> GetAll()
			{
				try 
                {
                        List<AlimentosNoSIPSA> l = SqlMapper.Query<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}

			public List<AlimentosNoSIPSA> GetAllFull()
			{
				try 
				{
                    List<AlimentosNoSIPSA> l = SqlMapper.Query<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}
			
			public List<AlimentosNoSIPSA> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosNoSIPSA> l = SqlMapper.Query<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosNoSIPSA> GetByFilter(AlimentosNoSIPSA pAlimentosNoSIPSA, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlimentosNoSIPSA.id== null || pAlimentosNoSIPSA.id==0) ? vintNUll :pAlimentosNoSIPSA.id);
                    p.Add("@ID_AlimentosICBF",(pAlimentosNoSIPSA.ID_AlimentosICBF== null || pAlimentosNoSIPSA.ID_AlimentosICBF==0) ? vintNUll :pAlimentosNoSIPSA.ID_AlimentosICBF);
                    p.Add("@ID_ETC",(pAlimentosNoSIPSA.ID_ETC== null || pAlimentosNoSIPSA.ID_ETC==0) ? vintNUll :pAlimentosNoSIPSA.ID_ETC);
                    p.Add("@ID_ClasificacionNoSIPSA",(pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA== null || pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA==0) ? vintNUll :pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA);
                    p.Add("@CodigoSIPSA",(pAlimentosNoSIPSA.CodigoSIPSA== null) ? vintNUll :pAlimentosNoSIPSA.CodigoSIPSA);
                    p.Add("@NombreArticulo",(pAlimentosNoSIPSA.NombreArticulo== null) ? vintNUll :pAlimentosNoSIPSA.NombreArticulo);
                    p.Add("@ID_TipoUnidad",(pAlimentosNoSIPSA.ID_TipoUnidad== null || pAlimentosNoSIPSA.ID_TipoUnidad==0) ? vintNUll :pAlimentosNoSIPSA.ID_TipoUnidad);
                    p.Add("@Cantidad",(pAlimentosNoSIPSA.Cantidad== null) ? vintNUll :pAlimentosNoSIPSA.Cantidad);
                    p.Add("@Fuente1",(pAlimentosNoSIPSA.Fuente1== null) ? vintNUll :pAlimentosNoSIPSA.Fuente1);
                    p.Add("@Precio1",(pAlimentosNoSIPSA.Precio1== null) ? vintNUll :pAlimentosNoSIPSA.Precio1);
                    p.Add("@Fuente2",(pAlimentosNoSIPSA.Fuente2== null) ? vintNUll :pAlimentosNoSIPSA.Fuente2);
                    p.Add("@Precio2",(pAlimentosNoSIPSA.Precio2== null) ? vintNUll :pAlimentosNoSIPSA.Precio2);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosNoSIPSA> l = SqlMapper.Query<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}

			public AlimentosNoSIPSA Add(AlimentosNoSIPSA pAlimentosNoSIPSA)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlimentosNoSIPSA.id==null ? 0 : pAlimentosNoSIPSA.id);
p.Add("@ID_AlimentosICBF",pAlimentosNoSIPSA.ID_AlimentosICBF==null ? 0 : pAlimentosNoSIPSA.ID_AlimentosICBF);
p.Add("@ID_ETC",pAlimentosNoSIPSA.ID_ETC==null ? 0 : pAlimentosNoSIPSA.ID_ETC);
p.Add("@ID_ClasificacionNoSIPSA",pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA==null ? 0 : pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA);
                    p.Add("@CodigoSIPSA", pAlimentosNoSIPSA.CodigoSIPSA);
                    p.Add("@NombreArticulo", pAlimentosNoSIPSA.NombreArticulo);
p.Add("@ID_TipoUnidad",pAlimentosNoSIPSA.ID_TipoUnidad==null ? 0 : pAlimentosNoSIPSA.ID_TipoUnidad);
p.Add("@Cantidad",pAlimentosNoSIPSA.Cantidad==null ? 0 : pAlimentosNoSIPSA.Cantidad);
                    p.Add("@Fuente1", pAlimentosNoSIPSA.Fuente1);
                    p.Add("@Precio1", pAlimentosNoSIPSA.Precio1);
                    p.Add("@Fuente2", pAlimentosNoSIPSA.Fuente2);
                    p.Add("@Precio2", pAlimentosNoSIPSA.Precio2);
                    p.Add("@auditoria", pAlimentosNoSIPSA.auditoria);

                         


                    AlimentosNoSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}

			public AlimentosNoSIPSA  Update(AlimentosNoSIPSA pAlimentosNoSIPSA)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlimentosNoSIPSA.id==null ? 0 : pAlimentosNoSIPSA.id);
p.Add("@ID_AlimentosICBF",pAlimentosNoSIPSA.ID_AlimentosICBF==null ? 0 : pAlimentosNoSIPSA.ID_AlimentosICBF);
p.Add("@ID_ETC",pAlimentosNoSIPSA.ID_ETC==null ? 0 : pAlimentosNoSIPSA.ID_ETC);
p.Add("@ID_ClasificacionNoSIPSA",pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA==null ? 0 : pAlimentosNoSIPSA.ID_ClasificacionNoSIPSA);
                    p.Add("@CodigoSIPSA", pAlimentosNoSIPSA.CodigoSIPSA);
                    p.Add("@NombreArticulo", pAlimentosNoSIPSA.NombreArticulo);
p.Add("@ID_TipoUnidad",pAlimentosNoSIPSA.ID_TipoUnidad==null ? 0 : pAlimentosNoSIPSA.ID_TipoUnidad);
p.Add("@Cantidad",pAlimentosNoSIPSA.Cantidad==null ? 0 : pAlimentosNoSIPSA.Cantidad);
                    p.Add("@Fuente1", pAlimentosNoSIPSA.Fuente1);
                    p.Add("@Precio1", pAlimentosNoSIPSA.Precio1);
                    p.Add("@Fuente2", pAlimentosNoSIPSA.Fuente2);
                    p.Add("@Precio2", pAlimentosNoSIPSA.Precio2);
                    p.Add("@auditoria", pAlimentosNoSIPSA.auditoria);

                         


                    AlimentosNoSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSAUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosNoSIPSA  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosNoSIPSA pAlimentosNoSIPSA)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosNoSIPSA.id);
                    p.Add("@auditoria", pAlimentosNoSIPSA.auditoria);

                

 

					AlimentosNoSIPSA o = SqlMapper.QueryFirstOrDefault<AlimentosNoSIPSA>(con, "API.PA_AlimentosNoSIPSADelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosNoSIPSA  ->" + ex.Message);
				}
			}

		



            public List<AlimentosNoSIPSA> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosNoSIPSA> AlimentosNoSIPSAList = new List<AlimentosNoSIPSA>();

                    AlimentosNoSIPSAList = SqlMapper.Query<AlimentosNoSIPSA>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosNoSIPSAList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosNoSIPSA  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosNoSIPSA> b)
            {
                DapperPlusManager.Entity<AlimentosNoSIPSA>().Table("AlimentosNoSIPSA");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}