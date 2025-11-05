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
     /// Clase Abstracta para  ConfiguracionVistas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ConfiguracionVistasRepository : DataObject , IConfiguracionVistas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ConfiguracionVistasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ConfiguracionVistasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ConfiguracionVistas GetById(ConfiguracionVistas pConfiguracionVistas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pConfiguracionVistas.id);                                    


    				ConfiguracionVistas o = SqlMapper.QueryFirstOrDefault<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ConfiguracionVistas  ->" + ex.Message);
				}
			}

			public List<ConfiguracionVistas> GetAll()
			{
				try 
                {
                        List<ConfiguracionVistas> l = SqlMapper.Query<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ConfiguracionVistas  ->" + ex.Message);
				}
			}

			public List<ConfiguracionVistas> GetAllFull()
			{
				try 
				{
                    List<ConfiguracionVistas> l = SqlMapper.Query<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ConfiguracionVistas  ->" + ex.Message);
				}
			}
			
			public List<ConfiguracionVistas> GetAllByWithRelation()
			{
				try 
                {
                    List<ConfiguracionVistas> l = SqlMapper.Query<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ConfiguracionVistas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ConfiguracionVistas> GetByFilter(ConfiguracionVistas pConfiguracionVistas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pConfiguracionVistas.id== null || pConfiguracionVistas.id==0) ? vintNUll :pConfiguracionVistas.id);
                    p.Add("@Nombre",(pConfiguracionVistas.Nombre== null) ? vintNUll :pConfiguracionVistas.Nombre);
                    p.Add("@TipoContratoId",(pConfiguracionVistas.TipoContratoId== null) ? vintNUll :pConfiguracionVistas.TipoContratoId);
                    p.Add("@SubTipoContratoId",(pConfiguracionVistas.SubTipoContratoId== null) ? vintNUll :pConfiguracionVistas.SubTipoContratoId);
                    p.Add("@Seccion1",(pConfiguracionVistas.Seccion1== null) ? vintNUll :pConfiguracionVistas.Seccion1);
                    p.Add("@Seccion2",(pConfiguracionVistas.Seccion2== null) ? vintNUll :pConfiguracionVistas.Seccion2);
                    p.Add("@Seccion3",(pConfiguracionVistas.Seccion3== null) ? vintNUll :pConfiguracionVistas.Seccion3);
                    p.Add("@Seccion4",(pConfiguracionVistas.Seccion4== null) ? vintNUll :pConfiguracionVistas.Seccion4);
                    p.Add("@Seccion5",(pConfiguracionVistas.Seccion5== null) ? vintNUll :pConfiguracionVistas.Seccion5);
                    p.Add("@Seccion6",(pConfiguracionVistas.Seccion6== null) ? vintNUll :pConfiguracionVistas.Seccion6);
                    p.Add("@Seccion7",(pConfiguracionVistas.Seccion7== null) ? vintNUll :pConfiguracionVistas.Seccion7);
                    p.Add("@Seccion8",(pConfiguracionVistas.Seccion8== null) ? vintNUll :pConfiguracionVistas.Seccion8);
                    p.Add("@Seccion9",(pConfiguracionVistas.Seccion9== null) ? vintNUll :pConfiguracionVistas.Seccion9);
                    p.Add("@Seccion10",(pConfiguracionVistas.Seccion10== null) ? vintNUll :pConfiguracionVistas.Seccion10);
                    p.Add("@Seccion11",(pConfiguracionVistas.Seccion11== null) ? vintNUll :pConfiguracionVistas.Seccion11);
                    p.Add("@Seccion12",(pConfiguracionVistas.Seccion12== null) ? vintNUll :pConfiguracionVistas.Seccion12);
                    p.Add("@Seccion13",(pConfiguracionVistas.Seccion13== null) ? vintNUll :pConfiguracionVistas.Seccion13);
                    p.Add("@Seccion14",(pConfiguracionVistas.Seccion14== null) ? vintNUll :pConfiguracionVistas.Seccion14);
                    p.Add("@Seccion15",(pConfiguracionVistas.Seccion15== null) ? vintNUll :pConfiguracionVistas.Seccion15);
                    p.Add("@Seccion16",(pConfiguracionVistas.Seccion16== null) ? vintNUll :pConfiguracionVistas.Seccion16);
                    p.Add("@NumSec1",(pConfiguracionVistas.NumSec1== null) ? vintNUll :pConfiguracionVistas.NumSec1);
                    p.Add("@NumSec2",(pConfiguracionVistas.NumSec2== null) ? vintNUll :pConfiguracionVistas.NumSec2);
                    p.Add("@NumSec3",(pConfiguracionVistas.NumSec3== null) ? vintNUll :pConfiguracionVistas.NumSec3);
                    p.Add("@NumSec4",(pConfiguracionVistas.NumSec4== null) ? vintNUll :pConfiguracionVistas.NumSec4);
                    p.Add("@NumSec5",(pConfiguracionVistas.NumSec5== null) ? vintNUll :pConfiguracionVistas.NumSec5);
                    p.Add("@NumSec6",(pConfiguracionVistas.NumSec6== null) ? vintNUll :pConfiguracionVistas.NumSec6);
                    p.Add("@NumSec7",(pConfiguracionVistas.NumSec7== null) ? vintNUll :pConfiguracionVistas.NumSec7);
                    p.Add("@NumSec8",(pConfiguracionVistas.NumSec8== null) ? vintNUll :pConfiguracionVistas.NumSec8);
                    p.Add("@NumSec9",(pConfiguracionVistas.NumSec9== null) ? vintNUll :pConfiguracionVistas.NumSec9);
                    p.Add("@NumSec10",(pConfiguracionVistas.NumSec10== null) ? vintNUll :pConfiguracionVistas.NumSec10);
                    p.Add("@NumSec11",(pConfiguracionVistas.NumSec11== null) ? vintNUll :pConfiguracionVistas.NumSec11);
                    p.Add("@NumSec12",(pConfiguracionVistas.NumSec12== null) ? vintNUll :pConfiguracionVistas.NumSec12);
                    p.Add("@NumSec13",(pConfiguracionVistas.NumSec13== null) ? vintNUll :pConfiguracionVistas.NumSec13);
                    p.Add("@NumSec14",(pConfiguracionVistas.NumSec14== null) ? vintNUll :pConfiguracionVistas.NumSec14);
                    p.Add("@NumSec15",(pConfiguracionVistas.NumSec15== null) ? vintNUll :pConfiguracionVistas.NumSec15);
                    p.Add("@NumSec16",(pConfiguracionVistas.NumSec16== null) ? vintNUll :pConfiguracionVistas.NumSec16);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ConfiguracionVistas> l = SqlMapper.Query<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ConfiguracionVistas  ->" + ex.Message);
				}
			}

			public ConfiguracionVistas Add(ConfiguracionVistas pConfiguracionVistas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pConfiguracionVistas.id==null ? 0 : pConfiguracionVistas.id);
                    p.Add("@Nombre", pConfiguracionVistas.Nombre);
p.Add("@TipoContratoId",pConfiguracionVistas.TipoContratoId==null ? 0 : pConfiguracionVistas.TipoContratoId);
p.Add("@SubTipoContratoId",pConfiguracionVistas.SubTipoContratoId==null ? 0 : pConfiguracionVistas.SubTipoContratoId);
                    p.Add("@Seccion1", pConfiguracionVistas.Seccion1);
                    p.Add("@Seccion2", pConfiguracionVistas.Seccion2);
                    p.Add("@Seccion3", pConfiguracionVistas.Seccion3);
                    p.Add("@Seccion4", pConfiguracionVistas.Seccion4);
                    p.Add("@Seccion5", pConfiguracionVistas.Seccion5);
                    p.Add("@Seccion6", pConfiguracionVistas.Seccion6);
                    p.Add("@Seccion7", pConfiguracionVistas.Seccion7);
                    p.Add("@Seccion8", pConfiguracionVistas.Seccion8);
                    p.Add("@Seccion9", pConfiguracionVistas.Seccion9);
                    p.Add("@Seccion10", pConfiguracionVistas.Seccion10);
                    p.Add("@Seccion11", pConfiguracionVistas.Seccion11);
                    p.Add("@Seccion12", pConfiguracionVistas.Seccion12);
                    p.Add("@Seccion13", pConfiguracionVistas.Seccion13);
                    p.Add("@Seccion14", pConfiguracionVistas.Seccion14);
                    p.Add("@Seccion15", pConfiguracionVistas.Seccion15);
                    p.Add("@Seccion16", pConfiguracionVistas.Seccion16);
p.Add("@NumSec1",pConfiguracionVistas.NumSec1==null ? 0 : pConfiguracionVistas.NumSec1);
p.Add("@NumSec2",pConfiguracionVistas.NumSec2==null ? 0 : pConfiguracionVistas.NumSec2);
p.Add("@NumSec3",pConfiguracionVistas.NumSec3==null ? 0 : pConfiguracionVistas.NumSec3);
p.Add("@NumSec4",pConfiguracionVistas.NumSec4==null ? 0 : pConfiguracionVistas.NumSec4);
p.Add("@NumSec5",pConfiguracionVistas.NumSec5==null ? 0 : pConfiguracionVistas.NumSec5);
p.Add("@NumSec6",pConfiguracionVistas.NumSec6==null ? 0 : pConfiguracionVistas.NumSec6);
p.Add("@NumSec7",pConfiguracionVistas.NumSec7==null ? 0 : pConfiguracionVistas.NumSec7);
p.Add("@NumSec8",pConfiguracionVistas.NumSec8==null ? 0 : pConfiguracionVistas.NumSec8);
p.Add("@NumSec9",pConfiguracionVistas.NumSec9==null ? 0 : pConfiguracionVistas.NumSec9);
p.Add("@NumSec10",pConfiguracionVistas.NumSec10==null ? 0 : pConfiguracionVistas.NumSec10);
p.Add("@NumSec11",pConfiguracionVistas.NumSec11==null ? 0 : pConfiguracionVistas.NumSec11);
p.Add("@NumSec12",pConfiguracionVistas.NumSec12==null ? 0 : pConfiguracionVistas.NumSec12);
p.Add("@NumSec13",pConfiguracionVistas.NumSec13==null ? 0 : pConfiguracionVistas.NumSec13);
p.Add("@NumSec14",pConfiguracionVistas.NumSec14==null ? 0 : pConfiguracionVistas.NumSec14);
p.Add("@NumSec15",pConfiguracionVistas.NumSec15==null ? 0 : pConfiguracionVistas.NumSec15);
p.Add("@NumSec16",pConfiguracionVistas.NumSec16==null ? 0 : pConfiguracionVistas.NumSec16);

                         


                    ConfiguracionVistas o = SqlMapper.QueryFirstOrDefault<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ConfiguracionVistas  ->" + ex.Message);
				}
			}

			public ConfiguracionVistas  Update(ConfiguracionVistas pConfiguracionVistas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pConfiguracionVistas.id==null ? 0 : pConfiguracionVistas.id);
                    p.Add("@Nombre", pConfiguracionVistas.Nombre);
p.Add("@TipoContratoId",pConfiguracionVistas.TipoContratoId==null ? 0 : pConfiguracionVistas.TipoContratoId);
p.Add("@SubTipoContratoId",pConfiguracionVistas.SubTipoContratoId==null ? 0 : pConfiguracionVistas.SubTipoContratoId);
                    p.Add("@Seccion1", pConfiguracionVistas.Seccion1);
                    p.Add("@Seccion2", pConfiguracionVistas.Seccion2);
                    p.Add("@Seccion3", pConfiguracionVistas.Seccion3);
                    p.Add("@Seccion4", pConfiguracionVistas.Seccion4);
                    p.Add("@Seccion5", pConfiguracionVistas.Seccion5);
                    p.Add("@Seccion6", pConfiguracionVistas.Seccion6);
                    p.Add("@Seccion7", pConfiguracionVistas.Seccion7);
                    p.Add("@Seccion8", pConfiguracionVistas.Seccion8);
                    p.Add("@Seccion9", pConfiguracionVistas.Seccion9);
                    p.Add("@Seccion10", pConfiguracionVistas.Seccion10);
                    p.Add("@Seccion11", pConfiguracionVistas.Seccion11);
                    p.Add("@Seccion12", pConfiguracionVistas.Seccion12);
                    p.Add("@Seccion13", pConfiguracionVistas.Seccion13);
                    p.Add("@Seccion14", pConfiguracionVistas.Seccion14);
                    p.Add("@Seccion15", pConfiguracionVistas.Seccion15);
                    p.Add("@Seccion16", pConfiguracionVistas.Seccion16);
p.Add("@NumSec1",pConfiguracionVistas.NumSec1==null ? 0 : pConfiguracionVistas.NumSec1);
p.Add("@NumSec2",pConfiguracionVistas.NumSec2==null ? 0 : pConfiguracionVistas.NumSec2);
p.Add("@NumSec3",pConfiguracionVistas.NumSec3==null ? 0 : pConfiguracionVistas.NumSec3);
p.Add("@NumSec4",pConfiguracionVistas.NumSec4==null ? 0 : pConfiguracionVistas.NumSec4);
p.Add("@NumSec5",pConfiguracionVistas.NumSec5==null ? 0 : pConfiguracionVistas.NumSec5);
p.Add("@NumSec6",pConfiguracionVistas.NumSec6==null ? 0 : pConfiguracionVistas.NumSec6);
p.Add("@NumSec7",pConfiguracionVistas.NumSec7==null ? 0 : pConfiguracionVistas.NumSec7);
p.Add("@NumSec8",pConfiguracionVistas.NumSec8==null ? 0 : pConfiguracionVistas.NumSec8);
p.Add("@NumSec9",pConfiguracionVistas.NumSec9==null ? 0 : pConfiguracionVistas.NumSec9);
p.Add("@NumSec10",pConfiguracionVistas.NumSec10==null ? 0 : pConfiguracionVistas.NumSec10);
p.Add("@NumSec11",pConfiguracionVistas.NumSec11==null ? 0 : pConfiguracionVistas.NumSec11);
p.Add("@NumSec12",pConfiguracionVistas.NumSec12==null ? 0 : pConfiguracionVistas.NumSec12);
p.Add("@NumSec13",pConfiguracionVistas.NumSec13==null ? 0 : pConfiguracionVistas.NumSec13);
p.Add("@NumSec14",pConfiguracionVistas.NumSec14==null ? 0 : pConfiguracionVistas.NumSec14);
p.Add("@NumSec15",pConfiguracionVistas.NumSec15==null ? 0 : pConfiguracionVistas.NumSec15);
p.Add("@NumSec16",pConfiguracionVistas.NumSec16==null ? 0 : pConfiguracionVistas.NumSec16);
          

                         


                    ConfiguracionVistas o = SqlMapper.QueryFirstOrDefault<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ConfiguracionVistas  ->" + ex.Message);
				}
			}

			public bool Delete(ConfiguracionVistas pConfiguracionVistas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pConfiguracionVistas.id);

                

 

					ConfiguracionVistas o = SqlMapper.QueryFirstOrDefault<ConfiguracionVistas>(con, "API.PA_ConfiguracionVistasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ConfiguracionVistas  ->" + ex.Message);
				}
			}

		



            public List<ConfiguracionVistas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ConfiguracionVistas> ConfiguracionVistasList = new List<ConfiguracionVistas>();

                    ConfiguracionVistasList = SqlMapper.Query<ConfiguracionVistas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ConfiguracionVistasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ConfiguracionVistas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ConfiguracionVistas> b)
            {
                DapperPlusManager.Entity<ConfiguracionVistas>().Table("ConfiguracionVistas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}