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
     /// Clase Abstracta para  PriorizacionesContrato
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PriorizacionesContratoRepository : DataObject , IPriorizacionesContrato 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PriorizacionesContratoRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PriorizacionesContratoRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public PriorizacionesContrato GetById(PriorizacionesContrato pPriorizacionesContrato)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pPriorizacionesContrato.id);                                    


    				PriorizacionesContrato o = SqlMapper.QueryFirstOrDefault<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  PriorizacionesContrato  ->" + ex.Message);
				}
			}

			public List<PriorizacionesContrato> GetAll()
			{
				try 
                {
                        List<PriorizacionesContrato> l = SqlMapper.Query<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  PriorizacionesContrato  ->" + ex.Message);
				}
			}

			public List<PriorizacionesContrato> GetAllFull()
			{
				try 
				{
                    List<PriorizacionesContrato> l = SqlMapper.Query<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  PriorizacionesContrato  ->" + ex.Message);
				}
			}
			
			public List<PriorizacionesContrato> GetAllByWithRelation()
			{
				try 
                {
                    List<PriorizacionesContrato> l = SqlMapper.Query<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  PriorizacionesContrato  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<PriorizacionesContrato> GetByFilter(PriorizacionesContrato pPriorizacionesContrato, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pPriorizacionesContrato.id== null || pPriorizacionesContrato.id==0) ? vintNUll :pPriorizacionesContrato.id);
                    p.Add("@ID_Contrato",(pPriorizacionesContrato.ID_Contrato== null || pPriorizacionesContrato.ID_Contrato==0) ? vintNUll :pPriorizacionesContrato.ID_Contrato);
                    p.Add("@ID_GradoSedeJornada",(pPriorizacionesContrato.ID_GradoSedeJornada== null || pPriorizacionesContrato.ID_GradoSedeJornada==0) ? vintNUll :pPriorizacionesContrato.ID_GradoSedeJornada);
                    p.Add("@ID_TipoModelooperacion",(pPriorizacionesContrato.ID_TipoModelooperacion== null || pPriorizacionesContrato.ID_TipoModelooperacion==0) ? vintNUll :pPriorizacionesContrato.ID_TipoModelooperacion);
                    p.Add("@ID_TipoModalidadComplemento",(pPriorizacionesContrato.ID_TipoModalidadComplemento== null || pPriorizacionesContrato.ID_TipoModalidadComplemento==0) ? vintNUll :pPriorizacionesContrato.ID_TipoModalidadComplemento);
                    p.Add("@ID_TipoComplemento",(pPriorizacionesContrato.ID_TipoComplemento== null || pPriorizacionesContrato.ID_TipoComplemento==0) ? vintNUll :pPriorizacionesContrato.ID_TipoComplemento);
                    p.Add("@NumeroComplementos",(pPriorizacionesContrato.NumeroComplementos== null) ? vintNUll :pPriorizacionesContrato.NumeroComplementos);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<PriorizacionesContrato> l = SqlMapper.Query<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  PriorizacionesContrato  ->" + ex.Message);
				}
			}

			public PriorizacionesContrato Add(PriorizacionesContrato pPriorizacionesContrato)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pPriorizacionesContrato.id==null ? 0 : pPriorizacionesContrato.id);
p.Add("@ID_Contrato",pPriorizacionesContrato.ID_Contrato==null ? 0 : pPriorizacionesContrato.ID_Contrato);
p.Add("@ID_GradoSedeJornada",pPriorizacionesContrato.ID_GradoSedeJornada==null ? 0 : pPriorizacionesContrato.ID_GradoSedeJornada);
p.Add("@ID_TipoModelooperacion",pPriorizacionesContrato.ID_TipoModelooperacion==null ? 0 : pPriorizacionesContrato.ID_TipoModelooperacion);
p.Add("@ID_TipoModalidadComplemento",pPriorizacionesContrato.ID_TipoModalidadComplemento==null ? 0 : pPriorizacionesContrato.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pPriorizacionesContrato.ID_TipoComplemento==null ? 0 : pPriorizacionesContrato.ID_TipoComplemento);
p.Add("@NumeroComplementos",pPriorizacionesContrato.NumeroComplementos==null ? 0 : pPriorizacionesContrato.NumeroComplementos);
                    p.Add("@auditoria", pPriorizacionesContrato.auditoria);

                         


                    PriorizacionesContrato o = SqlMapper.QueryFirstOrDefault<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  PriorizacionesContrato  ->" + ex.Message);
				}
			}

			public PriorizacionesContrato  Update(PriorizacionesContrato pPriorizacionesContrato)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pPriorizacionesContrato.id==null ? 0 : pPriorizacionesContrato.id);
p.Add("@ID_Contrato",pPriorizacionesContrato.ID_Contrato==null ? 0 : pPriorizacionesContrato.ID_Contrato);
p.Add("@ID_GradoSedeJornada",pPriorizacionesContrato.ID_GradoSedeJornada==null ? 0 : pPriorizacionesContrato.ID_GradoSedeJornada);
p.Add("@ID_TipoModelooperacion",pPriorizacionesContrato.ID_TipoModelooperacion==null ? 0 : pPriorizacionesContrato.ID_TipoModelooperacion);
p.Add("@ID_TipoModalidadComplemento",pPriorizacionesContrato.ID_TipoModalidadComplemento==null ? 0 : pPriorizacionesContrato.ID_TipoModalidadComplemento);
p.Add("@ID_TipoComplemento",pPriorizacionesContrato.ID_TipoComplemento==null ? 0 : pPriorizacionesContrato.ID_TipoComplemento);
p.Add("@NumeroComplementos",pPriorizacionesContrato.NumeroComplementos==null ? 0 : pPriorizacionesContrato.NumeroComplementos);
                    p.Add("@auditoria", pPriorizacionesContrato.auditoria);

                         


                    PriorizacionesContrato o = SqlMapper.QueryFirstOrDefault<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  PriorizacionesContrato  ->" + ex.Message);
				}
			}

			public bool Delete(PriorizacionesContrato pPriorizacionesContrato)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pPriorizacionesContrato.id);
                    p.Add("@auditoria", pPriorizacionesContrato.auditoria);

                

 

					PriorizacionesContrato o = SqlMapper.QueryFirstOrDefault<PriorizacionesContrato>(con, "API.PA_PriorizacionesContratoDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) PriorizacionesContrato  ->" + ex.Message);
				}
			}

		



            public List<PriorizacionesContrato> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<PriorizacionesContrato> PriorizacionesContratoList = new List<PriorizacionesContrato>();

                    PriorizacionesContratoList = SqlMapper.Query<PriorizacionesContrato>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return PriorizacionesContratoList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) PriorizacionesContrato  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<PriorizacionesContrato> b)
            {
                DapperPlusManager.Entity<PriorizacionesContrato>().Table("PriorizacionesContrato");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}