using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A8 RID: 1192
	[Serializable]
	public class EventSessionStatement : TSqlStatement
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x001D9542 File Offset: 0x001D7742
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x001D954A File Offset: 0x001D774A
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x001D955A File Offset: 0x001D775A
		public IList<EventDeclaration> EventDeclarations
		{
			get
			{
				return this._eventDeclarations;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x001D9562 File Offset: 0x001D7762
		public IList<TargetDeclaration> TargetDeclarations
		{
			get
			{
				return this._targetDeclarations;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x001D956A File Offset: 0x001D776A
		public IList<SessionOption> SessionOptions
		{
			get
			{
				return this._sessionOptions;
			}
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x001D9572 File Offset: 0x001D7772
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x001D9580 File Offset: 0x001D7780
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.EventDeclarations.Count;
			while (i < count)
			{
				this.EventDeclarations[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.TargetDeclarations.Count;
			while (j < count2)
			{
				this.TargetDeclarations[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = this.SessionOptions.Count;
			while (k < count3)
			{
				this.SessionOptions[k].Accept(visitor);
				k++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400221C RID: 8732
		private Identifier _name;

		// Token: 0x0400221D RID: 8733
		private List<EventDeclaration> _eventDeclarations = new List<EventDeclaration>();

		// Token: 0x0400221E RID: 8734
		private List<TargetDeclaration> _targetDeclarations = new List<TargetDeclaration>();

		// Token: 0x0400221F RID: 8735
		private List<SessionOption> _sessionOptions = new List<SessionOption>();
	}
}
