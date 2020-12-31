using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class SchemaPayloadOption : PayloadOption
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x001D44E5 File Offset: 0x001D26E5
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x001D44ED File Offset: 0x001D26ED
		public bool IsStandard
		{
			get
			{
				return this._isStandard;
			}
			set
			{
				this._isStandard = value;
			}
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x001D44F6 File Offset: 0x001D26F6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x001D4502 File Offset: 0x001D2702
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020C0 RID: 8384
		private bool _isStandard;
	}
}
