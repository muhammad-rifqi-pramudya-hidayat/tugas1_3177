using System;

namespace TheSuperComputer
{
	class Printer
	{
		private String brand;
		private String series;
		private int ppm;

		public Printer(String brand, String series, int ppm)
		{
			this.brand = brand;
			this.series = series;
			this.ppm = ppm;
		}
		public string getBrand()
		{
			return this.brand;
		}
		public String getSeries()
		{
			return this.series;
		}
		public int getPpm()
		{
			return this.ppm;
		}
		public override string ToString()
		{
			return $"Printer brand : {this.brand} ; Printer series : {this.series} ; printer paper per minute (ppm) : {this.ppm}";

		}
	}
}
