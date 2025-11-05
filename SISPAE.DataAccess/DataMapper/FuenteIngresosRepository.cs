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
     /// Clase Abstracta para  FuenteIngresos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class FuenteIngresosRepository : DataObject , IFuenteIngresos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public FuenteIngresosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public FuenteIngresosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public FuenteIngresos GetById(FuenteIngresos pFuenteIngresos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuenteIngresos.id);                                    


    				FuenteIngresos o = SqlMapper.QueryFirstOrDefault<FuenteIngresos>(con, "API.PA_FuenteIngresosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  FuenteIngresos  ->" + ex.Message);
				}
			}

			public List<FuenteIngresos> GetAll()
			{
				try 
                {
                        List<FuenteIngresos> l = SqlMapper.Query<FuenteIngresos>(con, "API.PA_FuenteIngresosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  FuenteIngresos  ->" + ex.Message);
				}
			}

			public List<FuenteIngresos> GetAllFull()
			{
				try 
				{
                    List<FuenteIngresos> l = SqlMapper.Query<FuenteIngresos>(con, "API.PA_FuenteIngresosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  FuenteIngresos  ->" + ex.Message);
				}
			}
			
			public List<FuenteIngresos> GetAllByWithRelation()
			{
				try 
                {
                    List<FuenteIngresos> l = SqlMapper.Query<FuenteIngresos>(con, "API.PA_FuenteIngresosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  FuenteIngresos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<FuenteIngresos> GetByFilter(FuenteIngresos pFuenteIngresos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pFuenteIngresos.id== null || pFuenteIngresos.id==0) ? vintNUll :pFuenteIngresos.id);
                    p.Add("@Nombre",(pFuenteIngresos.Nombre== null) ? vintNUll :pFuenteIngresos.Nombre);
                    p.Add("@FuenteSIGEPAE",(pFuenteIngresos.FuenteSIGEPAE== null) ? vintNUll :pFuenteIngresos.FuenteSIGEPAE);
                    p.Add("@IdFuentesFinanciacion",(pFuenteIngresos.IdFuentesFinanciacion== null || pFuenteIngresos.IdFuentesFinanciacion==0) ? vintNUll :pFuenteIngresos.IdFuentesFinanciacion);
                    p.Add("@Id_FuenteCHIP",(pFuenteIngresos.Id_FuenteCHIP== null || pFuenteIngresos.Id_FuenteCHIP==0) ? vintNUll :pFuenteIngresos.Id_FuenteCHIP);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<FuenteIngresos> l = SqlMapper.Query<FuenteIngresos>(con, "API.PA_FuenteIngresosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  FuenteIngresos  ->" + ex.Message);
				}
			}

			public FuenteIngresos Add(FuenteIngresos pFuenteIngresos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pFuenteIngresos.id==null ? 0 : pFuenteIngresos.id);
                    p.Add("@Nombre", pFuenteIngresos.Nombre);
                    p.Add("@FuenteSIGEPAE", pFuenteIngresos.FuenteSIGEPAE);
p.Add("@IdFuentesFinanciacion",pFuenteIngresos.IdFuentesFinanciacion==null ? 0 : pFuenteIngresos.IdFuentesFinanciacion);
p.Add("@Id_FuenteCHIP",pFuenteIngresos.Id_FuenteCHIP==null ? 0 : pFuenteIngresos.Id_FuenteCHIP);
                    p.Add("@auditoria", pFuenteIngresos.auditoria);

                         


                    FuenteIngresos o = SqlMapper.QueryFirstOrDefault<FuenteIngresos>(con, "API.PA_FuenteIngresosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  FuenteIngresos  ->" + ex.Message);
				}
			}

			public FuenteIngresos  Update(FuenteIngresos pFuenteIngresos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pFuenteIngresos.id==null ? 0 : pFuenteIngresos.id);
                    p.Add("@Nombre", pFuenteIngresos.Nombre);
                    p.Add("@FuenteSIGEPAE", pFuenteIngresos.FuenteSIGEPAE);
p.Add("@IdFuentesFinanciacion",pFuenteIngresos.IdFuentesFinanciacion==null ? 0 : pFuenteIngresos.IdFuentesFinanciacion);
p.Add("@Id_FuenteCHIP",pFuenteIngresos.Id_FuenteCHIP==null ? 0 : pFuenteIngresos.Id_FuenteCHIP);
                    p.Add("@auditoria", pFuenteIngresos.auditoria);

                         


                    FuenteIngresos o = SqlMapper.QueryFirstOrDefault<FuenteIngresos>(con, "API.PA_FuenteIngresosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  FuenteIngresos  ->" + ex.Message);
				}
			}

			public bool Delete(FuenteIngresos pFuenteIngresos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pFuenteIngresos.id);
                    p.Add("@auditoria", pFuenteIngresos.auditoria);

                

 

					FuenteIngresos o = SqlMapper.QueryFirstOrDefault<FuenteIngresos>(con, "API.PA_FuenteIngresosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) FuenteIngresos  ->" + ex.Message);
				}
			}

		



            public List<FuenteIngresos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<FuenteIngresos> FuenteIngresosList = new List<FuenteIngresos>();

                    FuenteIngresosList = SqlMapper.Query<FuenteIngresos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return FuenteIngresosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) FuenteIngresos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<FuenteIngresos> b)
            {
                DapperPlusManager.Entity<FuenteIngresos>().Table("FuenteIngresos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}