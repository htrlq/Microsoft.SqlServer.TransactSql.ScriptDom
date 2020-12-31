using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000250 RID: 592
	[Serializable]
	public class DeclareVariableElement : TSqlFragment
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x001CAFEA File Offset: 0x001C91EA
		// (set) Token: 0x06002C74 RID: 11380 RVA: 0x001CAFF2 File Offset: 0x001C91F2
		public Identifier VariableName
		{
			get
			{
				return this._variableName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variableName = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x001CB002 File Offset: 0x001C9202
		// (set) Token: 0x06002C76 RID: 11382 RVA: 0x001CB00A File Offset: 0x001C920A
		public DataTypeReference DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataType = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x001CB01A File Offset: 0x001C921A
		// (set) Token: 0x06002C78 RID: 11384 RVA: 0x001CB022 File Offset: 0x001C9222
		public NullableConstraintDefinition Nullable
		{
			get
			{
				return this._nullable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._nullable = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x001CB032 File Offset: 0x001C9232
		// (set) Token: 0x06002C7A RID: 11386 RVA: 0x001CB03A File Offset: 0x001C923A
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

		// Token: 0x06002C7B RID: 11387 RVA: 0x001CB04A File Offset: 0x001C924A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x001CB058 File Offset: 0x001C9258
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.VariableName != null)
			{
				this.VariableName.Accept(visitor);
			}
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.Nullable != null)
			{
				this.Nullable.Accept(visitor);
			}
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E27 RID: 7719
		private Identifier _variableName;

		// Token: 0x04001E28 RID: 7720
		private DataTypeReference _dataType;

		// Token: 0x04001E29 RID: 7721
		private NullableConstraintDefinition _nullable;

		// Token: 0x04001E2A RID: 7722
		private ScalarExpression _value;
	}
}
