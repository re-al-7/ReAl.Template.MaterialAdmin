#region 
/***********************************************************************************************************
	NOMBRE:       EntSegUsuario
	DESCRIPCION:
		Clase que define un objeto para la Tabla seg_usuario

	REVISIONES:
		Ver        FECHA       Autor            Descripcion 
		---------  ----------  ---------------  ------------------------------------
		1.0        15/08/2017  R Alonzo Vera A  Creacion 

*************************************************************************************************************/
#endregion


#region
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security.Claims;
#endregion

namespace Test.CoreMvc.Dal.Entidades
{
	public class EntSegUsuario : ClaimsIdentity
    {
		public const string StrNombreTabla = "seg_usuario";
		public const string StrAliasTabla = "seg_usuario";
		public enum Fields
		{
			id_usuario
			,id_departamento
			,login
			,password
			,nombre
			,paterno
			,materno
			,telefono
			,fecha_vigente
			,apiestado
			,usucre
			,feccre
			,usumod
			,fecmod

		}
		
		#region Constructoress
		
		public EntSegUsuario()
		{
			//Inicializacion de Variables
			id_departamento = null;
			login = null;
			password = null;
			nombre = null;
			paterno = null;
			materno = null;
			telefono = null;
			fecha_vigente = null;
			apiestado = null;
			usucre = null;
			usumod = null;
			fecmod = null;
		}
		
		public EntSegUsuario(EntSegUsuario obj)
		{
			id_usuario = obj.id_usuario;
			id_departamento = obj.id_departamento;
			login = obj.login;
			password = obj.password;
			nombre = obj.nombre;
			paterno = obj.paterno;
			materno = obj.materno;
			telefono = obj.telefono;
			fecha_vigente = obj.fecha_vigente;
			apiestado = obj.apiestado;
			usucre = obj.usucre;
			feccre = obj.feccre;
			usumod = obj.usumod;
			fecmod = obj.fecmod;
		}
		
		#endregion
				
		/// <summary>
		/// llave primaria de los usuarios
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: Yes
		/// Es ForeignKey: No
		/// </summary>
		public int id_usuario { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo int que representa a la columna id_departamento de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: Yes
		/// </summary>
		public int? id_departamento { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna login de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String login { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna password de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String password { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna nombre de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String nombre { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna paterno de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String paterno { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna materno de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String materno { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo Decimal que representa a la columna telefono de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public Decimal? telefono { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna fecha_vigente de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public DateTime? fecha_vigente { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna apiestado de la Tabla seg_usuario
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String apiestado { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna usucre de la Tabla seg_usuario
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String usucre { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna feccre de la Tabla seg_usuario
		/// Permite Null: No
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public DateTime feccre { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo String que representa a la columna usumod de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public String usumod { get; set; } 

		/// <summary>
		/// Propiedad publica de tipo DateTime que representa a la columna fecmod de la Tabla seg_usuario
		/// Permite Null: Yes
		/// Es Calculada: No
		/// Es RowGui: No
		/// Es PrimaryKey: No
		/// Es ForeignKey: No
		/// </summary>
		public DateTime? fecmod { get; set; } 

	}
}

