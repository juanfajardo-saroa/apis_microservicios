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
     /// Clase Abstracta para  AlimentosICBF
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AlimentosICBFRepository : DataObject , IAlimentosICBF 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AlimentosICBFRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AlimentosICBFRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AlimentosICBF GetById(AlimentosICBF pAlimentosICBF)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosICBF.id);                                    


    				AlimentosICBF o = SqlMapper.QueryFirstOrDefault<AlimentosICBF>(con, "API.PA_AlimentosICBFGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AlimentosICBF  ->" + ex.Message);
				}
			}

			public List<AlimentosICBF> GetAll()
			{
				try 
                {
                        List<AlimentosICBF> l = SqlMapper.Query<AlimentosICBF>(con, "API.PA_AlimentosICBFGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AlimentosICBF  ->" + ex.Message);
				}
			}

			public List<AlimentosICBF> GetAllFull()
			{
				try 
				{
                    List<AlimentosICBF> l = SqlMapper.Query<AlimentosICBF>(con, "API.PA_AlimentosICBFGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AlimentosICBF  ->" + ex.Message);
				}
			}
			
			public List<AlimentosICBF> GetAllByWithRelation()
			{
				try 
                {
                    List<AlimentosICBF> l = SqlMapper.Query<AlimentosICBF>(con, "API.PA_AlimentosICBFGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AlimentosICBF  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AlimentosICBF> GetByFilter(AlimentosICBF pAlimentosICBF, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAlimentosICBF.id== null || pAlimentosICBF.id==0) ? vintNUll :pAlimentosICBF.id);
                    p.Add("@ID_SubGrupoAlimentos",(pAlimentosICBF.ID_SubGrupoAlimentos== null || pAlimentosICBF.ID_SubGrupoAlimentos==0) ? vintNUll :pAlimentosICBF.ID_SubGrupoAlimentos);
                    p.Add("@ID_TipoAlimento",(pAlimentosICBF.ID_TipoAlimento== null || pAlimentosICBF.ID_TipoAlimento==0) ? vintNUll :pAlimentosICBF.ID_TipoAlimento);
                    p.Add("@ID_ETC",(pAlimentosICBF.ID_ETC== null || pAlimentosICBF.ID_ETC==0) ? vintNUll :pAlimentosICBF.ID_ETC);
                    p.Add("@ID_TipoFuenteNutricional",(pAlimentosICBF.ID_TipoFuenteNutricional== null || pAlimentosICBF.ID_TipoFuenteNutricional==0) ? vintNUll :pAlimentosICBF.ID_TipoFuenteNutricional);
                    p.Add("@CodigoICBF",(pAlimentosICBF.CodigoICBF== null) ? vintNUll :pAlimentosICBF.CodigoICBF);
                    p.Add("@PathlmagenAlimento",(pAlimentosICBF.PathlmagenAlimento== null) ? vintNUll :pAlimentosICBF.PathlmagenAlimento);
                    p.Add("@PathImagenInformacionNutricional",(pAlimentosICBF.PathImagenInformacionNutricional== null) ? vintNUll :pAlimentosICBF.PathImagenInformacionNutricional);
                    p.Add("@PorcentajeComestible",(pAlimentosICBF.PorcentajeComestible== null) ? vintNUll :pAlimentosICBF.PorcentajeComestible);
                    p.Add("@IntercambioEstandarizado",(pAlimentosICBF.IntercambioEstandarizado== null) ? vintNUll :pAlimentosICBF.IntercambioEstandarizado);
                    p.Add("@PesoBruto",(pAlimentosICBF.PesoBruto== null) ? vintNUll :pAlimentosICBF.PesoBruto);
                    p.Add("@Nombre",(pAlimentosICBF.Nombre== null) ? vintNUll :pAlimentosICBF.Nombre);
                    p.Add("@ID_TiposUnidad",(pAlimentosICBF.ID_TiposUnidad== null || pAlimentosICBF.ID_TiposUnidad==0) ? vintNUll :pAlimentosICBF.ID_TiposUnidad);
                    p.Add("@ID_EstadoRegistro",(pAlimentosICBF.ID_EstadoRegistro== null || pAlimentosICBF.ID_EstadoRegistro==0) ? vintNUll :pAlimentosICBF.ID_EstadoRegistro);
                    p.Add("@FechaRegistro",(pAlimentosICBF.FechaRegistro== null) ? vintNUll :pAlimentosICBF.FechaRegistro);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AlimentosICBF> l = SqlMapper.Query<AlimentosICBF>(con, "API.PA_AlimentosICBFGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AlimentosICBF  ->" + ex.Message);
				}
			}

			public AlimentosICBF Add(AlimentosICBF pAlimentosICBF)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAlimentosICBF.id==null ? 0 : pAlimentosICBF.id);
p.Add("@ID_SubGrupoAlimentos",pAlimentosICBF.ID_SubGrupoAlimentos==null ? 0 : pAlimentosICBF.ID_SubGrupoAlimentos);
p.Add("@ID_TipoAlimento",pAlimentosICBF.ID_TipoAlimento==null ? 0 : pAlimentosICBF.ID_TipoAlimento);
p.Add("@ID_ETC",pAlimentosICBF.ID_ETC==null ? 0 : pAlimentosICBF.ID_ETC);
p.Add("@ID_TipoFuenteNutricional",pAlimentosICBF.ID_TipoFuenteNutricional==null ? 0 : pAlimentosICBF.ID_TipoFuenteNutricional);
                    p.Add("@CodigoICBF", pAlimentosICBF.CodigoICBF);
                    p.Add("@PathlmagenAlimento", pAlimentosICBF.PathlmagenAlimento);
                    p.Add("@PathImagenInformacionNutricional", pAlimentosICBF.PathImagenInformacionNutricional);
                    p.Add("@PorcentajeComestible", pAlimentosICBF.PorcentajeComestible);
                    p.Add("@IntercambioEstandarizado", pAlimentosICBF.IntercambioEstandarizado);
                    p.Add("@PesoBruto", pAlimentosICBF.PesoBruto);
                    p.Add("@Nombre", pAlimentosICBF.Nombre);
p.Add("@ID_TiposUnidad",pAlimentosICBF.ID_TiposUnidad==null ? 0 : pAlimentosICBF.ID_TiposUnidad);
p.Add("@ID_EstadoRegistro",pAlimentosICBF.ID_EstadoRegistro==null ? 0 : pAlimentosICBF.ID_EstadoRegistro);
                    p.Add("@FechaRegistro", pAlimentosICBF.FechaRegistro);
                    p.Add("@auditoria", pAlimentosICBF.auditoria);

                         


                    AlimentosICBF o = SqlMapper.QueryFirstOrDefault<AlimentosICBF>(con, "API.PA_AlimentosICBFAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AlimentosICBF  ->" + ex.Message);
				}
			}

			public AlimentosICBF  Update(AlimentosICBF pAlimentosICBF)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAlimentosICBF.id==null ? 0 : pAlimentosICBF.id);
p.Add("@ID_SubGrupoAlimentos",pAlimentosICBF.ID_SubGrupoAlimentos==null ? 0 : pAlimentosICBF.ID_SubGrupoAlimentos);
p.Add("@ID_TipoAlimento",pAlimentosICBF.ID_TipoAlimento==null ? 0 : pAlimentosICBF.ID_TipoAlimento);
p.Add("@ID_ETC",pAlimentosICBF.ID_ETC==null ? 0 : pAlimentosICBF.ID_ETC);
p.Add("@ID_TipoFuenteNutricional",pAlimentosICBF.ID_TipoFuenteNutricional==null ? 0 : pAlimentosICBF.ID_TipoFuenteNutricional);
                    p.Add("@CodigoICBF", pAlimentosICBF.CodigoICBF);
                    p.Add("@PathlmagenAlimento", pAlimentosICBF.PathlmagenAlimento);
                    p.Add("@PathImagenInformacionNutricional", pAlimentosICBF.PathImagenInformacionNutricional);
                    p.Add("@PorcentajeComestible", pAlimentosICBF.PorcentajeComestible);
                    p.Add("@IntercambioEstandarizado", pAlimentosICBF.IntercambioEstandarizado);
                    p.Add("@PesoBruto", pAlimentosICBF.PesoBruto);
                    p.Add("@Nombre", pAlimentosICBF.Nombre);
p.Add("@ID_TiposUnidad",pAlimentosICBF.ID_TiposUnidad==null ? 0 : pAlimentosICBF.ID_TiposUnidad);
p.Add("@ID_EstadoRegistro",pAlimentosICBF.ID_EstadoRegistro==null ? 0 : pAlimentosICBF.ID_EstadoRegistro);
                    p.Add("@FechaRegistro", pAlimentosICBF.FechaRegistro);
                    p.Add("@auditoria", pAlimentosICBF.auditoria);

                         


                    AlimentosICBF o = SqlMapper.QueryFirstOrDefault<AlimentosICBF>(con, "API.PA_AlimentosICBFUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AlimentosICBF  ->" + ex.Message);
				}
			}

			public bool Delete(AlimentosICBF pAlimentosICBF)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAlimentosICBF.id);
                    p.Add("@auditoria", pAlimentosICBF.auditoria);

                

 

					AlimentosICBF o = SqlMapper.QueryFirstOrDefault<AlimentosICBF>(con, "API.PA_AlimentosICBFDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AlimentosICBF  ->" + ex.Message);
				}
			}

		



            public List<AlimentosICBF> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AlimentosICBF> AlimentosICBFList = new List<AlimentosICBF>();

                    AlimentosICBFList = SqlMapper.Query<AlimentosICBF>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AlimentosICBFList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AlimentosICBF  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AlimentosICBF> b)
            {
                DapperPlusManager.Entity<AlimentosICBF>().Table("AlimentosICBF");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}