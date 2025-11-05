/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:DataAccess (Data Access Layer) - Contenedor de 	Interfaces Repository  (Source: MVC7_DataMaperInterface.cs)   Interfaces 
/// </Derechos_Reservados>



namespace SISPAE.DataAccess.DataInterfaces
{
    public interface IRepositoryContainer
    {
                IPA_EstadoNotificaciones PA_EstadoNotificaciones{ get; set; }
        IPA_ObtenerNotificaciones PA_ObtenerNotificaciones{ get; set; }
        IPA_RegistrarNotificacion PA_RegistrarNotificacion{ get; set; }
        IPA_AprobacionesGetAllWithRel PA_AprobacionesGetAllWithRel{ get; set; }
        IPA_MunicipiosGetbyContrato PA_MunicipiosGetbyContrato{ get; set; }
        IPA_SedeExcedentes PA_SedeExcedentes{ get; set; }
        IPA_ContratosCantidadBeneficiarios PA_ContratosCantidadBeneficiarios{ get; set; }
        IPA_ContratosGetbyOperador PA_ContratosGetbyOperador{ get; set; }
        IPA_ContratosIE PA_ContratosIE{ get; set; }
        IPA_ContratosSedeJornadaBeneficiarios PA_ContratosSedeJornadaBeneficiarios{ get; set; }
        IPA_ContratosSedeJornadaListaBenef PA_ContratosSedeJornadaListaBenef{ get; set; }
        IPA_ContratosSedeJornadaRPI PA_ContratosSedeJornadaRPI{ get; set; }
        IPA_ContratosSedeNovedades PA_ContratosSedeNovedades{ get; set; }
        IPA_OperadorContratos PA_OperadorContratos{ get; set; }
        IPA_ReporteExcedentes PA_ReporteExcedentes{ get; set; }
        IGetCaracterizacionNivel GetCaracterizacionNivel{ get; set; }
        IGetCaracterizacionNivel2 GetCaracterizacionNivel2{ get; set; }
        IGetCaracterizacionNivel3 GetCaracterizacionNivel3{ get; set; }
        IGetCaracterizacionNivel4 GetCaracterizacionNivel4{ get; set; }
        IGetCaracterizacionValidacion GetCaracterizacionValidacion{ get; set; }
        IPA_DiagnosticoInfraEst PA_DiagnosticoInfraEst{ get; set; }
        IPA_DiagnosticoSituacionalGetAllFullbyEtc PA_DiagnosticoSituacionalGetAllFullbyEtc{ get; set; }
        IPA_ETCMunicipioRacion PA_ETCMunicipioRacion{ get; set; }
        IPA_ETCSedesCHSFavorable PA_ETCSedesCHSFavorable{ get; set; }
        IPA_MatrizRiesgoModOper PA_MatrizRiesgoModOper{ get; set; }
        IPA_MatrizRiesgosSede PA_MatrizRiesgosSede{ get; set; }
        IPA_MatrizRiesgosSedeDetalleArea PA_MatrizRiesgosSedeDetalleArea{ get; set; }
        IPA_MatrizRiesgosSedeDetalleDimension PA_MatrizRiesgosSedeDetalleDimension{ get; set; }
        IPA_RiesgoETCModeloOper PA_RiesgoETCModeloOper{ get; set; }
        IPA_RiesgoETCSedesModeloOper PA_RiesgoETCSedesModeloOper{ get; set; }
        IPA_SedePregRespuesta PA_SedePregRespuesta{ get; set; }
        IPA_ContratosPlanAlistamientoGetAll PA_ContratosPlanAlistamientoGetAll{ get; set; }
        IPA_ActualiarFlatAmarilla PA_ActualiarFlatAmarilla{ get; set; }
        IPA_DivipolasGetbyETC PA_DivipolasGetbyETC{ get; set; }
        IPA_ETCSedesPriorizacion PA_ETCSedesPriorizacion{ get; set; }
        IPA_InstutucionesEduGetbyETC PA_InstutucionesEduGetbyETC{ get; set; }
        IPA_JornadaGetbyETC PA_JornadaGetbyETC{ get; set; }
        IPA_ModalidadModelobySede PA_ModalidadModelobySede{ get; set; }
        IPA_NivelEduGetbyETC PA_NivelEduGetbyETC{ get; set; }
        IPA_Paso1Fin PA_Paso1Fin{ get; set; }
        IPA_PrioAsistida PA_PrioAsistida{ get; set; }
        IPA_PriorizacionesContratoGetAllWithRel PA_PriorizacionesContratoGetAllWithRel{ get; set; }
        IPA_PriorizacionesGetAllWithRel PA_PriorizacionesGetAllWithRel{ get; set; }
        IPA_PriorizaUpdateEstadoPrio PA_PriorizaUpdateEstadoPrio{ get; set; }
        IPA_PrioSedeAsignaRacion PA_PrioSedeAsignaRacion{ get; set; }
        IPA_PrioSedeAsignaRacionPiv PA_PrioSedeAsignaRacionPiv{ get; set; }
        IPA_PrioSedeBeneficiarias PA_PrioSedeBeneficiarias{ get; set; }
        IPA_PrioSedeInformacion PA_PrioSedeInformacion{ get; set; }
        IPA_SedeGetbyETC PA_SedeGetbyETC{ get; set; }
        IPA_TiporacionbyModalidad PA_TiporacionbyModalidad{ get; set; }
        IPA_ZonaGetbyETC PA_ZonaGetbyETC{ get; set; }
        IPA_AporteNutricionalAlimentoICBF PA_AporteNutricionalAlimentoICBF{ get; set; }
        IPA_AporteNutricionalAlimentoICBFDet PA_AporteNutricionalAlimentoICBFDet{ get; set; }
        IPA_AporteNutricionalIngredientes PA_AporteNutricionalIngredientes{ get; set; }
        IPA_AporteNutricionalIngredientesDet PA_AporteNutricionalIngredientesDet{ get; set; }
        IPA_AporteNutricionalProducto PA_AporteNutricionalProducto{ get; set; }
        IPA_AporteNutricionalProductoDet PA_AporteNutricionalProductoDet{ get; set; }
        IPA_AportesComponentePreparacion PA_AportesComponentePreparacion{ get; set; }
        IPA_AportesComponentePreparacionDet PA_AportesComponentePreparacionDet{ get; set; }
        Ipa_BuscarPreparaciones pa_BuscarPreparaciones{ get; set; }
        IPA_BuscarProductos PA_BuscarProductos{ get; set; }
        IPA_CicloMenuAportesNutricionalesIndustrialesPiv PA_CicloMenuAportesNutricionalesIndustrialesPiv{ get; set; }
        IPA_CicloMenuAportesNutricionalesIndustrialesPivSem PA_CicloMenuAportesNutricionalesIndustrialesPivSem{ get; set; }
        IPA_CicloMenuAportesNutricionalesPiv PA_CicloMenuAportesNutricionalesPiv{ get; set; }
        IPA_CicloMenuAportesNutricionalesPivMAER PA_CicloMenuAportesNutricionalesPivMAER{ get; set; }
        IPA_CicloMenuAportesNutricionalesPivMAERsem PA_CicloMenuAportesNutricionalesPivMAERsem{ get; set; }
        IPA_CicloMenuAportesNutricionalesPivSem PA_CicloMenuAportesNutricionalesPivSem{ get; set; }
        IPA_conteoIntercambios PA_conteoIntercambios{ get; set; }
        IPA_Departamentos PA_Departamentos{ get; set; }
        IPA_GetPreparacion PA_GetPreparacion{ get; set; }
        IPA_IngredientesPreparacion PA_IngredientesPreparacion{ get; set; }
        IPA_NivelEducativoPesoServidoPiv PA_NivelEducativoPesoServidoPiv{ get; set; }
        IPA_ValidaFrecuencia PA_ValidaFrecuencia{ get; set; }
        IPA_ActualizaAprobacionSemana PA_ActualizaAprobacionSemana{ get; set; }
        IPA_ComplementosEntregadosGrado PA_ComplementosEntregadosGrado{ get; set; }
        IPA_ComplemetosEntregadosPorGrados PA_ComplemetosEntregadosPorGrados{ get; set; }
        IPA_DiasPaeSemana PA_DiasPaeSemana{ get; set; }
        IPA_FechasQuincenaRaciones PA_FechasQuincenaRaciones{ get; set; }
        IPA_IngresoSemanaEntregaRaciones PA_IngresoSemanaEntregaRaciones{ get; set; }
        IPA_QuincenaEntregaRacionesGetBySedeJornadaOperador PA_QuincenaEntregaRacionesGetBySedeJornadaOperador{ get; set; }
        IPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH{ get; set; }
        IPA_QuincenaEntregaRacionesGetDatosCompletos PA_QuincenaEntregaRacionesGetDatosCompletos{ get; set; }
        IPA_QuincenaEntregaRacionesGetDatosCompletosH PA_QuincenaEntregaRacionesGetDatosCompletosH{ get; set; }
        IPA_QuincenaEntregaRacionesGetDiasPae PA_QuincenaEntregaRacionesGetDiasPae{ get; set; }
        IPA_QuincenaEntregaRacionesGetDiasPaeH PA_QuincenaEntregaRacionesGetDiasPaeH{ get; set; }
        IPA_QuincenaEntregaRacionesGetxGrado PA_QuincenaEntregaRacionesGetxGrado{ get; set; }
        IPA_QuincenaEntregaRacionesGetxGradoH PA_QuincenaEntregaRacionesGetxGradoH{ get; set; }
        IPA_SedeJornadaMesSemana PA_SedeJornadaMesSemana{ get; set; }
        IPA_SeguimientoRacionesDetalleSemana PA_SeguimientoRacionesDetalleSemana{ get; set; }
        IPA_GetMenuRol PA_GetMenuRol{ get; set; }
        IPA_GetMenuRolAll PA_GetMenuRolAll{ get; set; }
        IPA_GetRolPermisos PA_GetRolPermisos{ get; set; }
        IPA_MenuRolActualiza PA_MenuRolActualiza{ get; set; }
        IPA_RolPermisosActualiza PA_RolPermisosActualiza{ get; set; }
        INivelEducativoGetAllBySedeJornada NivelEducativoGetAllBySedeJornada{ get; set; }
        IPA_ActualizaSedesPrioModeloOper PA_ActualizaSedesPrioModeloOper{ get; set; }
        IPA_InstitucionEducativaGetbyOperadorContratoMunicipio PA_InstitucionEducativaGetbyOperadorContratoMunicipio{ get; set; }
        IPA_JornadaGetbyContratoMunicipio PA_JornadaGetbyContratoMunicipio{ get; set; }
        IPA_SedesGetbyContratoMunicipio PA_SedesGetbyContratoMunicipio{ get; set; }

    }
}