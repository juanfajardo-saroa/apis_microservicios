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
     /// Clase Abstracta para  PoblacionAtendida
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PoblacionAtendidaRepository : DataObject , IPoblacionAtendida 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PoblacionAtendidaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PoblacionAtendidaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PoblacionAtendida GetById(PoblacionAtendida pPoblacionAtendida)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPoblacionAtendida.id);                                    


    				PoblacionAtendida o = SqlMapper.QueryFirstOrDefault<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PoblacionAtendida  ->" + ex.Message);
				}
			}

			public List<PoblacionAtendida> GetAll()
			{
				try 
                {
                        List<PoblacionAtendida> l = SqlMapper.Query<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PoblacionAtendida  ->" + ex.Message);
				}
			}

			public List<PoblacionAtendida> GetAllFull()
			{
				try 
				{
                    List<PoblacionAtendida> l = SqlMapper.Query<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PoblacionAtendida  ->" + ex.Message);
				}
			}
			
			public List<PoblacionAtendida> GetAllByWithRelation()
			{
				try 
                {
                    List<PoblacionAtendida> l = SqlMapper.Query<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PoblacionAtendida  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PoblacionAtendida> GetByFilter(PoblacionAtendida pPoblacionAtendida, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPoblacionAtendida.id== null || pPoblacionAtendida.id==0) ? vintNUll :pPoblacionAtendida.id);
                    p.Add("@ID_TipoPoblacionAtendida",(pPoblacionAtendida.ID_TipoPoblacionAtendida== null || pPoblacionAtendida.ID_TipoPoblacionAtendida==0) ? vintNUll :pPoblacionAtendida.ID_TipoPoblacionAtendida);
                    p.Add("@ID_TipoPoblacionEtnica",(pPoblacionAtendida.ID_TipoPoblacionEtnica== null || pPoblacionAtendida.ID_TipoPoblacionEtnica==0) ? vintNUll :pPoblacionAtendida.ID_TipoPoblacionEtnica);
                    p.Add("@ID_AgrupacionMensual",(pPoblacionAtendida.ID_AgrupacionMensual== null || pPoblacionAtendida.ID_AgrupacionMensual==0) ? vintNUll :pPoblacionAtendida.ID_AgrupacionMensual);
                    p.Add("@CantidadTitul",(pPoblacionAtendida.CantidadTitul== null) ? vintNUll :pPoblacionAtendida.CantidadTitul);
                    p.Add("@CantidadVictima",(pPoblacionAtendida.CantidadVictima== null) ? vintNUll :pPoblacionAtendida.CantidadVictima);
                    p.Add("@Cantidad",(pPoblacionAtendida.Cantidad== null) ? vintNUll :pPoblacionAtendida.Cantidad);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PoblacionAtendida> l = SqlMapper.Query<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PoblacionAtendida  ->" + ex.Message);
				}
			}

			public PoblacionAtendida Add(PoblacionAtendida pPoblacionAtendida)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPoblacionAtendida.id==null ? 0 : pPoblacionAtendida.id);
p.Add("@ID_TipoPoblacionAtendida",pPoblacionAtendida.ID_TipoPoblacionAtendida==null ? 0 : pPoblacionAtendida.ID_TipoPoblacionAtendida);
p.Add("@ID_TipoPoblacionEtnica",pPoblacionAtendida.ID_TipoPoblacionEtnica==null ? 0 : pPoblacionAtendida.ID_TipoPoblacionEtnica);
p.Add("@ID_AgrupacionMensual",pPoblacionAtendida.ID_AgrupacionMensual==null ? 0 : pPoblacionAtendida.ID_AgrupacionMensual);
p.Add("@CantidadTitul",pPoblacionAtendida.CantidadTitul==null ? 0 : pPoblacionAtendida.CantidadTitul);
p.Add("@CantidadVictima",pPoblacionAtendida.CantidadVictima==null ? 0 : pPoblacionAtendida.CantidadVictima);
p.Add("@Cantidad",pPoblacionAtendida.Cantidad==null ? 0 : pPoblacionAtendida.Cantidad);
                    p.Add("@auditoria", pPoblacionAtendida.auditoria);

                         


                    PoblacionAtendida o = SqlMapper.QueryFirstOrDefault<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PoblacionAtendida  ->" + ex.Message);
				}
			}

			public PoblacionAtendida  Update(PoblacionAtendida pPoblacionAtendida)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPoblacionAtendida.id==null ? 0 : pPoblacionAtendida.id);
p.Add("@ID_TipoPoblacionAtendida",pPoblacionAtendida.ID_TipoPoblacionAtendida==null ? 0 : pPoblacionAtendida.ID_TipoPoblacionAtendida);
p.Add("@ID_TipoPoblacionEtnica",pPoblacionAtendida.ID_TipoPoblacionEtnica==null ? 0 : pPoblacionAtendida.ID_TipoPoblacionEtnica);
p.Add("@ID_AgrupacionMensual",pPoblacionAtendida.ID_AgrupacionMensual==null ? 0 : pPoblacionAtendida.ID_AgrupacionMensual);
p.Add("@CantidadTitul",pPoblacionAtendida.CantidadTitul==null ? 0 : pPoblacionAtendida.CantidadTitul);
p.Add("@CantidadVictima",pPoblacionAtendida.CantidadVictima==null ? 0 : pPoblacionAtendida.CantidadVictima);
p.Add("@Cantidad",pPoblacionAtendida.Cantidad==null ? 0 : pPoblacionAtendida.Cantidad);
                    p.Add("@auditoria", pPoblacionAtendida.auditoria);

                         


                    PoblacionAtendida o = SqlMapper.QueryFirstOrDefault<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PoblacionAtendida  ->" + ex.Message);
				}
			}

			public bool Delete(PoblacionAtendida pPoblacionAtendida)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPoblacionAtendida.id);
                    p.Add("@auditoria", pPoblacionAtendida.auditoria);

                

 

					PoblacionAtendida o = SqlMapper.QueryFirstOrDefault<PoblacionAtendida>(con, "API.PA_PoblacionAtendidaDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PoblacionAtendida  ->" + ex.Message);
				}
			}

		



            public List<PoblacionAtendida> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PoblacionAtendida> PoblacionAtendidaList = new List<PoblacionAtendida>();

                    PoblacionAtendidaList = SqlMapper.Query<PoblacionAtendida>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PoblacionAtendidaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PoblacionAtendida  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PoblacionAtendida> b)
            {
                DapperPlusManager.Entity<PoblacionAtendida>().Table("PoblacionAtendida");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}