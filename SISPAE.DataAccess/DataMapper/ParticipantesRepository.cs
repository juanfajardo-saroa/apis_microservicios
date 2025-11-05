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
     /// Clase Abstracta para  Participantes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ParticipantesRepository : DataObject , IParticipantes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ParticipantesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ParticipantesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Participantes GetById(Participantes pParticipantes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pParticipantes.id);                                    


    				Participantes o = SqlMapper.QueryFirstOrDefault<Participantes>(con, "API.PA_ParticipantesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Participantes  ->" + ex.Message);
				}
			}

			public List<Participantes> GetAll()
			{
				try 
                {
                        List<Participantes> l = SqlMapper.Query<Participantes>(con, "API.PA_ParticipantesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Participantes  ->" + ex.Message);
				}
			}

			public List<Participantes> GetAllFull()
			{
				try 
				{
                    List<Participantes> l = SqlMapper.Query<Participantes>(con, "API.PA_ParticipantesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Participantes  ->" + ex.Message);
				}
			}
			
			public List<Participantes> GetAllByWithRelation()
			{
				try 
                {
                    List<Participantes> l = SqlMapper.Query<Participantes>(con, "API.PA_ParticipantesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Participantes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Participantes> GetByFilter(Participantes pParticipantes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pParticipantes.id== null || pParticipantes.id==0) ? vintNUll :pParticipantes.id);
                    p.Add("@ID_Comite",(pParticipantes.ID_Comite== null || pParticipantes.ID_Comite==0) ? vintNUll :pParticipantes.ID_Comite);
                    p.Add("@ID_TipoParticipante",(pParticipantes.ID_TipoParticipante== null || pParticipantes.ID_TipoParticipante==0) ? vintNUll :pParticipantes.ID_TipoParticipante);
                    p.Add("@ID_Grado",(pParticipantes.ID_Grado== null || pParticipantes.ID_Grado==0) ? vintNUll :pParticipantes.ID_Grado);
                    p.Add("@Activo",(pParticipantes.Activo== null) ? vintNUll :pParticipantes.Activo);
                    p.Add("@Cargolnstitucion",(pParticipantes.Cargolnstitucion== null) ? vintNUll :pParticipantes.Cargolnstitucion);
                    p.Add("@FechaPersonero",(pParticipantes.FechaPersonero== null) ? vintNUll :pParticipantes.FechaPersonero);
                    p.Add("@Nombre",(pParticipantes.Nombre== null) ? vintNUll :pParticipantes.Nombre);
                    p.Add("@Apellido",(pParticipantes.Apellido== null) ? vintNUll :pParticipantes.Apellido);
                    p.Add("@Celular",(pParticipantes.Celular== null) ? vintNUll :pParticipantes.Celular);
                    p.Add("@Correo",(pParticipantes.Correo== null) ? vintNUll :pParticipantes.Correo);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Participantes> l = SqlMapper.Query<Participantes>(con, "API.PA_ParticipantesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Participantes  ->" + ex.Message);
				}
			}

			public Participantes Add(Participantes pParticipantes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pParticipantes.id==null ? 0 : pParticipantes.id);
p.Add("@ID_Comite",pParticipantes.ID_Comite==null ? 0 : pParticipantes.ID_Comite);
p.Add("@ID_TipoParticipante",pParticipantes.ID_TipoParticipante==null ? 0 : pParticipantes.ID_TipoParticipante);
p.Add("@ID_Grado",pParticipantes.ID_Grado==null ? 0 : pParticipantes.ID_Grado);
                    p.Add("@Activo", pParticipantes.Activo);
                    p.Add("@Cargolnstitucion", pParticipantes.Cargolnstitucion);
                    p.Add("@FechaPersonero", pParticipantes.FechaPersonero);
                    p.Add("@Nombre", pParticipantes.Nombre);
                    p.Add("@Apellido", pParticipantes.Apellido);
                    p.Add("@Celular", pParticipantes.Celular);
                    p.Add("@Correo", pParticipantes.Correo);
                    p.Add("@auditoria", pParticipantes.auditoria);

                         


                    Participantes o = SqlMapper.QueryFirstOrDefault<Participantes>(con, "API.PA_ParticipantesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Participantes  ->" + ex.Message);
				}
			}

			public Participantes  Update(Participantes pParticipantes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pParticipantes.id==null ? 0 : pParticipantes.id);
p.Add("@ID_Comite",pParticipantes.ID_Comite==null ? 0 : pParticipantes.ID_Comite);
p.Add("@ID_TipoParticipante",pParticipantes.ID_TipoParticipante==null ? 0 : pParticipantes.ID_TipoParticipante);
p.Add("@ID_Grado",pParticipantes.ID_Grado==null ? 0 : pParticipantes.ID_Grado);
                    p.Add("@Activo", pParticipantes.Activo);
                    p.Add("@Cargolnstitucion", pParticipantes.Cargolnstitucion);
                    p.Add("@FechaPersonero", pParticipantes.FechaPersonero);
                    p.Add("@Nombre", pParticipantes.Nombre);
                    p.Add("@Apellido", pParticipantes.Apellido);
                    p.Add("@Celular", pParticipantes.Celular);
                    p.Add("@Correo", pParticipantes.Correo);
                    p.Add("@auditoria", pParticipantes.auditoria);

                         


                    Participantes o = SqlMapper.QueryFirstOrDefault<Participantes>(con, "API.PA_ParticipantesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Participantes  ->" + ex.Message);
				}
			}

			public bool Delete(Participantes pParticipantes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pParticipantes.id);
                    p.Add("@auditoria", pParticipantes.auditoria);

                

 

					Participantes o = SqlMapper.QueryFirstOrDefault<Participantes>(con, "API.PA_ParticipantesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Participantes  ->" + ex.Message);
				}
			}

		



            public List<Participantes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Participantes> ParticipantesList = new List<Participantes>();

                    ParticipantesList = SqlMapper.Query<Participantes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ParticipantesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Participantes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Participantes> b)
            {
                DapperPlusManager.Entity<Participantes>().Table("Participantes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}