/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using SISPAE.Model;
using SISPAE.DataAccess;
using SISPAE.DataAccess.DataMapper;
using System.Data.SqlClient;
using SISPAE.Common;





namespace SISPAE.Business
/// <Resumen>
/// Clase del Business  para  PA_CalculaIntercambioAlimentoICBF
/// 
/// </Resumen>


{



	#region Metodos de negocio


	public partial class PA_CalculaIntercambioAlimentoICBFMs
	{

		#region Implementacion Metodos


		public List<PA_CalculaIntercambioAlimentoICBF> GetPA_CalculaIntercambioAlimentoICBF(int? ID_AlimentoICBF, String? auditoria)
		{
			var returnedEntities = new List<PA_CalculaIntercambioAlimentoICBF>();

			try
			{
				using (var repository = new PA_CalculaIntercambioAlimentoICBFRepository())
				{
					foreach (var entity in repository.GetPA_CalculaIntercambioAlimentoICBF(ID_AlimentoICBF, auditoria))
					{
						returnedEntities.Add(entity);
					}
				}

				return returnedEntities;
			}
			catch (Exception ex)
			{
				throw new Exception("BusinessLogic:PA_CalculaIntercambioAlimentoICBFBusiness::GetPA_CalculaIntercambioAlimentoICBF::Error occured.", ex);
			}
		}











		#endregion Implementacion Metodos


	}
	#endregion Metodos de Negocio

}