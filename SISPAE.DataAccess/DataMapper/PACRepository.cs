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
     /// Clase Abstracta para  PAC
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PACRepository : DataObject , IPAC 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PACRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PACRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PAC GetById(PAC pPAC)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPAC.id);                                    


    				PAC o = SqlMapper.QueryFirstOrDefault<PAC>(con, "API.PA_PACGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PAC  ->" + ex.Message);
				}
			}

			public List<PAC> GetAll()
			{
				try 
                {
                        List<PAC> l = SqlMapper.Query<PAC>(con, "API.PA_PACGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PAC  ->" + ex.Message);
				}
			}

			public List<PAC> GetAllFull()
			{
				try 
				{
                    List<PAC> l = SqlMapper.Query<PAC>(con, "API.PA_PACGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PAC  ->" + ex.Message);
				}
			}
			
			public List<PAC> GetAllByWithRelation()
			{
				try 
                {
                    List<PAC> l = SqlMapper.Query<PAC>(con, "API.PA_PACGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PAC  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PAC> GetByFilter(PAC pPAC, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPAC.id== null || pPAC.id==0) ? vintNUll :pPAC.id);
                    p.Add("@ID_ETC",(pPAC.ID_ETC== null || pPAC.ID_ETC==0) ? vintNUll :pPAC.ID_ETC);
                    p.Add("@ID_Vigencia",(pPAC.ID_Vigencia== null || pPAC.ID_Vigencia==0) ? vintNUll :pPAC.ID_Vigencia);
                    p.Add("@Mes",(pPAC.Mes== null) ? vintNUll :pPAC.Mes);
                    p.Add("@GiroProyectado",(pPAC.GiroProyectado== null) ? vintNUll :pPAC.GiroProyectado);
                    p.Add("@GiroConfirmado",(pPAC.GiroConfirmado== null) ? vintNUll :pPAC.GiroConfirmado);
                    p.Add("@DocumentoGiro",(pPAC.DocumentoGiro== null) ? vintNUll :pPAC.DocumentoGiro);
                    p.Add("@FechaGiro",(pPAC.FechaGiro== null) ? vintNUll :pPAC.FechaGiro);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PAC> l = SqlMapper.Query<PAC>(con, "API.PA_PACGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PAC  ->" + ex.Message);
				}
			}

			public PAC Add(PAC pPAC)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPAC.id==null ? 0 : pPAC.id);
p.Add("@ID_ETC",pPAC.ID_ETC==null ? 0 : pPAC.ID_ETC);
p.Add("@ID_Vigencia",pPAC.ID_Vigencia==null ? 0 : pPAC.ID_Vigencia);
p.Add("@Mes",pPAC.Mes==null ? 0 : pPAC.Mes);
                    p.Add("@GiroProyectado", pPAC.GiroProyectado);
                    p.Add("@GiroConfirmado", pPAC.GiroConfirmado);
                    p.Add("@DocumentoGiro", pPAC.DocumentoGiro);
                    p.Add("@FechaGiro", pPAC.FechaGiro);
                    p.Add("@auditoria", pPAC.auditoria);

                         


                    PAC o = SqlMapper.QueryFirstOrDefault<PAC>(con, "API.PA_PACAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PAC  ->" + ex.Message);
				}
			}

			public PAC  Update(PAC pPAC)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPAC.id==null ? 0 : pPAC.id);
p.Add("@ID_ETC",pPAC.ID_ETC==null ? 0 : pPAC.ID_ETC);
p.Add("@ID_Vigencia",pPAC.ID_Vigencia==null ? 0 : pPAC.ID_Vigencia);
p.Add("@Mes",pPAC.Mes==null ? 0 : pPAC.Mes);
                    p.Add("@GiroProyectado", pPAC.GiroProyectado);
                    p.Add("@GiroConfirmado", pPAC.GiroConfirmado);
                    p.Add("@DocumentoGiro", pPAC.DocumentoGiro);
                    p.Add("@FechaGiro", pPAC.FechaGiro);
                    p.Add("@auditoria", pPAC.auditoria);

                         


                    PAC o = SqlMapper.QueryFirstOrDefault<PAC>(con, "API.PA_PACUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PAC  ->" + ex.Message);
				}
			}

			public bool Delete(PAC pPAC)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPAC.id);
                    p.Add("@auditoria", pPAC.auditoria);

                

 

					PAC o = SqlMapper.QueryFirstOrDefault<PAC>(con, "API.PA_PACDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PAC  ->" + ex.Message);
				}
			}

		



            public List<PAC> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PAC> PACList = new List<PAC>();

                    PACList = SqlMapper.Query<PAC>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PACList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PAC  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PAC> b)
            {
                DapperPlusManager.Entity<PAC>().Table("PAC");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}