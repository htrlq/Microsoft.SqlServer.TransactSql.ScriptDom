using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000456 RID: 1110
	[Serializable]
	public class OnOffDialogOption : DialogOption
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x001D7D54 File Offset: 0x001D5F54
		// (set) Token: 0x060038DF RID: 14559 RVA: 0x001D7D5C File Offset: 0x001D5F5C
		public OptionState OptionState
		{
			get
			{
				return this._optionState;
			}
			set
			{
				this._optionState = value;
			}
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x001D7D65 File Offset: 0x001D5F65
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x001D7D71 File Offset: 0x001D5F71
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021B6 RID: 8630
		private OptionState _optionState;
	}
}
