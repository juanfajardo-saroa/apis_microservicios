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
     /// Clase Abstracta para  VisitasControlSocial
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class VisitasControlSocialRepository : DataObject , IVisitasControlSocial 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public VisitasControlSocialRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public VisitasControlSocialRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public VisitasControlSocial GetById(VisitasControlSocial pVisitasControlSocial)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pVisitasControlSocial.id);                                    


    				VisitasControlSocial o = SqlMapper.QueryFirstOrDefault<VisitasControlSocial>(con, "API.PA_VisitasControlSocialGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  VisitasControlSocial  ->" + ex.Message);
				}
			}

			public List<VisitasControlSocial> GetAll()
			{
				try 
                {
                        List<VisitasControlSocial> l = SqlMapper.Query<VisitasControlSocial>(con, "API.PA_VisitasControlSocialGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  VisitasControlSocial  ->" + ex.Message);
				}
			}

			public List<VisitasControlSocial> GetAllFull()
			{
				try 
				{
                    List<VisitasControlSocial> l = SqlMapper.Query<VisitasControlSocial>(con, "API.PA_VisitasControlSocialGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  VisitasControlSocial  ->" + ex.Message);
				}
			}
			
			public List<VisitasControlSocial> GetAllByWithRelation()
			{
				try 
                {
                    List<VisitasControlSocial> l = SqlMapper.Query<VisitasControlSocial>(con, "API.PA_VisitasControlSocialGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  VisitasControlSocial  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<VisitasControlSocial> GetByFilter(VisitasControlSocial pVisitasControlSocial, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pVisitasControlSocial.id== null || pVisitasControlSocial.id==0) ? vintNUll :pVisitasControlSocial.id);
                    p.Add("@ID_TipoActorControlSocial",(pVisitasControlSocial.ID_TipoActorControlSocial== null || pVisitasControlSocial.ID_TipoActorControlSocial==0) ? vintNUll :pVisitasControlSocial.ID_TipoActorControlSocial);
                    p.Add("@ID_Divipola",(pVisitasControlSocial.ID_Divipola== null || pVisitasControlSocial.ID_Divipola==0) ? vintNUll :pVisitasControlSocial.ID_Divipola);
                    p.Add("@ID_TipoEntidad",(pVisitasControlSocial.ID_TipoEntidad== null || pVisitasControlSocial.ID_TipoEntidad==0) ? vintNUll :pVisitasControlSocial.ID_TipoEntidad);
                    p.Add("@ID_Sede",(pVisitasControlSocial.ID_Sede== null || pVisitasControlSocial.ID_Sede==0) ? vintNUll :pVisitasControlSocial.ID_Sede);
                    p.Add("@ID_Vigencia",(pVisitasControlSocial.ID_Vigencia== null || pVisitasControlSocial.ID_Vigencia==0) ? vintNUll :pVisitasControlSocial.ID_Vigencia);
                    p.Add("@ID_TipoCargoControlSocial",(pVisitasControlSocial.ID_TipoCargoControlSocial== null || pVisitasControlSocial.ID_TipoCargoControlSocial==0) ? vintNUll :pVisitasControlSocial.ID_TipoCargoControlSocial);
                    p.Add("@cargoControlSocialOtros",(pVisitasControlSocial.cargoControlSocialOtros== null) ? vintNUll :pVisitasControlSocial.cargoControlSocialOtros);
                    p.Add("@ID_TipolnstitucionControlSocial",(pVisitasControlSocial.ID_TipolnstitucionControlSocial== null || pVisitasControlSocial.ID_TipolnstitucionControlSocial==0) ? vintNUll :pVisitasControlSocial.ID_TipolnstitucionControlSocial);
                    p.Add("@InstitucionControlSocialOtros",(pVisitasControlSocial.InstitucionControlSocialOtros== null) ? vintNUll :pVisitasControlSocial.InstitucionControlSocialOtros);
                    p.Add("@Correo",(pVisitasControlSocial.Correo== null) ? vintNUll :pVisitasControlSocial.Correo);
                    p.Add("@Nombre",(pVisitasControlSocial.Nombre== null) ? vintNUll :pVisitasControlSocial.Nombre);
                    p.Add("@Apellido",(pVisitasControlSocial.Apellido== null) ? vintNUll :pVisitasControlSocial.Apellido);
                    p.Add("@Cedula",(pVisitasControlSocial.Cedula== null) ? vintNUll :pVisitasControlSocial.Cedula);
                    p.Add("@Celular",(pVisitasControlSocial.Celular== null) ? vintNUll :pVisitasControlSocial.Celular);
                    p.Add("@FechaHoraVisita",(pVisitasControlSocial.FechaHoraVisita== null) ? vintNUll :pVisitasControlSocial.FechaHoraVisita);
                    p.Add("@FechaReporte",(pVisitasControlSocial.FechaReporte== null) ? vintNUll :pVisitasControlSocial.FechaReporte);
                    p.Add("@FotoComplementoEvidenciaPath",(pVisitasControlSocial.FotoComplementoEvidenciaPath== null) ? vintNUll :pVisitasControlSocial.FotoComplementoEvidenciaPath);
                    p.Add("@DescripcionFoto",(pVisitasControlSocial.DescripcionFoto== null) ? vintNUll :pVisitasControlSocial.DescripcionFoto);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<VisitasControlSocial> l = SqlMapper.Query<VisitasControlSocial>(con, "API.PA_VisitasControlSocialGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  VisitasControlSocial  ->" + ex.Message);
				}
			}

			public VisitasControlSocial Add(VisitasControlSocial pVisitasControlSocial)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pVisitasControlSocial.id==null ? 0 : pVisitasControlSocial.id);
p.Add("@ID_TipoActorControlSocial",pVisitasControlSocial.ID_TipoActorControlSocial==null ? 0 : pVisitasControlSocial.ID_TipoActorControlSocial);
p.Add("@ID_Divipola",pVisitasControlSocial.ID_Divipola==null ? 0 : pVisitasControlSocial.ID_Divipola);
p.Add("@ID_TipoEntidad",pVisitasControlSocial.ID_TipoEntidad==null ? 0 : pVisitasControlSocial.ID_TipoEntidad);
p.Add("@ID_Sede",pVisitasControlSocial.ID_Sede==null ? 0 : pVisitasControlSocial.ID_Sede);
p.Add("@ID_Vigencia",pVisitasControlSocial.ID_Vigencia==null ? 0 : pVisitasControlSocial.ID_Vigencia);
p.Add("@ID_TipoCargoControlSocial",pVisitasControlSocial.ID_TipoCargoControlSocial==null ? 0 : pVisitasControlSocial.ID_TipoCargoControlSocial);
p.Add("@cargoControlSocialOtros",pVisitasControlSocial.cargoControlSocialOtros==null ? 0 : pVisitasControlSocial.cargoControlSocialOtros);
p.Add("@ID_TipolnstitucionControlSocial",pVisitasControlSocial.ID_TipolnstitucionControlSocial==null ? 0 : pVisitasControlSocial.ID_TipolnstitucionControlSocial);
p.Add("@InstitucionControlSocialOtros",pVisitasControlSocial.InstitucionControlSocialOtros==null ? 0 : pVisitasControlSocial.InstitucionControlSocialOtros);
                    p.Add("@Correo", pVisitasControlSocial.Correo);
                    p.Add("@Nombre", pVisitasControlSocial.Nombre);
                    p.Add("@Apellido", pVisitasControlSocial.Apellido);
                    p.Add("@Cedula", pVisitasControlSocial.Cedula);
                    p.Add("@Celular", pVisitasControlSocial.Celular);
p.Add("@FechaHoraVisita",pVisitasControlSocial.FechaHoraVisita==null ? 0 : pVisitasControlSocial.FechaHoraVisita);
p.Add("@FechaReporte",pVisitasControlSocial.FechaReporte==null ? 0 : pVisitasControlSocial.FechaReporte);
p.Add("@FotoComplementoEvidenciaPath",pVisitasControlSocial.FotoComplementoEvidenciaPath==null ? 0 : pVisitasControlSocial.FotoComplementoEvidenciaPath);
p.Add("@DescripcionFoto",pVisitasControlSocial.DescripcionFoto==null ? 0 : pVisitasControlSocial.DescripcionFoto);
                    p.Add("@auditoria", pVisitasControlSocial.auditoria);

                         


                    VisitasControlSocial o = SqlMapper.QueryFirstOrDefault<VisitasControlSocial>(con, "API.PA_VisitasControlSocialAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  VisitasControlSocial  ->" + ex.Message);
				}
			}

			public VisitasControlSocial  Update(VisitasControlSocial pVisitasControlSocial)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pVisitasControlSocial.id==null ? 0 : pVisitasControlSocial.id);
p.Add("@ID_TipoActorControlSocial",pVisitasControlSocial.ID_TipoActorControlSocial==null ? 0 : pVisitasControlSocial.ID_TipoActorControlSocial);
p.Add("@ID_Divipola",pVisitasControlSocial.ID_Divipola==null ? 0 : pVisitasControlSocial.ID_Divipola);
p.Add("@ID_TipoEntidad",pVisitasControlSocial.ID_TipoEntidad==null ? 0 : pVisitasControlSocial.ID_TipoEntidad);
p.Add("@ID_Sede",pVisitasControlSocial.ID_Sede==null ? 0 : pVisitasControlSocial.ID_Sede);
p.Add("@ID_Vigencia",pVisitasControlSocial.ID_Vigencia==null ? 0 : pVisitasControlSocial.ID_Vigencia);
p.Add("@ID_TipoCargoControlSocial",pVisitasControlSocial.ID_TipoCargoControlSocial==null ? 0 : pVisitasControlSocial.ID_TipoCargoControlSocial);
p.Add("@cargoControlSocialOtros",pVisitasControlSocial.cargoControlSocialOtros==null ? 0 : pVisitasControlSocial.cargoControlSocialOtros);
p.Add("@ID_TipolnstitucionControlSocial",pVisitasControlSocial.ID_TipolnstitucionControlSocial==null ? 0 : pVisitasControlSocial.ID_TipolnstitucionControlSocial);
p.Add("@InstitucionControlSocialOtros",pVisitasControlSocial.InstitucionControlSocialOtros==null ? 0 : pVisitasControlSocial.InstitucionControlSocialOtros);
                    p.Add("@Correo", pVisitasControlSocial.Correo);
                    p.Add("@Nombre", pVisitasControlSocial.Nombre);
                    p.Add("@Apellido", pVisitasControlSocial.Apellido);
                    p.Add("@Cedula", pVisitasControlSocial.Cedula);
                    p.Add("@Celular", pVisitasControlSocial.Celular);
p.Add("@FechaHoraVisita",pVisitasControlSocial.FechaHoraVisita==null ? 0 : pVisitasControlSocial.FechaHoraVisita);
p.Add("@FechaReporte",pVisitasControlSocial.FechaReporte==null ? 0 : pVisitasControlSocial.FechaReporte);
p.Add("@FotoComplementoEvidenciaPath",pVisitasControlSocial.FotoComplementoEvidenciaPath==null ? 0 : pVisitasControlSocial.FotoComplementoEvidenciaPath);
p.Add("@DescripcionFoto",pVisitasControlSocial.DescripcionFoto==null ? 0 : pVisitasControlSocial.DescripcionFoto);
                    p.Add("@auditoria", pVisitasControlSocial.auditoria);

                         


                    VisitasControlSocial o = SqlMapper.QueryFirstOrDefault<VisitasControlSocial>(con, "API.PA_VisitasControlSocialUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  VisitasControlSocial  ->" + ex.Message);
				}
			}

			public bool Delete(VisitasControlSocial pVisitasControlSocial)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pVisitasControlSocial.id);
                    p.Add("@auditoria", pVisitasControlSocial.auditoria);

                

 

					VisitasControlSocial o = SqlMapper.QueryFirstOrDefault<VisitasControlSocial>(con, "API.PA_VisitasControlSocialDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) VisitasControlSocial  ->" + ex.Message);
				}
			}

		



            public List<VisitasControlSocial> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<VisitasControlSocial> VisitasControlSocialList = new List<VisitasControlSocial>();

                    VisitasControlSocialList = SqlMapper.Query<VisitasControlSocial>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return VisitasControlSocialList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) VisitasControlSocial  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<VisitasControlSocial> b)
            {
                DapperPlusManager.Entity<VisitasControlSocial>().Table("VisitasControlSocial");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}