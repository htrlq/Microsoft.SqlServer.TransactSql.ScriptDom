using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000208 RID: 520
	[Serializable]
	public class FullTextPredicate : BooleanExpression
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x001C8E8D File Offset: 0x001C708D
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x001C8E95 File Offset: 0x001C7095
		public FullTextFunctionType FullTextFunctionType
		{
			get
			{
				return this._fullTextFunctionType;
			}
			set
			{
				this._fullTextFunctionType = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x001C8E9E File Offset: 0x001C709E
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x001C8EA6 File Offset: 0x001C70A6
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x001C8EAE File Offset: 0x001C70AE
		public ValueExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x001C8EBE File Offset: 0x001C70BE
		// (set) Token: 0x06002AB5 RID: 10933 RVA: 0x001C8EC6 File Offset: 0x001C70C6
		public ValueExpression LanguageTerm
		{
			get
			{
				return this._languageTerm;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._languageTerm = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x001C8ED6 File Offset: 0x001C70D6
		// (set) Token: 0x06002AB7 RID: 10935 RVA: 0x001C8EDE File Offset: 0x001C70DE
		public StringLiteral PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._propertyName = value;
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x001C8EEE File Offset: 0x001C70EE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x001C8EFC File Offset: 0x001C70FC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			if (this.LanguageTerm != null)
			{
				this.LanguageTerm.Accept(visitor);
			}
			if (this.PropertyName != null)
			{
				this.PropertyName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DA2 RID: 7586
		private FullTextFunctionType _fullTextFunctionType;

		// Token: 0x04001DA3 RID: 7587
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();

		// Token: 0x04001DA4 RID: 7588
		private ValueExpression _value;

		// Token: 0x04001DA5 RID: 7589
		private ValueExpression _languageTerm;

		// Token: 0x04001DA6 RID: 7590
		private StringLiteral _propertyName;
	}
}
