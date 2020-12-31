using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000344 RID: 836
	[Serializable]
	public class CreateDatabaseStatement : TSqlStatement, ICollationSetter
	{
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x001D0C16 File Offset: 0x001CEE16
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x001D0C1E File Offset: 0x001CEE1E
		public Identifier DatabaseName
		{
			get
			{
				return this._databaseName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._databaseName = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x001D0C2E File Offset: 0x001CEE2E
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x001D0C36 File Offset: 0x001CEE36
		public ContainmentDatabaseOption Containment
		{
			get
			{
				return this._containment;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._containment = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x001D0C46 File Offset: 0x001CEE46
		public IList<FileGroupDefinition> FileGroups
		{
			get
			{
				return this._fileGroups;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x001D0C4E File Offset: 0x001CEE4E
		public IList<FileDeclaration> LogOn
		{
			get
			{
				return this._logOn;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x001D0C56 File Offset: 0x001CEE56
		public IList<DatabaseOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x001D0C5E File Offset: 0x001CEE5E
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x001D0C66 File Offset: 0x001CEE66
		public AttachMode AttachMode
		{
			get
			{
				return this._attachMode;
			}
			set
			{
				this._attachMode = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x001D0C6F File Offset: 0x001CEE6F
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x001D0C77 File Offset: 0x001CEE77
		public Identifier DatabaseSnapshot
		{
			get
			{
				return this._databaseSnapshot;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._databaseSnapshot = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x001D0C87 File Offset: 0x001CEE87
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x001D0C8F File Offset: 0x001CEE8F
		public MultiPartIdentifier CopyOf
		{
			get
			{
				return this._copyOf;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._copyOf = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x001D0C9F File Offset: 0x001CEE9F
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x001D0CA7 File Offset: 0x001CEEA7
		public Identifier Collation
		{
			get
			{
				return this._collation;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._collation = value;
			}
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x001D0CB7 File Offset: 0x001CEEB7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x001D0CC4 File Offset: 0x001CEEC4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			if (this.Containment != null)
			{
				this.Containment.Accept(visitor);
			}
			int i = 0;
			int count = this.FileGroups.Count;
			while (i < count)
			{
				this.FileGroups[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.LogOn.Count;
			while (j < count2)
			{
				this.LogOn[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = this.Options.Count;
			while (k < count3)
			{
				this.Options[k].Accept(visitor);
				k++;
			}
			if (this.DatabaseSnapshot != null)
			{
				this.DatabaseSnapshot.Accept(visitor);
			}
			if (this.CopyOf != null)
			{
				this.CopyOf.Accept(visitor);
			}
			if (this.Collation != null)
			{
				this.Collation.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FAB RID: 8107
		private Identifier _databaseName;

		// Token: 0x04001FAC RID: 8108
		private ContainmentDatabaseOption _containment;

		// Token: 0x04001FAD RID: 8109
		private List<FileGroupDefinition> _fileGroups = new List<FileGroupDefinition>();

		// Token: 0x04001FAE RID: 8110
		private List<FileDeclaration> _logOn = new List<FileDeclaration>();

		// Token: 0x04001FAF RID: 8111
		private List<DatabaseOption> _options = new List<DatabaseOption>();

		// Token: 0x04001FB0 RID: 8112
		private AttachMode _attachMode;

		// Token: 0x04001FB1 RID: 8113
		private Identifier _databaseSnapshot;

		// Token: 0x04001FB2 RID: 8114
		private MultiPartIdentifier _copyOf;

		// Token: 0x04001FB3 RID: 8115
		private Identifier _collation;
	}
}
