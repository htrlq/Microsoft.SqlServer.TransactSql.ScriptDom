using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000FA RID: 250
	internal class MessageValidationMethodsHelper : OptionsHelper<MessageValidationMethod>
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00008A2B File Offset: 0x00006C2B
		private MessageValidationMethodsHelper()
		{
			base.AddOptionMapping(MessageValidationMethod.None, "NONE");
			base.AddOptionMapping(MessageValidationMethod.Empty, "EMPTY");
			base.AddOptionMapping(MessageValidationMethod.WellFormedXml, "WELL_FORMED_XML");
			base.AddOptionMapping(MessageValidationMethod.ValidXml, "VALID_XML");
		}

		// Token: 0x04000BE8 RID: 3048
		internal static readonly MessageValidationMethodsHelper Instance = new MessageValidationMethodsHelper();
	}
}
