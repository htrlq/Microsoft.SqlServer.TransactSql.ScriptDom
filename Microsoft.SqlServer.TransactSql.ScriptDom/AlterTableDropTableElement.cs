using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B8 RID: 696
	[Serializable]
	public class AlterTableDropTableElement : TSqlFragment
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x001CD84F File Offset: 0x001CBA4F
		// (set) Token: 0x06002ED6 RID: 11990 RVA: 0x001CD857 File Offset: 0x001CBA57
		public TableElementType TableElementType
		{
			get
			{
				return this._tableElementType;
			}
			set
			{
				this._tableElementType = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x001CD860 File Offset: 0x001CBA60
		// (set) Token: 0x06002ED8 RID: 11992 RVA: 0x001CD868 File Offset: 0x001CBA68
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

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x001CD878 File Offset: 0x001CBA78
		public IList<DropClusteredConstraintOption> DropClusteredConstraintOptions
		{
			get
			{
				return this._dropClusteredConstraintOptions;
			}
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x001CD880 File Offset: 0x001CBA80
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x001CD88C File Offset: 0x001CBA8C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.DropClusteredConstraintOptions.Count;
			while (i < count)
			{
				this.DropClusteredConstraintOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001ED1 RID: 7889
		private TableElementType _tableElementType;

		// Token: 0x04001ED2 RID: 7890
		private Identifier _name;

		// Token: 0x04001ED3 RID: 7891
		private List<DropClusteredConstraintOption> _dropClusteredConstraintOptions = new List<DropClusteredConstraintOption>();
	}
}
