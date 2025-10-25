/// <Derechos_Reservados>
/// Aplicacion      :SISPAE
/// Autor           :Oscar Mauricio Cortes
/// Ano             :2022
/// Arquitectura    :Patron MVC Net Core 6, Repository ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa            :Ulilitarios Transversales  
/// </Derechos_Reservados>

namespace SISPAE.Common
{

    public enum CsType
    {
        Binary,
        Boolean,
        Byte,
        ByteArray,
        Char,
        DateTime,
        Decimal,
        Double,
        Guid,
        Short,
        Int,
        Long,
        String,
        Null
    }
	
		public enum ServiceToUse
	{
		IsGd,
		ToLy,
		BitLy,
		JMp,
		TinyURL
	}
}