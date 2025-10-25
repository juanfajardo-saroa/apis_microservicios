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
     /// Clase Abstracta para  ConveniosAportes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ConveniosAportesRepository : DataObject , IConveniosAportes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ConveniosAportesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ConveniosAportesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ConveniosAportes GetById(ConveniosAportes pConveniosAportes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pConveniosAportes.id);                                    


    				ConveniosAportes o = SqlMapper.QueryFirstOrDefault<ConveniosAportes>(con, "API.PA_ConveniosAportesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ConveniosAportes  ->" + ex.Message);
				}
			}

			public List<ConveniosAportes> GetAll()
			{
				try 
                {
                        List<ConveniosAportes> l = SqlMapper.Query<ConveniosAportes>(con, "API.PA_ConveniosAportesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ConveniosAportes  ->" + ex.Message);
				}
			}

			public List<ConveniosAportes> GetAllFull()
			{
				try 
				{
                    List<ConveniosAportes> l = SqlMapper.Query<ConveniosAportes>(con, "API.PA_ConveniosAportesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ConveniosAportes  ->" + ex.Message);
				}
			}
			
			public List<ConveniosAportes> GetAllByWithRelation()
			{
				try 
                {
                    List<ConveniosAportes> l = SqlMapper.Query<ConveniosAportes>(con, "API.PA_ConveniosAportesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ConveniosAportes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ConveniosAportes> GetByFilter(ConveniosAportes pConveniosAportes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pConveniosAportes.id== null || pConveniosAportes.id==0) ? vintNUll :pConveniosAportes.id);
                    p.Add("@ID_Contrato",(pConveniosAportes.ID_Contrato== null || pConveniosAportes.ID_Contrato==0) ? vintNUll :pConveniosAportes.ID_Contrato);
                    p.Add("@ID_DiviPola",(pConveniosAportes.ID_DiviPola== null || pConveniosAportes.ID_DiviPola==0) ? vintNUll :pConveniosAportes.ID_DiviPola);
                    p.Add("@AporteGobiernoMunicipio",(pConveniosAportes.AporteGobiernoMunicipio== null) ? vintNUll :pConveniosAportes.AporteGobiernoMunicipio);
                    p.Add("@CofinanciacionMunicipio",(pConveniosAportes.CofinanciacionMunicipio== null) ? vintNUll :pConveniosAportes.CofinanciacionMunicipio);
                    p.Add("@AporteMunicipioGobernacion",(pConveniosAportes.AporteMunicipioGobernacion== null) ? vintNUll :pConveniosAportes.AporteMunicipioGobernacion);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ConveniosAportes> l = SqlMapper.Query<ConveniosAportes>(con, "API.PA_ConveniosAportesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ConveniosAportes  ->" + ex.Message);
				}
			}

			public ConveniosAportes Add(ConveniosAportes pConveniosAportes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pConveniosAportes.id==null ? 0 : pConveniosAportes.id);
p.Add("@ID_Contrato",pConveniosAportes.ID_Contrato==null ? 0 : pConveniosAportes.ID_Contrato);
p.Add("@ID_DiviPola",pConveniosAportes.ID_DiviPola==null ? 0 : pConveniosAportes.ID_DiviPola);
                    p.Add("@AporteGobiernoMunicipio", pConveniosAportes.AporteGobiernoMunicipio);
                    p.Add("@CofinanciacionMunicipio", pConveniosAportes.CofinanciacionMunicipio);
                    p.Add("@AporteMunicipioGobernacion", pConveniosAportes.AporteMunicipioGobernacion);
                    p.Add("@auditoria", pConveniosAportes.auditoria);

                         


                    ConveniosAportes o = SqlMapper.QueryFirstOrDefault<ConveniosAportes>(con, "API.PA_ConveniosAportesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ConveniosAportes  ->" + ex.Message);
				}
			}

			public ConveniosAportes  Update(ConveniosAportes pConveniosAportes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pConveniosAportes.id==null ? 0 : pConveniosAportes.id);
p.Add("@ID_Contrato",pConveniosAportes.ID_Contrato==null ? 0 : pConveniosAportes.ID_Contrato);
p.Add("@ID_DiviPola",pConveniosAportes.ID_DiviPola==null ? 0 : pConveniosAportes.ID_DiviPola);
                    p.Add("@AporteGobiernoMunicipio", pConveniosAportes.AporteGobiernoMunicipio);
                    p.Add("@CofinanciacionMunicipio", pConveniosAportes.CofinanciacionMunicipio);
                    p.Add("@AporteMunicipioGobernacion", pConveniosAportes.AporteMunicipioGobernacion);
                    p.Add("@auditoria", pConveniosAportes.auditoria);

                         


                    ConveniosAportes o = SqlMapper.QueryFirstOrDefault<ConveniosAportes>(con, "API.PA_ConveniosAportesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ConveniosAportes  ->" + ex.Message);
				}
			}

			public bool Delete(ConveniosAportes pConveniosAportes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pConveniosAportes.id);
                    p.Add("@auditoria", pConveniosAportes.auditoria);

                

 

					ConveniosAportes o = SqlMapper.QueryFirstOrDefault<ConveniosAportes>(con, "API.PA_ConveniosAportesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ConveniosAportes  ->" + ex.Message);
				}
			}

		



            public List<ConveniosAportes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ConveniosAportes> ConveniosAportesList = new List<ConveniosAportes>();

                    ConveniosAportesList = SqlMapper.Query<ConveniosAportes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ConveniosAportesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ConveniosAportes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ConveniosAportes> b)
            {
                DapperPlusManager.Entity<ConveniosAportes>().Table("ConveniosAportes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}