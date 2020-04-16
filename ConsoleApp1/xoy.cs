using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class xoy : otrezok
	{
		double z;

		public double getz() { return z; }
		public void putz(double zz) { z = zz; }
		public bool Display() { Console.WriteLine(z); return true; }
		public void Init(double x1, double y1, double x2, double y2, double z)
		{
			Init(x1, y1, x2, y2); // вызов init базы
			this.z = z;
		}
		public new double dlina_otreazka() // перегрузка dlina
		{
			double dlina = ((getx2() - getx1()) * (getx2() - getx1()) + (gety2() - gety1()) * (gety2() - gety1()));
			return dlina + z;
		}
	}
}
