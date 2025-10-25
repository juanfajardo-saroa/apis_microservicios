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
     /// Clase Abstracta para  CaracteristicasFinancieras
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CaracteristicasFinancierasRepository : DataObject , ICaracteristicasFinancieras 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CaracteristicasFinancierasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CaracteristicasFinancierasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public CaracteristicasFinancieras GetById(CaracteristicasFinancieras pCaracteristicasFinancieras)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCaracteristicasFinancieras.id);                                    


    				CaracteristicasFinancieras o = SqlMapper.QueryFirstOrDefault<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}

			public List<CaracteristicasFinancieras> GetAll()
			{
				try 
                {
                        List<CaracteristicasFinancieras> l = SqlMapper.Query<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}

			public List<CaracteristicasFinancieras> GetAllFull()
			{
				try 
				{
                    List<CaracteristicasFinancieras> l = SqlMapper.Query<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}
			
			public List<CaracteristicasFinancieras> GetAllByWithRelation()
			{
				try 
                {
                    List<CaracteristicasFinancieras> l = SqlMapper.Query<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<CaracteristicasFinancieras> GetByFilter(CaracteristicasFinancieras pCaracteristicasFinancieras, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCaracteristicasFinancieras.id== null || pCaracteristicasFinancieras.id==0) ? vintNUll :pCaracteristicasFinancieras.id);
                    p.Add("@ID_Contrato",(pCaracteristicasFinancieras.ID_Contrato== null || pCaracteristicasFinancieras.ID_Contrato==0) ? vintNUll :pCaracteristicasFinancieras.ID_Contrato);
                    p.Add("@ID_TipoModeloOperacion",(pCaracteristicasFinancieras.ID_TipoModeloOperacion== null || pCaracteristicasFinancieras.ID_TipoModeloOperacion==0) ? vintNUll :pCaracteristicasFinancieras.ID_TipoModeloOperacion);
                    p.Add("@ID_TipoModalidadComplemento",(pCaracteristicasFinancieras.ID_TipoModalidadComplemento== null || pCaracteristicasFinancieras.ID_TipoModalidadComplemento==0) ? vintNUll :pCaracteristicasFinancieras.ID_TipoModalidadComplemento);
                    p.Add("@ID_TipoComplemento",(pCaracteristicasFinancieras.ID_TipoComplemento== null || pCaracteristicasFinancieras.ID_TipoComplemento==0) ? vintNUll :pCaracteristicasFinancieras.ID_TipoComplemento);
                    p.Add("@ID_Jornada",(pCaracteristicasFinancieras.ID_Jornada== null || pCaracteristicasFinancieras.ID_Jornada==0) ? vintNUll :pCaracteristicasFinancieras.ID_Jornada);
                    p.Add("@PrecioComplemento",(pCaracteristicasFinancieras.PrecioComplemento== null) ? vintNUll :pCaracteristicasFinancieras.PrecioComplemento);
                    p.Add("@IdZona",(pCaracteristicasFinancieras.IdZona== null || pCaracteristicasFinancieras.IdZona==0) ? vintNUll :pCaracteristicasFinancieras.IdZona);
                    p.Add("@IdNivelEducativo",(pCaracteristicasFinancieras.IdNivelEducativo== null || pCaracteristicasFinancieras.IdNivelEducativo==0) ? vintNUll :pCaracteristicasFinancieras.IdNivelEducativo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<CaracteristicasFinancieras> l = SqlMapper.Query<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}

			public CaracteristicasFinancieras Add(CaracteristicasFinancieras pCaracteristicasFinancieras)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCaracteristicasFinancieras.id==null ? 0 : pCaracteristicasFinancieras.id);
p.Add("@ID_Contrato",pCaracteristicasFinancieras.ID_Contrato==null ? 0 : pCaracteristicasFinancieras.ID_Contrato);
p.Add("@ID_TipoModeloOperacion",pCaracteristicasFinancieras.ID_TipoModeloOperacion==null ? 0 : pCaracteristicasFinancieras.ID_TipoModeloOperacion);
p.Add("@ID_TipoModalidadComplemento",pCaracteristicasFinancieras.ID_TipoModalidadComplemento==null ? 0 : pCaracteristicasFinancieras.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pCaracteristicasFinancieras.ID_TipoComplemento==null ? 0 : pCaracteristicasFinancieras.ID_TipoComplemento);
p.Add("@ID_Jornada",pCaracteristicasFinancieras.ID_Jornada==null ? 0 : pCaracteristicasFinancieras.ID_Jornada);
                    p.Add("@PrecioComplemento", pCaracteristicasFinancieras.PrecioComplemento);
p.Add("@IdZona",pCaracteristicasFinancieras.IdZona==null ? 0 : pCaracteristicasFinancieras.IdZona);
p.Add("@IdNivelEducativo",pCaracteristicasFinancieras.IdNivelEducativo==null ? 0 : pCaracteristicasFinancieras.IdNivelEducativo);
                    p.Add("@auditoria", pCaracteristicasFinancieras.auditoria);

                         


                    CaracteristicasFinancieras o = SqlMapper.QueryFirstOrDefault<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}

			public CaracteristicasFinancieras  Update(CaracteristicasFinancieras pCaracteristicasFinancieras)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCaracteristicasFinancieras.id==null ? 0 : pCaracteristicasFinancieras.id);
p.Add("@ID_Contrato",pCaracteristicasFinancieras.ID_Contrato==null ? 0 : pCaracteristicasFinancieras.ID_Contrato);
p.Add("@ID_TipoModeloOperacion",pCaracteristicasFinancieras.ID_TipoModeloOperacion==null ? 0 : pCaracteristicasFinancieras.ID_TipoModeloOperacion);
p.Add("@ID_TipoModalidadComplemento",pCaracteristicasFinancieras.ID_TipoModalidadComplemento==null ? 0 : pCaracteristicasFinancieras.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pCaracteristicasFinancieras.ID_TipoComplemento==null ? 0 : pCaracteristicasFinancieras.ID_TipoComplemento);
p.Add("@ID_Jornada",pCaracteristicasFinancieras.ID_Jornada==null ? 0 : pCaracteristicasFinancieras.ID_Jornada);
                    p.Add("@PrecioComplemento", pCaracteristicasFinancieras.PrecioComplemento);
p.Add("@IdZona",pCaracteristicasFinancieras.IdZona==null ? 0 : pCaracteristicasFinancieras.IdZona);
p.Add("@IdNivelEducativo",pCaracteristicasFinancieras.IdNivelEducativo==null ? 0 : pCaracteristicasFinancieras.IdNivelEducativo);
                    p.Add("@auditoria", pCaracteristicasFinancieras.auditoria);

                         


                    CaracteristicasFinancieras o = SqlMapper.QueryFirstOrDefault<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  CaracteristicasFinancieras  ->" + ex.Message);
				}
			}

			public bool Delete(CaracteristicasFinancieras pCaracteristicasFinancieras)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCaracteristicasFinancieras.id);
                    p.Add("@auditoria", pCaracteristicasFinancieras.auditoria);

                

 

					CaracteristicasFinancieras o = SqlMapper.QueryFirstOrDefault<CaracteristicasFinancieras>(con, "API.PA_CaracteristicasFinancierasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) CaracteristicasFinancieras  ->" + ex.Message);
				}
			}

		



            public List<CaracteristicasFinancieras> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<CaracteristicasFinancieras> CaracteristicasFinancierasList = new List<CaracteristicasFinancieras>();

                    CaracteristicasFinancierasList = SqlMapper.Query<CaracteristicasFinancieras>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CaracteristicasFinancierasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) CaracteristicasFinancieras  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<CaracteristicasFinancieras> b)
            {
                DapperPlusManager.Entity<CaracteristicasFinancieras>().Table("CaracteristicasFinancieras");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}