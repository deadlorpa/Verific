using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class otrezok
    {
		// начало отрезка
		private double x1;
		private double y1;
		// конец отрезка
		private double x2;
		private double y2;
		public void Init(double x1, double y1, double x2, double y2) // со всеми параметрами
		{
			this.x1 = x1; this.y1 = y1; this.x2 = x2; this.y2 = y2;
		}
		public double dlina_otreazka() // длина отрезка
		{
			double dlina = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) * ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
			return dlina;
		}

		public double getx1() { return x1; }
		public double gety1() { return y1; }
		public double getx2() { return x2; }
		public double gety2() { return y2; }
		public void putx1(double a) { x1 = a; }
		public void puty1(double a) { y1 = a; }
		public void putx2(double a) { x2 = a; }
		public void puty2(double a) { y2 = a; }
	}
}
