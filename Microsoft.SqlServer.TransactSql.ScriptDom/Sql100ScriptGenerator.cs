using System;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001AA RID: 426
	public sealed class Sql100ScriptGenerator : SqlScriptGenerator
	{
		// Token: 0x0600101C RID: 4124 RVA: 0x0003624B File Offset: 0x0003444B
		public Sql100ScriptGenerator() : this(new SqlScriptGeneratorOptions())
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00036258 File Offset: 0x00034458
		public Sql100ScriptGenerator(SqlScriptGeneratorOptions options) : base(options)
		{
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00036261 File Offset: 0x00034461
		internal override SqlScriptGeneratorVisitor CreateSqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter scriptWriter)
		{
			ScriptGeneratorSupporter.CheckForNullReference(options, "options");
			ScriptGeneratorSupporter.CheckForNullReference(scriptWriter, "scriptWriter");
			return new Sql100ScriptGeneratorVisitor(options, scriptWriter);
		}
	}
}
