using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000422 RID: 1058
	[Serializable]
	public class SetStopListAlterFullTextIndexAction : AlterFullTextIndexAction
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x001D6898 File Offset: 0x001D4A98
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x001D68A0 File Offset: 0x001D4AA0
		public StopListFullTextIndexOption StopListOption
		{
			get
			{
				return this._stopListOption;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._stopListOption = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x001D68B0 File Offset: 0x001D4AB0
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x001D68B8 File Offset: 0x001D4AB8
		public bool WithNoPopulation
		{
			get
			{
				return this._withNoPopulation;
			}
			set
			{
				this._withNoPopulation = value;
			}
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x001D68C1 File Offset: 0x001D4AC1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x001D68CD File Offset: 0x001D4ACD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.StopListOption != null)
			{
				this.StopListOption.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002157 RID: 8535
		private StopListFullTextIndexOption _stopListOption;

		// Token: 0x04002158 RID: 8536
		private bool _withNoPopulation;
	}
}
