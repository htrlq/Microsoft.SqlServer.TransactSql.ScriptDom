using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000178 RID: 376
	[Serializable]
	internal class TSqlFragmentFactory
	{
		// Token: 0x06000B08 RID: 2824 RVA: 0x0001F527 File Offset: 0x0001D727
		public void SetTokenStream(IList<TSqlParserToken> tokenStream)
		{
			this._tokenStream = tokenStream;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001F530 File Offset: 0x0001D730
		public virtual FragmentType CreateFragment<FragmentType>() where FragmentType : TSqlFragment, new()
		{
			FragmentType result = Activator.CreateInstance<FragmentType>();
			result.ScriptTokenStream = this._tokenStream;
			return result;
		}

		// Token: 0x04000F70 RID: 3952
		private IList<TSqlParserToken> _tokenStream;
	}
}
