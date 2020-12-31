using System;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001AC RID: 428
	public sealed class Sql120ScriptGenerator : SqlScriptGenerator
	{
		// Token: 0x06001022 RID: 4130 RVA: 0x000362B5 File Offset: 0x000344B5
		public Sql120ScriptGenerator() : this(new SqlScriptGeneratorOptions())
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000362C2 File Offset: 0x000344C2
		public Sql120ScriptGenerator(SqlScriptGeneratorOptions options) : base(options)
		{
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000362CB File Offset: 0x000344CB
		internal override SqlScriptGeneratorVisitor CreateSqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter scriptWriter)
		{
			ScriptGeneratorSupporter.CheckForNullReference(options, "options");
			ScriptGeneratorSupporter.CheckForNullReference(scriptWriter, "scriptWriter");
			return new Sql120ScriptGeneratorVisitor(options, scriptWriter);
		}
	}
}
