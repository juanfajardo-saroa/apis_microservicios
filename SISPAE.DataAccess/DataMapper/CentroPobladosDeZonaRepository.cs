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
     /// Clase Abstracta para  CentroPobladosDeZona
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CentroPobladosDeZonaRepository : DataObject , ICentroPobladosDeZona 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CentroPobladosDeZonaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CentroPobladosDeZonaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CentroPobladosDeZona GetById(CentroPobladosDeZona pCentroPobladosDeZona)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCentroPobladosDeZona.id);                                    


    				CentroPobladosDeZona o = SqlMapper.QueryFirstOrDefault<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}

			public List<CentroPobladosDeZona> GetAll()
			{
				try 
                {
                        List<CentroPobladosDeZona> l = SqlMapper.Query<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}

			public List<CentroPobladosDeZona> GetAllFull()
			{
				try 
				{
                    List<CentroPobladosDeZona> l = SqlMapper.Query<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}
			
			public List<CentroPobladosDeZona> GetAllByWithRelation()
			{
				try 
                {
                    List<CentroPobladosDeZona> l = SqlMapper.Query<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CentroPobladosDeZona> GetByFilter(CentroPobladosDeZona pCentroPobladosDeZona, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCentroPobladosDeZona.id== null || pCentroPobladosDeZona.id==0) ? vintNUll :pCentroPobladosDeZona.id);
                    p.Add("@ID_DiviPola",(pCentroPobladosDeZona.ID_DiviPola== null || pCentroPobladosDeZona.ID_DiviPola==0) ? vintNUll :pCentroPobladosDeZona.ID_DiviPola);
                    p.Add("@ID_Zona",(pCentroPobladosDeZona.ID_Zona== null || pCentroPobladosDeZona.ID_Zona==0) ? vintNUll :pCentroPobladosDeZona.ID_Zona);
                    p.Add("@CabeceraMunicipalId",(pCentroPobladosDeZona.CabeceraMunicipalId== null) ? vintNUll :pCentroPobladosDeZona.CabeceraMunicipalId);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CentroPobladosDeZona> l = SqlMapper.Query<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}

			public CentroPobladosDeZona Add(CentroPobladosDeZona pCentroPobladosDeZona)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCentroPobladosDeZona.id==null ? 0 : pCentroPobladosDeZona.id);
p.Add("@ID_DiviPola",pCentroPobladosDeZona.ID_DiviPola==null ? 0 : pCentroPobladosDeZona.ID_DiviPola);
p.Add("@ID_Zona",pCentroPobladosDeZona.ID_Zona==null ? 0 : pCentroPobladosDeZona.ID_Zona);
p.Add("@CabeceraMunicipalId",pCentroPobladosDeZona.CabeceraMunicipalId==null ? 0 : pCentroPobladosDeZona.CabeceraMunicipalId);
                    p.Add("@auditoria", pCentroPobladosDeZona.auditoria);

                         


                    CentroPobladosDeZona o = SqlMapper.QueryFirstOrDefault<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}

			public CentroPobladosDeZona  Update(CentroPobladosDeZona pCentroPobladosDeZona)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCentroPobladosDeZona.id==null ? 0 : pCentroPobladosDeZona.id);
p.Add("@ID_DiviPola",pCentroPobladosDeZona.ID_DiviPola==null ? 0 : pCentroPobladosDeZona.ID_DiviPola);
p.Add("@ID_Zona",pCentroPobladosDeZona.ID_Zona==null ? 0 : pCentroPobladosDeZona.ID_Zona);
p.Add("@CabeceraMunicipalId",pCentroPobladosDeZona.CabeceraMunicipalId==null ? 0 : pCentroPobladosDeZona.CabeceraMunicipalId);
                    p.Add("@auditoria", pCentroPobladosDeZona.auditoria);

                         


                    CentroPobladosDeZona o = SqlMapper.QueryFirstOrDefault<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CentroPobladosDeZona  ->" + ex.Message);
				}
			}

			public bool Delete(CentroPobladosDeZona pCentroPobladosDeZona)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCentroPobladosDeZona.id);
                    p.Add("@auditoria", pCentroPobladosDeZona.auditoria);

                

 

					CentroPobladosDeZona o = SqlMapper.QueryFirstOrDefault<CentroPobladosDeZona>(con, "API.PA_CentroPobladosDeZonaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CentroPobladosDeZona  ->" + ex.Message);
				}
			}

		



            public List<CentroPobladosDeZona> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CentroPobladosDeZona> CentroPobladosDeZonaList = new List<CentroPobladosDeZona>();

                    CentroPobladosDeZonaList = SqlMapper.Query<CentroPobladosDeZona>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CentroPobladosDeZonaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CentroPobladosDeZona  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CentroPobladosDeZona> b)
            {
                DapperPlusManager.Entity<CentroPobladosDeZona>().Table("CentroPobladosDeZona");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}