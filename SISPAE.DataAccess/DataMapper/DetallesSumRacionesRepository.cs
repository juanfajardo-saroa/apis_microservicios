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
     /// Clase Abstracta para  DetallesSumRaciones
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesSumRacionesRepository : DataObject , IDetallesSumRaciones 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesSumRacionesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesSumRacionesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesSumRaciones GetById(DetallesSumRaciones pDetallesSumRaciones)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumRaciones.id);                                    


    				DetallesSumRaciones o = SqlMapper.QueryFirstOrDefault<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesSumRaciones  ->" + ex.Message);
				}
			}

			public List<DetallesSumRaciones> GetAll()
			{
				try 
                {
                        List<DetallesSumRaciones> l = SqlMapper.Query<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesSumRaciones  ->" + ex.Message);
				}
			}

			public List<DetallesSumRaciones> GetAllFull()
			{
				try 
				{
                    List<DetallesSumRaciones> l = SqlMapper.Query<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesSumRaciones  ->" + ex.Message);
				}
			}
			
			public List<DetallesSumRaciones> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesSumRaciones> l = SqlMapper.Query<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesSumRaciones  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesSumRaciones> GetByFilter(DetallesSumRaciones pDetallesSumRaciones, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesSumRaciones.id== null || pDetallesSumRaciones.id==0) ? vintNUll :pDetallesSumRaciones.id);
                    p.Add("@ID_Contrato",(pDetallesSumRaciones.ID_Contrato== null || pDetallesSumRaciones.ID_Contrato==0) ? vintNUll :pDetallesSumRaciones.ID_Contrato);
                    p.Add("@ID_TipoModelooperacion",(pDetallesSumRaciones.ID_TipoModelooperacion== null || pDetallesSumRaciones.ID_TipoModelooperacion==0) ? vintNUll :pDetallesSumRaciones.ID_TipoModelooperacion);
                    p.Add("@ID_TipoModalidadRacion",(pDetallesSumRaciones.ID_TipoModalidadRacion== null || pDetallesSumRaciones.ID_TipoModalidadRacion==0) ? vintNUll :pDetallesSumRaciones.ID_TipoModalidadRacion);
                    p.Add("@ID_TipoRacion",(pDetallesSumRaciones.ID_TipoRacion== null || pDetallesSumRaciones.ID_TipoRacion==0) ? vintNUll :pDetallesSumRaciones.ID_TipoRacion);
                    p.Add("@ID_Jornada",(pDetallesSumRaciones.ID_Jornada== null || pDetallesSumRaciones.ID_Jornada==0) ? vintNUll :pDetallesSumRaciones.ID_Jornada);
                    p.Add("@Raciones",(pDetallesSumRaciones.Raciones== null) ? vintNUll :pDetallesSumRaciones.Raciones);
                    p.Add("@DiasSuministro",(pDetallesSumRaciones.DiasSuministro== null) ? vintNUll :pDetallesSumRaciones.DiasSuministro);
                    p.Add("@MesesSuministro",(pDetallesSumRaciones.MesesSuministro== null) ? vintNUll :pDetallesSumRaciones.MesesSuministro);
                    p.Add("@ContratoPAEC",(pDetallesSumRaciones.ContratoPAEC== null) ? vintNUll :pDetallesSumRaciones.ContratoPAEC);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesSumRaciones> l = SqlMapper.Query<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesSumRaciones  ->" + ex.Message);
				}
			}

			public DetallesSumRaciones Add(DetallesSumRaciones pDetallesSumRaciones)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesSumRaciones.id==null ? 0 : pDetallesSumRaciones.id);
p.Add("@ID_Contrato",pDetallesSumRaciones.ID_Contrato==null ? 0 : pDetallesSumRaciones.ID_Contrato);
p.Add("@ID_TipoModelooperacion",pDetallesSumRaciones.ID_TipoModelooperacion==null ? 0 : pDetallesSumRaciones.ID_TipoModelooperacion);
p.Add("@ID_TipoModalidadRacion",pDetallesSumRaciones.ID_TipoModalidadRacion==null ? 0 : pDetallesSumRaciones.ID_TipoModalidadRacion);
p.Add("@ID_TipoRacion",pDetallesSumRaciones.ID_TipoRacion==null ? 0 : pDetallesSumRaciones.ID_TipoRacion);
p.Add("@ID_Jornada",pDetallesSumRaciones.ID_Jornada==null ? 0 : pDetallesSumRaciones.ID_Jornada);
p.Add("@Raciones",pDetallesSumRaciones.Raciones==null ? 0 : pDetallesSumRaciones.Raciones);
p.Add("@DiasSuministro",pDetallesSumRaciones.DiasSuministro==null ? 0 : pDetallesSumRaciones.DiasSuministro);
p.Add("@MesesSuministro",pDetallesSumRaciones.MesesSuministro==null ? 0 : pDetallesSumRaciones.MesesSuministro);
                    p.Add("@ContratoPAEC", pDetallesSumRaciones.ContratoPAEC);
                    p.Add("@auditoria", pDetallesSumRaciones.auditoria);

                         


                    DetallesSumRaciones o = SqlMapper.QueryFirstOrDefault<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesSumRaciones  ->" + ex.Message);
				}
			}

			public DetallesSumRaciones  Update(DetallesSumRaciones pDetallesSumRaciones)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesSumRaciones.id==null ? 0 : pDetallesSumRaciones.id);
p.Add("@ID_Contrato",pDetallesSumRaciones.ID_Contrato==null ? 0 : pDetallesSumRaciones.ID_Contrato);
p.Add("@ID_TipoModelooperacion",pDetallesSumRaciones.ID_TipoModelooperacion==null ? 0 : pDetallesSumRaciones.ID_TipoModelooperacion);
p.Add("@ID_TipoModalidadRacion",pDetallesSumRaciones.ID_TipoModalidadRacion==null ? 0 : pDetallesSumRaciones.ID_TipoModalidadRacion);
p.Add("@ID_TipoRacion",pDetallesSumRaciones.ID_TipoRacion==null ? 0 : pDetallesSumRaciones.ID_TipoRacion);
p.Add("@ID_Jornada",pDetallesSumRaciones.ID_Jornada==null ? 0 : pDetallesSumRaciones.ID_Jornada);
p.Add("@Raciones",pDetallesSumRaciones.Raciones==null ? 0 : pDetallesSumRaciones.Raciones);
p.Add("@DiasSuministro",pDetallesSumRaciones.DiasSuministro==null ? 0 : pDetallesSumRaciones.DiasSuministro);
p.Add("@MesesSuministro",pDetallesSumRaciones.MesesSuministro==null ? 0 : pDetallesSumRaciones.MesesSuministro);
                    p.Add("@ContratoPAEC", pDetallesSumRaciones.ContratoPAEC);
                    p.Add("@auditoria", pDetallesSumRaciones.auditoria);

                         


                    DetallesSumRaciones o = SqlMapper.QueryFirstOrDefault<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesSumRaciones  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesSumRaciones pDetallesSumRaciones)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumRaciones.id);
                    p.Add("@auditoria", pDetallesSumRaciones.auditoria);

                

 

					DetallesSumRaciones o = SqlMapper.QueryFirstOrDefault<DetallesSumRaciones>(con, "API.PA_DetallesSumRacionesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesSumRaciones  ->" + ex.Message);
				}
			}

		



            public List<DetallesSumRaciones> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesSumRaciones> DetallesSumRacionesList = new List<DetallesSumRaciones>();

                    DetallesSumRacionesList = SqlMapper.Query<DetallesSumRaciones>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesSumRacionesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesSumRaciones  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesSumRaciones> b)
            {
                DapperPlusManager.Entity<DetallesSumRaciones>().Table("DetallesSumRaciones");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}