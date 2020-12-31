using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x02000198 RID: 408
	internal sealed class KeywordGenerator : TokenGenerator
	{
		// Token: 0x06000B5C RID: 2908 RVA: 0x0001FC11 File Offset: 0x0001DE11
		public KeywordGenerator(TSqlTokenType keywordId) : this(keywordId, false)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001FC1B File Offset: 0x0001DE1B
		public KeywordGenerator(TSqlTokenType keywordId, bool appendSpace) : base(appendSpace)
		{
			this._keywordId = keywordId;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001FC2B File Offset: 0x0001DE2B
		public override void Generate(ScriptWriter writer)
		{
			writer.AddKeyword(this._keywordId);
			base.AppendSpaceIfRequired(writer);
		}

		// Token: 0x04000FD2 RID: 4050
		private TSqlTokenType _keywordId;
	}
}
