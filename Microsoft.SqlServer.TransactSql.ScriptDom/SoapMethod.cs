using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003BE RID: 958
	[Serializable]
	public class SoapMethod : PayloadOption
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x001D42AA File Offset: 0x001D24AA
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x001D42B2 File Offset: 0x001D24B2
		public Literal Alias
		{
			get
			{
				return this._alias;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._alias = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x001D42C2 File Offset: 0x001D24C2
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x001D42CA File Offset: 0x001D24CA
		public Literal Namespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._namespace = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x001D42DA File Offset: 0x001D24DA
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x001D42E2 File Offset: 0x001D24E2
		public SoapMethodAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x001D42EB File Offset: 0x001D24EB
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x001D42F3 File Offset: 0x001D24F3
		public Literal Name
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

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x001D4303 File Offset: 0x001D2503
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x001D430B File Offset: 0x001D250B
		public SoapMethodFormat Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x001D4314 File Offset: 0x001D2514
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x001D431C File Offset: 0x001D251C
		public SoapMethodSchemas Schema
		{
			get
			{
				return this._schema;
			}
			set
			{
				this._schema = value;
			}
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x001D4325 File Offset: 0x001D2525
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x001D4334 File Offset: 0x001D2534
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Alias != null)
			{
				this.Alias.Accept(visitor);
			}
			if (this.Namespace != null)
			{
				this.Namespace.Accept(visitor);
			}
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
		}

		// Token: 0x040020B3 RID: 8371
		private Literal _alias;

		// Token: 0x040020B4 RID: 8372
		private Literal _namespace;

		// Token: 0x040020B5 RID: 8373
		private SoapMethodAction _action;

		// Token: 0x040020B6 RID: 8374
		private Literal _name;

		// Token: 0x040020B7 RID: 8375
		private SoapMethodFormat _format;

		// Token: 0x040020B8 RID: 8376
		private SoapMethodSchemas _schema;
	}
}
