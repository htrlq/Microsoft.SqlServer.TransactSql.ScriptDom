using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000255 RID: 597
	[Serializable]
	public class ProcedureParameter : DeclareVariableElement
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x001CB24E File Offset: 0x001C944E
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x001CB256 File Offset: 0x001C9456
		public bool IsVarying
		{
			get
			{
				return this._isVarying;
			}
			set
			{
				this._isVarying = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x001CB25F File Offset: 0x001C945F
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x001CB267 File Offset: 0x001C9467
		public ParameterModifier Modifier
		{
			get
			{
				return this._modifier;
			}
			set
			{
				this._modifier = value;
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x001CB270 File Offset: 0x001C9470
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x001CB27C File Offset: 0x001C947C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E31 RID: 7729
		private bool _isVarying;

		// Token: 0x04001E32 RID: 7730
		private ParameterModifier _modifier;
	}
}
