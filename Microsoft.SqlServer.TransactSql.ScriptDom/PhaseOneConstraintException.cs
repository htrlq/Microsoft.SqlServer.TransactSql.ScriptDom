using System;
using System.Runtime.Serialization;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	internal sealed class PhaseOneConstraintException : Exception
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00008E17 File Offset: 0x00007017
		public ConstraintDefinition Constraint
		{
			get
			{
				return this._constraint;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00008E1F File Offset: 0x0000701F
		public PhaseOneConstraintException(ConstraintDefinition constraint)
		{
			this._constraint = constraint;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00008E2E File Offset: 0x0000702E
		private PhaseOneConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000C67 RID: 3175
		private ConstraintDefinition _constraint;
	}
}
