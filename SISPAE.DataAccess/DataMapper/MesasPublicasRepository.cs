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
     /// Clase Abstracta para  MesasPublicas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class MesasPublicasRepository : DataObject , IMesasPublicas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public MesasPublicasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public MesasPublicasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public MesasPublicas GetById(MesasPublicas pMesasPublicas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pMesasPublicas.id);                                    


    				MesasPublicas o = SqlMapper.QueryFirstOrDefault<MesasPublicas>(con, "API.PA_MesasPublicasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  MesasPublicas  ->" + ex.Message);
				}
			}

			public List<MesasPublicas> GetAll()
			{
				try 
                {
                        List<MesasPublicas> l = SqlMapper.Query<MesasPublicas>(con, "API.PA_MesasPublicasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  MesasPublicas  ->" + ex.Message);
				}
			}

			public List<MesasPublicas> GetAllFull()
			{
				try 
				{
                    List<MesasPublicas> l = SqlMapper.Query<MesasPublicas>(con, "API.PA_MesasPublicasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  MesasPublicas  ->" + ex.Message);
				}
			}
			
			public List<MesasPublicas> GetAllByWithRelation()
			{
				try 
                {
                    List<MesasPublicas> l = SqlMapper.Query<MesasPublicas>(con, "API.PA_MesasPublicasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  MesasPublicas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<MesasPublicas> GetByFilter(MesasPublicas pMesasPublicas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pMesasPublicas.id== null || pMesasPublicas.id==0) ? vintNUll :pMesasPublicas.id);
                    p.Add("@ID_ETC",(pMesasPublicas.ID_ETC== null || pMesasPublicas.ID_ETC==0) ? vintNUll :pMesasPublicas.ID_ETC);
                    p.Add("@ID_UsuarioEntidad",(pMesasPublicas.ID_UsuarioEntidad== null || pMesasPublicas.ID_UsuarioEntidad==0) ? vintNUll :pMesasPublicas.ID_UsuarioEntidad);
                    p.Add("@ID_EstadoValidacion",(pMesasPublicas.ID_EstadoValidacion== null || pMesasPublicas.ID_EstadoValidacion==0) ? vintNUll :pMesasPublicas.ID_EstadoValidacion);
                    p.Add("@ID_Vigencia",(pMesasPublicas.ID_Vigencia== null || pMesasPublicas.ID_Vigencia==0) ? vintNUll :pMesasPublicas.ID_Vigencia);
                    p.Add("@TemasTratados",(pMesasPublicas.TemasTratados== null) ? vintNUll :pMesasPublicas.TemasTratados);
                    p.Add("@DecisionesTomadas",(pMesasPublicas.DecisionesTomadas== null) ? vintNUll :pMesasPublicas.DecisionesTomadas);
                    p.Add("@FechaAprobacion",(pMesasPublicas.FechaAprobacion== null) ? vintNUll :pMesasPublicas.FechaAprobacion);
                    p.Add("@ObservacionesLiderPAE",(pMesasPublicas.ObservacionesLiderPAE== null) ? vintNUll :pMesasPublicas.ObservacionesLiderPAE);
                    p.Add("@SoporteMesaPath",(pMesasPublicas.SoporteMesaPath== null) ? vintNUll :pMesasPublicas.SoporteMesaPath);
                    p.Add("@DescripcionTiposParticipantes",(pMesasPublicas.DescripcionTiposParticipantes== null) ? vintNUll :pMesasPublicas.DescripcionTiposParticipantes);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<MesasPublicas> l = SqlMapper.Query<MesasPublicas>(con, "API.PA_MesasPublicasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  MesasPublicas  ->" + ex.Message);
				}
			}

			public MesasPublicas Add(MesasPublicas pMesasPublicas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pMesasPublicas.id==null ? 0 : pMesasPublicas.id);
p.Add("@ID_ETC",pMesasPublicas.ID_ETC==null ? 0 : pMesasPublicas.ID_ETC);
p.Add("@ID_UsuarioEntidad",pMesasPublicas.ID_UsuarioEntidad==null ? 0 : pMesasPublicas.ID_UsuarioEntidad);
p.Add("@ID_EstadoValidacion",pMesasPublicas.ID_EstadoValidacion==null ? 0 : pMesasPublicas.ID_EstadoValidacion);
p.Add("@ID_Vigencia",pMesasPublicas.ID_Vigencia==null ? 0 : pMesasPublicas.ID_Vigencia);
p.Add("@TemasTratados",pMesasPublicas.TemasTratados==null ? 0 : pMesasPublicas.TemasTratados);
p.Add("@DecisionesTomadas",pMesasPublicas.DecisionesTomadas==null ? 0 : pMesasPublicas.DecisionesTomadas);
p.Add("@FechaAprobacion",pMesasPublicas.FechaAprobacion==null ? 0 : pMesasPublicas.FechaAprobacion);
p.Add("@ObservacionesLiderPAE",pMesasPublicas.ObservacionesLiderPAE==null ? 0 : pMesasPublicas.ObservacionesLiderPAE);
p.Add("@SoporteMesaPath",pMesasPublicas.SoporteMesaPath==null ? 0 : pMesasPublicas.SoporteMesaPath);
p.Add("@DescripcionTiposParticipantes",pMesasPublicas.DescripcionTiposParticipantes==null ? 0 : pMesasPublicas.DescripcionTiposParticipantes);
                    p.Add("@auditoria", pMesasPublicas.auditoria);

                         


                    MesasPublicas o = SqlMapper.QueryFirstOrDefault<MesasPublicas>(con, "API.PA_MesasPublicasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  MesasPublicas  ->" + ex.Message);
				}
			}

			public MesasPublicas  Update(MesasPublicas pMesasPublicas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pMesasPublicas.id==null ? 0 : pMesasPublicas.id);
p.Add("@ID_ETC",pMesasPublicas.ID_ETC==null ? 0 : pMesasPublicas.ID_ETC);
p.Add("@ID_UsuarioEntidad",pMesasPublicas.ID_UsuarioEntidad==null ? 0 : pMesasPublicas.ID_UsuarioEntidad);
p.Add("@ID_EstadoValidacion",pMesasPublicas.ID_EstadoValidacion==null ? 0 : pMesasPublicas.ID_EstadoValidacion);
p.Add("@ID_Vigencia",pMesasPublicas.ID_Vigencia==null ? 0 : pMesasPublicas.ID_Vigencia);
p.Add("@TemasTratados",pMesasPublicas.TemasTratados==null ? 0 : pMesasPublicas.TemasTratados);
p.Add("@DecisionesTomadas",pMesasPublicas.DecisionesTomadas==null ? 0 : pMesasPublicas.DecisionesTomadas);
p.Add("@FechaAprobacion",pMesasPublicas.FechaAprobacion==null ? 0 : pMesasPublicas.FechaAprobacion);
p.Add("@ObservacionesLiderPAE",pMesasPublicas.ObservacionesLiderPAE==null ? 0 : pMesasPublicas.ObservacionesLiderPAE);
p.Add("@SoporteMesaPath",pMesasPublicas.SoporteMesaPath==null ? 0 : pMesasPublicas.SoporteMesaPath);
p.Add("@DescripcionTiposParticipantes",pMesasPublicas.DescripcionTiposParticipantes==null ? 0 : pMesasPublicas.DescripcionTiposParticipantes);
                    p.Add("@auditoria", pMesasPublicas.auditoria);

                         


                    MesasPublicas o = SqlMapper.QueryFirstOrDefault<MesasPublicas>(con, "API.PA_MesasPublicasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  MesasPublicas  ->" + ex.Message);
				}
			}

			public bool Delete(MesasPublicas pMesasPublicas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pMesasPublicas.id);
                    p.Add("@auditoria", pMesasPublicas.auditoria);

                

 

					MesasPublicas o = SqlMapper.QueryFirstOrDefault<MesasPublicas>(con, "API.PA_MesasPublicasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) MesasPublicas  ->" + ex.Message);
				}
			}

		



            public List<MesasPublicas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<MesasPublicas> MesasPublicasList = new List<MesasPublicas>();

                    MesasPublicasList = SqlMapper.Query<MesasPublicas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return MesasPublicasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) MesasPublicas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<MesasPublicas> b)
            {
                DapperPlusManager.Entity<MesasPublicas>().Table("MesasPublicas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}