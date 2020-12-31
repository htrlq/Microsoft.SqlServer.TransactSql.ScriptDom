using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000217 RID: 535
	[Serializable]
	public class VariableValuePair : TSqlFragment
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x001C94C9 File Offset: 0x001C76C9
		// (set) Token: 0x06002B03 RID: 11011 RVA: 0x001C94D1 File Offset: 0x001C76D1
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x001C94E1 File Offset: 0x001C76E1
		// (set) Token: 0x06002B05 RID: 11013 RVA: 0x001C94E9 File Offset: 0x001C76E9
		public ScalarExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x001C94F9 File Offset: 0x001C76F9
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x001C9501 File Offset: 0x001C7701
		public bool IsForUnknown
		{
			get
			{
				return this._isForUnknown;
			}
			set
			{
				this._isForUnknown = value;
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x001C950A File Offset: 0x001C770A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x001C9516 File Offset: 0x001C7716
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DBA RID: 7610
		private VariableReference _variable;

		// Token: 0x04001DBB RID: 7611
		private ScalarExpression _value;

		// Token: 0x04001DBC RID: 7612
		private bool _isForUnknown;
	}
}
