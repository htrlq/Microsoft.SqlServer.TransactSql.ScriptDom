using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000453 RID: 1107
	[Serializable]
	public class BeginDialogStatement : TSqlStatement
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x001D7B97 File Offset: 0x001D5D97
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x001D7B9F File Offset: 0x001D5D9F
		public bool IsConversation
		{
			get
			{
				return this._isConversation;
			}
			set
			{
				this._isConversation = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x001D7BA8 File Offset: 0x001D5DA8
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x001D7BB0 File Offset: 0x001D5DB0
		public VariableReference Handle
		{
			get
			{
				return this._handle;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._handle = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x001D7BC0 File Offset: 0x001D5DC0
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x001D7BC8 File Offset: 0x001D5DC8
		public IdentifierOrValueExpression InitiatorServiceName
		{
			get
			{
				return this._initiatorServiceName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._initiatorServiceName = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x001D7BD8 File Offset: 0x001D5DD8
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x001D7BE0 File Offset: 0x001D5DE0
		public ValueExpression TargetServiceName
		{
			get
			{
				return this._targetServiceName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._targetServiceName = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x001D7BF0 File Offset: 0x001D5DF0
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x001D7BF8 File Offset: 0x001D5DF8
		public ValueExpression InstanceSpec
		{
			get
			{
				return this._instanceSpec;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._instanceSpec = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x001D7C08 File Offset: 0x001D5E08
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x001D7C10 File Offset: 0x001D5E10
		public IdentifierOrValueExpression ContractName
		{
			get
			{
				return this._contractName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._contractName = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x001D7C20 File Offset: 0x001D5E20
		public IList<DialogOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x001D7C28 File Offset: 0x001D5E28
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x001D7C34 File Offset: 0x001D5E34
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Handle != null)
			{
				this.Handle.Accept(visitor);
			}
			if (this.InitiatorServiceName != null)
			{
				this.InitiatorServiceName.Accept(visitor);
			}
			if (this.TargetServiceName != null)
			{
				this.TargetServiceName.Accept(visitor);
			}
			if (this.InstanceSpec != null)
			{
				this.InstanceSpec.Accept(visitor);
			}
			if (this.ContractName != null)
			{
				this.ContractName.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021AD RID: 8621
		private bool _isConversation;

		// Token: 0x040021AE RID: 8622
		private VariableReference _handle;

		// Token: 0x040021AF RID: 8623
		private IdentifierOrValueExpression _initiatorServiceName;

		// Token: 0x040021B0 RID: 8624
		private ValueExpression _targetServiceName;

		// Token: 0x040021B1 RID: 8625
		private ValueExpression _instanceSpec;

		// Token: 0x040021B2 RID: 8626
		private IdentifierOrValueExpression _contractName;

		// Token: 0x040021B3 RID: 8627
		private List<DialogOption> _options = new List<DialogOption>();
	}
}
