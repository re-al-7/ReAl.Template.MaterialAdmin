#region 
/***********************************************************************************************************
	NOMBRE:       EntSegPaginas
	DESCRIPCION:
		Clase que define un objeto para la Tabla segpaginas

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
	[Table("segpaginas")]
	public class EntSegPaginas
	{
		public const string StrNombreTabla = "SegPaginas";
		public const string StrAliasTabla = "Spg";
		public enum Fields
		{
			paginaspg
			,aplicacionsap
			,paginapadrespg
			,nombrespg
			,nombremenuspg
			,descripcionspg
			,prioridadspg
			,apiestadospg
			,apitransaccionspg
			,usucrespg
			,feccrespg
			,usumodspg
			,fecmodspg

		}
		
		#region Constructoress
		
		public EntSegPaginas()
		{
			//Inicializacion de Variables
			aplicacionsap = null;
			paginapadrespg = null;
			nombrespg = null;
			nombremenuspg = null;
			descripcionspg = null;
			prioridadspg = null;
			apiestadospg = null;
			apitransaccionspg = null;
			usucrespg = null;
			usumodspg = null;
			fecmodspg = null;
		}
		
		public EntSegPaginas(EntSegPaginas obj)
		{
			paginaspg = obj.paginaspg;
			aplicacionsap = obj.aplicacionsap;
			paginapadrespg = obj.paginapadrespg;
			nombrespg = obj.nombrespg;
			nombremenuspg = obj.nombremenuspg;
			descripcionspg = obj.descripcionspg;
			prioridadspg = obj.prioridadspg;
			apiestadospg = obj.apiestadospg;
			apitransaccionspg = obj.apitransaccionspg;
			usucrespg = obj.usucrespg;
			feccrespg = obj.feccrespg;
			usumodspg = obj.usumodspg;
			fecmodspg = obj.fecmodspg;
		}
		
		#endregion
		
				
		/// <summary>
		/// Propiedad publica de tipo int que representa a la columna paginaspg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: Yes
		/// Es ForeignKey: No
		/// </summary>
		[Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
		[Display(Name = "paginaspg", Description = " Propiedad publica de tipo int que representa a la columna paginaspg de la Tabla segpaginas")]
		[Required(ErrorMessage = "paginaspg es un campo requerido.")]
		[Key]
		public int paginaspg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna aplicacionsap de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: Yes
		/// </summary>
		[StringLength(3, MinimumLength=0)]
		[Display(Name = "aplicacionsap", Description = " Propiedad publica de tipo String que representa a la columna aplicacionsap de la Tabla segpaginas")]
		[Required(AllowEmptyStrings = true, ErrorMessage = "aplicacionsap es un campo requerido.")]
		public String aplicacionsap { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo Decimal que representa a la columna paginapadrespg de la Tabla segpaginas
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[Display(Name = "paginapadrespg", Description = " Propiedad publica de tipo Decimal que representa a la columna paginapadrespg de la Tabla segpaginas")]
		public Decimal? paginapadrespg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna nombrespg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(60, MinimumLength=0)]
		[Display(Name = "nombrespg", Description = " Propiedad publica de tipo String que representa a la columna nombrespg de la Tabla segpaginas")]
		[Required(AllowEmptyStrings = true, ErrorMessage = "nombrespg es un campo requerido.")]
		public String nombrespg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna nombremenuspg de la Tabla segpaginas
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(30, MinimumLength=0)]
		[Display(Name = "nombremenuspg", Description = " Propiedad publica de tipo String que representa a la columna nombremenuspg de la Tabla segpaginas")]
		public String nombremenuspg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna descripcionspg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(100, MinimumLength=0)]
		[Display(Name = "descripcionspg", Description = " Propiedad publica de tipo String que representa a la columna descripcionspg de la Tabla segpaginas")]
		[Required(AllowEmptyStrings = true, ErrorMessage = "descripcionspg es un campo requerido.")]
		public String descripcionspg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo Decimal que representa a la columna prioridadspg de la Tabla segpaginas
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[Display(Name = "prioridadspg", Description = " Propiedad publica de tipo Decimal que representa a la columna prioridadspg de la Tabla segpaginas")]
		public Decimal? prioridadspg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna apiestadospg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "apiestadospg", Description = " Propiedad publica de tipo String que representa a la columna apiestadospg de la Tabla segpaginas")]
		public String apiestadospg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna apitransaccionspg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "apitransaccionspg", Description = " Propiedad publica de tipo String que representa a la columna apitransaccionspg de la Tabla segpaginas")]
		public String apitransaccionspg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna usucrespg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "usucrespg", Description = " Propiedad publica de tipo String que representa a la columna usucrespg de la Tabla segpaginas")]
		public String usucrespg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna feccrespg de la Tabla segpaginas
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[DataType(DataType.DateTime, ErrorMessage = "Fecha invalida")]
		[DisplayFormat(DataFormatString = "{ 0:dd/MM/yyyy HH:mm:ss.ffffff}", ApplyFormatInEditMode = true)]
		[Display(Name = "feccrespg", Description = " Propiedad publica de tipo DateTime que representa a la columna feccrespg de la Tabla segpaginas")]
		public DateTime feccrespg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna usumodspg de la Tabla segpaginas
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[StringLength(15, MinimumLength=0)]
		[Display(Name = "usumodspg", Description = " Propiedad publica de tipo String que representa a la columna usumodspg de la Tabla segpaginas")]
		public String usumodspg { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna fecmodspg de la Tabla segpaginas
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		[DataType(DataType.DateTime, ErrorMessage = "Fecha invalida")]
		[DisplayFormat(DataFormatString = "{ 0:dd/MM/yyyy HH:mm:ss.ffffff}", ApplyFormatInEditMode = true)]
		[Display(Name = "fecmodspg", Description = " Propiedad publica de tipo DateTime que representa a la columna fecmodspg de la Tabla segpaginas")]
		public DateTime? fecmodspg { get; set; } 

	}
}

