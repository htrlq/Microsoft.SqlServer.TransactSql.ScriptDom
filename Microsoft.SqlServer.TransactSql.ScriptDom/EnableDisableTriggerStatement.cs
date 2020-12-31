using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002BB RID: 699
	[Serializable]
	public class EnableDisableTriggerStatement : TSqlStatement
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x001CD9FA File Offset: 0x001CBBFA
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x001CDA02 File Offset: 0x001CBC02
		public TriggerEnforcement TriggerEnforcement
		{
			get
			{
				return this._triggerEnforcement;
			}
			set
			{
				this._triggerEnforcement = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x001CDA0B File Offset: 0x001CBC0B
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x001CDA13 File Offset: 0x001CBC13
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

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x001CDA1C File Offset: 0x001CBC1C
		public IList<SchemaObjectName> TriggerNames
		{
			get
			{
				return this._triggerNames;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x001CDA24 File Offset: 0x001CBC24
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x001CDA2C File Offset: 0x001CBC2C
		public TriggerObject TriggerObject
		{
			get
			{
				return this._triggerObject;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._triggerObject = value;
			}
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x001CDA3C File Offset: 0x001CBC3C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x001CDA48 File Offset: 0x001CBC48
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.TriggerNames.Count;
			while (i < count)
			{
				this.TriggerNames[i].Accept(visitor);
				i++;
			}
			if (this.TriggerObject != null)
			{
				this.TriggerObject.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001ED8 RID: 7896
		private TriggerEnforcement _triggerEnforcement;

		// Token: 0x04001ED9 RID: 7897
		private bool _all;

		// Token: 0x04001EDA RID: 7898
		private List<SchemaObjectName> _triggerNames = new List<SchemaObjectName>();

		// Token: 0x04001EDB RID: 7899
		private TriggerObject _triggerObject;
	}
}
