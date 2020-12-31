using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B0 RID: 688
	[Serializable]
	public class AlterTableConstraintModificationStatement : AlterTableStatement
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x001CD549 File Offset: 0x001CB749
		// (set) Token: 0x06002EA7 RID: 11943 RVA: 0x001CD551 File Offset: 0x001CB751
		public ConstraintEnforcement ExistingRowsCheckEnforcement
		{
			get
			{
				return this._existingRowsCheckEnforcement;
			}
			set
			{
				this._existingRowsCheckEnforcement = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x001CD55A File Offset: 0x001CB75A
		// (set) Token: 0x06002EA9 RID: 11945 RVA: 0x001CD562 File Offset: 0x001CB762
		public ConstraintEnforcement ConstraintEnforcement
		{
			get
			{
				return this._constraintEnforcement;
			}
			set
			{
				this._constraintEnforcement = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x001CD56B File Offset: 0x001CB76B
		// (set) Token: 0x06002EAB RID: 11947 RVA: 0x001CD573 File Offset: 0x001CB773
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x001CD57C File Offset: 0x001CB77C
		public IList<Identifier> ConstraintNames
		{
			get
			{
				return this._constraintNames;
			}
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x001CD584 File Offset: 0x001CB784
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x001CD590 File Offset: 0x001CB790
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.ConstraintNames.Count;
			while (i < count)
			{
				this.ConstraintNames[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001EC3 RID: 7875
		private ConstraintEnforcement _existingRowsCheckEnforcement;

		// Token: 0x04001EC4 RID: 7876
		private ConstraintEnforcement _constraintEnforcement;

		// Token: 0x04001EC5 RID: 7877
		private bool _all;

		// Token: 0x04001EC6 RID: 7878
		private List<Identifier> _constraintNames = new List<Identifier>();
	}
}
