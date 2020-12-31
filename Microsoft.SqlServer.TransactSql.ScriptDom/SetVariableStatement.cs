using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200030C RID: 780
	[Serializable]
	public class SetVariableStatement : TSqlStatement
	{
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x001CFAF3 File Offset: 0x001CDCF3
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x001CFAFB File Offset: 0x001CDCFB
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x001CFB0B File Offset: 0x001CDD0B
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x001CFB13 File Offset: 0x001CDD13
		public SeparatorType SeparatorType
		{
			get
			{
				return this._separatorType;
			}
			set
			{
				this._separatorType = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x001CFB1C File Offset: 0x001CDD1C
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x001CFB24 File Offset: 0x001CDD24
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x001CFB34 File Offset: 0x001CDD34
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x001CFB3C File Offset: 0x001CDD3C
		public bool FunctionCallExists
		{
			get
			{
				return this._functionCallExists;
			}
			set
			{
				this._functionCallExists = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x001CFB45 File Offset: 0x001CDD45
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x001CFB4D File Offset: 0x001CDD4D
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x001CFB55 File Offset: 0x001CDD55
		public ScalarExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expression = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x001CFB65 File Offset: 0x001CDD65
		// (set) Token: 0x060030D9 RID: 12505 RVA: 0x001CFB6D File Offset: 0x001CDD6D
		public CursorDefinition CursorDefinition
		{
			get
			{
				return this._cursorDefinition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cursorDefinition = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x001CFB7D File Offset: 0x001CDD7D
		// (set) Token: 0x060030DB RID: 12507 RVA: 0x001CFB85 File Offset: 0x001CDD85
		public AssignmentKind AssignmentKind
		{
			get
			{
				return this._assignmentKind;
			}
			set
			{
				this._assignmentKind = value;
			}
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x001CFB8E File Offset: 0x001CDD8E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x001CFB9C File Offset: 0x001CDD9C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			if (this.CursorDefinition != null)
			{
				this.CursorDefinition.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F63 RID: 8035
		private VariableReference _variable;

		// Token: 0x04001F64 RID: 8036
		private SeparatorType _separatorType;

		// Token: 0x04001F65 RID: 8037
		private Identifier _identifier;

		// Token: 0x04001F66 RID: 8038
		private bool _functionCallExists;

		// Token: 0x04001F67 RID: 8039
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();

		// Token: 0x04001F68 RID: 8040
		private ScalarExpression _expression;

		// Token: 0x04001F69 RID: 8041
		private CursorDefinition _cursorDefinition;

		// Token: 0x04001F6A RID: 8042
		private AssignmentKind _assignmentKind;
	}
}
