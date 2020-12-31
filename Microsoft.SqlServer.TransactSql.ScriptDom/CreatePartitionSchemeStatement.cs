using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200039A RID: 922
	[Serializable]
	public class CreatePartitionSchemeStatement : TSqlStatement
	{
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x001D32EA File Offset: 0x001D14EA
		// (set) Token: 0x0600345E RID: 13406 RVA: 0x001D32F2 File Offset: 0x001D14F2
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x001D3302 File Offset: 0x001D1502
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x001D330A File Offset: 0x001D150A
		public Identifier PartitionFunction
		{
			get
			{
				return this._partitionFunction;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._partitionFunction = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x001D331A File Offset: 0x001D151A
		// (set) Token: 0x06003462 RID: 13410 RVA: 0x001D3322 File Offset: 0x001D1522
		public bool IsAll
		{
			get
			{
				return this._isAll;
			}
			set
			{
				this._isAll = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x001D332B File Offset: 0x001D152B
		public IList<IdentifierOrValueExpression> FileGroups
		{
			get
			{
				return this._fileGroups;
			}
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x001D3333 File Offset: 0x001D1533
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x001D3340 File Offset: 0x001D1540
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.PartitionFunction != null)
			{
				this.PartitionFunction.Accept(visitor);
			}
			int i = 0;
			int count = this.FileGroups.Count;
			while (i < count)
			{
				this.FileGroups[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400206E RID: 8302
		private Identifier _name;

		// Token: 0x0400206F RID: 8303
		private Identifier _partitionFunction;

		// Token: 0x04002070 RID: 8304
		private bool _isAll;

		// Token: 0x04002071 RID: 8305
		private List<IdentifierOrValueExpression> _fileGroups = new List<IdentifierOrValueExpression>();
	}
}
