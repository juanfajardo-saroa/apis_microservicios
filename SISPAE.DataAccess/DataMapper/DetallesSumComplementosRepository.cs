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
     /// Clase Abstracta para  DetallesSumComplementos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesSumComplementosRepository : DataObject , IDetallesSumComplementos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesSumComplementosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesSumComplementosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesSumComplementos GetById(DetallesSumComplementos pDetallesSumComplementos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumComplementos.id);                                    


    				DetallesSumComplementos o = SqlMapper.QueryFirstOrDefault<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesSumComplementos  ->" + ex.Message);
				}
			}

			public List<DetallesSumComplementos> GetAll()
			{
				try 
                {
                        List<DetallesSumComplementos> l = SqlMapper.Query<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesSumComplementos  ->" + ex.Message);
				}
			}

			public List<DetallesSumComplementos> GetAllFull()
			{
				try 
				{
                    List<DetallesSumComplementos> l = SqlMapper.Query<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesSumComplementos  ->" + ex.Message);
				}
			}
			
			public List<DetallesSumComplementos> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesSumComplementos> l = SqlMapper.Query<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesSumComplementos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesSumComplementos> GetByFilter(DetallesSumComplementos pDetallesSumComplementos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesSumComplementos.id== null || pDetallesSumComplementos.id==0) ? vintNUll :pDetallesSumComplementos.id);
                    p.Add("@ID_Contrato",(pDetallesSumComplementos.ID_Contrato== null || pDetallesSumComplementos.ID_Contrato==0) ? vintNUll :pDetallesSumComplementos.ID_Contrato);
                    p.Add("@ID_TipoModelooperacion",(pDetallesSumComplementos.ID_TipoModelooperacion== null || pDetallesSumComplementos.ID_TipoModelooperacion==0) ? vintNUll :pDetallesSumComplementos.ID_TipoModelooperacion);
                    p.Add("@ID_TipoModalidadComplemento",(pDetallesSumComplementos.ID_TipoModalidadComplemento== null || pDetallesSumComplementos.ID_TipoModalidadComplemento==0) ? vintNUll :pDetallesSumComplementos.ID_TipoModalidadComplemento);
                    p.Add("@ID_TipoComplemento",(pDetallesSumComplementos.ID_TipoComplemento== null || pDetallesSumComplementos.ID_TipoComplemento==0) ? vintNUll :pDetallesSumComplementos.ID_TipoComplemento);
                    p.Add("@ID_Jornada",(pDetallesSumComplementos.ID_Jornada== null || pDetallesSumComplementos.ID_Jornada==0) ? vintNUll :pDetallesSumComplementos.ID_Jornada);
                    p.Add("@Complementos",(pDetallesSumComplementos.Complementos== null) ? vintNUll :pDetallesSumComplementos.Complementos);
                    p.Add("@DiasSuministro",(pDetallesSumComplementos.DiasSuministro== null) ? vintNUll :pDetallesSumComplementos.DiasSuministro);
                    p.Add("@MesesSuministro",(pDetallesSumComplementos.MesesSuministro== null) ? vintNUll :pDetallesSumComplementos.MesesSuministro);
                    p.Add("@ContratoPAEC",(pDetallesSumComplementos.ContratoPAEC== null) ? vintNUll :pDetallesSumComplementos.ContratoPAEC);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesSumComplementos> l = SqlMapper.Query<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesSumComplementos  ->" + ex.Message);
				}
			}

			public DetallesSumComplementos Add(DetallesSumComplementos pDetallesSumComplementos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesSumComplementos.id==null ? 0 : pDetallesSumComplementos.id);
p.Add("@ID_Contrato",pDetallesSumComplementos.ID_Contrato==null ? 0 : pDetallesSumComplementos.ID_Contrato);
p.Add("@ID_TipoModelooperacion",pDetallesSumComplementos.ID_TipoModelooperacion==null ? 0 : pDetallesSumComplementos.ID_TipoModelooperacion);
p.Add("@ID_TipoModalidadComplemento",pDetallesSumComplementos.ID_TipoModalidadComplemento==null ? 0 : pDetallesSumComplementos.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pDetallesSumComplementos.ID_TipoComplemento==null ? 0 : pDetallesSumComplementos.ID_TipoComplemento);
p.Add("@ID_Jornada",pDetallesSumComplementos.ID_Jornada==null ? 0 : pDetallesSumComplementos.ID_Jornada);
p.Add("@Complementos",pDetallesSumComplementos.Complementos==null ? 0 : pDetallesSumComplementos.Complementos);
p.Add("@DiasSuministro",pDetallesSumComplementos.DiasSuministro==null ? 0 : pDetallesSumComplementos.DiasSuministro);
p.Add("@MesesSuministro",pDetallesSumComplementos.MesesSuministro==null ? 0 : pDetallesSumComplementos.MesesSuministro);
                    p.Add("@ContratoPAEC", pDetallesSumComplementos.ContratoPAEC);
                    p.Add("@auditoria", pDetallesSumComplementos.auditoria);

                         


                    DetallesSumComplementos o = SqlMapper.QueryFirstOrDefault<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesSumComplementos  ->" + ex.Message);
				}
			}

			public DetallesSumComplementos  Update(DetallesSumComplementos pDetallesSumComplementos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesSumComplementos.id==null ? 0 : pDetallesSumComplementos.id);
p.Add("@ID_Contrato",pDetallesSumComplementos.ID_Contrato==null ? 0 : pDetallesSumComplementos.ID_Contrato);
p.Add("@ID_TipoModelooperacion",pDetallesSumComplementos.ID_TipoModelooperacion==null ? 0 : pDetallesSumComplementos.ID_TipoModelooperacion);
p.Add("@ID_TipoModalidadComplemento",pDetallesSumComplementos.ID_TipoModalidadComplemento==null ? 0 : pDetallesSumComplementos.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pDetallesSumComplementos.ID_TipoComplemento==null ? 0 : pDetallesSumComplementos.ID_TipoComplemento);
p.Add("@ID_Jornada",pDetallesSumComplementos.ID_Jornada==null ? 0 : pDetallesSumComplementos.ID_Jornada);
p.Add("@Complementos",pDetallesSumComplementos.Complementos==null ? 0 : pDetallesSumComplementos.Complementos);
p.Add("@DiasSuministro",pDetallesSumComplementos.DiasSuministro==null ? 0 : pDetallesSumComplementos.DiasSuministro);
p.Add("@MesesSuministro",pDetallesSumComplementos.MesesSuministro==null ? 0 : pDetallesSumComplementos.MesesSuministro);
                    p.Add("@ContratoPAEC", pDetallesSumComplementos.ContratoPAEC);
                    p.Add("@auditoria", pDetallesSumComplementos.auditoria);

                         


                    DetallesSumComplementos o = SqlMapper.QueryFirstOrDefault<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesSumComplementos  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesSumComplementos pDetallesSumComplementos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumComplementos.id);
                    p.Add("@auditoria", pDetallesSumComplementos.auditoria);

                

 

					DetallesSumComplementos o = SqlMapper.QueryFirstOrDefault<DetallesSumComplementos>(con, "API.PA_DetallesSumComplementosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesSumComplementos  ->" + ex.Message);
				}
			}

		



            public List<DetallesSumComplementos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesSumComplementos> DetallesSumComplementosList = new List<DetallesSumComplementos>();

                    DetallesSumComplementosList = SqlMapper.Query<DetallesSumComplementos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesSumComplementosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesSumComplementos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesSumComplementos> b)
            {
                DapperPlusManager.Entity<DetallesSumComplementos>().Table("DetallesSumComplementos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}