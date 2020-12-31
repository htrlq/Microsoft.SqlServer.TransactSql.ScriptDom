using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200028F RID: 655
	[Serializable]
	public abstract class SequenceStatement : TSqlStatement
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x001CCA5A File Offset: 0x001CAC5A
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x001CCA62 File Offset: 0x001CAC62
		public SchemaObjectName Name
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x001CCA72 File Offset: 0x001CAC72
		public IList<SequenceOption> SequenceOptions
		{
			get
			{
				return this._sequenceOptions;
			}
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x001CCA7C File Offset: 0x001CAC7C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.SequenceOptions.Count;
			while (i < count)
			{
				this.SequenceOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E98 RID: 7832
		private SchemaObjectName _name;

		// Token: 0x04001E99 RID: 7833
		private List<SequenceOption> _sequenceOptions = new List<SequenceOption>();
	}
}
