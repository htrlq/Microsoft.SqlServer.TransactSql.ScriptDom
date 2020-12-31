using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200044F RID: 1103
	[Serializable]
	public class AlterSchemaStatement : TSqlStatement
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600389F RID: 14495 RVA: 0x001D792D File Offset: 0x001D5B2D
		// (set) Token: 0x060038A0 RID: 14496 RVA: 0x001D7935 File Offset: 0x001D5B35
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x001D7945 File Offset: 0x001D5B45
		// (set) Token: 0x060038A2 RID: 14498 RVA: 0x001D794D File Offset: 0x001D5B4D
		public SchemaObjectName ObjectName
		{
			get
			{
				return this._objectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._objectName = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x001D795D File Offset: 0x001D5B5D
		// (set) Token: 0x060038A4 RID: 14500 RVA: 0x001D7965 File Offset: 0x001D5B65
		public SecurityObjectKind ObjectKind
		{
			get
			{
				return this._objectKind;
			}
			set
			{
				this._objectKind = value;
			}
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x001D796E File Offset: 0x001D5B6E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x001D797A File Offset: 0x001D5B7A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.ObjectName != null)
			{
				this.ObjectName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021A0 RID: 8608
		private Identifier _name;

		// Token: 0x040021A1 RID: 8609
		private SchemaObjectName _objectName;

		// Token: 0x040021A2 RID: 8610
		private SecurityObjectKind _objectKind;
	}
}
