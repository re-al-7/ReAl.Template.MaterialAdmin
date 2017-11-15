#region 
/***********************************************************************************************************
	NOMBRE:       EntSegAplicaciones
	DESCRIPCION:
		Clase que define un objeto para la Tabla segaplicaciones

	REVISIONES:
		Ver        FECHA       Autor            Descripcion 
		---------  ----------  ---------------  ------------------------------------
		1.0        03/11/2017  R Alonzo Vera A  Creacion 

*************************************************************************************************************/
#endregion


#region
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
#endregion

namespace Test.CoreMvc.Dal.Entidades
{
	[Table("segaplicaciones")]
	public class EntSegAplicaciones
	{
		public const string StrNombreTabla = "SegAplicaciones";
		public const string StrAliasTabla = "Sap";
		public enum Fields
		{
			aplicacionsap
			,descripcionsap
			,apiestadosap
			,apitransaccionsap
			,usucresap
			,feccresap
			,usumodsap
			,fecmodsap
			,nombresap

		}
		
		#region Constructoress
		
		public EntSegAplicaciones()
		{
			//Inicializacion de Variables
			aplicacionsap = null;
			descripcionsap = null;
			apiestadosap = null;
			apitransaccionsap = null;
			usucresap = null;
			usumodsap = null;
			fecmodsap = null;
			nombresap = null;
		}
		
		public EntSegAplicaciones(EntSegAplicaciones obj)
		{
			aplicacionsap = obj.aplicacionsap;
			descripcionsap = obj.descripcionsap;
			apiestadosap = obj.apiestadosap;
			apitransaccionsap = obj.apitransaccionsap;
			usucresap = obj.usucresap;
			feccresap = obj.feccresap;
			usumodsap = obj.usumodsap;
			fecmodsap = obj.fecmodsap;
			nombresap = obj.nombresap;
		}
		
		#endregion
		
				
		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna aplicacionsap de la Tabla segaplicaciones
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: Yes
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(3, MinimumLength=0)]
		[Display(Name = "aplicacionsap", Description = " Propiedad publica de tipo String que representa a la columna aplicacionsap de la Tabla segaplicaciones")]
		[Required(AllowEmptyStrings = true, ErrorMessage = "aplicacionsap es un campo requerido.")]
		[Key]
		public String aplicacionsap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna descripcionsap de la Tabla segaplicaciones
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(60, MinimumLength=0)]
		[Display(Name = "descripcionsap", Description = " Propiedad publica de tipo String que representa a la columna descripcionsap de la Tabla segaplicaciones")]
		[Required(AllowEmptyStrings = true, ErrorMessage = "descripcionsap es un campo requerido.")]
		public String descripcionsap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna apiestadosap de la Tabla segaplicaciones
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "apiestadosap", Description = " Propiedad publica de tipo String que representa a la columna apiestadosap de la Tabla segaplicaciones")]
		public String apiestadosap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna apitransaccionsap de la Tabla segaplicaciones
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "apitransaccionsap", Description = " Propiedad publica de tipo String que representa a la columna apitransaccionsap de la Tabla segaplicaciones")]
		public String apitransaccionsap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna usucresap de la Tabla segaplicaciones
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "usucresap", Description = " Propiedad publica de tipo String que representa a la columna usucresap de la Tabla segaplicaciones")]
		public String usucresap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna feccresap de la Tabla segaplicaciones
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[DataType(DataType.DateTime, ErrorMessage = "Fecha invalida")]
		[DisplayFormat(DataFormatString = "{ 0:dd/MM/yyyy HH:mm:ss.ffffff}", ApplyFormatInEditMode = true)]
		[Display(Name = "feccresap", Description = " Propiedad publica de tipo DateTime que representa a la columna feccresap de la Tabla segaplicaciones")]
		public DateTime feccresap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna usumodsap de la Tabla segaplicaciones
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "usumodsap", Description = " Propiedad publica de tipo String que representa a la columna usumodsap de la Tabla segaplicaciones")]
		public String usumodsap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna fecmodsap de la Tabla segaplicaciones
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[DataType(DataType.DateTime, ErrorMessage = "Fecha invalida")]
		[DisplayFormat(DataFormatString = "{ 0:dd/MM/yyyy HH:mm:ss.ffffff}", ApplyFormatInEditMode = true)]
		[Display(Name = "fecmodsap", Description = " Propiedad publica de tipo DateTime que representa a la columna fecmodsap de la Tabla segaplicaciones")]
		public DateTime? fecmodsap { get; set; } 

		/// <summary>
		/// Nombre que se despliega en el Menu
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(30, MinimumLength=0)]
		[Display(Name = "nombresap", Description = "Nombre que se despliega en el Menu")]
		public String nombresap { get; set; } 

	}
}

