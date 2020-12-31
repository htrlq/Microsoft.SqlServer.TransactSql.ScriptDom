using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C8 RID: 968
	[Serializable]
	public class EncryptionPayloadOption : PayloadOption
	{
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x001D45DA File Offset: 0x001D27DA
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x001D45E2 File Offset: 0x001D27E2
		public EndpointEncryptionSupport EncryptionSupport
		{
			get
			{
				return this._encryptionSupport;
			}
			set
			{
				this._encryptionSupport = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x001D45EB File Offset: 0x001D27EB
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x001D45F3 File Offset: 0x001D27F3
		public EncryptionAlgorithmPreference AlgorithmPartOne
		{
			get
			{
				return this._algorithmPartOne;
			}
			set
			{
				this._algorithmPartOne = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x001D45FC File Offset: 0x001D27FC
		// (set) Token: 0x0600358B RID: 13707 RVA: 0x001D4604 File Offset: 0x001D2804
		public EncryptionAlgorithmPreference AlgorithmPartTwo
		{
			get
			{
				return this._algorithmPartTwo;
			}
			set
			{
				this._algorithmPartTwo = value;
			}
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x001D460D File Offset: 0x001D280D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x001D4619 File Offset: 0x001D2819
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020C6 RID: 8390
		private EndpointEncryptionSupport _encryptionSupport;

		// Token: 0x040020C7 RID: 8391
		private EncryptionAlgorithmPreference _algorithmPartOne;

		// Token: 0x040020C8 RID: 8392
		private EncryptionAlgorithmPreference _algorithmPartTwo;
	}
}
