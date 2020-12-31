using System;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001AB RID: 427
	public sealed class Sql110ScriptGenerator : SqlScriptGenerator
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x00036280 File Offset: 0x00034480
		public Sql110ScriptGenerator() : this(new SqlScriptGeneratorOptions())
		{
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0003628D File Offset: 0x0003448D
		public Sql110ScriptGenerator(SqlScriptGeneratorOptions options) : base(options)
		{
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00036296 File Offset: 0x00034496
		internal override SqlScriptGeneratorVisitor CreateSqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter scriptWriter)
		{
			ScriptGeneratorSupporter.CheckForNullReference(options, "options");
			ScriptGeneratorSupporter.CheckForNullReference(scriptWriter, "scriptWriter");
			return new Sql110ScriptGeneratorVisitor(options, scriptWriter);
		}
	}
}
