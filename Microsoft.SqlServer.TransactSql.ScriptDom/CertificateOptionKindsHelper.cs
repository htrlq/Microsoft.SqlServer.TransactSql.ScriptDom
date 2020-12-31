using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000079 RID: 121
	internal class CertificateOptionKindsHelper : OptionsHelper<CertificateOptionKinds>
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00006DCD File Offset: 0x00004FCD
		private CertificateOptionKindsHelper()
		{
			base.AddOptionMapping(CertificateOptionKinds.Subject, "SUBJECT");
			base.AddOptionMapping(CertificateOptionKinds.StartDate, "START_DATE");
			base.AddOptionMapping(CertificateOptionKinds.ExpiryDate, "EXPIRY_DATE");
		}

		// Token: 0x04000248 RID: 584
		internal static readonly CertificateOptionKindsHelper Instance = new CertificateOptionKindsHelper();
	}
}
