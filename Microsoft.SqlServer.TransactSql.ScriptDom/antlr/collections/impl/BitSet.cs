using System;
using System.Collections;

namespace antlr.collections.impl
{
	// Token: 0x02000003 RID: 3
	internal class BitSet : ICloneable
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000020D7 File Offset: 0x000002D7
		public BitSet() : this(64)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		public BitSet(long[] bits_)
		{
			this.dataBits = bits_;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020F0 File Offset: 0x000002F0
		public BitSet(int nbits)
		{
			this.dataBits = new long[(nbits - 1 >> 6) + 1];
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000210C File Offset: 0x0000030C
		public virtual void add(int el)
		{
			int num = BitSet.wordNumber(el);
			if (num >= this.dataBits.Length)
			{
				this.growToInclude(el);
			}
			this.dataBits[num] |= BitSet.bitMask(el);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002150 File Offset: 0x00000350
		public virtual BitSet and(BitSet a)
		{
			BitSet bitSet = (BitSet)this.Clone();
			bitSet.andInPlace(a);
			return bitSet;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002174 File Offset: 0x00000374
		public virtual void andInPlace(BitSet a)
		{
			int num = Math.Min(this.dataBits.Length, a.dataBits.Length);
			for (int i = num - 1; i >= 0; i--)
			{
				this.dataBits[i] &= a.dataBits[i];
			}
			for (int j = num; j < this.dataBits.Length; j++)
			{
				this.dataBits[j] = 0L;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021E4 File Offset: 0x000003E4
		private static long bitMask(int bitNumber)
		{
			int num = bitNumber & BitSet.MOD_MASK;
			return 1L << num;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002200 File Offset: 0x00000400
		public virtual void clear()
		{
			for (int i = this.dataBits.Length - 1; i >= 0; i--)
			{
				this.dataBits[i] = 0L;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000222C File Offset: 0x0000042C
		public virtual void clear(int el)
		{
			int num = BitSet.wordNumber(el);
			if (num >= this.dataBits.Length)
			{
				this.growToInclude(el);
			}
			this.dataBits[num] &= ~BitSet.bitMask(el);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002274 File Offset: 0x00000474
		public virtual object Clone()
		{
			BitSet bitSet = new BitSet();
			bitSet.dataBits = new long[this.dataBits.Length];
			Array.Copy(this.dataBits, 0, bitSet.dataBits, 0, this.dataBits.Length);
			return bitSet;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022B8 File Offset: 0x000004B8
		public virtual int degree()
		{
			int num = 0;
			for (int i = this.dataBits.Length - 1; i >= 0; i--)
			{
				long num2 = this.dataBits[i];
				if (num2 != 0L)
				{
					for (int j = 63; j >= 0; j--)
					{
						if ((num2 & 1L << j) != 0L)
						{
							num++;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002309 File Offset: 0x00000509
		public override int GetHashCode()
		{
			return this.dataBits.GetHashCode();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002318 File Offset: 0x00000518
		public override bool Equals(object obj)
		{
			if (obj != null && obj is BitSet)
			{
				BitSet bitSet = (BitSet)obj;
				int num = Math.Min(this.dataBits.Length, bitSet.dataBits.Length);
				int num2 = num;
				while (num2-- > 0)
				{
					if (this.dataBits[num2] != bitSet.dataBits[num2])
					{
						return false;
					}
				}
				if (this.dataBits.Length > num)
				{
					int num3 = this.dataBits.Length;
					while (num3-- > num)
					{
						if (this.dataBits[num3] != 0L)
						{
							return false;
						}
					}
				}
				else if (bitSet.dataBits.Length > num)
				{
					int num4 = bitSet.dataBits.Length;
					while (num4-- > num)
					{
						if (bitSet.dataBits[num4] != 0L)
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023D4 File Offset: 0x000005D4
		public virtual void growToInclude(int bit)
		{
			int num = Math.Max(this.dataBits.Length << 1, BitSet.numWordsToHold(bit));
			long[] destinationArray = new long[num];
			Array.Copy(this.dataBits, 0, destinationArray, 0, this.dataBits.Length);
			this.dataBits = destinationArray;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000241C File Offset: 0x0000061C
		public virtual bool member(int el)
		{
			int num = BitSet.wordNumber(el);
			return num < this.dataBits.Length && (this.dataBits[num] & BitSet.bitMask(el)) != 0L;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002454 File Offset: 0x00000654
		public virtual bool nil()
		{
			for (int i = this.dataBits.Length - 1; i >= 0; i--)
			{
				if (this.dataBits[i] != 0L)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002488 File Offset: 0x00000688
		public virtual BitSet not()
		{
			BitSet bitSet = (BitSet)this.Clone();
			bitSet.notInPlace();
			return bitSet;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024A8 File Offset: 0x000006A8
		public virtual void notInPlace()
		{
			for (int i = this.dataBits.Length - 1; i >= 0; i--)
			{
				this.dataBits[i] = ~this.dataBits[i];
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024DB File Offset: 0x000006DB
		public virtual void notInPlace(int maxBit)
		{
			this.notInPlace(0, maxBit);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024E8 File Offset: 0x000006E8
		public virtual void notInPlace(int minBit, int maxBit)
		{
			this.growToInclude(maxBit);
			for (int i = minBit; i <= maxBit; i++)
			{
				int num = BitSet.wordNumber(i);
				this.dataBits[num] ^= BitSet.bitMask(i);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000252D File Offset: 0x0000072D
		private static int numWordsToHold(int el)
		{
			return (el >> 6) + 1;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002534 File Offset: 0x00000734
		public static BitSet of(int el)
		{
			BitSet bitSet = new BitSet(el + 1);
			bitSet.add(el);
			return bitSet;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002554 File Offset: 0x00000754
		public virtual BitSet or(BitSet a)
		{
			BitSet bitSet = (BitSet)this.Clone();
			bitSet.orInPlace(a);
			return bitSet;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002578 File Offset: 0x00000778
		public virtual void orInPlace(BitSet a)
		{
			if (a.dataBits.Length > this.dataBits.Length)
			{
				this.setSize(a.dataBits.Length);
			}
			int num = Math.Min(this.dataBits.Length, a.dataBits.Length);
			for (int i = num - 1; i >= 0; i--)
			{
				this.dataBits[i] |= a.dataBits[i];
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025EC File Offset: 0x000007EC
		public virtual void remove(int el)
		{
			int num = BitSet.wordNumber(el);
			if (num >= this.dataBits.Length)
			{
				this.growToInclude(el);
			}
			this.dataBits[num] &= ~BitSet.bitMask(el);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002634 File Offset: 0x00000834
		private void setSize(int nwords)
		{
			long[] destinationArray = new long[nwords];
			int length = Math.Min(nwords, this.dataBits.Length);
			Array.Copy(this.dataBits, 0, destinationArray, 0, length);
			this.dataBits = destinationArray;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000266D File Offset: 0x0000086D
		public virtual int size()
		{
			return this.dataBits.Length << 6;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002679 File Offset: 0x00000879
		public virtual int lengthInLongWords()
		{
			return this.dataBits.Length;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002683 File Offset: 0x00000883
		public virtual bool subset(BitSet a)
		{
			return a != null && this.and(a).Equals(this);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002698 File Offset: 0x00000898
		public virtual void subtractInPlace(BitSet a)
		{
			if (a == null)
			{
				return;
			}
			int num = 0;
			while (num < this.dataBits.Length && num < a.dataBits.Length)
			{
				this.dataBits[num] &= ~a.dataBits[num];
				num++;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000026E8 File Offset: 0x000008E8
		public virtual int[] toArray()
		{
			int[] array = new int[this.degree()];
			int num = 0;
			for (int i = 0; i < this.dataBits.Length << 6; i++)
			{
				if (this.member(i))
				{
					array[num++] = i;
				}
			}
			return array;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000272A File Offset: 0x0000092A
		public virtual long[] toPackedArray()
		{
			return this.dataBits;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002732 File Offset: 0x00000932
		public override string ToString()
		{
			return this.ToString(",");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002740 File Offset: 0x00000940
		public virtual string ToString(string separator)
		{
			string text = "";
			for (int i = 0; i < this.dataBits.Length << 6; i++)
			{
				if (this.member(i))
				{
					if (text.Length > 0)
					{
						text += separator;
					}
					text += i;
				}
			}
			return text;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002790 File Offset: 0x00000990
		public virtual string ToString(string separator, ArrayList vocabulary)
		{
			if (vocabulary == null)
			{
				return this.ToString(separator);
			}
			string text = "";
			for (int i = 0; i < this.dataBits.Length << 6; i++)
			{
				if (this.member(i))
				{
					if (text.Length > 0)
					{
						text += separator;
					}
					if (i >= vocabulary.Count)
					{
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							"<bad element ",
							i,
							">"
						});
					}
					else if (vocabulary[i] == null)
					{
						object obj2 = text;
						text = string.Concat(new object[]
						{
							obj2,
							"<",
							i,
							">"
						});
					}
					else
					{
						text += (string)vocabulary[i];
					}
				}
			}
			return text;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002874 File Offset: 0x00000A74
		public virtual string toStringOfHalfWords()
		{
			string text = new string("".ToCharArray());
			for (int i = 0; i < this.dataBits.Length; i++)
			{
				if (i != 0)
				{
					text += ", ";
				}
				long num = this.dataBits[i];
				num &= (long)(-1);
				text = text + num + "UL";
				text += ", ";
				num = BitSet.URShift(this.dataBits[i], 32);
				num &= (long)(-1);
				text = text + num + "UL";
			}
			return text;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002908 File Offset: 0x00000B08
		public virtual string toStringOfWords()
		{
			string text = new string("".ToCharArray());
			for (int i = 0; i < this.dataBits.Length; i++)
			{
				if (i != 0)
				{
					text += ", ";
				}
				text = text + this.dataBits[i] + "L";
			}
			return text;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002961 File Offset: 0x00000B61
		private static int wordNumber(int bit)
		{
			return bit >> 6;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002966 File Offset: 0x00000B66
		public static int URShift(int number, int bits)
		{
			if (number >= 0)
			{
				return number >> bits;
			}
			return (number >> bits) + (2 << ~bits);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002981 File Offset: 0x00000B81
		public static int URShift(int number, long bits)
		{
			return BitSet.URShift(number, (int)bits);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000298B File Offset: 0x00000B8B
		public static long URShift(long number, int bits)
		{
			if (number >= 0L)
			{
				return number >> bits;
			}
			return (number >> bits) + (2L << ~bits);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000029A8 File Offset: 0x00000BA8
		public static long URShift(long number, long bits)
		{
			return BitSet.URShift(number, (int)bits);
		}

		// Token: 0x04000022 RID: 34
		protected internal const int BITS = 64;

		// Token: 0x04000023 RID: 35
		protected internal const int NIBBLE = 4;

		// Token: 0x04000024 RID: 36
		protected internal const int LOG_BITS = 6;

		// Token: 0x04000025 RID: 37
		protected internal static readonly int MOD_MASK = 63;

		// Token: 0x04000026 RID: 38
		protected internal long[] dataBits;
	}
}
