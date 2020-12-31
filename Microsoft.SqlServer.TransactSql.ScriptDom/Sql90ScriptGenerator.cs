using System;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001AE RID: 430
	public sealed class Sql90ScriptGenerator : SqlScriptGenerator
	{
		// Token: 0x06001028 RID: 4136 RVA: 0x0003631F File Offset: 0x0003451F
		public Sql90ScriptGenerator() : this(new SqlScriptGeneratorOptions())
		{
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0003632C File Offset: 0x0003452C
		public Sql90ScriptGenerator(SqlScriptGeneratorOptions options) : base(options)
		{
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00036335 File Offset: 0x00034535
		internal override SqlScriptGeneratorVisitor CreateSqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter scriptWriter)
		{
			ScriptGeneratorSupporter.CheckForNullReference(options, "options");
			ScriptGeneratorSupporter.CheckForNullReference(scriptWriter, "scriptWriter");
			return new Sql90ScriptGeneratorVisitor(options, scriptWriter);
		}
	}
}
