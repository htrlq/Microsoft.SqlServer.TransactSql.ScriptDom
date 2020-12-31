using System;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001AD RID: 429
	public sealed class Sql80ScriptGenerator : SqlScriptGenerator
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x000362EA File Offset: 0x000344EA
		public Sql80ScriptGenerator() : this(new SqlScriptGeneratorOptions())
		{
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000362F7 File Offset: 0x000344F7
		public Sql80ScriptGenerator(SqlScriptGeneratorOptions options) : base(options)
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00036300 File Offset: 0x00034500
		internal override SqlScriptGeneratorVisitor CreateSqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter scriptWriter)
		{
			ScriptGeneratorSupporter.CheckForNullReference(options, "options");
			ScriptGeneratorSupporter.CheckForNullReference(scriptWriter, "scriptWriter");
			return new Sql80ScriptGeneratorVisitor(options, scriptWriter);
		}
	}
}
