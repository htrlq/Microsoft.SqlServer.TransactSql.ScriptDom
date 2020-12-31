using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x02000197 RID: 407
	internal sealed class IdentifierGenerator : TokenGenerator
	{
		// Token: 0x06000B59 RID: 2905 RVA: 0x0001FBE2 File Offset: 0x0001DDE2
		public IdentifierGenerator(string identifier) : this(identifier, false)
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		public IdentifierGenerator(string identifier, bool appendSpace) : base(appendSpace)
		{
			this._identifier = identifier;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		public override void Generate(ScriptWriter writer)
		{
			writer.AddIdentifierWithCasing(this._identifier);
			base.AppendSpaceIfRequired(writer);
		}

		// Token: 0x04000FD1 RID: 4049
		private string _identifier;
	}
}
