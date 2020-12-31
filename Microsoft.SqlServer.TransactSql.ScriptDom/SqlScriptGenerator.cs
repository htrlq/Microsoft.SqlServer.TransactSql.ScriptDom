using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001A9 RID: 425
	public abstract class SqlScriptGenerator
	{
		// Token: 0x06001015 RID: 4117 RVA: 0x00036135 File Offset: 0x00034335
		protected SqlScriptGenerator(SqlScriptGeneratorOptions options)
		{
			ScriptGeneratorSupporter.CheckForNullReference(options, "options");
			this._options = options;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0003614F File Offset: 0x0003434F
		public SqlScriptGeneratorOptions Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00036158 File Offset: 0x00034358
		public void GenerateScript(TSqlFragment scriptFragment, out string script)
		{
			StringBuilder stringBuilder = new StringBuilder();
			using (StringWriter stringWriter = new StringWriter(stringBuilder, CultureInfo.InvariantCulture))
			{
				this.GenerateScript(scriptFragment, stringWriter);
			}
			script = stringBuilder.ToString();
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000361A4 File Offset: 0x000343A4
		public void GenerateScript(TSqlFragment scriptFragment, TextWriter writer)
		{
			ScriptGeneratorSupporter.CheckForNullReference(scriptFragment, "scriptFragment");
			ScriptGeneratorSupporter.CheckForNullReference(writer, "writer");
			if (scriptFragment == null)
			{
				throw new ArgumentException(SqlScriptGeneratorResource.ScriptDomTreeTypeNotSupported, "scriptFragment");
			}
			ScriptWriter scriptWriter = this.WriteScript(scriptFragment);
			scriptWriter.WriteTo(writer);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000361EC File Offset: 0x000343EC
		public IList<TSqlParserToken> GenerateTokens(TSqlFragment scriptFragment)
		{
			ScriptGeneratorSupporter.CheckForNullReference(scriptFragment, "scriptFragment");
			ScriptWriter scriptWriter = this.WriteScript(scriptFragment);
			IList<TSqlParserToken> list = new List<TSqlParserToken>();
			scriptWriter.WriteTo(list);
			return list;
		}

		// Token: 0x0600101A RID: 4122
		internal abstract SqlScriptGeneratorVisitor CreateSqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter scriptWriter);

		// Token: 0x0600101B RID: 4123 RVA: 0x0003621C File Offset: 0x0003441C
		private ScriptWriter WriteScript(TSqlFragment scriptFragment)
		{
			ScriptWriter scriptWriter = new ScriptWriter(this._options);
			SqlScriptGeneratorVisitor visitor = this.CreateSqlScriptGeneratorVisitor(this._options, scriptWriter);
			scriptFragment.Accept(visitor);
			return scriptWriter;
		}

		// Token: 0x0400104D RID: 4173
		private SqlScriptGeneratorOptions _options;
	}
}
