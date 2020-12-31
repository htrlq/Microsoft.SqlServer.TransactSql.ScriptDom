using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000398 RID: 920
	[Serializable]
	public class CreatePartitionFunctionStatement : TSqlStatement
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x001D31A4 File Offset: 0x001D13A4
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x001D31AC File Offset: 0x001D13AC
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x001D31BC File Offset: 0x001D13BC
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x001D31C4 File Offset: 0x001D13C4
		public PartitionParameterType ParameterType
		{
			get
			{
				return this._parameterType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameterType = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x001D31D4 File Offset: 0x001D13D4
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x001D31DC File Offset: 0x001D13DC
		public PartitionFunctionRange Range
		{
			get
			{
				return this._range;
			}
			set
			{
				this._range = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x001D31E5 File Offset: 0x001D13E5
		public IList<ScalarExpression> BoundaryValues
		{
			get
			{
				return this._boundaryValues;
			}
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x001D31ED File Offset: 0x001D13ED
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x001D31FC File Offset: 0x001D13FC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.ParameterType != null)
			{
				this.ParameterType.Accept(visitor);
			}
			int i = 0;
			int count = this.BoundaryValues.Count;
			while (i < count)
			{
				this.BoundaryValues[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002068 RID: 8296
		private Identifier _name;

		// Token: 0x04002069 RID: 8297
		private PartitionParameterType _parameterType;

		// Token: 0x0400206A RID: 8298
		private PartitionFunctionRange _range;

		// Token: 0x0400206B RID: 8299
		private List<ScalarExpression> _boundaryValues = new List<ScalarExpression>();
	}
}
