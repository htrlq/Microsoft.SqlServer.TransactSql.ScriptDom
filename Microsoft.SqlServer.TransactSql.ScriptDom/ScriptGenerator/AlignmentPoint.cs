using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x02000194 RID: 404
	internal class AlignmentPoint
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x0001FB92 File Offset: 0x0001DD92
		public AlignmentPoint() : this(null)
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001FB9B File Offset: 0x0001DD9B
		public AlignmentPoint(string name)
		{
			this._name = name;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0001FBAA File Offset: 0x0001DDAA
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x04000FCF RID: 4047
		private string _name;
	}
}
