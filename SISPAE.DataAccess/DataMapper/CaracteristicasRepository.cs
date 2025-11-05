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
     /// Clase Abstracta para  Caracteristicas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class CaracteristicasRepository : DataObject , ICaracteristicas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public CaracteristicasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public CaracteristicasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Caracteristicas GetById(Caracteristicas pCaracteristicas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pCaracteristicas.id);                                    


    				Caracteristicas o = SqlMapper.QueryFirstOrDefault<Caracteristicas>(con, "API.PA_CaracteristicasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Caracteristicas  ->" + ex.Message);
				}
			}

			public List<Caracteristicas> GetAll()
			{
				try 
                {
                        List<Caracteristicas> l = SqlMapper.Query<Caracteristicas>(con, "API.PA_CaracteristicasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Caracteristicas  ->" + ex.Message);
				}
			}

			public List<Caracteristicas> GetAllFull()
			{
				try 
				{
                    List<Caracteristicas> l = SqlMapper.Query<Caracteristicas>(con, "API.PA_CaracteristicasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Caracteristicas  ->" + ex.Message);
				}
			}
			
			public List<Caracteristicas> GetAllByWithRelation()
			{
				try 
                {
                    List<Caracteristicas> l = SqlMapper.Query<Caracteristicas>(con, "API.PA_CaracteristicasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Caracteristicas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Caracteristicas> GetByFilter(Caracteristicas pCaracteristicas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pCaracteristicas.id== null || pCaracteristicas.id==0) ? vintNUll :pCaracteristicas.id);
                    p.Add("@ID_Indicador",(pCaracteristicas.ID_Indicador== null || pCaracteristicas.ID_Indicador==0) ? vintNUll :pCaracteristicas.ID_Indicador);
                    p.Add("@ID_Escala",(pCaracteristicas.ID_Escala== null || pCaracteristicas.ID_Escala==0) ? vintNUll :pCaracteristicas.ID_Escala);
                    p.Add("@Pregunta",(pCaracteristicas.Pregunta== null) ? vintNUll :pCaracteristicas.Pregunta);
                    p.Add("@ID_PreguntaPadre",(pCaracteristicas.ID_PreguntaPadre== null || pCaracteristicas.ID_PreguntaPadre==0) ? vintNUll :pCaracteristicas.ID_PreguntaPadre);
                    p.Add("@OrdenPregunta",(pCaracteristicas.OrdenPregunta== null) ? vintNUll :pCaracteristicas.OrdenPregunta);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Caracteristicas> l = SqlMapper.Query<Caracteristicas>(con, "API.PA_CaracteristicasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Caracteristicas  ->" + ex.Message);
				}
			}

			public Caracteristicas Add(Caracteristicas pCaracteristicas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pCaracteristicas.id==null ? 0 : pCaracteristicas.id);
p.Add("@ID_Indicador",pCaracteristicas.ID_Indicador==null ? 0 : pCaracteristicas.ID_Indicador);
p.Add("@ID_Escala",pCaracteristicas.ID_Escala==null ? 0 : pCaracteristicas.ID_Escala);
                    p.Add("@Pregunta", pCaracteristicas.Pregunta);
p.Add("@ID_PreguntaPadre",pCaracteristicas.ID_PreguntaPadre==null ? 0 : pCaracteristicas.ID_PreguntaPadre);
p.Add("@OrdenPregunta",pCaracteristicas.OrdenPregunta==null ? 0 : pCaracteristicas.OrdenPregunta);
                    p.Add("@auditoria", pCaracteristicas.auditoria);

                         


                    Caracteristicas o = SqlMapper.QueryFirstOrDefault<Caracteristicas>(con, "API.PA_CaracteristicasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Caracteristicas  ->" + ex.Message);
				}
			}

			public Caracteristicas  Update(Caracteristicas pCaracteristicas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pCaracteristicas.id==null ? 0 : pCaracteristicas.id);
p.Add("@ID_Indicador",pCaracteristicas.ID_Indicador==null ? 0 : pCaracteristicas.ID_Indicador);
p.Add("@ID_Escala",pCaracteristicas.ID_Escala==null ? 0 : pCaracteristicas.ID_Escala);
                    p.Add("@Pregunta", pCaracteristicas.Pregunta);
p.Add("@ID_PreguntaPadre",pCaracteristicas.ID_PreguntaPadre==null ? 0 : pCaracteristicas.ID_PreguntaPadre);
p.Add("@OrdenPregunta",pCaracteristicas.OrdenPregunta==null ? 0 : pCaracteristicas.OrdenPregunta);
                    p.Add("@auditoria", pCaracteristicas.auditoria);

                         


                    Caracteristicas o = SqlMapper.QueryFirstOrDefault<Caracteristicas>(con, "API.PA_CaracteristicasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Caracteristicas  ->" + ex.Message);
				}
			}

			public bool Delete(Caracteristicas pCaracteristicas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pCaracteristicas.id);
                    p.Add("@auditoria", pCaracteristicas.auditoria);

                

 

					Caracteristicas o = SqlMapper.QueryFirstOrDefault<Caracteristicas>(con, "API.PA_CaracteristicasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Caracteristicas  ->" + ex.Message);
				}
			}

		



            public List<Caracteristicas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Caracteristicas> CaracteristicasList = new List<Caracteristicas>();

                    CaracteristicasList = SqlMapper.Query<Caracteristicas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return CaracteristicasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Caracteristicas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Caracteristicas> b)
            {
                DapperPlusManager.Entity<Caracteristicas>().Table("Caracteristicas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}