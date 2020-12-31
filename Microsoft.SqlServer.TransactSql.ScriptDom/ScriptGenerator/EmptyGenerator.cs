using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x02000196 RID: 406
	internal class EmptyGenerator : TokenGenerator
	{
		// Token: 0x06000B57 RID: 2903 RVA: 0x0001FBD7 File Offset: 0x0001DDD7
		public EmptyGenerator() : base(false)
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0001FBE0 File Offset: 0x0001DDE0
		public override void Generate(ScriptWriter writer)
		{
		}
	}
}
