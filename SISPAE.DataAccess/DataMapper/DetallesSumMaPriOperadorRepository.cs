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
     /// Clase Abstracta para  DetallesSumMaPriOperador
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class DetallesSumMaPriOperadorRepository : DataObject , IDetallesSumMaPriOperador 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public DetallesSumMaPriOperadorRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public DetallesSumMaPriOperadorRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public DetallesSumMaPriOperador GetById(DetallesSumMaPriOperador pDetallesSumMaPriOperador)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumMaPriOperador.id);                                    


    				DetallesSumMaPriOperador o = SqlMapper.QueryFirstOrDefault<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}

			public List<DetallesSumMaPriOperador> GetAll()
			{
				try 
                {
                        List<DetallesSumMaPriOperador> l = SqlMapper.Query<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}

			public List<DetallesSumMaPriOperador> GetAllFull()
			{
				try 
				{
                    List<DetallesSumMaPriOperador> l = SqlMapper.Query<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}
			
			public List<DetallesSumMaPriOperador> GetAllByWithRelation()
			{
				try 
                {
                    List<DetallesSumMaPriOperador> l = SqlMapper.Query<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<DetallesSumMaPriOperador> GetByFilter(DetallesSumMaPriOperador pDetallesSumMaPriOperador, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pDetallesSumMaPriOperador.id== null || pDetallesSumMaPriOperador.id==0) ? vintNUll :pDetallesSumMaPriOperador.id);
                    p.Add("@ID_Contrato",(pDetallesSumMaPriOperador.ID_Contrato== null || pDetallesSumMaPriOperador.ID_Contrato==0) ? vintNUll :pDetallesSumMaPriOperador.ID_Contrato);
                    p.Add("@ID_GrupoAlimento",(pDetallesSumMaPriOperador.ID_GrupoAlimento== null || pDetallesSumMaPriOperador.ID_GrupoAlimento==0) ? vintNUll :pDetallesSumMaPriOperador.ID_GrupoAlimento);
                    p.Add("@ID_TipoGrupoEtario",(pDetallesSumMaPriOperador.ID_TipoGrupoEtario== null || pDetallesSumMaPriOperador.ID_TipoGrupoEtario==0) ? vintNUll :pDetallesSumMaPriOperador.ID_TipoGrupoEtario);
                    p.Add("@ID_TipoUnidad",(pDetallesSumMaPriOperador.ID_TipoUnidad== null || pDetallesSumMaPriOperador.ID_TipoUnidad==0) ? vintNUll :pDetallesSumMaPriOperador.ID_TipoUnidad);
                    p.Add("@DiasSuministro",(pDetallesSumMaPriOperador.DiasSuministro== null) ? vintNUll :pDetallesSumMaPriOperador.DiasSuministro);
                    p.Add("@NombreAlimento",(pDetallesSumMaPriOperador.NombreAlimento== null) ? vintNUll :pDetallesSumMaPriOperador.NombreAlimento);
                    p.Add("@Gramaje",(pDetallesSumMaPriOperador.Gramaje== null) ? vintNUll :pDetallesSumMaPriOperador.Gramaje);
                    p.Add("@UnidadesContratadas",(pDetallesSumMaPriOperador.UnidadesContratadas== null) ? vintNUll :pDetallesSumMaPriOperador.UnidadesContratadas);
                    p.Add("@ValorUnitario",(pDetallesSumMaPriOperador.ValorUnitario== null) ? vintNUll :pDetallesSumMaPriOperador.ValorUnitario);
                    p.Add("@ValorTotal",(pDetallesSumMaPriOperador.ValorTotal== null) ? vintNUll :pDetallesSumMaPriOperador.ValorTotal);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<DetallesSumMaPriOperador> l = SqlMapper.Query<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}

			public DetallesSumMaPriOperador Add(DetallesSumMaPriOperador pDetallesSumMaPriOperador)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pDetallesSumMaPriOperador.id==null ? 0 : pDetallesSumMaPriOperador.id);
p.Add("@ID_Contrato",pDetallesSumMaPriOperador.ID_Contrato==null ? 0 : pDetallesSumMaPriOperador.ID_Contrato);
p.Add("@ID_GrupoAlimento",pDetallesSumMaPriOperador.ID_GrupoAlimento==null ? 0 : pDetallesSumMaPriOperador.ID_GrupoAlimento);
p.Add("@ID_TipoGrupoEtario",pDetallesSumMaPriOperador.ID_TipoGrupoEtario==null ? 0 : pDetallesSumMaPriOperador.ID_TipoGrupoEtario);
p.Add("@ID_TipoUnidad",pDetallesSumMaPriOperador.ID_TipoUnidad==null ? 0 : pDetallesSumMaPriOperador.ID_TipoUnidad);
p.Add("@DiasSuministro",pDetallesSumMaPriOperador.DiasSuministro==null ? 0 : pDetallesSumMaPriOperador.DiasSuministro);
                    p.Add("@NombreAlimento", pDetallesSumMaPriOperador.NombreAlimento);
                    p.Add("@Gramaje", pDetallesSumMaPriOperador.Gramaje);
p.Add("@UnidadesContratadas",pDetallesSumMaPriOperador.UnidadesContratadas==null ? 0 : pDetallesSumMaPriOperador.UnidadesContratadas);
                    p.Add("@ValorUnitario", pDetallesSumMaPriOperador.ValorUnitario);
                    p.Add("@ValorTotal", pDetallesSumMaPriOperador.ValorTotal);
                    p.Add("@auditoria", pDetallesSumMaPriOperador.auditoria);

                         


                    DetallesSumMaPriOperador o = SqlMapper.QueryFirstOrDefault<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}

			public DetallesSumMaPriOperador  Update(DetallesSumMaPriOperador pDetallesSumMaPriOperador)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pDetallesSumMaPriOperador.id==null ? 0 : pDetallesSumMaPriOperador.id);
p.Add("@ID_Contrato",pDetallesSumMaPriOperador.ID_Contrato==null ? 0 : pDetallesSumMaPriOperador.ID_Contrato);
p.Add("@ID_GrupoAlimento",pDetallesSumMaPriOperador.ID_GrupoAlimento==null ? 0 : pDetallesSumMaPriOperador.ID_GrupoAlimento);
p.Add("@ID_TipoGrupoEtario",pDetallesSumMaPriOperador.ID_TipoGrupoEtario==null ? 0 : pDetallesSumMaPriOperador.ID_TipoGrupoEtario);
p.Add("@ID_TipoUnidad",pDetallesSumMaPriOperador.ID_TipoUnidad==null ? 0 : pDetallesSumMaPriOperador.ID_TipoUnidad);
p.Add("@DiasSuministro",pDetallesSumMaPriOperador.DiasSuministro==null ? 0 : pDetallesSumMaPriOperador.DiasSuministro);
                    p.Add("@NombreAlimento", pDetallesSumMaPriOperador.NombreAlimento);
                    p.Add("@Gramaje", pDetallesSumMaPriOperador.Gramaje);
p.Add("@UnidadesContratadas",pDetallesSumMaPriOperador.UnidadesContratadas==null ? 0 : pDetallesSumMaPriOperador.UnidadesContratadas);
                    p.Add("@ValorUnitario", pDetallesSumMaPriOperador.ValorUnitario);
                    p.Add("@ValorTotal", pDetallesSumMaPriOperador.ValorTotal);
                    p.Add("@auditoria", pDetallesSumMaPriOperador.auditoria);

                         


                    DetallesSumMaPriOperador o = SqlMapper.QueryFirstOrDefault<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}

			public bool Delete(DetallesSumMaPriOperador pDetallesSumMaPriOperador)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pDetallesSumMaPriOperador.id);
                    p.Add("@auditoria", pDetallesSumMaPriOperador.auditoria);

                

 

					DetallesSumMaPriOperador o = SqlMapper.QueryFirstOrDefault<DetallesSumMaPriOperador>(con, "API.PA_DetallesSumMaPriOperadorDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) DetallesSumMaPriOperador  ->" + ex.Message);
				}
			}

		



            public List<DetallesSumMaPriOperador> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<DetallesSumMaPriOperador> DetallesSumMaPriOperadorList = new List<DetallesSumMaPriOperador>();

                    DetallesSumMaPriOperadorList = SqlMapper.Query<DetallesSumMaPriOperador>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return DetallesSumMaPriOperadorList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) DetallesSumMaPriOperador  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<DetallesSumMaPriOperador> b)
            {
                DapperPlusManager.Entity<DetallesSumMaPriOperador>().Table("DetallesSumMaPriOperador");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}