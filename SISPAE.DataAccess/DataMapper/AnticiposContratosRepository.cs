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
     /// Clase Abstracta para  AnticiposContratos
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class AnticiposContratosRepository : DataObject , IAnticiposContratos 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public AnticiposContratosRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public AnticiposContratosRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public AnticiposContratos GetById(AnticiposContratos pAnticiposContratos)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pAnticiposContratos.id);                                    


    				AnticiposContratos o = SqlMapper.QueryFirstOrDefault<AnticiposContratos>(con, "API.PA_AnticiposContratosGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  AnticiposContratos  ->" + ex.Message);
				}
			}

			public List<AnticiposContratos> GetAll()
			{
				try 
                {
                        List<AnticiposContratos> l = SqlMapper.Query<AnticiposContratos>(con, "API.PA_AnticiposContratosGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  AnticiposContratos  ->" + ex.Message);
				}
			}

			public List<AnticiposContratos> GetAllFull()
			{
				try 
				{
                    List<AnticiposContratos> l = SqlMapper.Query<AnticiposContratos>(con, "API.PA_AnticiposContratosGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  AnticiposContratos  ->" + ex.Message);
				}
			}
			
			public List<AnticiposContratos> GetAllByWithRelation()
			{
				try 
                {
                    List<AnticiposContratos> l = SqlMapper.Query<AnticiposContratos>(con, "API.PA_AnticiposContratosGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  AnticiposContratos  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<AnticiposContratos> GetByFilter(AnticiposContratos pAnticiposContratos, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pAnticiposContratos.id== null || pAnticiposContratos.id==0) ? vintNUll :pAnticiposContratos.id);
                    p.Add("@ID_tipoperiodicidad",(pAnticiposContratos.ID_tipoperiodicidad== null || pAnticiposContratos.ID_tipoperiodicidad==0) ? vintNUll :pAnticiposContratos.ID_tipoperiodicidad);
                    p.Add("@ValorAnticipo",(pAnticiposContratos.ValorAnticipo== null) ? vintNUll :pAnticiposContratos.ValorAnticipo);
                    p.Add("@PorcentajeAnticipo",(pAnticiposContratos.PorcentajeAnticipo== null) ? vintNUll :pAnticiposContratos.PorcentajeAnticipo);
                    p.Add("@TipoPeriodicidadld",(pAnticiposContratos.TipoPeriodicidadld== null) ? vintNUll :pAnticiposContratos.TipoPeriodicidadld);
                    p.Add("@NumeroPagos",(pAnticiposContratos.NumeroPagos== null) ? vintNUll :pAnticiposContratos.NumeroPagos);
                    p.Add("@ID_Contrato",(pAnticiposContratos.ID_Contrato== null || pAnticiposContratos.ID_Contrato==0) ? vintNUll :pAnticiposContratos.ID_Contrato);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<AnticiposContratos> l = SqlMapper.Query<AnticiposContratos>(con, "API.PA_AnticiposContratosGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  AnticiposContratos  ->" + ex.Message);
				}
			}

			public AnticiposContratos Add(AnticiposContratos pAnticiposContratos)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pAnticiposContratos.id==null ? 0 : pAnticiposContratos.id);
p.Add("@ID_tipoperiodicidad",pAnticiposContratos.ID_tipoperiodicidad==null ? 0 : pAnticiposContratos.ID_tipoperiodicidad);
                    p.Add("@ValorAnticipo", pAnticiposContratos.ValorAnticipo);
                    p.Add("@PorcentajeAnticipo", pAnticiposContratos.PorcentajeAnticipo);
p.Add("@TipoPeriodicidadld",pAnticiposContratos.TipoPeriodicidadld==null ? 0 : pAnticiposContratos.TipoPeriodicidadld);
p.Add("@NumeroPagos",pAnticiposContratos.NumeroPagos==null ? 0 : pAnticiposContratos.NumeroPagos);
p.Add("@ID_Contrato",pAnticiposContratos.ID_Contrato==null ? 0 : pAnticiposContratos.ID_Contrato);
                    p.Add("@auditoria", pAnticiposContratos.auditoria);

                         


                    AnticiposContratos o = SqlMapper.QueryFirstOrDefault<AnticiposContratos>(con, "API.PA_AnticiposContratosAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  AnticiposContratos  ->" + ex.Message);
				}
			}

			public AnticiposContratos  Update(AnticiposContratos pAnticiposContratos)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pAnticiposContratos.id==null ? 0 : pAnticiposContratos.id);
p.Add("@ID_tipoperiodicidad",pAnticiposContratos.ID_tipoperiodicidad==null ? 0 : pAnticiposContratos.ID_tipoperiodicidad);
                    p.Add("@ValorAnticipo", pAnticiposContratos.ValorAnticipo);
                    p.Add("@PorcentajeAnticipo", pAnticiposContratos.PorcentajeAnticipo);
p.Add("@TipoPeriodicidadld",pAnticiposContratos.TipoPeriodicidadld==null ? 0 : pAnticiposContratos.TipoPeriodicidadld);
p.Add("@NumeroPagos",pAnticiposContratos.NumeroPagos==null ? 0 : pAnticiposContratos.NumeroPagos);
p.Add("@ID_Contrato",pAnticiposContratos.ID_Contrato==null ? 0 : pAnticiposContratos.ID_Contrato);
                    p.Add("@auditoria", pAnticiposContratos.auditoria);

                         


                    AnticiposContratos o = SqlMapper.QueryFirstOrDefault<AnticiposContratos>(con, "API.PA_AnticiposContratosUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  AnticiposContratos  ->" + ex.Message);
				}
			}

			public bool Delete(AnticiposContratos pAnticiposContratos)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pAnticiposContratos.id);
                    p.Add("@auditoria", pAnticiposContratos.auditoria);

                

 

					AnticiposContratos o = SqlMapper.QueryFirstOrDefault<AnticiposContratos>(con, "API.PA_AnticiposContratosDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) AnticiposContratos  ->" + ex.Message);
				}
			}

		



            public List<AnticiposContratos> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<AnticiposContratos> AnticiposContratosList = new List<AnticiposContratos>();

                    AnticiposContratosList = SqlMapper.Query<AnticiposContratos>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return AnticiposContratosList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) AnticiposContratos  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<AnticiposContratos> b)
            {
                DapperPlusManager.Entity<AnticiposContratos>().Table("AnticiposContratos");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}