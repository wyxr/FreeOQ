using System;

namespace FreeQuant.Data
{
	[Serializable]
	public class PnF
	{
		protected DateTime beginTime;
		protected DateTime endTime;
		protected double high;
		protected double low;
		protected double open;
		protected double close;
		protected long volume;
		protected long openInt;
		protected double boxSize;

		public DateTime DateTime
		{
			get
			{
				return this.beginTime;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public DateTime BeginTime
		{
			get
			{
				return this.beginTime;
			}
		}

		[View]
		public virtual DateTime EndTime
		{
			get
			{
				return this.endTime;
			}
			set
			{
				this.endTime = value;
			}
		}

		[View]
		public TimeSpan Duration
		{
			get
			{
				return this.endTime - this.beginTime;
			}
		}

		public PnFKind Kind
		{
			get
			{
				return this.open > this.close ? PnFKind.Down : PnFKind.Up;
			}
		}

		public double BoxSize
		{
			get
			{
				return this.boxSize;
			}
		}

		public int BoxCount
		{
			get
			{
				return (int)Math.Round(Math.Abs(this.close - this.open) / this.boxSize);
			}
		}

		[PriceView]
		public double Open
		{
			get
			{
				return this.open;
			}
			set
			{
				this.open = value;
			}
		}

		[PriceView]
		public double High
		{
			get
			{
				return this.high;
			}
			set
			{
				this.high = value;
			}
		}

		[PriceView]
		public double Low
		{
			get
			{
				return this.low;
			}
			set
			{
				this.low = value;
			}
		}

		[PriceView]
		public double Close
		{
			get
			{
				return this.close;
			}
			set
			{
				this.close = value;
			}
		}

		[View]
		public long Volume
		{
			get
			{
				return this.volume;
			}
			set
			{
				this.volume = value;
			}
		}

		public long OpenInt
		{
			get
			{
				return this.openInt;
			}
			set
			{
				this.openInt = value;
			}
		}

		public double Median
		{
			get
			{
				return (this.High + this.Low) / 2.0;
			}
		}

		public double Typical
		{
			get
			{
				return (this.High + this.Low + this.Close) / 3.0;
			}
		}

		public double Weighted
		{
			get
			{
				return (this.High + this.Low + 2.0 * this.Close) / 4.0;
			}
		}

		public double this[int barData]
		{
			get
			{
				switch (barData)
				{
					case 0:
						return this.Close;
					case 1:
						return this.Open;
					case 2:
						return this.High;
					case 3:
						return this.Low;
					case 4:
						return this.Median;
					case 5:
						return this.Typical;
					case 6:
						return this.Weighted;
					case 7:
						return this.Volume;
					case 8:
						return this.OpenInt;
					default:
						return double.NaN;
				}
			}
		}

		public double this[BarData barData]
		{
			get
			{
				return this[(int)barData];
			}
		}

		public PnF(double boxSize, DateTime beginTime, DateTime endTime, double open, double high, double low, double close, long volume, long openInt)
		{
			this.boxSize = boxSize;
			this.beginTime = beginTime;
			this.EndTime = endTime;
			this.Open = open;
			this.High = high;
			this.Low = low;
			this.Close = close;
			this.Volume = volume;
			this.OpenInt = openInt;
		}

		public PnF(PnF pnF) : this(pnF.BoxSize, pnF.beginTime, pnF.endTime, pnF.open, pnF.high, pnF.low, pnF.close, pnF.volume, pnF.openInt)
		{
		}

		public double GetPrice(BarPrice option)
		{
            double result = 0.0; 
            switch (option) 
			{
				case BarPrice.High:
					result = this.High;
					break;
				case BarPrice.Low:
					result = this.Low;
					break;
				case BarPrice.Open:
					result = this.Open;
					break;
				case BarPrice.Close:
					result = this.Close;
					break;
				case BarPrice.Median:
					result = this.Median;
					break;
				case BarPrice.Typical:
					result = this.Typical;
					break;
				case BarPrice.Weighted:
					result = this.Weighted;
					break;
			}
			return result;
		}

		public override string ToString()
		{
            return string.Format("BeginTime: {0}\nEndTime: {1}\nBoxSize: {2}\nOpen: {3}\n and so on", new object[]
			{
				this.beginTime.ToShortDateString() + this.beginTime.ToLongTimeString(),
				this.endTime.ToShortDateString() + this.endTime.ToLongTimeString(),
				this.boxSize,
				this.open,
				this.high,
				this.low,
				this.close,
				this.volume,
				this.openInt,
				this.Kind
			});
		}
	}


}
