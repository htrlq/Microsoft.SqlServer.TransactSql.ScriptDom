using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x02000195 RID: 405
	internal abstract class TokenGenerator
	{
		// Token: 0x06000B54 RID: 2900 RVA: 0x0001FBB2 File Offset: 0x0001DDB2
		public TokenGenerator(bool appendSpace)
		{
			this._appendSpace = appendSpace;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0001FBC1 File Offset: 0x0001DDC1
		protected void AppendSpaceIfRequired(ScriptWriter writer)
		{
			if (this._appendSpace)
			{
				writer.AddToken(ScriptGeneratorSupporter.CreateWhitespaceToken(1));
			}
		}

		// Token: 0x06000B56 RID: 2902
		public abstract void Generate(ScriptWriter writer);

		// Token: 0x04000FD0 RID: 4048
		private bool _appendSpace;
	}
}
