using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class XmlForClauseOption : ForClause
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x001C91F5 File Offset: 0x001C73F5
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x001C91FD File Offset: 0x001C73FD
		public XmlForClauseOptions OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x001C9206 File Offset: 0x001C7406
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x001C920E File Offset: 0x001C740E
		public Literal Value
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

		// Token: 0x06002ADF RID: 10975 RVA: 0x001C921E File Offset: 0x001C741E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x001C922A File Offset: 0x001C742A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DAF RID: 7599
		private XmlForClauseOptions _optionKind;

		// Token: 0x04001DB0 RID: 7600
		private Literal _value;
	}
}
